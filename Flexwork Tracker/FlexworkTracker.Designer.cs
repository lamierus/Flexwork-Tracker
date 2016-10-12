namespace FlexWork_Tracker {
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
            this.dgvFlexWork = new System.Windows.Forms.DataGridView();
            this.bwLoadFlexWork = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bwSaveFlexWork = new System.ComponentModel.BackgroundWorker();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlexWork)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFlexWork
            // 
            this.dgvFlexWork.AllowUserToAddRows = false;
            this.dgvFlexWork.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvFlexWork.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlexWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFlexWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlexWork.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFlexWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFlexWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlexWork.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFlexWork.Location = new System.Drawing.Point(12, 27);
            this.dgvFlexWork.MultiSelect = false;
            this.dgvFlexWork.Name = "dgvFlexWork";
            this.dgvFlexWork.ReadOnly = true;
            this.dgvFlexWork.RowHeadersVisible = false;
            this.dgvFlexWork.RowHeadersWidth = 10;
            this.dgvFlexWork.RowTemplate.ReadOnly = true;
            this.dgvFlexWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlexWork.Size = new System.Drawing.Size(966, 330);
            this.dgvFlexWork.TabIndex = 0;
            this.dgvFlexWork.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlexWork_CellDoubleClick);
            // 
            // bwLoadFlexWork
            // 
            this.bwLoadFlexWork.WorkerReportsProgress = true;
            this.bwLoadFlexWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadFlexWork_DoWork);
            this.bwLoadFlexWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwLoadFlexWork_ProgressChanged);
            this.bwLoadFlexWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadFlexWork_WorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Excel Files|*.xlsx|All Files|*.*\"";
            this.openFileDialog.InitialDirectory = "C:\\Users\\simon.je\\Documents";
            // 
            // bwSaveFlexWork
            // 
            this.bwSaveFlexWork.WorkerReportsProgress = true;
            this.bwSaveFlexWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSaveFlexWork_DoWork);
            this.bwSaveFlexWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwSaveFlexWork_ProgressChanged);
            this.bwSaveFlexWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSaveFlexWork_WorkerCompleted);
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
            this.tsmiSave.Text = "Save FlexWork";
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
            // FlexWorkTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 498);
            this.Controls.Add(this.btnSaveAndSend);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvFlexWork);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FlexWorkTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlexWork Tracker";
            this.Activated += new System.EventHandler(this.FlexWorkTracker_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlexWorkTracker_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlexWork)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFlexWork;
        private System.ComponentModel.BackgroundWorker bwLoadFlexWork;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker bwSaveFlexWork;
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