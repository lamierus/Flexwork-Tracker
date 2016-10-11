using System;
using System.Windows.Forms;


/// <summary>
///     this form displays an error message and offers the user multiple options of how to continue
/// </summary>
namespace Flexwork_Tracker {
    public partial class ErrorWithOptions : Form {

        public ErrorWithOptions(string message, string ok, string cancel, bool thirdButton = false, string thirdOption = "") {
            InitializeComponent();
            lblMessage.Text = message;
            btnOK.Text = ok;
            btnCancel.Text = cancel;
            if (thirdButton) {
                btnThirdOption.Visible = true;
                btnThirdOption.Text = thirdOption;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnThirdOption_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
