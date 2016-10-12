using System;
using System.Windows.Forms;

/// <summary>
///     this is a basic form that just manipulates the global static variables from the main program
/// </summary>
namespace FlexWork_Tracker {
    public partial class Settings : Form {

        public Settings() {
            InitializeComponent();
            cboxCategories.DataSource = FlexWorkTracker.Categories;
            cboxSites.DataSource = FlexWorkTracker.Sites;
            cboxLeads.DataSource = FlexWorkTracker.SiteLeads;

            tbTechnician.Text = FlexWorkTracker.DefaultTechnician;

            int index = cboxCategories.FindString(FlexWorkTracker.DefaultCategory);
            cboxCategories.SelectedIndex = index;

            index = cboxSites.FindString(FlexWorkTracker.DefaultSite);
            cboxSites.SelectedIndex = index;

            index = cboxLeads.FindString(FlexWorkTracker.DefaultLead);
            cboxLeads.SelectedIndex = index;
            if (FlexWorkTracker.Fabulous) {
                cbFabulous.CheckState = CheckState.Checked;
            }
        }

        /// <summary>
        ///     FABULOUSSSSSSS!!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFabulous_CheckedChanged(object sender, EventArgs e) {
            var sent = sender as CheckBox;
            if (sent.Checked) {
                FlexWorkTracker.Fabulous = true;
            } else {
                FlexWorkTracker.Fabulous = false;
            }
        }

        /// <summary>
        ///     checks for any nulls
        /// </summary>
        /// <returns>
        ///     if there is a single null variable
        /// </returns>
        private bool NullFound() {
            return FlexWorkTracker.DefaultTechnician == null ||
                   FlexWorkTracker.DefaultCategory == null ||
                   FlexWorkTracker.DefaultSite == null ||
                   FlexWorkTracker.DefaultLead == null;
        }

        /// <summary>
        ///     if there is a null, this will set it to be blank, instead.
        ///     this will avoid any errors at a later time.
        /// </summary>
        private void SetNullsToBlanks() {
            if (FlexWorkTracker.DefaultTechnician == null)
                FlexWorkTracker.DefaultTechnician = "";
            if (FlexWorkTracker.DefaultCategory == null)
                FlexWorkTracker.DefaultCategory = "";
            if (FlexWorkTracker.DefaultSite == null)
                FlexWorkTracker.DefaultSite = "";
            if (FlexWorkTracker.DefaultLead == null)
                FlexWorkTracker.DefaultLead = "";
        }

        /// <summary>
        ///     cancels and closes, but at least sets them to blanks, to avoid errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            if (NullFound()) {
                SetNullsToBlanks();
            }
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        ///     sets the defaults the user chooses, and if any are still null, sets them to be blank.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e) {
            FlexWorkTracker.DefaultTechnician = tbTechnician.Text;
            FlexWorkTracker.DefaultCategory = (string)cboxCategories.SelectedItem;
            FlexWorkTracker.DefaultSite = (string)cboxSites.SelectedItem;
            FlexWorkTracker.DefaultLead = (string)cboxLeads.SelectedItem;
            if (NullFound()) {
                SetNullsToBlanks();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
