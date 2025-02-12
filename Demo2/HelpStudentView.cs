using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2
{
    public partial class HelpStudentView : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;
        private int userId;
        private string fullName;

        public HelpStudentView(int userId, string fullName)
        {
            InitializeComponent();
            this.userId = userId;
            this.fullName = fullName;
            this.Load += new System.EventHandler(this.HelpStudentView_Load);
        }

        private void HelpStudentView_Load(object sender, EventArgs e)
        {
            // Set the title of the form
            this.Text = "Help - Student Dashboard";

            // Load help content into the RichTextBox
            LoadHelpContent();

            // Set the background color of the form
            this.BackColor = Color.White;

            // Set the font for the RichTextBox
            rtbHelpContent.Font = new Font("Arial", 12, FontStyle.Regular);

            // Set the initial focus to the RichTextBox
            rtbHelpContent.Focus();

            // Set the header panel background color
            panelHeader.BackColor = Color.FromArgb(31, 80, 154);

            // Set the school name and HiLCoE label colors
            labelHiLCoe.ForeColor = Color.White;
            labelSchoolName.ForeColor = Color.White;

            // Set the back button style
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(31, 80, 154);
            btnBack.ForeColor = Color.White;
            btnBack.Font = new Font("Arial", 12, FontStyle.Bold);

            // Set the help title label style
            lblHelpTitle.Font = new Font("Arial", 20, FontStyle.Bold);
            lblHelpTitle.ForeColor = Color.FromArgb(31, 80, 154);

            // Center the help title label
            lblHelpTitle.Location = new Point((this.ClientSize.Width - lblHelpTitle.Width) / 2, 120);

            // Center the back button
            btnBack.Location = new Point((this.ClientSize.Width - btnBack.Width) / 2, 530);
        }

        private void LoadHelpContent()
        {
            // Updated help content
            string helpContent = @"
Welcome to the Student Dashboard! This guide will help you navigate through the various features and functionalities available to you.

1. Request Replacement
   - What it does: Use this option to request a replacement for your student ID card if it is lost, stolen, or damaged.
   - How to use: Click the ""Request Replacement"" button, fill out the required details, and submit your request.

2. Check ID Status
   - What it does: Check the status of your student ID card (e.g., whether it is ready for pickup or still in process).
   - How to use: Click the ""Check ID Status"" button to view the current status of your ID card.

3. Update Information
   - What it does: Update your personal information, such as your address, phone number, or email.
   - How to use: Click the ""Update Information"" button, make the necessary changes, and save your updates.

4. Contact Information
   - What it does: View the contact information for the student services department or other relevant offices.
   - How to use: Click the ""Contact Information"" button to access the contact details.

5. Pay Fee
   - What it does: Pay any outstanding fees related to your student ID card or other services.
   - How to use: Click the ""Pay Fee"" button, enter your payment details, and complete the transaction.

6. View Request History
   - What it does: View a history of all your previous requests, such as ID replacements or fee payments.
   - How to use: Click the ""View Request History"" button to see a list of your past requests.

7. Profile
   - What it does: Access and manage your student profile, including your personal details and account settings.
   - How to use: Right-click on the left logo and select ""View Profile"" from the dropdown menu.

8. Help
   - What it does: Access this help guide for assistance with using the student dashboard.
   - How to use: Right-click on the left logo and select ""Help"" from the dropdown menu.
";

            // Set the help content in the RichTextBox
            rtbHelpContent.Text = helpContent;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}