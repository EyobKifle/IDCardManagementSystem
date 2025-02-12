using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Demo2
{
    public partial class DeleteStudentView : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;
        private string loggedInUserInitials;
        private int userId;
        private ContextMenuStrip contextMenuRightLogo;
        private string fullName;

        public DeleteStudentView(string loggedInUserInitials, int userId)
        {
            InitializeComponent();
            this.loggedInUserInitials = loggedInUserInitials;
            this.userId = userId; // Initialize userId
            DrawInitialsOnLogo(loggedInUserInitials);
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            // Create a new ContextMenuStrip
            contextMenuRightLogo = new ContextMenuStrip();

            // Add menu items
            ToolStripMenuItem viewProfileMenuItem = new ToolStripMenuItem("View Profile");
            ToolStripMenuItem helpMenuItem = new ToolStripMenuItem("Help");

            // Add event handlers for the menu items
            viewProfileMenuItem.Click += viewProfileMenuItem_Click; // Fixed event handler
            helpMenuItem.Click += helpMenuItem_Click;

            // Add the menu items to the context menu
            contextMenuRightLogo.Items.Add(viewProfileMenuItem);
            contextMenuRightLogo.Items.Add(helpMenuItem);

            // Associate the context menu with the PictureBox (e.g., pictureBoxRightLogo)
            pictureBoxRightLogo.ContextMenuStrip = contextMenuRightLogo;
        }

        // Define the viewProfileMenuItem_Click event handler
        private void viewProfileMenuItem_Click(object sender, EventArgs e)
        {
            OpenProfileView(); // Call the OpenProfileView method
        }

        private void DrawInitialsOnLogo(string initials)
        {
            Bitmap bitmap = new Bitmap(pictureBoxRightLogo.Width, pictureBoxRightLogo.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Gray);
                Font font = new Font("Arial", 24, FontStyle.Bold);
                Brush brush = Brushes.White;
                SizeF textSize = graphics.MeasureString(initials, font);
                float x = (bitmap.Width - textSize.Width) / 2;
                float y = (bitmap.Height - textSize.Height) / 2;
                graphics.DrawString(initials, font, brush, x, y);
            }
            pictureBoxRightLogo.Image = bitmap;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a student name or ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SearchStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate student details
                                textBoxStudentId.Text = reader["StudentID"].ToString();
                                textBoxFullName.Text = reader["FullName"].ToString();
                                textBoxAge.Text = reader["Age"].ToString(); // Display Age instead of DOB
                                textBoxEmail.Text = reader["Email"].ToString();
                                textBoxPhoneNumber.Text = reader["PhoneNumber"].ToString();
                                textBoxEmergencyContactNumber.Text = reader["EmergencyContactNumber"].ToString();
                                textBoxEmergencyContactName.Text = reader["EmergencyContactName"].ToString();
                                textBoxAddress.Text = reader["Address"].ToString();

                                // Fetch and display the profile picture
                                string profilePicturePath = reader["ProfilePicturePath"].ToString();
                                LoadProfilePicture(profilePicturePath);
                            }
                            else
                            {
                                MessageBox.Show("No matching student found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentId = textBoxStudentId.Text.Trim();

            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("No student selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the confirmation message to reflect the "delete" action
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("SoftDeleteStudent", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@StudentID", studentId);

                            // Execute the stored procedure
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Student marked as deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm();
                            }
                            else
                            {
                                MessageBox.Show("Failed to mark student as deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            textBoxSearch.Text = "";
            textBoxStudentId.Text = "";
            textBoxFullName.Text = "";
            textBoxAge.Text = ""; // Clear the Age field
            textBoxEmail.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxEmergencyContactNumber.Text = "";
            textBoxEmergencyContactName.Text = "";
            textBoxAddress.Text = "";
            pictureBoxProfilePicture.Image = null; // Clear the profile picture
        }

        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            contextMenuRightLogo.Show(pictureBoxRightLogo, new Point(0, pictureBoxRightLogo.Height));
        }

        private void OpenProfileView()
        {
            // Create an instance of ProfileDeanView and pass the necessary data
            ProfileDeanView profileView = new ProfileDeanView(userId, loggedInUserInitials);
            profileView.Show(); // Show the ProfileDeanView form
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            // Open HelpDeanView form
            HelpDeanView helpView = new HelpDeanView(userId, fullName);
            helpView.Show();
        }

        // Add the Load event handler
        private void DeleteStudentView_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here
            MessageBox.Show("Delete Student View loaded.");
        }

        // Method to load the profile picture
        private void LoadProfilePicture(string profilePicturePath)
        {
            if (!string.IsNullOrEmpty(profilePicturePath))
            {
                string baseImagePath = @"C:\Images\Profiles\"; // Replace with your base image path
                string fullPath = Path.Combine(baseImagePath, profilePicturePath);

                if (File.Exists(fullPath))
                {
                    pictureBoxProfilePicture.Image = Image.FromFile(fullPath);
                }
                else
                {
                    pictureBoxProfilePicture.Image = Properties.Resources.DefaultImage; // Use a default image if the file doesn't exist
                }
            }
            else
            {
                pictureBoxProfilePicture.Image = Properties.Resources.DefaultImage; // Use a default image if no path is provided
            }
        }
    }

    // Extension method to check for column existence
    public static class SqlDataReaderExtensions
    {
        public static bool HasColumn(this SqlDataReader reader, string columnName)
        {
            try
            {
                return reader.GetOrdinal(columnName) >= 0;
            }
            catch
            {
                return false;
            }
        }
    }
}