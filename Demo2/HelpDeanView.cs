using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2
{
    public partial class HelpDeanView : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;
        private int userId;
        private string fullName;

        public HelpDeanView(int userId, string fullName)
        {
            InitializeComponent();
            this.userId = userId;
            this.fullName = fullName;
            this.Load += new System.EventHandler(this.HelpDeanView_Load);
        }

        private void HelpDeanView_Load(object sender, EventArgs e)
        {
            // Set the title of the form
            this.Text = "Help - Dean Dashboard";

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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadHelpContent()
        {
            // Load help content from the provided information
            rtbHelpContent.Text = @"
Welcome to the Dean Dashboard! This dashboard provides you with various tools and options to manage student-related tasks efficiently. Below is a detailed explanation of the buttons and their functionalities:

1. View Requests
Button: btnViewRequests

Tooltip: 'Click to view all requests'

Functionality:
This button allows you to view all student requests. When clicked, it opens the ViewRequests form, where you can see a list of requests submitted by students. You can review, approve, or deny these requests as needed.

2. ID Card History
Button: btnIDCardHistory

Tooltip: 'Click to view ID card history'

Functionality:
This button opens the IdCardHistoryDean form, where you can view the history of ID card requests and issuances. It provides a detailed log of all ID card-related activities, including when cards were issued, replaced, or deactivated.

3. Create New Student
Button: btnCreateNewStudent

Tooltip: 'Click to create a new student'

Functionality:
This button opens the CreateNewStudentView form, where you can add a new student to the system. You will be prompted to enter the student's details, such as name, ID, and other relevant information. This is useful for onboarding new students.

4. Delete Student
Button: btnDeleteStudent

Tooltip: 'Click to delete a student'

Functionality:
This button opens the DeleteStudentView form, where you can remove a student from the system. You will need to provide the student's ID or select them from a list to confirm the deletion. Use this option with caution, as it permanently removes the student's record.

5. Left Logo (Initials Logo)
Functionality:
Clicking on the left logo (which displays your initials) opens a context menu with two options:

- View Profile: Opens the ProfileDeanView form, where you can view and edit your profile information.
- Help: Opens the HelpDeanView form, which provides additional help and support information.

6. Right Logo
Functionality:
Similar to the left logo, clicking on the right logo opens a context menu with the same options:

- View Profile: Opens the ProfileDeanView form.
- Help: Opens the HelpDeanView form.
";
        }
    }
}