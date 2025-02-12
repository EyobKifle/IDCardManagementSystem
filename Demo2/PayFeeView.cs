using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2
{
    public partial class PayFeeView : Form
    {
        private int userId;
        private string loggedInUserInitials;

        private string fullName;

        public PayFeeView(int userId, string initials)
        {
            InitializeComponent();
            this.userId = userId;
            this.loggedInUserInitials = initials;

            // Draw initials on the logo
            DrawInitialsOnLogo();

            // Attach event handlers
            this.Load += PayFeeView_Load;
        }

        private void PayFeeView_Load(object sender, EventArgs e)
        {
            // Load fee details from the database
            LoadFeeDetails();
        }

        private void DrawInitialsOnLogo()
        {
            // Create a bitmap with the same size as the PictureBox
            Bitmap bitmap = new Bitmap(pictureBoxRightLogo.Width, pictureBoxRightLogo.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Set the background color to (114, 186, 169)
                g.Clear(Color.FromArgb(114, 186, 169));

                // Draw the initials
                using (Font font = new Font("Arial", 24, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(loggedInUserInitials, font);
                    float x = (bitmap.Width - textSize.Width) / 2;
                    float y = (bitmap.Height - textSize.Height) / 2;
                    g.DrawString(loggedInUserInitials, font, Brushes.White, x, y);
                }
            }

            // Assign the bitmap to the PictureBox
            pictureBoxRightLogo.Image = bitmap;
        }

        private void LoadFeeDetails()
        {
            // Implement the logic to load fee details from the database
        }

       

        // Event handler for right logo click (initials logo)
        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("View Profile", null, (s, ev) => OpenProfileView());
            contextMenu.Items.Add("Help", null, (s, ev) => OpenHelpView());
            contextMenu.Show(pictureBoxRightLogo, new Point(0, pictureBoxRightLogo.Height));
        }

        private void OpenProfileView()
        {
            // Create an instance of ProfileView and pass the necessary data
            ProfileStudentView profileStudentView = new ProfileStudentView(userId, loggedInUserInitials);
            profileStudentView.Show(); // Show the ProfileView form
        }
        private void OpenHelpView()
        {
            HelpStudentView helpView = new HelpStudentView(userId, fullName);
            helpView.Show();
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            // Handle the back button click event
            MessageBox.Show("Navigating back to the previous screen.", "Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}