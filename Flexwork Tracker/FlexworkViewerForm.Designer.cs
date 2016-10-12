namespace FlexWork_Tracker {
    partial class FlexWorkViewerForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlexWorkViewerForm));
            this.lblRequestor = new System.Windows.Forms.Label();
            this.tbRequestor = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.tbTicket = new System.Windows.Forms.TextBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.tbTechnician = new System.Windows.Forms.TextBox();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblWarningTitle = new System.Windows.Forms.Label();
            this.datetimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblRequestor
            // 
            this.lblRequestor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRequestor.AutoSize = true;
            this.lblRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestor.Location = new System.Drawing.Point(9, 9);
            this.lblRequestor.Name = "lblRequestor";
            this.lblRequestor.Size = new System.Drawing.Size(71, 16);
            this.lblRequestor.TabIndex = 0;
            this.lblRequestor.Text = "Requestor";
            // 
            // tbRequestor
            // 
            this.tbRequestor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequestor.Location = new System.Drawing.Point(12, 28);
            this.tbRequestor.Name = "tbRequestor";
            this.tbRequestor.Size = new System.Drawing.Size(200, 24);
            this.tbRequestor.TabIndex = 1;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(278, 9);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(80, 16);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours Used";
            // 
            // tbHours
            // 
            this.tbHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHours.Location = new System.Drawing.Point(281, 28);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(200, 24);
            this.tbHours.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(9, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(122, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date (mm/dd/yyyy)";
            // 
            // tbDetails
            // 
            this.tbDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetails.Location = new System.Drawing.Point(281, 97);
            this.tbDetails.Multiline = true;
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(200, 100);
            this.tbDetails.TabIndex = 7;
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(278, 78);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(50, 16);
            this.lblDetails.TabIndex = 6;
            this.lblDetails.Text = "Details";
            // 
            // tbTicket
            // 
            this.tbTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTicket.Location = new System.Drawing.Point(12, 174);
            this.tbTicket.Name = "tbTicket";
            this.tbTicket.Size = new System.Drawing.Size(200, 24);
            this.tbTicket.TabIndex = 9;
            // 
            // lblTicket
            // 
            this.lblTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(9, 155);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(117, 16);
            this.lblTicket.TabIndex = 8;
            this.lblTicket.Text = "Ticket for Request";
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(9, 227);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 16);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category";
            // 
            // lblSite
            // 
            this.lblSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(278, 227);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(31, 16);
            this.lblSite.TabIndex = 12;
            this.lblSite.Text = "Site";
            // 
            // tbComments
            // 
            this.tbComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComments.Location = new System.Drawing.Point(12, 323);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(200, 100);
            this.tbComments.TabIndex = 15;
            // 
            // lblComments
            // 
            this.lblComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(9, 304);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(72, 16);
            this.lblComments.TabIndex = 14;
            this.lblComments.Text = "Comments";
            // 
            // tbTechnician
            // 
            this.tbTechnician.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTechnician.Location = new System.Drawing.Point(281, 323);
            this.tbTechnician.Name = "tbTechnician";
            this.tbTechnician.Size = new System.Drawing.Size(200, 24);
            this.tbTechnician.TabIndex = 17;
            // 
            // lblTechnician
            // 
            this.lblTechnician.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnician.Location = new System.Drawing.Point(278, 304);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(74, 16);
            this.lblTechnician.TabIndex = 16;
            this.lblTechnician.Text = "Technician";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(12, 246);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 26);
            this.cbCategory.TabIndex = 11;
            // 
            // cbSite
            // 
            this.cbSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(281, 246);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(200, 26);
            this.cbSite.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 30);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(184, 454);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Location = new System.Drawing.Point(356, 454);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 30);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWarning.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Maroon;
            this.lblWarning.Location = new System.Drawing.Point(233, 383);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(244, 40);
            this.lblWarning.TabIndex = 21;
            this.lblWarning.Text = "Deletion is permanent, and cannot be recovered, once confirmed!";
            this.lblWarning.Visible = false;
            // 
            // lblWarningTitle
            // 
            this.lblWarningTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWarningTitle.AutoSize = true;
            this.lblWarningTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblWarningTitle.Location = new System.Drawing.Point(231, 356);
            this.lblWarningTitle.Name = "lblWarningTitle";
            this.lblWarningTitle.Size = new System.Drawing.Size(109, 27);
            this.lblWarningTitle.TabIndex = 22;
            this.lblWarningTitle.Text = "Warning:";
            this.lblWarningTitle.Visible = false;
            // 
            // datetimePicker
            // 
            this.datetimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datetimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePicker.Location = new System.Drawing.Point(12, 97);
            this.datetimePicker.Name = "datetimePicker";
            this.datetimePicker.Size = new System.Drawing.Size(200, 24);
            this.datetimePicker.TabIndex = 5;
            // 
            // FlexWorkViewerForm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(496, 496);
            this.ControlBox = false;
            this.Controls.Add(this.datetimePicker);
            this.Controls.Add(this.lblWarningTitle);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbSite);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbTechnician);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbTicket);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.tbDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.tbRequestor);
            this.Controls.Add(this.lblRequestor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlexWorkViewerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestor;
        private System.Windows.Forms.TextBox tbRequestor;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox tbTicket;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox tbTechnician;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblWarningTitle;
        private System.Windows.Forms.DateTimePicker datetimePicker;
    }
}