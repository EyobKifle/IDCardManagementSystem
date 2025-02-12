namespace Demo2
{
    partial class PayFeeView
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelSchool = new System.Windows.Forms.Label();
            this.labelPayFees = new System.Windows.Forms.Label();
            this.labelCBE = new System.Windows.Forms.Label();
            this.labelDashenBank = new System.Windows.Forms.Label();
            this.labelTeleBirr = new System.Windows.Forms.Label();
            this.labelAbyssiniaBank = new System.Windows.Forms.Label();
            this.labelZemenBank = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pictureBoxLeftLogo
            // 
            this.pictureBoxLeftLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftLogo.Location = new System.Drawing.Point(14, 12);
            this.pictureBoxLeftLogo.Size = new System.Drawing.Size(100, 65);
            this.pictureBoxLeftLogo.Image = global::Demo2.Properties.Resources.download;
            this.pictureBoxLeftLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // 
            // pictureBoxRightLogo
            // 
            this.pictureBoxRightLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(186)))), ((int)(((byte)(169)))));
            this.pictureBoxRightLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(700, 10);
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxRightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightLogo.Click += new System.EventHandler(this.pictureBoxRightLogo_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(120, 10);
            this.labelHeader.Text = "HiLCoE";

            // 
            // labelSchool
            // 
            this.labelSchool.AutoSize = true;
            this.labelSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSchool.ForeColor = System.Drawing.Color.White;
            this.labelSchool.Location = new System.Drawing.Point(120, 50);
            this.labelSchool.Text = "School of Computer Science & Technology";

            // 
            // labelPayFees
            // 
            this.labelPayFees.AutoSize = true;
            this.labelPayFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPayFees.Location = new System.Drawing.Point(50, 150);
            this.labelPayFees.Text = "Pay your fees through the following options:";

            // 
            // labelCBE
            // 
            this.labelCBE.AutoSize = true;
            this.labelCBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCBE.Location = new System.Drawing.Point(50, 180);
            this.labelCBE.Text = "CBE - 1000********1";

            // 
            // labelDashenBank
            // 
            this.labelDashenBank.AutoSize = true;
            this.labelDashenBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDashenBank.Location = new System.Drawing.Point(50, 210);
            this.labelDashenBank.Text = "DASHEN BANK - 43**********";

            // 
            // labelTeleBirr
            // 
            this.labelTeleBirr.AutoSize = true;
            this.labelTeleBirr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTeleBirr.Location = new System.Drawing.Point(50, 240);
            this.labelTeleBirr.Text = "TELE BIRR - 09********";

            // 
            // labelAbyssiniaBank
            // 
            this.labelAbyssiniaBank.AutoSize = true;
            this.labelAbyssiniaBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAbyssiniaBank.Location = new System.Drawing.Point(50, 270);
            this.labelAbyssiniaBank.Text = "ABYSSINIA BANK - 63********";

            // 
            // labelZemenBank
            // 
            this.labelZemenBank.AutoSize = true;
            this.labelZemenBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelZemenBank.Location = new System.Drawing.Point(50, 300);
            this.labelZemenBank.Text = "ZEMEN BANK - 100000**********";

            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelNote.ForeColor = System.Drawing.Color.Red;
            this.labelNote.Location = new System.Drawing.Point(50, 350);
            this.labelNote.Text = "ANY PAYMENT MADE TO THE SCHOOL IS NON REFUNDABLE!!!!!!!";

            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(255, 92, 92);
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(650, 420);
            this.backButton.Size = new System.Drawing.Size(120, 40);
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(31, 80, 154);
            this.panelHeader.Controls.Add(this.pictureBoxLeftLogo);
            this.panelHeader.Controls.Add(this.pictureBoxRightLogo);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.labelSchool);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Size = new System.Drawing.Size(800, 100);

            // 
            // PayFeeView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(212, 235, 248);
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelPayFees);
            this.Controls.Add(this.labelCBE);
            this.Controls.Add(this.labelDashenBank);
            this.Controls.Add(this.labelTeleBirr);
            this.Controls.Add(this.labelAbyssiniaBank);
            this.Controls.Add(this.labelZemenBank);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.backButton);
            this.Text = "Pay Fees";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelSchool;
        private System.Windows.Forms.Label labelPayFees;
        private System.Windows.Forms.Label labelCBE;
        private System.Windows.Forms.Label labelDashenBank;
        private System.Windows.Forms.Label labelTeleBirr;
        private System.Windows.Forms.Label labelAbyssiniaBank;
        private System.Windows.Forms.Label labelZemenBank;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panelHeader;
    }
}
