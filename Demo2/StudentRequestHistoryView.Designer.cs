namespace Demo2
{
    partial class StudentRequestHistoryView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblRequestHistoryTitle;
        private System.Windows.Forms.DataGridView dataGridViewRequestHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenuRightLogo;
        private System.Windows.Forms.ToolStripMenuItem viewProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRequestHistoryView));
            this.lblRequestHistoryTitle = new System.Windows.Forms.Label();
            this.dataGridViewRequestHistory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.contextMenuRightLogo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHiLCoe = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.contextMenuRightLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblRequestHistoryTitle
            // 
            this.lblRequestHistoryTitle.AutoSize = true;
            this.lblRequestHistoryTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.lblRequestHistoryTitle.Location = new System.Drawing.Point(20, 120);
            this.lblRequestHistoryTitle.Name = "lblRequestHistoryTitle";
            this.lblRequestHistoryTitle.Size = new System.Drawing.Size(363, 40);
            this.lblRequestHistoryTitle.TabIndex = 0;
            this.lblRequestHistoryTitle.Text = "View Request History";

            // 
            // dataGridViewRequestHistory
            // 
            this.dataGridViewRequestHistory.AllowUserToAddRows = false;
            this.dataGridViewRequestHistory.AllowUserToDeleteRows = false;
            this.dataGridViewRequestHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRequestHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRequestHistory.ColumnHeadersHeight = 40;
            this.dataGridViewRequestHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRequestHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dataGridViewRequestHistory.Location = new System.Drawing.Point(20, 170);
            this.dataGridViewRequestHistory.Name = "dataGridViewRequestHistory";
            this.dataGridViewRequestHistory.ReadOnly = true;
            this.dataGridViewRequestHistory.RowHeadersWidth = 51;
            this.dataGridViewRequestHistory.RowTemplate.Height = 24;
            this.dataGridViewRequestHistory.Size = new System.Drawing.Size(960, 350);
            this.dataGridViewRequestHistory.TabIndex = 1;

            // 
            // Column1 (Request ID)
            // 
            this.Column1.HeaderText = "Request ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;

            // 
            // Column2 (Request Type)
            // 
            this.Column2.HeaderText = "Request Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;

            // 
            // Column3 (Date Requested)
            // 
            this.Column3.HeaderText = "Date Requested";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;

            // 
            // Column4 (Student Name)
            // 
            this.Column4.HeaderText = "Student Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;

            // 
            // Column6 (Status)
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;

            // 
            // Column7 (Reason)
            // 
            this.Column7.HeaderText = "Reason";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;

            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(420, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;

            // 
            // pictureBoxLeftLogo
            // 
            this.pictureBoxLeftLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeftLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftLogo.Image = global::Demo2.Properties.Resources.download;
            this.pictureBoxLeftLogo.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxLeftLogo.Name = "pictureBoxLeftLogo";
            this.pictureBoxLeftLogo.Size = new System.Drawing.Size(81, 65);
            this.pictureBoxLeftLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeftLogo.TabIndex = 1;
            this.pictureBoxLeftLogo.TabStop = false;

            // 
            // pictureBoxRightLogo
            // 
            this.pictureBoxRightLogo.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxRightLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRightLogo.ContextMenuStrip = this.contextMenuRightLogo;
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(877, 13);
            this.pictureBoxRightLogo.Name = "pictureBoxRightLogo";
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(81, 65);
            this.pictureBoxRightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRightLogo.TabIndex = 1;
            this.pictureBoxRightLogo.TabStop = false;

            // 
            // contextMenuRightLogo
            // 
            this.contextMenuRightLogo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuRightLogo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileMenuItem,
            this.helpMenuItem});
            this.contextMenuRightLogo.Name = "contextMenuRightLogo";
            this.contextMenuRightLogo.Size = new System.Drawing.Size(158, 52);

            // 
            // viewProfileMenuItem
            // 
            this.viewProfileMenuItem.Name = "viewProfileMenuItem";
            this.viewProfileMenuItem.Size = new System.Drawing.Size(157, 24);
            this.viewProfileMenuItem.Text = "View Profile";

            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(157, 24);
            this.helpMenuItem.Text = "Help";

            // 
            // labelHiLCoe
            // 
            this.labelHiLCoe.AutoSize = true;
            this.labelHiLCoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHiLCoe.ForeColor = System.Drawing.Color.White;
            this.labelHiLCoe.Location = new System.Drawing.Point(122, 12);
            this.labelHiLCoe.Name = "labelHiLCoe";
            this.labelHiLCoe.Size = new System.Drawing.Size(276, 46);
            this.labelHiLCoe.TabIndex = 3;
            this.labelHiLCoe.Text = "HiLCOE System";

            // 
            // labelSchoolName
            // 
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchoolName.ForeColor = System.Drawing.Color.White;
            this.labelSchoolName.Location = new System.Drawing.Point(122, 58);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(211, 24);
            this.labelSchoolName.TabIndex = 4;
            this.labelSchoolName.Text = "Higher Learning Center";

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.panelHeader.Controls.Add(this.labelHiLCoe);
            this.panelHeader.Controls.Add(this.labelSchoolName);
            this.panelHeader.Controls.Add(this.pictureBoxLeftLogo);
            this.panelHeader.Controls.Add(this.pictureBoxRightLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 90);
            this.panelHeader.TabIndex = 5;

            // 
            // ViewRequestHistoryView
            // 
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewRequestHistory);
            this.Controls.Add(this.lblRequestHistoryTitle);
            this.Name = "ViewRequestHistoryView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.contextMenuRightLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
