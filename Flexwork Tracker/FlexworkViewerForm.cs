using System;
using System.Windows.Forms;

/// <summary>
///     form for adding/deleting/editing/viewing flexwork items.
/// </summary>
namespace Flexwork_Tracker {
    public partial class FlexWorkViewerForm : Form {

        public FlexWork ReturnFlexwork { get; set; }

        /// <summary>
        ///     basic constructor, for adding a new flexwork object.
        ///     this also checks for and loads defaults from the registry, if they have been set.
        ///     it will also prompt the user, if they haven't been set, yet.
        /// </summary>
        public FlexWorkViewerForm() {
            ReturnFlexwork = new FlexWork();
            
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
        ///     each of the flexwork objects properties.
        /// </summary>
        /// <param name="flexwork"></param>
        /// <param name="type"></param>
        public FlexWorkViewerForm(FlexWork flexwork, FlexworkViewerType type) {
            InitializeComponent();

            cbCategory.DataSource = FlexWorkTracker.Categories;
            cbSite.DataSource = FlexWorkTracker.Sites;

            int dataSourceIndex;
            ReturnFlexwork = flexwork;

            tbComments.Text = ReturnFlexwork.Comments;
            datetimePicker.Text = ReturnFlexwork.Date;
            tbDetails.Text = ReturnFlexwork.Details;
            tbHours.Text = ReturnFlexwork.Hours.ToString();
            tbRequestor.Text = ReturnFlexwork.Requestor;
            tbTechnician.Text = ReturnFlexwork.Technician;
            tbTicket.Text = ReturnFlexwork.Ticket;

            if (type == FlexworkViewerType.View || type == FlexworkViewerType.Delete) {
                tbComments.Enabled = false;
                datetimePicker.Enabled = false;
                tbDetails.Enabled = false;
                tbHours.Enabled = false;
                tbRequestor.Enabled = false;
                tbTechnician.Enabled = false;
                tbTicket.Enabled = false;
                cbCategory.Enabled = false;
                cbSite.Enabled = false;

                if (type == FlexworkViewerType.View) {
                    btnCancel.Visible = false;
                    btnConfirm.Visible = false;
                    btnClose.Visible = true;
                    CancelButton = btnClose;
                    AcceptButton = btnClose;
                } else if (type == FlexworkViewerType.Delete) {
                    lblWarning.Visible = true;
                    lblWarningTitle.Visible = true;
                }
            }

            dataSourceIndex = cbCategory.FindString(ReturnFlexwork.Category);
            cbCategory.SelectedIndex = dataSourceIndex;

            dataSourceIndex = cbSite.FindString(ReturnFlexwork.Site);
            cbSite.SelectedIndex = dataSourceIndex;

            datetimePicker.Value = DateTime.Today;
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
        ///     sets the ReturnFlexwork property properties to the selected/entered values.
        ///     also checks to make sure the hours used are in the correct format, as that is the only 
        ///     variable needing parsed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e) {
            ReturnFlexwork.Category = (string)cbCategory.SelectedItem;
            ReturnFlexwork.Comments = tbComments.Text;
            ReturnFlexwork.Date = datetimePicker.Text;
            ReturnFlexwork.Details = tbDetails.Text;
            ReturnFlexwork.Requestor = tbRequestor.Text;
            ReturnFlexwork.Site = (string)cbSite.SelectedItem;
            ReturnFlexwork.Technician = tbTechnician.Text;
            ReturnFlexwork.Ticket = tbTicket.Text;

            double parsedNum;
            if (double.TryParse(tbHours.Text, out parsedNum)) {
                ReturnFlexwork.Hours = parsedNum;
                DialogResult = DialogResult.OK;
                Close();
            } else {
                var error = new ErrorMessage("Please enter a number in decimal format, representing the hours spent working on the issue.");
                error.ShowDialog();
            }
        }

        /// <summary>
        ///     this is the button displayed when the user is just viewing the flexwork object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
