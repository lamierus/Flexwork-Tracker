namespace Flexwork_Tracker {
    partial class Settings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.tbTechnician = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxSites = new System.Windows.Forms.ComboBox();
            this.cboxCategories = new System.Windows.Forms.ComboBox();
            this.lblLead = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboxLeads = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.cbFabulous = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Technician Name:";
            // 
            // tbTechnician
            // 
            this.tbTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTechnician.Location = new System.Drawing.Point(15, 26);
            this.tbTechnician.Name = "tbTechnician";
            this.tbTechnician.Size = new System.Drawing.Size(213, 22);
            this.tbTechnician.TabIndex = 1;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(12, 60);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 2;
            this.lblSite.Text = "Site";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // cboxSites
            // 
            this.cboxSites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSites.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxSites.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSites.FormattingEnabled = true;
            this.cboxSites.Location = new System.Drawing.Point(15, 76);
            this.cboxSites.Name = "cboxSites";
            this.cboxSites.Size = new System.Drawing.Size(213, 24);
            this.cboxSites.TabIndex = 4;
            // 
            // cboxCategories
            // 
            this.cboxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategories.FormattingEnabled = true;
            this.cboxCategories.Location = new System.Drawing.Point(15, 126);
            this.cboxCategories.Name = "cboxCategories";
            this.cboxCategories.Size = new System.Drawing.Size(213, 24);
            this.cboxCategories.TabIndex = 5;
            // 
            // lblLead
            // 
            this.lblLead.AutoSize = true;
            this.lblLead.Location = new System.Drawing.Point(12, 160);
            this.lblLead.Name = "lblLead";
            this.lblLead.Size = new System.Drawing.Size(31, 13);
            this.lblLead.TabIndex = 6;
            this.lblLead.Text = "Lead";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(153, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(12, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboxLeads
            // 
            this.cboxLeads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxLeads.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxLeads.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxLeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLeads.FormattingEnabled = true;
            this.cboxLeads.Location = new System.Drawing.Point(15, 176);
            this.cboxLeads.Name = "cboxLeads";
            this.cboxLeads.Size = new System.Drawing.Size(213, 24);
            this.cboxLeads.TabIndex = 6;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.SystemColors.Control;
            this.colorDialog.SolidColorOnly = true;
            // 
            // cbFabulous
            // 
            this.cbFabulous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbFabulous.Location = new System.Drawing.Point(65, 223);
            this.cbFabulous.Name = "cbFabulous";
            this.cbFabulous.Size = new System.Drawing.Size(118, 17);
            this.cbFabulous.TabIndex = 10;
            this.cbFabulous.Text = "FABULOUS MODE";
            this.cbFabulous.UseVisualStyleBackColor = true;
            this.cbFabulous.CheckedChanged += new System.EventHandler(this.cbFabulous_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 298);
            this.ControlBox = false;
            this.Controls.Add(this.cbFabulous);
            this.Controls.Add(this.cboxLeads);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLead);
            this.Controls.Add(this.cboxCategories);
            this.Controls.Add(this.cboxSites);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.tbTechnician);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTechnician;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxSites;
        private System.Windows.Forms.ComboBox cboxCategories;
        private System.Windows.Forms.Label lblLead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboxLeads;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox cbFabulous;
    }
}