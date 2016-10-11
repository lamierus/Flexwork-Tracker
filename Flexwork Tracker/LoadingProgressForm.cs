using System.Windows.Forms;

/// <summary>
///     this just displays the received message and a progressbar for when saving/loading
/// </summary>
namespace Flexwork_Tracker {
    public partial class LoadingProgressForm : Form {

        public LoadingProgressForm(string message = "Loading...", int progressMax = 100) {
            InitializeComponent();
            setMessage(message);
            setProgressMax(progressMax);
        }

        public void setMessage(string message) {
            lblMessage.Text = message;
        }

        public void setProgressMax(int progressMax) {
            pbProgress.Maximum = progressMax;
        }

        public int getProgressMax() {
            return pbProgress.Maximum;
        }

        public void changeProgress(int progress) {
            pbProgress.Value = progress;
        }
    }
}
