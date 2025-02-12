using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2
{
    public partial class ContactInformationView : Form
    {
        private string loggedInUserInitials;
        private int userId;
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;
        private string fullName;

        public ContactInformationView(string loggedInUserInitials, int userId, string fullName)
        {
            InitializeComponent();
            this.loggedInUserInitials = loggedInUserInitials;
            this.userId = userId;
            this.fullName = fullName;
            InitializeDashboardLayout();
            LoadContactInformation();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeDashboardLayout()
        {
            SetLeftLogo();    // Set the left logo to the downloaded logo from resources
            DrawInitialsOnRightLogo();  // Right logo with initials and context menu
        }

        private void SetLeftLogo()
        {
            // Set the left logo to the image from resources (downloaded logo)
            pictureBoxLeftLogo.Image = Properties.Resources.download;
        }

        private void DrawInitialsOnRightLogo()
        {
            Bitmap bitmap = new Bitmap(pictureBoxRightLogo.Width, pictureBoxRightLogo.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.FromArgb(0x72, 0xBA, 0xA9));
                using (Font font = new Font("Roboto", 24, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(loggedInUserInitials, font);
                    float x = (bitmap.Width - textSize.Width) / 2;
                    float y = (bitmap.Height - textSize.Height) / 2;
                    g.DrawString(loggedInUserInitials, font, Brushes.White, x, y);
                }
            }
            pictureBoxRightLogo.Image = bitmap;
        }

        private void pictureBoxLeftLogo_Click(object sender, EventArgs e)
        {
            // No context menu for the left logo
        }

        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            // Show context menu for the right logo
            ShowContextMenu(pictureBoxRightLogo);
        }

        private void ShowContextMenu(PictureBox pictureBox)
        {
            // Creating context menu and adding items
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            var viewProfileMenuItem = new ToolStripMenuItem("View Profile", null, viewProfileMenuItem_Click);
            var helpMenuItem = new ToolStripMenuItem("Help", null, helpMenuItem_Click);
            contextMenu.Items.Add(viewProfileMenuItem);
            contextMenu.Items.Add(helpMenuItem);
            contextMenu.Show(pictureBox, new Point(0, pictureBox.Height));
        }

        private void viewProfileMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ProfileStudentView"] == null)
            {
                ProfileStudentView profileView = new ProfileStudentView(userId, loggedInUserInitials);
                profileView.Show();
            }
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HelpStudentView"] == null)
            {
                HelpStudentView helpView = new HelpStudentView(userId, fullName);
                helpView.Show();
            }
        }

        private void LoadContactInformation()
        {
            rtbContactContent.Text = "For support, please contact:\n\n" +
                                     "Email: support@hilcoe.com\n" +
                                     "Phone: +251 111 223344\n" +
                                     "Address: HiLCoE School of Computer Science\n" +
                                     "P.O. Box 12345, Addis Ababa, Ethiopia\n\n" +
                                     "Our support team is available Monday to Friday, 9:00 AM to 5:00 PM.";
        }

        private void ContactInformationView_Load(object sender, EventArgs e)
        {
            InitializeDashboardLayout();
        }

        private void ContactInformationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
