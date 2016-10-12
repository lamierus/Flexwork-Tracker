using System;
using System.Windows.Forms;

/// <summary>
///     form for adding/deleting/editing/viewing FlexWork items.
/// </summary>
namespace FlexWork_Tracker {
    public partial class FlexWorkViewerForm : Form {

        public FlexWork ReturnFlexWork { get; set; }

        /// <summary>
        ///     basic constructor, for adding a new FlexWork object.
        ///     this also checks for and loads defaults from the registry, if they have been set.
        ///     it will also prompt the user, if they haven't been set, yet.
        /// </summary>
        public FlexWorkViewerForm() {
            ReturnFlexWork = new FlexWork();
            
            InitializeComponent();

            if (!FlexWorkTracker.GetDefaults() && FlexWorkTracker.RequestDefaults) {
                var defaultsMissing = new ErrorWithOptions("Defaults not set.\nWould you like to set them, now?",
                                                           "Set",
                                                           "Not Now",
                                                           true, "Stop Asking");
                var result = defaultsMissing.ShowDialog();
                if (result == DialogResult.OK) {
                    FlexWorkTracker.SetDefaults(FlexWorkTracker.ProgramKey);
                } else if (result == DialogResult.Yes) {
                    FlexWorkTracker.RequestDefaults = false;
                }
            }

            cbCategory.DataSource = FlexWorkTracker.Categories;
            cbSite.DataSource = FlexWorkTracker.Sites;
            
            int index = cbCategory.FindString(FlexWorkTracker.DefaultCategory);
            cbCategory.SelectedIndex = index;

            index = cbSite.FindString(FlexWorkTracker.DefaultSite);
            cbSite.SelectedIndex = index;

            tbTechnician.Text = FlexWorkTracker.DefaultTechnician;

            datetimePicker.Value = DateTime.Today;
        }

        /// <summary>
        ///     this constructor is for any of the other 3 options, as they will have items already set for
        ///     each of the FlexWork objects properties.
        /// </summary>
        /// <param name="FlexWork"></param>
        /// <param name="type"></param>
        public FlexWorkViewerForm(FlexWork FlexWork, FlexWorkViewerType type) {
            InitializeComponent();

            cbCategory.DataSource = FlexWorkTracker.Categories;
            cbSite.DataSource = FlexWorkTracker.Sites;

            int dataSourceIndex;
            ReturnFlexWork = FlexWork;

            tbComments.Text = ReturnFlexWork.Comments;
            datetimePicker.Text = ReturnFlexWork.Date;
            tbDetails.Text = ReturnFlexWork.Details;
            tbHours.Text = ReturnFlexWork.Hours.ToString();
            tbRequestor.Text = ReturnFlexWork.Requestor;
            tbTechnician.Text = ReturnFlexWork.Technician;
            tbTicket.Text = ReturnFlexWork.Ticket;

            if (type == FlexWorkViewerType.View || type == FlexWorkViewerType.Delete) {
                tbComments.Enabled = false;
                datetimePicker.Enabled = false;
                tbDetails.Enabled = false;
                tbHours.Enabled = false;
                tbRequestor.Enabled = false;
                tbTechnician.Enabled = false;
                tbTicket.Enabled = false;
                cbCategory.Enabled = false;
                cbSite.Enabled = false;

                if (type == FlexWorkViewerType.View) {
                    btnCancel.Visible = false;
                    btnConfirm.Visible = false;
                    btnClose.Visible = true;
                    CancelButton = btnClose;
                    AcceptButton = btnClose;
                } else if (type == FlexWorkViewerType.Delete) {
                    lblWarning.Visible = true;
                    lblWarningTitle.Visible = true;
                }
            }

            dataSourceIndex = cbCategory.FindString(ReturnFlexWork.Category);
            cbCategory.SelectedIndex = dataSourceIndex;

            dataSourceIndex = cbSite.FindString(ReturnFlexWork.Site);
            cbSite.SelectedIndex = dataSourceIndex;
        }
        
        /// <summary>
        ///     not much here other than returning a cancel result and closing the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        ///     sets the ReturnFlexWork property properties to the selected/entered values.
        ///     also checks to make sure the hours used are in the correct format, as that is the only 
        ///     variable needing parsed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e) {
            ReturnFlexWork.Category = (string)cbCategory.SelectedItem;
            ReturnFlexWork.Comments = tbComments.Text;
            ReturnFlexWork.Date = datetimePicker.Text;
            ReturnFlexWork.Details = tbDetails.Text;
            ReturnFlexWork.Requestor = tbRequestor.Text;
            ReturnFlexWork.Site = (string)cbSite.SelectedItem;
            ReturnFlexWork.Technician = tbTechnician.Text;
            ReturnFlexWork.Ticket = tbTicket.Text;

            double parsedNum;
            if (double.TryParse(tbHours.Text, out parsedNum)) {
                ReturnFlexWork.Hours = parsedNum;
                DialogResult = DialogResult.OK;
                Close();
            } else {
                var error = new ErrorMessage("Please enter a number in decimal format, representing the hours spent working on the issue.");
                error.ShowDialog();
            }
        }

        /// <summary>
        ///     this is the button displayed when the user is just viewing the FlexWork object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
