using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;

namespace Demo2
{
    public partial class ProfileDeanView : Form
    {
        private int userId;
        private string loggedInUserInitials;

        // Retrieve the connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;

        // Declare contextMenuLogo here
        private ContextMenuStrip contextMenuLogo;

        // Constructor to accept userId and initials
        public ProfileDeanView(int userId, string initials)
        {
            InitializeComponent();
            this.userId = userId;
            this.loggedInUserInitials = initials;

            // Draw initials on the logo
            DrawInitialsOnLogo(pictureBoxLeftLogo, loggedInUserInitials, Color.FromArgb(0x72, 0xBA, 0xA9));

            // Initialize the context menu
            InitializeContextMenu();

            // Attach event handlers
            this.Load += ProfileDeanView_Load;

            // Set textboxes to read-only
            txtFullName.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtEmergencyContactName.ReadOnly = true;
            txtEmergencyContactPhone.ReadOnly = true;
        }

        private void InitializeContextMenu()
        {
            // Create a new ContextMenuStrip
            contextMenuLogo = new ContextMenuStrip();

            // Add menu items
            ToolStripMenuItem viewProfileMenuItem = new ToolStripMenuItem("View Profile");
            ToolStripMenuItem helpMenuItem = new ToolStripMenuItem("Help");

            // Add event handlers for the menu items
            viewProfileMenuItem.Click += ViewProfileMenuItem_Click;
            helpMenuItem.Click += HelpMenuItem_Click;

            // Add the menu items to the context menu
            contextMenuLogo.Items.Add(viewProfileMenuItem);
            contextMenuLogo.Items.Add(helpMenuItem);

            // Associate the context menu with the PictureBox (e.g., pictureBoxRightLogo)
            pictureBoxRightLogo.ContextMenuStrip = contextMenuLogo;
        }

        private void ViewProfileMenuItem_Click(object sender, EventArgs e)
        {
            // Open the ProfileView form (or refresh the current form)
            MessageBox.Show("View Profile clicked.");
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Help form or display help information
            MessageBox.Show("Help clicked.");
        }

        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            // Show the context menu when the PictureBox is clicked
            contextMenuLogo.Show(pictureBoxRightLogo, new Point(0, pictureBoxRightLogo.Height));
        }

        private void ProfileDeanView_Load(object sender, EventArgs e)
        {
            // Fetch and display dean profile details
            var deanDetails = FetchDeanProfile(userId);
            if (deanDetails != null)
            {
                // Populate the textboxes with dean details
                txtFullName.Text = deanDetails.FullName;
                txtAge.Text = deanDetails.Age.ToString();
                txtPhoneNumber.Text = deanDetails.PhoneNumber;
                txtEmail.Text = deanDetails.Email;
                txtAddress.Text = deanDetails.Address;
                txtEmergencyContactName.Text = deanDetails.EmergencyContactName;
                txtEmergencyContactPhone.Text = deanDetails.EmergencyContactPhone;
            }
            else
            {
                MessageBox.Show("Dean details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Load profile picture
            string profilePicturePath = GetProfilePicturePathFromDatabase(userId);
            if (!string.IsNullOrEmpty(profilePicturePath) && File.Exists(profilePicturePath))
            {
                pictureBox.Image = Image.FromFile(profilePicturePath);
            }
            else
            {
                pictureBox.Image = Properties.Resources.DefaultImage;
            }
        }

        private DeanDetails FetchDeanProfile(int userId)
        {
            DeanDetails deanDetails = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("FetchDeanProfile", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                deanDetails = new DeanDetails
                                {
                                    FullName = reader["FullName"].ToString(),
                                    Age = Convert.ToInt32(reader["Age"]), // Read Age instead of DOB
                                    PhoneNumber = reader["PhoneNumber"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    EmergencyContactName = reader["EmergencyContactName"].ToString(),
                                    EmergencyContactPhone = reader["EmergencyContactPhone"].ToString(),
                                    ProfilePicturePath = reader["ProfilePicturePath"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching dean details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return deanDetails;
        }

        private void DrawInitialsOnLogo(PictureBox pictureBox, string initials, Color backgroundColor)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(backgroundColor);
                Font font = new Font("Roboto", 24, FontStyle.Bold);
                Brush brush = Brushes.White;
                SizeF textSize = graphics.MeasureString(initials, font);
                float x = (pictureBox.Width - textSize.Width) / 2;
                float y = (pictureBox.Height - textSize.Height) / 2;
                graphics.DrawString(initials, font, brush, x, y);
            }
            pictureBox.Image = bitmap;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    openForms.Add(form);
                }
            }

            foreach (Form form in openForms)
            {
                form.Close();
            }

            this.Close();
            Application.Restart();
        }

        private string GetProfilePicturePathFromDatabase(int userId)
        {
            string profilePicturePath = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetProfilePicturePath", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            profilePicturePath = reader["ProfilePicturePath"].ToString();
                        }
                    }
                }
            }

            return profilePicturePath;
        }
    }

    public class DeanDetails
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string ProfilePicturePath { get; set; }
    }
}