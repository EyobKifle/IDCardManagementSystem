namespace Demo2
{
    partial class DeanDashboardView
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.labelHiLCoe = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.btnViewRequests = new Demo2.RoundButton();
            this.btnIDCardHistory = new Demo2.RoundButton();
            this.btnCreateNewStudent = new Demo2.RoundButton();
            this.btnDeleteStudent = new Demo2.RoundButton();
            this.footer = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.pictureBoxLeftLogo);
            this.panelHeader.Controls.Add(this.pictureBoxRightLogo);
            this.panelHeader.Controls.Add(this.labelHiLCoe);
            this.panelHeader.Controls.Add(this.labelSchoolName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 100);
            this.panelHeader.TabIndex = 1;

            // 
            // pictureBoxLeftLogo
            // 
            this.pictureBoxLeftLogo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxLeftLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(186)))), ((int)(((byte)(169)))));
            this.pictureBoxLeftLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftLogo.Location = new System.Drawing.Point(900, 10);
            this.pictureBoxLeftLogo.Name = "pictureBoxLeftLogo";
            this.pictureBoxLeftLogo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxLeftLogo.TabIndex = 3;
            this.pictureBoxLeftLogo.TabStop = false;
            this.pictureBoxLeftLogo.Click += new System.EventHandler(this.pictureBoxLeftLogo_Click);

            // 
            // pictureBoxRightLogo
            // 
            this.pictureBoxRightLogo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxRightLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRightLogo.Image = global::Demo2.Properties.Resources.download; // Ensure this image exists
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(20, 10);
            this.pictureBoxRightLogo.Name = "pictureBoxRightLogo";
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxRightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightLogo.TabIndex = 2;
            this.pictureBoxRightLogo.TabStop = false;
            this.pictureBoxRightLogo.Click += new System.EventHandler(this.pictureBoxRightLogo_Click);

            // 
            // labelHiLCoe
            // 
            this.labelHiLCoe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHiLCoe.AutoSize = true;
            this.labelHiLCoe.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHiLCoe.ForeColor = System.Drawing.Color.White;
            this.labelHiLCoe.Location = new System.Drawing.Point(350, 10);
            this.labelHiLCoe.Name = "labelHiLCoe";
            this.labelHiLCoe.Size = new System.Drawing.Size(165, 46);
            this.labelHiLCoe.TabIndex = 1;
            this.labelHiLCoe.Text = "HiLCoE";

            // 
            // labelSchoolName
            // 
            this.labelSchoolName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchoolName.ForeColor = System.Drawing.Color.White;
            this.labelSchoolName.Location = new System.Drawing.Point(250, 60);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(490, 25);
            this.labelSchoolName.TabIndex = 0;
            this.labelSchoolName.Text = "School of Computer Science and Software Engineering";

            // 
            // btnViewRequests
            // 
            this.btnViewRequests.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnViewRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnViewRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRequests.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRequests.ForeColor = System.Drawing.Color.White;
            this.btnViewRequests.Location = new System.Drawing.Point(50, 150);
            this.btnViewRequests.Name = "btnViewRequests";
            this.btnViewRequests.Size = new System.Drawing.Size(350, 60);
            this.btnViewRequests.TabIndex = 2;
            this.btnViewRequests.Text = "View Requests";
            this.btnViewRequests.UseVisualStyleBackColor = false;
            this.btnViewRequests.Click += new System.EventHandler(this.BtnViewRequests_Click);

            // 
            // btnIDCardHistory
            // 
            this.btnIDCardHistory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnIDCardHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnIDCardHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIDCardHistory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIDCardHistory.ForeColor = System.Drawing.Color.White;
            this.btnIDCardHistory.Location = new System.Drawing.Point(500, 150);
            this.btnIDCardHistory.Name = "btnIDCardHistory";
            this.btnIDCardHistory.Size = new System.Drawing.Size(350, 60);
            this.btnIDCardHistory.TabIndex = 3;
            this.btnIDCardHistory.Text = "ID Card History";
            this.btnIDCardHistory.UseVisualStyleBackColor = false;
            this.btnIDCardHistory.Click += new System.EventHandler(this.BtnIDCardHistory_Click);

            // 
            // btnCreateNewStudent
            // 
            this.btnCreateNewStudent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnCreateNewStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCreateNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewStudent.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewStudent.Location = new System.Drawing.Point(50, 250);
            this.btnCreateNewStudent.Name = "btnCreateNewStudent";
            this.btnCreateNewStudent.Size = new System.Drawing.Size(350, 60);
            this.btnCreateNewStudent.TabIndex = 4;
            this.btnCreateNewStudent.Text = "Create New Student";
            this.btnCreateNewStudent.UseVisualStyleBackColor = false;
            this.btnCreateNewStudent.Click += new System.EventHandler(this.BtnCreateNewStudent_Click);

            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Location = new System.Drawing.Point(500, 250);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(350, 60);
            this.btnDeleteStudent.TabIndex = 5;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.BtnDeleteStudent_Click);

            // 
            // footer
            // 
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.footer.ForeColor = System.Drawing.Color.White;
            this.footer.Text = "© 2025 HiLCoE. All rights reserved.";
            this.footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.footer.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.Height = 40;
            this.footer.Location = new System.Drawing.Point(0, 560);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1000, 40);
            this.footer.TabIndex = 6;

            // 
            // DeanDashboardView
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnCreateNewStudent);
            this.Controls.Add(this.btnIDCardHistory);
            this.Controls.Add(this.btnViewRequests);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.footer);
            this.Name = "DeanDashboardView";
            this.Text = "Dean Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeanDashboardView_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeanDashboardView_FormClosing);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private RoundButton btnViewRequests;
        private RoundButton btnIDCardHistory;
        private RoundButton btnCreateNewStudent;
        private RoundButton btnDeleteStudent;
        private System.Windows.Forms.Label footer;
    }
}