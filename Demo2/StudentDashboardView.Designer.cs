namespace Demo2
{
    partial class StudentDashboardView
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
            this.footer = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonRequestReplacement = new System.Windows.Forms.Button();
            this.buttonCheckIDStatus = new System.Windows.Forms.Button();
            this.buttonUpdateInformation = new System.Windows.Forms.Button();
            this.buttonContactInformation = new System.Windows.Forms.Button();
            this.buttonPayFee = new System.Windows.Forms.Button();
            this.buttonViewRequestHistory = new System.Windows.Forms.Button();
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
            this.panelHeader.Size = new System.Drawing.Size(1348, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // pictureBoxLeftLogo
            // 
            this.pictureBoxLeftLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLeftLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(186)))), ((int)(((byte)(169)))));
            this.pictureBoxLeftLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftLogo.Location = new System.Drawing.Point(1248, 10);
            this.pictureBoxLeftLogo.Name = "pictureBoxLeftLogo";
            this.pictureBoxLeftLogo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxLeftLogo.TabIndex = 3;
            this.pictureBoxLeftLogo.TabStop = false;
            // 
            // pictureBoxRightLogo
            // 
            this.pictureBoxRightLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRightLogo.Image = global::Demo2.Properties.Resources.download;
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(20, 10);
            this.pictureBoxRightLogo.Name = "pictureBoxRightLogo";
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxRightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightLogo.TabIndex = 2;
            this.pictureBoxRightLogo.TabStop = false;
            // 
            // labelHiLCoe
            // 
            this.labelHiLCoe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHiLCoe.AutoSize = true;
            this.labelHiLCoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHiLCoe.ForeColor = System.Drawing.Color.White;
            this.labelHiLCoe.Location = new System.Drawing.Point(524, 10);
            this.labelHiLCoe.Name = "labelHiLCoe";
            this.labelHiLCoe.Size = new System.Drawing.Size(165, 46);
            this.labelHiLCoe.TabIndex = 1;
            this.labelHiLCoe.Text = "HiLCoE";
            // 
            // labelSchoolName
            // 
            this.labelSchoolName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchoolName.ForeColor = System.Drawing.Color.White;
            this.labelSchoolName.Location = new System.Drawing.Point(424, 60);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(490, 25);
            this.labelSchoolName.TabIndex = 0;
            this.labelSchoolName.Text = "School of Computer Science and Software Engineering";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.ForeColor = System.Drawing.Color.White;
            this.footer.Location = new System.Drawing.Point(0, 560);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1348, 40);
            this.footer.TabIndex = 6;
            this.footer.Text = "© 2025 HiLCoE. All rights reserved.";
            this.footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(118, 120);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(0, 16);
            this.labelFullName.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(118, 150);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 16);
            this.labelEmail.TabIndex = 2;
            // 
            // buttonRequestReplacement
            // 
            this.buttonRequestReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequestReplacement.Location = new System.Drawing.Point(20, 200);
            this.buttonRequestReplacement.Name = "buttonRequestReplacement";
            this.buttonRequestReplacement.Size = new System.Drawing.Size(287, 79);
            this.buttonRequestReplacement.TabIndex = 3;
            this.buttonRequestReplacement.Text = "Request Replacement";
            this.buttonRequestReplacement.UseVisualStyleBackColor = true;
            this.buttonRequestReplacement.Click += new System.EventHandler(this.ButtonRequestReplacement_Click);
            // 
            // buttonCheckIDStatus
            // 
            this.buttonCheckIDStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIDStatus.Location = new System.Drawing.Point(487, 200);
            this.buttonCheckIDStatus.Name = "buttonCheckIDStatus";
            this.buttonCheckIDStatus.Size = new System.Drawing.Size(286, 79);
            this.buttonCheckIDStatus.TabIndex = 4;
            this.buttonCheckIDStatus.Text = "Check ID Status";
            this.buttonCheckIDStatus.UseVisualStyleBackColor = true;
            this.buttonCheckIDStatus.Click += new System.EventHandler(this.ButtonCheckIDStatus_Click);
            // 
            // buttonUpdateInformation
            // 
            this.buttonUpdateInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateInformation.Location = new System.Drawing.Point(922, 200);
            this.buttonUpdateInformation.Name = "buttonUpdateInformation";
            this.buttonUpdateInformation.Size = new System.Drawing.Size(295, 79);
            this.buttonUpdateInformation.TabIndex = 5;
            this.buttonUpdateInformation.Text = "Update Information";
            this.buttonUpdateInformation.UseVisualStyleBackColor = true;
            this.buttonUpdateInformation.Click += new System.EventHandler(this.ButtonUpdateInformation_Click);
            // 
            // buttonContactInformation
            // 
            this.buttonContactInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContactInformation.Location = new System.Drawing.Point(20, 454);
            this.buttonContactInformation.Name = "buttonContactInformation";
            this.buttonContactInformation.Size = new System.Drawing.Size(287, 89);
            this.buttonContactInformation.TabIndex = 6;
            this.buttonContactInformation.Text = "Contact Information";
            this.buttonContactInformation.UseVisualStyleBackColor = true;
            this.buttonContactInformation.Click += new System.EventHandler(this.ButtonContactInformation_Click);
            // 
            // buttonPayFee
            // 
            this.buttonPayFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayFee.Location = new System.Drawing.Point(487, 454);
            this.buttonPayFee.Name = "buttonPayFee";
            this.buttonPayFee.Size = new System.Drawing.Size(286, 89);
            this.buttonPayFee.TabIndex = 7;
            this.buttonPayFee.Text = "Pay Fee";
            this.buttonPayFee.UseVisualStyleBackColor = true;
            this.buttonPayFee.Click += new System.EventHandler(this.ButtonPayFee_Click);
            // 
            // buttonViewRequestHistory
            // 
            this.buttonViewRequestHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewRequestHistory.Location = new System.Drawing.Point(922, 454);
            this.buttonViewRequestHistory.Name = "buttonViewRequestHistory";
            this.buttonViewRequestHistory.Size = new System.Drawing.Size(295, 89);
            this.buttonViewRequestHistory.TabIndex = 8;
            this.buttonViewRequestHistory.Text = "View Request History";
            this.buttonViewRequestHistory.UseVisualStyleBackColor = true;
            this.buttonViewRequestHistory.Click += new System.EventHandler(this.ButtonViewRequestHistory_Click);
            // 
            // StudentDashboardView
            // 
            this.ClientSize = new System.Drawing.Size(1348, 600);
            this.Controls.Add(this.buttonViewRequestHistory);
            this.Controls.Add(this.buttonPayFee);
            this.Controls.Add(this.buttonContactInformation);
            this.Controls.Add(this.buttonUpdateInformation);
            this.Controls.Add(this.buttonCheckIDStatus);
            this.Controls.Add(this.buttonRequestReplacement);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.footer);
            this.Name = "StudentDashboardView";
            this.Text = "Student Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonRequestReplacement;
        private System.Windows.Forms.Button buttonCheckIDStatus;
        private System.Windows.Forms.Button buttonUpdateInformation;
        private System.Windows.Forms.Button buttonContactInformation;
        private System.Windows.Forms.Button buttonPayFee;
        private System.Windows.Forms.Button buttonViewRequestHistory;
    }
}