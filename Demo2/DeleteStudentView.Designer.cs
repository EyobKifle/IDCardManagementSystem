namespace Demo2
{
    partial class DeleteStudentView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelEmergencyContactNumber;
        private System.Windows.Forms.TextBox textBoxEmergencyContactNumber;
        private System.Windows.Forms.Label labelEmergencyContactName;
        private System.Windows.Forms.TextBox textBoxEmergencyContactName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Panel panelHeader;

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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelEmergencyContactNumber = new System.Windows.Forms.Label();
            this.textBoxEmergencyContactNumber = new System.Windows.Forms.TextBox();
            this.labelEmergencyContactName = new System.Windows.Forms.Label();
            this.textBoxEmergencyContactName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.labelHiLCoe = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(50, 120);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(300, 30);
            this.textBoxSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(360, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStudentId.Location = new System.Drawing.Point(50, 170);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(110, 25);
            this.labelStudentId.TabIndex = 2;
            this.labelStudentId.Text = "Student ID:";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxStudentId.Location = new System.Drawing.Point(250, 170);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.ReadOnly = true;
            this.textBoxStudentId.Size = new System.Drawing.Size(300, 30);
            this.textBoxStudentId.TabIndex = 3;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFullName.Location = new System.Drawing.Point(50, 220);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(106, 25);
            this.labelFullName.TabIndex = 4;
            this.labelFullName.Text = "Full Name:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFullName.Location = new System.Drawing.Point(250, 220);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.ReadOnly = true;
            this.textBoxFullName.Size = new System.Drawing.Size(300, 30);
            this.textBoxFullName.TabIndex = 5;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAge.Location = new System.Drawing.Point(50, 270);
            this.labelAge.Name = "labelDOB";
            this.labelAge.Size = new System.Drawing.Size(124, 25);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age:";
            //
            // textBoxAge
            // 
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAge.Location = new System.Drawing.Point(250, 270);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(345, 30);
            this.textBoxAge.TabIndex = 7;
            this.Controls.Add(this.textBoxAge);

            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmail.Location = new System.Drawing.Point(50, 320);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(66, 25);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmail.Location = new System.Drawing.Point(250, 320);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(300, 30);
            this.textBoxEmail.TabIndex = 9;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPhoneNumber.Location = new System.Drawing.Point(50, 370);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(149, 25);
            this.labelPhoneNumber.TabIndex = 10;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(250, 370);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(300, 30);
            this.textBoxPhoneNumber.TabIndex = 11;
            // 
            // labelEmergencyContactNumber
            // 
            this.labelEmergencyContactNumber.AutoSize = true;
            this.labelEmergencyContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmergencyContactNumber.Location = new System.Drawing.Point(50, 420);
            this.labelEmergencyContactNumber.Name = "labelEmergencyContactNumber";
            this.labelEmergencyContactNumber.Size = new System.Drawing.Size(264, 25);
            this.labelEmergencyContactNumber.TabIndex = 12;
            this.labelEmergencyContactNumber.Text = "Emergency Contact Number:";
            // 
            // textBoxEmergencyContactNumber
            // 
            this.textBoxEmergencyContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmergencyContactNumber.Location = new System.Drawing.Point(300, 420);
            this.textBoxEmergencyContactNumber.Name = "textBoxEmergencyContactNumber";
            this.textBoxEmergencyContactNumber.ReadOnly = true;
            this.textBoxEmergencyContactNumber.Size = new System.Drawing.Size(250, 30);
            this.textBoxEmergencyContactNumber.TabIndex = 13;
            // 
            // labelEmergencyContactName
            // 
            this.labelEmergencyContactName.AutoSize = true;
            this.labelEmergencyContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmergencyContactName.Location = new System.Drawing.Point(50, 470);
            this.labelEmergencyContactName.Name = "labelEmergencyContactName";
            this.labelEmergencyContactName.Size = new System.Drawing.Size(247, 25);
            this.labelEmergencyContactName.TabIndex = 14;
            this.labelEmergencyContactName.Text = "Emergency Contact Name:";
            // 
            // textBoxEmergencyContactName
            // 
            this.textBoxEmergencyContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmergencyContactName.Location = new System.Drawing.Point(300, 470);
            this.textBoxEmergencyContactName.Name = "textBoxEmergencyContactName";
            this.textBoxEmergencyContactName.ReadOnly = true;
            this.textBoxEmergencyContactName.Size = new System.Drawing.Size(250, 30);
            this.textBoxEmergencyContactName.TabIndex = 15;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAddress.Location = new System.Drawing.Point(50, 520);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(91, 25);
            this.labelAddress.TabIndex = 16;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAddress.Location = new System.Drawing.Point(250, 520);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(300, 30);
            this.textBoxAddress.TabIndex = 17;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(773, 170);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 18;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(773, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBoxLeftLogo
            // 
            this.pictureBoxLeftLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftLogo.Image = global::Demo2.Properties.Resources.download; // Assign image from resources
            this.pictureBoxLeftLogo.Location = new System.Drawing.Point(35, 12); // Switched to the left
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
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(922, 13); // Switched to the right
            this.pictureBoxRightLogo.Name = "pictureBoxRightLogo";
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(81, 65);
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.panelHeader.Controls.Add(this.pictureBoxLeftLogo); // Switched order
            this.panelHeader.Controls.Add(this.pictureBoxRightLogo);
            this.panelHeader.Controls.Add(this.labelHiLCoe);
            this.panelHeader.Controls.Add(this.labelSchoolName);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1030, 100);
            this.panelHeader.TabIndex = 20;
            // 
            // DeleteStudentView
            // 
            this.ClientSize = new System.Drawing.Size(1030, 650);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxEmergencyContactName);
            this.Controls.Add(this.labelEmergencyContactName);
            this.Controls.Add(this.textBoxEmergencyContactNumber);
            this.Controls.Add(this.labelEmergencyContactNumber);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "DeleteStudentView";
            this.Text = "Delete Student";
            this.Load += new System.EventHandler(this.DeleteStudentView_Load); // Ensure this is only here
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}