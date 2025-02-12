namespace Demo2
{
    partial class RequestReplacementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestReplacementForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonStolen = new System.Windows.Forms.Button();
            this.buttonDamaged = new System.Windows.Forms.Button();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.pictureBoxUpload = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightLogo = new System.Windows.Forms.PictureBox();
            this.labelHiLCoe = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(450, 150);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(326, 36);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Request Replacement";
            // 
            // buttonStolen
            // 
            this.buttonStolen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonStolen.Location = new System.Drawing.Point(400, 200);
            this.buttonStolen.Name = "buttonStolen";
            this.buttonStolen.Size = new System.Drawing.Size(120, 50);
            this.buttonStolen.TabIndex = 3;
            this.buttonStolen.Text = "STOLEN/LOST";
            this.buttonStolen.UseVisualStyleBackColor = false;
            this.buttonStolen.Click += new System.EventHandler(this.buttonStolen_Click);
            // 
            // buttonDamaged
            // 
            this.buttonDamaged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDamaged.Location = new System.Drawing.Point(623, 200);
            this.buttonDamaged.Name = "buttonDamaged";
            this.buttonDamaged.Size = new System.Drawing.Size(120, 50);
            this.buttonDamaged.TabIndex = 4;
            this.buttonDamaged.Text = "DAMAGED";
            this.buttonDamaged.UseVisualStyleBackColor = false;
            this.buttonDamaged.Click += new System.EventHandler(this.buttonDamaged_Click);
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelInstruction.Location = new System.Drawing.Point(175, 269);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(997, 29);
            this.labelInstruction.TabIndex = 5;
            this.labelInstruction.Text = "Upload a photo of the damaged card if Stolen or A government ID for verification " +
    "if Damaged.";
            // 
            // pictureBoxUpload
            // 
            this.pictureBoxUpload.BackColor = System.Drawing.Color.White;
            this.pictureBoxUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUpload.Location = new System.Drawing.Point(300, 310);
            this.pictureBoxUpload.Name = "pictureBoxUpload";
            this.pictureBoxUpload.Size = new System.Drawing.Size(600, 260);
            this.pictureBoxUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUpload.TabIndex = 6;
            this.pictureBoxUpload.TabStop = false;
            this.pictureBoxUpload.Click += new System.EventHandler(this.pictureBoxUpload_Click);
            // 
            // pictureBoxLeftLogo
            // 
            this.pictureBoxLeftLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftLogo.Image = global::Demo2.Properties.Resources.download;
            this.pictureBoxLeftLogo.Location = new System.Drawing.Point(1065, 10);
            this.pictureBoxLeftLogo.Name = "pictureBoxLeftLogo";
            this.pictureBoxLeftLogo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxLeftLogo.TabIndex = 1;
            this.pictureBoxLeftLogo.TabStop = false;
            this.pictureBoxLeftLogo.Click += new System.EventHandler(this.pictureBoxLeftLogo_Click);
            // 
            // pictureBoxRightLogo
            // 
            this.pictureBoxRightLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRightLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRightLogo.Image")));
            this.pictureBoxRightLogo.Location = new System.Drawing.Point(40, 10);
            this.pictureBoxRightLogo.Name = "pictureBoxRightLogo";
            this.pictureBoxRightLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxRightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightLogo.TabIndex = 0;
            this.pictureBoxRightLogo.TabStop = false;
            // 
            // labelHiLCoe
            // 
            this.labelHiLCoe.AutoSize = true;
            this.labelHiLCoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.labelHiLCoe.ForeColor = System.Drawing.Color.White;
            this.labelHiLCoe.Location = new System.Drawing.Point(250, 20);
            this.labelHiLCoe.Name = "labelHiLCoe";
            this.labelHiLCoe.Size = new System.Drawing.Size(190, 54);
            this.labelHiLCoe.TabIndex = 2;
            this.labelHiLCoe.Text = "HiLCoE";
            // 
            // labelSchoolName
            // 
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSchoolName.ForeColor = System.Drawing.Color.White;
            this.labelSchoolName.Location = new System.Drawing.Point(250, 80);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(603, 29);
            this.labelSchoolName.TabIndex = 3;
            this.labelSchoolName.Text = "School of Computer Science and Software Engineering";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.panelHeader.Controls.Add(this.pictureBoxRightLogo);
            this.panelHeader.Controls.Add(this.pictureBoxLeftLogo);
            this.panelHeader.Controls.Add(this.labelHiLCoe);
            this.panelHeader.Controls.Add(this.labelSchoolName);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 120);
            this.panelHeader.TabIndex = 1;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(158, 52);
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSubmit.Location = new System.Drawing.Point(400, 600);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(120, 50);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCancel.Location = new System.Drawing.Point(623, 600);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 50);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // RequestReplacementForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonStolen);
            this.Controls.Add(this.buttonDamaged);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.pictureBoxUpload);
            this.Name = "RequestReplacementForm";
            this.Text = "Request Replacement";
            this.Load += new System.EventHandler(this.RequestReplacementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonStolen;
        private System.Windows.Forms.Button buttonDamaged;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.PictureBox pictureBoxUpload;
        private System.Windows.Forms.PictureBox pictureBoxLeftLogo;
        private System.Windows.Forms.PictureBox pictureBoxRightLogo;
        private System.Windows.Forms.Label labelHiLCoe;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
    }
}