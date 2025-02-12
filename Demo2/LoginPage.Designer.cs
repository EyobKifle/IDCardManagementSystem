using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Demo2
{
    partial class LoginPage
    {
        private System.ComponentModel.IContainer components = null;
        private Panel backgroundPanel;
        private Panel contentPanel;
        private Label welcomeLabel;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button loginButton;
        private LinkLabel forgotPasswordLink;
        private CheckBox showPasswordCheckBox;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::Demo2.Properties.Resources.download__1_; // Set your background image here
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; // Stretch the image to fill the panel
            this.backgroundPanel.Controls.Add(this.contentPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(800, 600);
            this.backgroundPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White; // Set background color to white
            this.contentPanel.Controls.Add(this.showPasswordCheckBox);
            this.contentPanel.Controls.Add(this.forgotPasswordLink);
            this.contentPanel.Controls.Add(this.loginButton);
            this.contentPanel.Controls.Add(this.passwordTextBox);
            this.contentPanel.Controls.Add(this.passwordLabel);
            this.contentPanel.Controls.Add(this.emailTextBox);
            this.contentPanel.Controls.Add(this.emailLabel);
            this.contentPanel.Controls.Add(this.welcomeLabel);
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(700, 600); // Reduced size by 1x (700x600)
            this.contentPanel.TabIndex = 1;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None; // Center the label
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Larger font size
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(225, 20); // Centered horizontally
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(250, 54);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Larger font size
            this.emailLabel.Location = new System.Drawing.Point(50, 100); // Positioned at the top-start of the emailTextBox
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(76, 32);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Larger font size
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.emailTextBox.Location = new System.Drawing.Point(50, 140); // Symmetrical to the edges
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(600, 39); // Fixed width, aligned to edges
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Larger font size
            this.passwordLabel.Location = new System.Drawing.Point(50, 200); // Positioned at the top-start of the passwordTextBox
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(116, 32);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Larger font size
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.passwordTextBox.Location = new System.Drawing.Point(50, 240); // Symmetrical to the edges
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(600, 39); // Fixed width, aligned to edges
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(0, 120, 215); // Medium blue color
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Larger font size
            this.loginButton.ForeColor = System.Drawing.Color.White; // White text color
            this.loginButton.Location = new System.Drawing.Point(50, 350); // Positioned below the passwordTextBox
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(600, 60); // Fixed width, aligned to edges
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Larger font size
            this.forgotPasswordLink.Location = new System.Drawing.Point(50, 430); // Positioned at the bottom-left
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(192, 28);
            this.forgotPasswordLink.TabIndex = 6;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password?";
            this.forgotPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLink_LinkClicked);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Larger font size
            this.showPasswordCheckBox.Location = new System.Drawing.Point(50, 300); // Positioned below the passwordTextBox
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(170, 32);
            this.showPasswordCheckBox.TabIndex = 7;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.Resize += new System.EventHandler(this.LoginPage_Resize);
            this.backgroundPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        // Helper method for rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {
            // Apply rounded corners to the content panel
            this.contentPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, contentPanel.Width, contentPanel.Height, 20, 20));
        }

        // Event handler to center the content panel when the form loads
        private void LoginPage_Load(object sender, EventArgs e)
        {
            CenterContentPanel();
        }

        // Event handler to center the content panel when the form is resized
        private void LoginPage_Resize(object sender, EventArgs e)
        {
            CenterContentPanel();
        }

        // Method to center the content panel and adjust its size
        private void CenterContentPanel()
        {
            // Calculate the center position of the form
            int centerX = (this.ClientSize.Width - contentPanel.Width) / 2;
            int centerY = (this.ClientSize.Height - contentPanel.Height) / 2;

            // Set the location of the content panel
            contentPanel.Location = new Point(centerX, centerY);
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = SystemColors.WindowText; // Reset to default text color
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Text = "Email";
                emailTextBox.ForeColor = SystemColors.GrayText; // Set to hint color
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = SystemColors.WindowText; // Reset to default text color
                passwordTextBox.UseSystemPasswordChar = true; // Enable password masking
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = SystemColors.GrayText; // Set to hint color
                passwordTextBox.UseSystemPasswordChar = false; // Disable password masking for hint
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked; // Toggle password visibility
        }

        // Validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Validate password (minimum 6 characters)
        private bool IsValidPassword(string password)
        {
            return password.Length >= 6;
        }
    }
}