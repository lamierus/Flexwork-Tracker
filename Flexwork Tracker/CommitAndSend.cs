using System;
using System.Linq;
using System.Windows.Forms;

namespace FlexWork_Tracker {
    public partial class CommitAndSend : Form {
        public string ReturnEmail { get; set; }

        public CommitAndSend() {
            InitializeComponent();
            cboxSiteLead.DataSource = FlexWorkTracker.SiteLeads;
            cboxSiteLead.SelectedIndex = cboxSiteLead.FindString(FlexWorkTracker.DefaultLead);
        }

        private void cbOther_CheckedChanged(object sender, EventArgs e) {
            CheckBox sent = (CheckBox)sender;
            if (sent.Checked) {
                tbOther.Enabled = true;
                cboxSiteLead.Enabled = false;
            } else {
                tbOther.Enabled = false;
                cboxSiteLead.Enabled = true;
            }
        }

        private void tbOther_MouseClick(object sender, MouseEventArgs e) {
            TextBox sent = (TextBox)sender;
            if (sent.Enabled && sent.Text == "Enter full email...") {
                sent.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSend_Click(object sender, EventArgs e) {
            ErrorMessage error;
            if (cbOther.Checked && tbOther.Text.EndsWith("@email.com")) {
                ReturnEmail = tbOther.Text;
                DialogResult = DialogResult.OK;
            } else if (cbOther.Checked) {
                error = new ErrorMessage("Not a valid @email.com email address");
                error.ShowDialog();
            } else {
                ReturnEmail = ((string)cboxSiteLead.SelectedItem).Split(new char[] { '-', ' ' }).Last();
                DialogResult = DialogResult.OK;
            }

            if (DialogResult == DialogResult.OK) {
                Close();
            }
        }
    }
}
