using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Flexwork_Tracker {
    public partial class FlexWorkTracker : Form {

        //these are used in multiple areas, so this makes it easier to access across all places, making it easier to modify, if requirements change in the future
        static public BindingList<string> Categories = new BindingList<string>() {
            "Data Collection/Report/Request for Information",
            "Meeting/Event Support",
            "Non-Base/Extended Support for End-User Computing",
            "Non-Company Area Clean-Up/Checks",
            "Non-Company Owned Equipment Support",
            "Pre-Authorized Efforts",
            "Project Work"
        };
        static public BindingList<string> Sites = new BindingList<string>(){
            "Onett",
            "Twoson",
            "Threed",
            "Fourside"
        };
        static public BindingList<string> SiteLeads = new BindingList<string>() {
            "Joseph Simon - simon.je@email.com",
            "Leeroy Jenkins - jenkins.lr@email.com"
        };
        static public string DefaultTechnician;
        static public string DefaultSite;
        static public string DefaultCategory;
        static public string DefaultLead;
        static public bool RequestDefaults;
        static public bool Fabulous;
        static private string KeyLocation = "SOFTWARE\\Flexwork Tracker";
        static public Microsoft.Win32.RegistryKey ProgramKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(KeyLocation);

        private BindingList<FlexWork> FlexworkList = new BindingList<FlexWork>();
        private bool WindowLoaded = false;
        private bool Saved = true;
        private int ProgressBarMax;
        private LoadingProgressForm LoadingForm;
        private Excel.Application ExcelApp = new Excel.Application() {
            Visible = false,
            DisplayAlerts = false
        };

        public FlexWorkTracker() {
            InitializeComponent();
            
            dgvFlexwork.DataSource = FlexworkList;
            RequestDefaults = true;
            CheckFabulous();
        }

        /// <summary>
        ///     make sure to load the current flexwork file being filled by the user, but only do it once, when first loading the application.
        ///     I wanted to put it in the _Load event handler, but i preferred to have it happen after the window is drawn, instead of before.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlexworkTracker_Activated(object sender, EventArgs e) {
            if (!WindowLoaded) {
                WindowLoaded = true;
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flexwork\\FW Tracking.xlsx";
                if (File.Exists(filePath)) {
                    LoadingForm = new LoadingProgressForm("Loading current flexwork...");
                    bwLoadFlexwork.RunWorkerAsync(filePath);
                    LoadingForm.ShowDialog();
                } else {
                    FlexworkList.Clear();
                }
                GetDefaults();
            }
            CheckFabulous();
        }

        private void CheckFabulous() {
            if (Fabulous) {
                BackColor = Color.HotPink;
            } else {
                BackColor = SystemColors.Control;
            }
        }

        /// <summary>
        ///     runs the settings form to set up the user's defaults
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSettings_Click(object sender, EventArgs e) {
            SetDefaults(ProgramKey);
        }

        /// <summary>
        ///     check if the defaults are already available, if not, sets the program's variables to be blank.
        /// </summary>
        /// <returns>
        ///     true - when the defaults have been previously set and can be loaded into the app's variables.
        ///     false =
        /// </returns>
        static public bool GetDefaults() {
            if (ProgramKey == null) {
                DefaultCategory = "";
                DefaultSite = "";
                DefaultTechnician = "";
                DefaultLead = "";
                return false;
            }
            DefaultCategory = (string)ProgramKey.GetValue("Default Category");
            DefaultSite = (string)ProgramKey.GetValue("Default Site");
            DefaultTechnician = (string)ProgramKey.GetValue("Default Technician");
            DefaultLead = (string)ProgramKey.GetValue("Default Lead");
            return true;
        }

        /// <summary>
        ///     opens a form to get the defaults from the user, then saves them to keys in the registry.
        /// </summary>
        /// <param name="key"></param>
        static public void SetDefaults(Microsoft.Win32.RegistryKey key) {
            var form = new Settings();
            form.ShowDialog();

            string siteName = DefaultSite;
            string categoryName = DefaultCategory;
            string technician = DefaultTechnician;
            string lead = DefaultLead;

            if (key == null) {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(KeyLocation);
                key.SetValue("Default Site", siteName);
                key.SetValue("Default Category", categoryName);
                key.SetValue("Default Technician", technician);
                key.SetValue("Default Lead", lead);
            } else {
                Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(KeyLocation);
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(KeyLocation);
                key.SetValue("Default Site", siteName);
                key.SetValue("Default Category", categoryName);
                key.SetValue("Default Technician", technician);
                key.SetValue("Default Lead", lead);
            }
            key.Close();
        }

        /// <summary>
        ///     this is the function for the background worker to load the current flexwork sheet into memory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwLoadFlexwork_DoWork(object sender, DoWorkEventArgs e) {
            string filePath = (string)e.Argument;
            Excel.Workbook workbook = ExcelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Worksheets.Item[1];

            int lastRow = getMaxRow(worksheet);
            int lastCol = getMaxCol(worksheet);
            ProgressBarMax = lastRow;

            FlexWork newFlexwork;
            FlexWork prevFlexwork = new FlexWork();

            for (int index = 2; index <= lastRow; index++) {
                // this array holds all of the information from each line of the excel sheet
                Array flexworkValues = (Array)worksheet.get_Range("A" + index.ToString(), ColumnNumToString(lastCol) + index.ToString()).Cells.Value;
                // I have to run the check null on each of these parsed cells, 
                // due to being brought in from an excel sheet with possible blank cells
                newFlexwork = new FlexWork() {
                    Requestor = stringCheckNull(flexworkValues.GetValue(1, 1)),
                    Hours = doubleCheckNull(flexworkValues.GetValue(1, 2)),
                    Date = stringCheckNull(flexworkValues.GetValue(1, 3)),
                    Details = stringCheckNull(flexworkValues.GetValue(1, 4)),
                    Ticket = stringCheckNull(flexworkValues.GetValue(1, 5)),
                    Category = stringCheckNull(flexworkValues.GetValue(1, 6)),
                    Site = stringCheckNull(flexworkValues.GetValue(1, 7)),
                    Comments = stringCheckNull(flexworkValues.GetValue(1, 8)),
                    Technician = stringCheckNull(flexworkValues.GetValue(1, 9))
                };
                //this verifies that the newly created laptop is not a copy of the previous one
                if (newFlexwork != prevFlexwork) {
                    bwLoadFlexwork.ReportProgress(index, newFlexwork);
                    prevFlexwork = newFlexwork;
                }
            }
            workbook.Close();
        }

        /// <summary>
        ///     updates the progressbar on the loading form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwLoadFlexwork_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (LoadingForm.getProgressMax() != ProgressBarMax) {
                LoadingForm.setProgressMax(ProgressBarMax);
            }
            FlexworkList.Add((FlexWork)e.UserState);
            LoadingForm.changeProgress(e.ProgressPercentage);
        }

        /// <summary>
        ///     closes the loading form and resets the bindings, to properly show the list of current flexwork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwLoadFlexwork_WorkerCompleted(object sender, AsyncCompletedEventArgs e) {
            FlexworkList.ResetBindings();
            LoadingForm.Close();
        }

        /// <summary>
        ///     check for a blank cell value and return a string, if that is expected
        /// </summary>
        /// <param name="value"></param>
        /// <returns> a string of the cell contents</returns>
        private string stringCheckNull(object value) {
            if (value == null) {
                return "";
            }
            return value.ToString();
        }

        /// <summary>
        ///     check for a blank cell value and return an integer, if that is expected
        /// </summary>
        /// <param name="value"></param>
        /// <returns> 0 if the cell is blank or the object doesn't parse, otherwise returns an int value</returns>
        private double doubleCheckNull(object value) {
            double parsedNum;
            if (value == null) {
                return 0.0;
            }
            if (double.TryParse(value.ToString(), out parsedNum)) {
                return parsedNum;
            } else {
                return 0.0;
            }
        }

        /// <summary>
        ///     Returns the last row number that has any information in any cell of an excel sheet
        /// </summary>
        /// <param name="worksheet"></param>
        /// <returns> the last row number with any data </returns>
        private int getMaxRow(Excel.Worksheet worksheet) {
            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            return lastRow;
        }

        /// <summary>
        ///     returns the last column number that has any information in any cell of an excel sheet
        /// </summary>
        /// <param name="worksheet"></param>
        /// <returns> the last column number with any data </returns>
        private int getMaxCol(Excel.Worksheet worksheet) {
            int lastCol = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Column;
            return lastCol;
        }

        /// <summary>
        ///     returns a full column name using the column number as a basis
        /// </summary>
        /// <param name="columnNumber"></param>
        /// <returns></returns>
        private string ColumnNumToString(int columnNumber) {
            int dividend = columnNumber;
            string strColumnName = "";
            int modulo;
            while (dividend > 0) {
                modulo = (dividend - 1) % 26;
                strColumnName = Convert.ToChar(65 + modulo).ToString() + strColumnName;
                dividend = (int)((dividend - modulo) / 26);
            }
            return strColumnName;
        }

        /// <summary>
        ///     sets up and starts the saving process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSave_Click(object sender, EventArgs e) {
            LoadingForm = new LoadingProgressForm("Saving current flexwork...");
            ProgressBarMax = FlexworkList.Count + 1;
            string weekDate = getWeekDate(DateTime.Today);
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flexwork\\FW Tracking.xlsx";
            bwSaveFlexwork.RunWorkerAsync(filePath);
            LoadingForm.ShowDialog();
        }

        /// <summary>
        ///     background work to build the new sheet and save the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwSaveFlexwork_DoWork(object sender, DoWorkEventArgs e) {
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            string filePath = (string)e.Argument;

            if (!Directory.Exists(Path.GetDirectoryName(filePath))) {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }
            workbook = ExcelApp.Workbooks.Add();
            worksheet = workbook.Worksheets.Item[1];

            worksheet.Columns.ColumnWidth = 20;
            worksheet.Cells[1, 1].Value = "Requestor";
            worksheet.Cells[1, 2].Value = "Hours Used";
            worksheet.Cells[1, 3].Value = "Date of Service";
            worksheet.Cells[1, 4].Value = "Details of request";
            worksheet.Cells[1, 5].Value = "Ticket Number";
            worksheet.Cells[1, 6].Value = "Category";
            worksheet.Cells[1, 7].Value = "Site";
            worksheet.Cells[1, 8].Value = "Comments";
            worksheet.Cells[1, 9].Value = "Created By";

            int lastRow = getMaxRow(worksheet);
            int lastCol = getMaxCol(worksheet);

            int index = 2;

            foreach (FlexWork flex in FlexworkList) {
                worksheet.Cells[index, 1].Value = flex.Requestor;
                worksheet.Cells[index, 2].Value = flex.Hours;
                worksheet.Cells[index, 3].Value = flex.Date;
                worksheet.Cells[index, 4].Value = flex.Details;
                worksheet.Cells[index, 5].Value = flex.Ticket;
                worksheet.Cells[index, 6].Value = flex.Category;
                worksheet.Cells[index, 7].Value = flex.Site;
                worksheet.Cells[index, 8].Value = flex.Comments;
                worksheet.Cells[index, 9].Value = flex.Technician;
                bwSaveFlexwork.ReportProgress(index++);
            }

            workbook.SaveAs(filePath);
            workbook.Close();
        }

        /// <summary>
        ///     update the progressbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwSaveFlexwork_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (LoadingForm.getProgressMax() != ProgressBarMax) {
                LoadingForm.setProgressMax(ProgressBarMax);
            }
            LoadingForm.changeProgress(e.ProgressPercentage);
        }

        /// <summary>
        ///     set the Saved boolean variable and close the loadingprogress form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwSaveFlexwork_WorkerCompleted(object sender, AsyncCompletedEventArgs e) {
            Saved = true;
            LoadingForm.Close();
        }

        /// <summary>
        ///     logic to load up the form for adding a new flexwork item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e) {
            using (var form = new FlexWorkViewerForm()) {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) {
                    FlexworkList.Add(form.ReturnFlexwork);
                    Saved = false;
                }
            }
        }

        /// <summary>
        ///     logic to load up the form for viewing a currently shown flexwork item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFlexwork_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var form = new FlexWorkViewerForm((FlexWork)dgvFlexwork.SelectedRows[0].DataBoundItem, FlexworkViewerType.View);
            form.ShowDialog();
        }

        /// <summary>
        ///     logic to load up the form for editing a current flexwork item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e) {
            FlexWork flexworkToEdit = (FlexWork)dgvFlexwork.SelectedRows[0].DataBoundItem;
            using (var form = new FlexWorkViewerForm(flexworkToEdit, FlexworkViewerType.Edit)) {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) {
                    FlexworkList.Insert(FlexworkList.IndexOf(flexworkToEdit), form.ReturnFlexwork);
                    FlexworkList.Remove(flexworkToEdit);
                    Saved = false;
                }
            }
        }

        /// <summary>
        ///     logic to load up the form for deleting an old flexwork item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e) {
            using (var form = new FlexWorkViewerForm((FlexWork)dgvFlexwork.SelectedRows[0].DataBoundItem, FlexworkViewerType.Delete)) {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) {
                    FlexworkList.Remove(form.ReturnFlexwork);
                    Saved = false;
                }
            }
        }

        /// <summary>
        ///     this is the logic to commit the current flexwork to a file and send that file to the user-chosen team lead for tracking/billing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAndSend_Click(object sender, EventArgs e) {
            string weekDate = getWeekDate(DateTime.Today);
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flexwork\\FW Tracking " + 
                              DateTime.Today.Year + " week of " + weekDate + ".xlsx";

            using (var form = new CommitAndSend()) {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) {
                    LoadingForm = new LoadingProgressForm("Saving...", (ProgressBarMax = FlexworkList.Count + 1));
                    bwSaveFlexwork.RunWorkerAsync(filePath);
                    LoadingForm.ShowDialog();
                    sendEmail(form.ReturnEmail, weekDate, filePath);
                    FlexworkList.Clear();
                    Saved = false;
                }
            }
        }

        /// <summary>
        ///     logic to send the email via outlook
        /// </summary>
        /// <param name="mailTo"></param>
        /// <param name="date"></param>
        /// <param name="attachment"></param>
        private void sendEmail(string mailTo, string date, string attachment) {
            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem email = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            email.To = mailTo;
            email.Subject = "Flexwork Tracking for week of " + date;
            email.Body = "Here is the latest Flexwork Tracking sheet.";
            Outlook.Attachments oAttachs = email.Attachments;
            oAttachs.Add(attachment);
            email.Send();
        }

        /// <summary>
        ///     i'm rather proud of this algorithm for figuring out the current work week,
        ///     for naming and sending/saving the file
        /// </summary>
        /// <param name="today"></param>
        /// <returns> a string of "month/day through month/day" (e.g. "10-08 through 10-14")</returns>
        private string getWeekDate(DateTime today) {
            int daysToStart;
            int daysToEnd;
            switch (today.DayOfWeek) {
                case DayOfWeek.Saturday:
                    daysToStart = 0;
                    daysToEnd = 6;
                    break;
                case DayOfWeek.Sunday:
                    daysToStart = 1;
                    daysToEnd = 5;
                    break;
                case DayOfWeek.Monday:
                    daysToStart = 2;
                    daysToEnd = 4;
                    break;
                case DayOfWeek.Tuesday:
                    daysToStart = 3;
                    daysToEnd = 3;
                    break;
                case DayOfWeek.Wednesday:
                    daysToStart = 4;
                    daysToEnd = 2;
                    break;
                case DayOfWeek.Thursday:
                    daysToStart = 5;
                    daysToEnd = 1;
                    break;
                default:
                    daysToStart = 6;
                    daysToEnd = 0;
                    break;
            }

            TimeSpan startOffset = new TimeSpan(daysToStart, 0, 0, 0);
            TimeSpan endOffset = new TimeSpan(daysToEnd, 0, 0, 0);

            return today.Subtract(startOffset).Month + "-" + today.Subtract(startOffset).Day + 
                   " through " + today.Add(endOffset).Month + "-" + today.Add(endOffset).Day;
        }

        /// <summary>
        ///     what to do when the Quit option is selected from the menus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiQuit_Click(object sender, EventArgs e) {
            Close();
        }

        /// <summary>
        ///     prompts the user, incase they haven't saved the current flexwork items, if they have been edited, deleted, or new items added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlexworkTracker_FormClosing(object sender, FormClosingEventArgs e) {
            if (!Saved) {
                using (var error = new ErrorWithOptions("You have not saved your data, yet.  Are you sure you want to close ?",
                                                        "Close",
                                                        "Go Back",
                                                        true, "Save and Close")) {
                    var result = error.ShowDialog();
                    if (result == DialogResult.OK) {
                        Saved = true;
                    } else if (result == DialogResult.Yes) {
                        tsmiSave.PerformClick();
                    } else {
                        e.Cancel = true;
                    }
                }
            } else {
                ExcelApp.Application.Quit();
            }
        }
    }
}