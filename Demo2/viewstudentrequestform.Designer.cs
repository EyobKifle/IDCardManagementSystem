namespace Demo2
{
    partial class ViewStudentRequestForm
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
            this.pictureBoxEvidence = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.labelHiLCoe = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelStudentEmail = new System.Windows.Forms.Label();
            this.labelRequestDate = new System.Windows.Forms.Label();
            this.labelRequestStatus = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.labelEvidencePath = new System.Windows.Forms.Label();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvidence)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEvidence
            // 
            this.pictureBoxEvidence.Location = new System.Drawing.Point(646, 260);
            this.pictureBoxEvidence.Name = "pictureBoxEvidence";
            this.pictureBoxEvidence.Size = new System.Drawing.Size(300, 200);
            this.pictureBoxEvidence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvidence.TabIndex = 0;
            this.pictureBoxEvidence.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.panelHeader.Controls.Add(this.pictureBoxLeftLogo);
            this.panelHeader.Controls.Add(this.pictureBoxRightLogo);
            this.panelHeader.Controls.Add(this.labelHiLCoe);
            this.panelHeader.Controls.Add(this.labelSchoolName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1030, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // pictureBoxLeftLogo
            // 
            this.pictureBoxLeftLogo.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxLeftLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftLogo.Location = new System.Drawing.Point(922, 13);
            this.pictureBoxLeftLogo.Name = "pictureBoxLeftLogo";
            this.pictureBoxLeftLogo.Size = new System.Drawing.Size(81, 65);
            this.pictureBoxLeftLogo.TabIndex = 1;
            this.pictureBoxLeftLogo.TabStop = false;
            // 
            // pictureBoxRightLogo
            // 
            this.pictureBoxRightLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRightLogo.Image = global::Demo2.Properties.Resources.download;
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxRightLogo.Name = "pictureBoxRightLogo";
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(81, 65);
            this.pictureBoxRightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightLogo.TabIndex = 1;
            this.pictureBoxRightLogo.TabStop = false;
            // 
            // labelHiLCoe
            // 
            this.labelHiLCoe.AutoSize = true;
            this.labelHiLCoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelHiLCoe.ForeColor = System.Drawing.Color.White;
            this.labelHiLCoe.Location = new System.Drawing.Point(331, 7);
            this.labelHiLCoe.Name = "labelHiLCoe";
            this.labelHiLCoe.Size = new System.Drawing.Size(165, 46);
            this.labelHiLCoe.TabIndex = 2;
            this.labelHiLCoe.Text = "HiLCoE";
            // 
            // labelSchoolName
            // 
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSchoolName.ForeColor = System.Drawing.Color.White;
            this.labelSchoolName.Location = new System.Drawing.Point(180, 53);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(490, 25);
            this.labelSchoolName.TabIndex = 3;
            this.labelSchoolName.Text = "School of Computer Science and Software Engineering";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.pictureBoxProfile);
            this.panelContent.Controls.Add(this.labelStudentName);
            this.panelContent.Controls.Add(this.labelStudentEmail);
            this.panelContent.Controls.Add(this.labelRequestDate);
            this.panelContent.Controls.Add(this.labelRequestStatus);
            this.panelContent.Controls.Add(this.labelReason);
            this.panelContent.Controls.Add(this.labelEvidencePath);
            this.panelContent.Controls.Add(this.buttonApprove);
            this.panelContent.Controls.Add(this.buttonReject);
            this.panelContent.Controls.Add(this.pictureBoxEvidence);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1030, 500);
            this.panelContent.TabIndex = 2;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxProfile.Location = new System.Drawing.Point(804, 34);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(142, 151);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentName.Location = new System.Drawing.Point(20, 120);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(129, 22);
            this.labelStudentName.TabIndex = 0;
            this.labelStudentName.Text = "Student Name:";
            // 
            // labelStudentEmail
            // 
            this.labelStudentEmail.AutoSize = true;
            this.labelStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentEmail.Location = new System.Drawing.Point(20, 160);
            this.labelStudentEmail.Name = "labelStudentEmail";
            this.labelStudentEmail.Size = new System.Drawing.Size(139, 25);
            this.labelStudentEmail.TabIndex = 0;
            this.labelStudentEmail.Text = "Student Email:";
            // 
            // labelRequestDate
            // 
            this.labelRequestDate.AutoSize = true;
            this.labelRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestDate.Location = new System.Drawing.Point(20, 200);
            this.labelRequestDate.Name = "labelRequestDate";
            this.labelRequestDate.Size = new System.Drawing.Size(136, 25);
            this.labelRequestDate.TabIndex = 0;
            this.labelRequestDate.Text = "Request Date:";
            // 
            // labelRequestStatus
            // 
            this.labelRequestStatus.AutoSize = true;
            this.labelRequestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestStatus.Location = new System.Drawing.Point(20, 240);
            this.labelRequestStatus.Name = "labelRequestStatus";
            this.labelRequestStatus.Size = new System.Drawing.Size(151, 25);
            this.labelRequestStatus.TabIndex = 0;
            this.labelRequestStatus.Text = "Request Status:";
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReason.Location = new System.Drawing.Point(20, 280);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(85, 25);
            this.labelReason.TabIndex = 0;
            this.labelReason.Text = "Reason:";
            // 
            // labelEvidencePath
            // 
            this.labelEvidencePath.AutoSize = true;
            this.labelEvidencePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvidencePath.Location = new System.Drawing.Point(20, 320);
            this.labelEvidencePath.Name = "labelEvidencePath";
            this.labelEvidencePath.Size = new System.Drawing.Size(144, 25);
            this.labelEvidencePath.TabIndex = 0;
            this.labelEvidencePath.Text = "Evidence Path:";
            // 
            // buttonApprove
            // 
            this.buttonApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApprove.Location = new System.Drawing.Point(200, 450);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(100, 40);
            this.buttonApprove.TabIndex = 0;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = true;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReject.Location = new System.Drawing.Point(350, 450);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(100, 40);
            this.buttonReject.TabIndex = 0;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(20, 450);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 40);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewStudentRequestForm
            // 
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonBack);
            this.Name = "ViewStudentRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Request View";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvidence)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxEvidence;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelStudentEmail;
        private System.Windows.Forms.Label labelRequestDate;
        private System.Windows.Forms.Label labelRequestStatus;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelEvidencePath;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Button buttonBack;
    }
}