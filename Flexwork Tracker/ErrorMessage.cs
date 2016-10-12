using System;
using System.Windows.Forms;

/// <summary>
///     this is just a very basic form for displaying an error message.  that's it.
/// </summary>
namespace FlexWork_Tracker {
    public partial class ErrorMessage : Form {

        public ErrorMessage(string errorMessage) {
            InitializeComponent();
            lblMessage.Text = errorMessage;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
