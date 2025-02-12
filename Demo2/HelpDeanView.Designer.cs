namespace Demo2
{
    partial class HelpDeanView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHelpTitle;
        private System.Windows.Forms.RichTextBox rtbHelpContent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenuRightLogo;
        private System.Windows.Forms.ToolStripMenuItem viewProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDeanView));
            this.lblHelpTitle = new System.Windows.Forms.Label();
            this.rtbHelpContent = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.labelHiLCoe = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.contextMenuRightLogo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.contextMenuRightLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelpTitle
            // 
            this.lblHelpTitle.AutoSize = true;
            this.lblHelpTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.lblHelpTitle.Location = new System.Drawing.Point(20, 120);
            this.lblHelpTitle.Name = "lblHelpTitle";
            this.lblHelpTitle.Size = new System.Drawing.Size(530, 40);
            this.lblHelpTitle.TabIndex = 0;
            this.lblHelpTitle.Text = "Help Guide for Dean Dashboard";
            // 
            // rtbHelpContent
            // 
            this.rtbHelpContent.BackColor = System.Drawing.Color.White;
            this.rtbHelpContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHelpContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHelpContent.Location = new System.Drawing.Point(20, 170);
            this.rtbHelpContent.Name = "rtbHelpContent";
            this.rtbHelpContent.ReadOnly = true;
            this.rtbHelpContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbHelpContent.Size = new System.Drawing.Size(938, 342);
            this.rtbHelpContent.TabIndex = 1;
            this.rtbHelpContent.Text = resources.GetString("rtbHelpContent.Text");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(340, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictureBoxLeftLogo
            // 
            this.pictureBoxLeftLogo.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxLeftLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(884, 12);
            this.pictureBoxRightLogo.Name = "pictureBoxRightLogo";
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(81, 65);
            this.pictureBoxRightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightLogo.TabIndex = 4;
            this.pictureBoxRightLogo.TabStop = false;
            // 
            // labelHiLCoe
            // 
            this.labelHiLCoe.AutoSize = true;
            this.labelHiLCoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 100);
            this.panelHeader.TabIndex = 1;
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
            // HelpDeanView
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rtbHelpContent);
            this.Controls.Add(this.lblHelpTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpDeanView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help View";
            this.Load += new System.EventHandler(this.HelpDeanView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.contextMenuRightLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}