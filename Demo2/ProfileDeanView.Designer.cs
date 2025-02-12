namespace Demo2
{
    partial class ProfileDeanView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmergencyContactName;
        private System.Windows.Forms.Label lblEmergencyContactPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmergencyContactName;
        private System.Windows.Forms.TextBox txtEmergencyContactPhone;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnBack;

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
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.labelHiLCoe = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmergencyContactName = new System.Windows.Forms.Label();
            this.lblEmergencyContactPhone = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactName = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactPhone = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
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
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(100, 150);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 16);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(100, 190);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 16);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(100, 230);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(100, 16);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(100, 270);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(100, 310);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmergencyContactName
            // 
            this.lblEmergencyContactName.AutoSize = true;
            this.lblEmergencyContactName.Location = new System.Drawing.Point(100, 350);
            this.lblEmergencyContactName.Name = "lblEmergencyContactName";
            this.lblEmergencyContactName.Size = new System.Drawing.Size(167, 16);
            this.lblEmergencyContactName.TabIndex = 12;
            this.lblEmergencyContactName.Text = "Emergency Contact Name:";
            // 
            // lblEmergencyContactPhone
            // 
            this.lblEmergencyContactPhone.AutoSize = true;
            this.lblEmergencyContactPhone.Location = new System.Drawing.Point(100, 390);
            this.lblEmergencyContactPhone.Name = "lblEmergencyContactPhone";
            this.lblEmergencyContactPhone.Size = new System.Drawing.Size(169, 16);
            this.lblEmergencyContactPhone.TabIndex = 14;
            this.lblEmergencyContactPhone.Text = "Emergency Contact Phone:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(300, 150);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(300, 190);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 22);
            this.txtAge.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(300, 230);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(300, 270);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(300, 310);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 11;
            // 
            // txtEmergencyContactName
            // 
            this.txtEmergencyContactName.Location = new System.Drawing.Point(300, 350);
            this.txtEmergencyContactName.Name = "txtEmergencyContactName";
            this.txtEmergencyContactName.Size = new System.Drawing.Size(200, 22);
            this.txtEmergencyContactName.TabIndex = 13;
            // 
            // txtEmergencyContactPhone
            // 
            this.txtEmergencyContactPhone.Location = new System.Drawing.Point(300, 390);
            this.txtEmergencyContactPhone.Name = "txtEmergencyContactPhone";
            this.txtEmergencyContactPhone.Size = new System.Drawing.Size(200, 22);
            this.txtEmergencyContactPhone.TabIndex = 15;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(882, 480);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(92, 80);
            this.btnLogOut.TabIndex = 20;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(774, 125);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(612, 503);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 57);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProfileDeanView
            // 
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtEmergencyContactPhone);
            this.Controls.Add(this.txtEmergencyContactName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblEmergencyContactPhone);
            this.Controls.Add(this.lblEmergencyContactName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox);
            this.Name = "ProfileDeanView";
            this.Text = "Profile Dean View";
            this.Load += new System.EventHandler(this.ProfileDeanView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}