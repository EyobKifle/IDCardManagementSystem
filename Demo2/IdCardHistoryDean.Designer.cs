namespace Demo2
{
    partial class IdCardHistoryDean
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdCardHistoryDean));
            this.dataGridViewRequestHistory = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.contextMenuRightLogo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHiLCoe = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.lblRequestHistoryTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.contextMenuRightLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // dataGridViewRequestHistory
            this.dataGridViewRequestHistory.AllowUserToAddRows = false;
            this.dataGridViewRequestHistory.AllowUserToDeleteRows = false;
            this.dataGridViewRequestHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRequestHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.requestIDDataGridViewTextBoxColumn,
                this.studentNameDataGridViewTextBoxColumn,
                this.studentIDDataGridViewTextBoxColumn,
                this.requestDateDataGridViewTextBoxColumn,
                this.processedDateDataGridViewTextBoxColumn,
                this.statusDataGridViewTextBoxColumn,
                this.remarkDataGridViewTextBoxColumn});
            this.dataGridViewRequestHistory.Location = new System.Drawing.Point(20, 220);
            this.dataGridViewRequestHistory.Name = "dataGridViewRequestHistory";
            this.dataGridViewRequestHistory.ReadOnly = true;
            this.dataGridViewRequestHistory.RowHeadersWidth = 51;
            this.dataGridViewRequestHistory.RowTemplate.Height = 24;
            this.dataGridViewRequestHistory.Size = new System.Drawing.Size(960, 300);
            this.dataGridViewRequestHistory.TabIndex = 1;

            // requestIDDataGridViewTextBoxColumn
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "Request ID";
            this.requestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestIDDataGridViewTextBoxColumn.Width = 125;

            // studentNameDataGridViewTextBoxColumn
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.Width = 150;

            // studentIDDataGridViewTextBoxColumn
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 125;

            // requestDateDataGridViewTextBoxColumn
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "Request Date";
            this.requestDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestDateDataGridViewTextBoxColumn.Width = 125;

            // processedDateDataGridViewTextBoxColumn
            this.processedDateDataGridViewTextBoxColumn.DataPropertyName = "ProcessedDate";
            this.processedDateDataGridViewTextBoxColumn.HeaderText = "Processed Date";
            this.processedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.processedDateDataGridViewTextBoxColumn.Name = "processedDateDataGridViewTextBoxColumn";
            this.processedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.processedDateDataGridViewTextBoxColumn.Width = 125;

            // statusDataGridViewTextBoxColumn
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;

            // remarkDataGridViewTextBoxColumn
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarkDataGridViewTextBoxColumn.Width = 150;

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(420, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            // pictureBoxLeftLogo
            this.pictureBoxLeftLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftLogo.Image")));
            this.pictureBoxLeftLogo.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxLeftLogo.Name = "pictureBoxLeftLogo";
            this.pictureBoxLeftLogo.Size = new System.Drawing.Size(81, 65);
            this.pictureBoxLeftLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeftLogo.TabIndex = 1;
            this.pictureBoxLeftLogo.TabStop = false;

            // pictureBoxRightLogo
            this.pictureBoxRightLogo.ContextMenuStrip = this.contextMenuRightLogo;
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(877, 13);
            this.pictureBoxRightLogo.Name = "pictureBoxRightLogo";
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(81, 65);
            this.pictureBoxRightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRightLogo.TabIndex = 1;
            this.pictureBoxRightLogo.TabStop = false;

            // contextMenuRightLogo
            this.contextMenuRightLogo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuRightLogo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.viewProfileMenuItem,
                this.helpMenuItem});
            this.contextMenuRightLogo.Name = "contextMenuRightLogo";
            this.contextMenuRightLogo.Size = new System.Drawing.Size(158, 52);

            // viewProfileMenuItem
            this.viewProfileMenuItem.Name = "viewProfileMenuItem";
            this.viewProfileMenuItem.Size = new System.Drawing.Size(157, 24);
            this.viewProfileMenuItem.Text = "View Profile";
            this.viewProfileMenuItem.Click += new System.EventHandler(this.ViewProfileMenuItem_Click);

            // helpMenuItem
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(157, 24);
            this.helpMenuItem.Text = "Help";
            this.helpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);

            // labelHiLCoe
            this.labelHiLCoe.AutoSize = true;
            this.labelHiLCoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelHiLCoe.ForeColor = System.Drawing.Color.White;
            this.labelHiLCoe.Location = new System.Drawing.Point(331, 7);
            this.labelHiLCoe.Name = "labelHiLCoe";
            this.labelHiLCoe.Size = new System.Drawing.Size(165, 46);
            this.labelHiLCoe.TabIndex = 2;
            this.labelHiLCoe.Text = "HiLCoE";

            // labelSchoolName
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSchoolName.ForeColor = System.Drawing.Color.White;
            this.labelSchoolName.Location = new System.Drawing.Point(180, 53);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(490, 25);
            this.labelSchoolName.TabIndex = 3;
            this.labelSchoolName.Text = "School of Computer Science and Software Engineering";

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.panelHeader.Controls.Add(this.pictureBoxLeftLogo);
            this.panelHeader.Controls.Add(this.pictureBoxRightLogo);
            this.panelHeader.Controls.Add(this.labelHiLCoe);
            this.panelHeader.Controls.Add(this.labelSchoolName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 100);
            this.panelHeader.TabIndex = 1;

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(120, 170);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 173);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search by:";

            // progressBarLoading
            this.progressBarLoading.Location = new System.Drawing.Point(20, 540);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(390, 23);
            this.progressBarLoading.TabIndex = 5;
            this.progressBarLoading.Visible = false;

            // lblRequestHistoryTitle
            this.lblRequestHistoryTitle.AutoSize = true;
            this.lblRequestHistoryTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblRequestHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.lblRequestHistoryTitle.Location = new System.Drawing.Point(20, 120);
            this.lblRequestHistoryTitle.Name = "lblRequestHistoryTitle";
            this.lblRequestHistoryTitle.Size = new System.Drawing.Size(363, 40);
            this.lblRequestHistoryTitle.TabIndex = 0;
            this.lblRequestHistoryTitle.Text = "View Request History";

            // IdCardHistoryDean
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewRequestHistory);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRequestHistoryTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IdCardHistoryDean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ID Card History Dean";
            this.Load += new System.EventHandler(this.IdCardHistoryDean_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.contextMenuRightLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequestHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.ContextMenuStrip contextMenuRightLogo;
        private System.Windows.Forms.ToolStripMenuItem viewProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Label lblRequestHistoryTitle;
    }
}