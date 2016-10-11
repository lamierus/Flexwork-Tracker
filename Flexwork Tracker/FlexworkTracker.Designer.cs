namespace Flexwork_Tracker {
    partial class FlexWorkTracker {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlexWorkTracker));
            this.dgvFlexwork = new System.Windows.Forms.DataGridView();
            this.bwLoadFlexwork = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bwSaveFlexwork = new System.ComponentModel.BackgroundWorker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveAndSend = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetDefaults = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlexwork)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFlexwork
            // 
            this.dgvFlexwork.AllowUserToAddRows = false;
            this.dgvFlexwork.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvFlexwork.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlexwork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFlexwork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlexwork.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFlexwork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFlexwork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlexwork.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFlexwork.Location = new System.Drawing.Point(12, 27);
            this.dgvFlexwork.MultiSelect = false;
            this.dgvFlexwork.Name = "dgvFlexwork";
            this.dgvFlexwork.ReadOnly = true;
            this.dgvFlexwork.RowHeadersVisible = false;
            this.dgvFlexwork.RowHeadersWidth = 10;
            this.dgvFlexwork.RowTemplate.ReadOnly = true;
            this.dgvFlexwork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlexwork.Size = new System.Drawing.Size(966, 330);
            this.dgvFlexwork.TabIndex = 0;
            this.dgvFlexwork.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlexwork_CellDoubleClick);
            // 
            // bwLoadFlexwork
            // 
            this.bwLoadFlexwork.WorkerReportsProgress = true;
            this.bwLoadFlexwork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadFlexwork_DoWork);
            this.bwLoadFlexwork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwLoadFlexwork_ProgressChanged);
            this.bwLoadFlexwork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadFlexwork_WorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Excel Files|*.xlsx|All Files|*.*\"";
            this.openFileDialog.InitialDirectory = "C:\\Users\\simon.je\\Documents";
            // 
            // bwSaveFlexwork
            // 
            this.bwSaveFlexwork.WorkerReportsProgress = true;
            this.bwSaveFlexwork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSaveFlexwork_DoWork);
            this.bwSaveFlexwork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwSaveFlexwork_ProgressChanged);
            this.bwSaveFlexwork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSaveFlexwork_WorkerCompleted);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(230, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(445, 385);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(670, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveAndSend
            // 
            this.btnSaveAndSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveAndSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndSend.Location = new System.Drawing.Point(418, 440);
            this.btnSaveAndSend.Name = "btnSaveAndSend";
            this.btnSaveAndSend.Size = new System.Drawing.Size(155, 45);
            this.btnSaveAndSend.TabIndex = 6;
            this.btnSaveAndSend.Text = "Commit and Send";
            this.btnSaveAndSend.UseVisualStyleBackColor = true;
            this.btnSaveAndSend.Click += new System.EventHandler(this.btnSaveAndSend_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiSettings});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(990, 24);
            this.menuStrip.TabIndex = 7;
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiQuit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(147, 22);
            this.tsmiSave.Text = "Save Flexwork";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(147, 22);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetDefaults});
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(61, 20);
            this.tsmiSettings.Text = "Settings";
            // 
            // tsmiSetDefaults
            // 
            this.tsmiSetDefaults.Name = "tsmiSetDefaults";
            this.tsmiSetDefaults.Size = new System.Drawing.Size(136, 22);
            this.tsmiSetDefaults.Text = "Set Defaults";
            this.tsmiSetDefaults.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // FlexworkTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 498);
            this.Controls.Add(this.btnSaveAndSend);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvFlexwork);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FlexworkTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flexwork Tracker";
            this.Activated += new System.EventHandler(this.FlexworkTracker_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlexworkTracker_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlexwork)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFlexwork;
        private System.ComponentModel.BackgroundWorker bwLoadFlexwork;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker bwSaveFlexwork;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveAndSend;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetDefaults;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
    }
}