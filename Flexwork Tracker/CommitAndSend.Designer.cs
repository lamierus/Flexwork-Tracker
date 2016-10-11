namespace Flexwork_Tracker {
    partial class CommitAndSend {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommitAndSend));
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboxSiteLead = new System.Windows.Forms.ComboBox();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(170, 140);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send Flexwork";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(30, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboxSiteLead
            // 
            this.cboxSiteLead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxSiteLead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxSiteLead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxSiteLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSiteLead.FormattingEnabled = true;
            this.cboxSiteLead.Location = new System.Drawing.Point(30, 15);
            this.cboxSiteLead.Name = "cboxSiteLead";
            this.cboxSiteLead.Size = new System.Drawing.Size(240, 24);
            this.cboxSiteLead.TabIndex = 3;
            // 
            // tbOther
            // 
            this.tbOther.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbOther.Enabled = false;
            this.tbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOther.Location = new System.Drawing.Point(75, 50);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(150, 21);
            this.tbOther.TabIndex = 4;
            this.tbOther.Text = "Enter full email...";
            this.tbOther.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbOther_MouseClick);
            // 
            // cbOther
            // 
            this.cbOther.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(12, 53);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(52, 17);
            this.cbOther.TabIndex = 5;
            this.cbOther.Text = "Other";
            this.cbOther.UseVisualStyleBackColor = true;
            this.cbOther.CheckedChanged += new System.EventHandler(this.cbOther_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(30, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sending with save a copy and start with a blank template.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CommitAndSend
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOther);
            this.Controls.Add(this.tbOther);
            this.Controls.Add(this.cboxSiteLead);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CommitAndSend";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboxSiteLead;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.Label label1;
    }
}