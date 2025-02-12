using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Demo2
{
    public partial class DeanDashboardView : Form
    {
        private string loggedInUserInitials;
        private int userId;
        private string fullName;

        public DeanDashboardView(string fullName)
        {
            InitializeComponent();
            loggedInUserInitials = GetInitials(fullName); // Extract initials from full name
            DrawInitialsOnLeftLogo();
            InitializeToolTips();
        }

        public DeanDashboardView(string fullName, int userId) : this(fullName)
        {
            this.userId = userId;
        }

        public DeanDashboardView(int userId)
        {
            this.userId = userId;
        }

        private void DeanDashboardView_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            InitializeDashboardLayout();
        }

        private void InitializeDashboardLayout()
        {
            DrawInitialsOnLeftLogo();
        }

        // Method to extract initials from full name
        private string GetInitials(string fullName)
        {
            string[] names = fullName.Split(' ');
            if (names.Length >= 2)
            {
                return $"{names[0][0]}{names[1][0]}".ToUpper(); // First letter of first and last name
            }
            else if (names.Length == 1)
            {
                return names[0].Substring(0, Math.Min(2, names[0].Length)).ToUpper(); // First 2 letters
            }
            return "NA"; // Default if no name is provided
        }

        // Method to draw initials on the left logo
        private void DrawInitialsOnLeftLogo()
        {
            Bitmap bitmap = new Bitmap(pictureBoxLeftLogo.Width, pictureBoxLeftLogo.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Set background color to #72BAA9
                g.Clear(Color.FromArgb(0x72, 0xBA, 0xA9));
                using (Font font = new Font("Roboto", 24, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(loggedInUserInitials, font);
                    float x = (bitmap.Width - textSize.Width) / 2;
                    float y = (bitmap.Height - textSize.Height) / 2;
                    g.DrawString(loggedInUserInitials, font, Brushes.White, x, y);
                }
            }
            pictureBoxLeftLogo.Image = bitmap;
        }

        // Method to initialize tooltips
        private void InitializeToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnViewRequests, "Click to view all requests");
            toolTip.SetToolTip(btnIDCardHistory, "Click to view ID card history");
            toolTip.SetToolTip(btnCreateNewStudent, "Click to create a new student");
            toolTip.SetToolTip(btnDeleteStudent, "Click to delete a student");
        }

        private void BtnViewRequests_Click(object sender, EventArgs e)
        {
            // Pass the userId when creating the ViewRequests instance
            ViewRequests viewRequests = new ViewRequests(userId, loggedInUserInitials);
            viewRequests.Show();
        }

        private void BtnIDCardHistory_Click(object sender, EventArgs e)
        {
            // Pass both loggedInUserInitials and userId
            IdCardHistoryDean idCardHistory = new IdCardHistoryDean(loggedInUserInitials, userId);
            idCardHistory.Show();
        }

        private void BtnCreateNewStudent_Click(object sender, EventArgs e)
        {
            // Pass both loggedInUserInitials and userId
            CreateNewStudentView createNewStudent = new CreateNewStudentView(loggedInUserInitials, userId);
            createNewStudent.Show();
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Pass both loggedInUserInitials and userId
            DeleteStudentView deleteStudent = new DeleteStudentView(loggedInUserInitials, userId);
            deleteStudent.Show();
        }

        // Event handler for left logo click (initials logo)
        private void pictureBoxLeftLogo_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("View Profile", null, (s, ev) => OpenProfileView());
            contextMenu.Items.Add("Help", null, (s, ev) => OpenHelpView());
            contextMenu.Show(pictureBoxLeftLogo, new Point(0, pictureBoxLeftLogo.Height));
        }

        // Event handler for right logo click
        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("View Profile", null, (s, ev) => OpenProfileView());
            contextMenu.Items.Add("Help", null, (s, ev) => OpenHelpView());
            contextMenu.Show(pictureBoxRightLogo, new Point(0, pictureBoxRightLogo.Height));
        }

        private void OpenProfileView()
        {
            // Create an instance of ProfileDeanView and pass the necessary data
            ProfileDeanView profileView = new ProfileDeanView(userId, loggedInUserInitials);
            profileView.Show(); // Show the ProfileDeanView form
        }

        private void OpenHelpView()
        {
            HelpDeanView helpView = new HelpDeanView(userId, fullName);
            helpView.Show();
        }

        private void DeanDashboardView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }

    // Custom RoundButton class for rounded corners
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 30; // Adjust for roundness
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }
    }
}