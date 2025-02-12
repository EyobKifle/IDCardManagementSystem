using System;

namespace Demo2
{
    partial class CheckIDStatusView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelStudentIdValue;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.Label labelIssueDateValue;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label labelExpirationDateValue;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusValue;
        private System.Windows.Forms.Label labelRemarks;
        private System.Windows.Forms.Label labelRemarksValue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelStudentNameValue;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIDStatusView));
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.labelHiLCoe = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelStudentIdValue = new System.Windows.Forms.Label();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.labelIssueDateValue = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelExpirationDateValue = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.labelRemarksValue = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelStudentNameValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pictureBoxLeftLogo
            // 
            this.pictureBoxLeftLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(186)))), ((int)(((byte)(169)))));
            this.pictureBoxLeftLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftLogo.Location = new System.Drawing.Point(922, 13);
            this.pictureBoxLeftLogo.Name = "pictureBoxLeftLogo";
            this.pictureBoxLeftLogo.Size = new System.Drawing.Size(81, 65);
            this.pictureBoxLeftLogo.TabIndex = 1;
            this.pictureBoxLeftLogo.TabStop = false;
            this.pictureBoxLeftLogo.Click += new System.EventHandler(this.pictureBoxLeftLogo_Click);
            // 
            // pictureBoxRightLogo
            // 
            this.pictureBoxRightLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRightLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRightLogo.Image")));
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxRightLogo.Name = "pictureBoxRightLogo";
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(81, 65);
            this.pictureBoxRightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightLogo.TabIndex = 1;
            this.pictureBoxRightLogo.TabStop = false;
            this.pictureBoxRightLogo.Click += new System.EventHandler(this.pictureBoxRightLogo_Click);
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.panelHeader.Controls.Add(this.pictureBoxLeftLogo);
            this.panelHeader.Controls.Add(this.pictureBoxRightLogo);
            this.panelHeader.Controls.Add(this.labelHiLCoe);
            this.panelHeader.Controls.Add(this.labelSchoolName);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1030, 100);
            this.panelHeader.TabIndex = 1;

            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStudentId.Location = new System.Drawing.Point(50, 150);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(108, 25);
            this.labelStudentId.TabIndex = 2;
            this.labelStudentId.Text = "Student ID:";
            // 
            // labelStudentIdValue
            // 
            this.labelStudentIdValue.AutoSize = true;
            this.labelStudentIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStudentIdValue.Location = new System.Drawing.Point(250, 150);
            this.labelStudentIdValue.Name = "labelStudentIdValue";
            this.labelStudentIdValue.Size = new System.Drawing.Size(0, 25);
            this.labelStudentIdValue.TabIndex = 3;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStudentName.Location = new System.Drawing.Point(50, 200);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(148, 25);
            this.labelStudentName.TabIndex = 4;
            this.labelStudentName.Text = "Student Name:";
            // 
            // labelStudentNameValue
            // 
            this.labelStudentNameValue.AutoSize = true;
            this.labelStudentNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStudentNameValue.Location = new System.Drawing.Point(250, 200);
            this.labelStudentNameValue.Name = "labelStudentNameValue";
            this.labelStudentNameValue.Size = new System.Drawing.Size(0, 25);
            this.labelStudentNameValue.TabIndex = 5;
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIssueDate.Location = new System.Drawing.Point(50, 250);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(111, 25);
            this.labelIssueDate.TabIndex = 6;
            this.labelIssueDate.Text = "Issue Date:";
            // 
            // labelIssueDateValue
            // 
            this.labelIssueDateValue.AutoSize = true;
            this.labelIssueDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIssueDateValue.Location = new System.Drawing.Point(250, 250);
            this.labelIssueDateValue.Name = "labelIssueDateValue";
            this.labelIssueDateValue.Size = new System.Drawing.Size(0, 25);
            this.labelIssueDateValue.TabIndex = 7;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelExpirationDate.Location = new System.Drawing.Point(50, 300);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(155, 25);
            this.labelExpirationDate.TabIndex = 8;
            this.labelExpirationDate.Text = "Expiration Date:";
            // 
            // labelExpirationDateValue
            // 
            this.labelExpirationDateValue.AutoSize = true;
            this.labelExpirationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelExpirationDateValue.Location = new System.Drawing.Point(250, 300);
            this.labelExpirationDateValue.Name = "labelExpirationDateValue";
            this.labelExpirationDateValue.Size = new System.Drawing.Size(0, 25);
            this.labelExpirationDateValue.TabIndex = 9;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatus.Location = new System.Drawing.Point(50, 350);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 25);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status:";
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatusValue.Location = new System.Drawing.Point(250, 350);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(0, 25);
            this.labelStatusValue.TabIndex = 11;
            // 
            // labelRemarks
            // 
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRemarks.Location = new System.Drawing.Point(50, 400);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(95, 25);
            this.labelRemarks.TabIndex = 12;
            this.labelRemarks.Text = "Remarks:";
            // 
            // labelRemarksValue
            // 
            this.labelRemarksValue.AutoSize = true;
            this.labelRemarksValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRemarksValue.Location = new System.Drawing.Point(250, 400);
            this.labelRemarksValue.Name = "labelRemarksValue";
            this.labelRemarksValue.Size = new System.Drawing.Size(0, 25);
            this.labelRemarksValue.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(50, 450);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CheckIDStatusView
            // 
            this.ClientSize = new System.Drawing.Size(1030, 510);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelRemarksValue);
            this.Controls.Add(this.labelRemarks);
            this.Controls.Add(this.labelStatusValue);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelExpirationDateValue);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.labelIssueDateValue);
            this.Controls.Add(this.labelIssueDate);
            this.Controls.Add(this.labelStudentNameValue);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.labelStudentIdValue);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.panelHeader);
            this.Name = "CheckIDStatusView";
            this.Text = "Check ID Status";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

       

    }
}
