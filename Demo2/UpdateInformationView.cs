using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace Demo2
{
    public partial class UpdateProfileView : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;
        private string loggedInUserInitials;
        private int _userId;
        private string fullName;
        private string profilePicturesFolder = Path.Combine(Application.StartupPath, "ProfilePictures");

        public UpdateProfileView(string initials, int userId, string fullName)
        {
            InitializeComponent();
            loggedInUserInitials = initials;
            _userId = userId;
            this.fullName = fullName;

            DrawInitialsOnLogo();
        }

        private void UpdateProfileView_Load(object sender, EventArgs e)
        {
            // Ensure ProfilePictures directory exists
            if (!Directory.Exists(profilePicturesFolder))
            {
                Directory.CreateDirectory(profilePicturesFolder);
            }

            // Fetch the most recent user data every time the form is loaded
            FetchUserData();
        }

        private void FetchUserData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("FetchStudentDetail", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", _userId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxFullName.Text = reader["FullName"].ToString();
                        dateTimePickerDOB.Value = Convert.ToDateTime(reader["DOB"]);
                        textBoxEmail.Text = reader["Email"].ToString();
                        textBoxPhoneNumber.Text = reader["PhoneNumber"].ToString();
                        textBoxEmergencyContactNumber.Text = reader["EmergencyContactNumber"].ToString();
                        textBoxEmergencyContactName.Text = reader["EmergencyContactName"].ToString();
                        textBoxAddress.Text = reader["Address"].ToString();

                        // Fetch and display profile picture
                        string profilePicturePath = reader["ProfilePicturePath"].ToString();
                        if (!string.IsNullOrEmpty(profilePicturePath) && File.Exists(profilePicturePath))
                        {
                            pictureBoxProfilePicture.Image = Image.FromFile(profilePicturePath);
                            pictureBoxProfilePicture.Tag = profilePicturePath; // Store the path in the Tag property
                        }
                        else
                        {
                            pictureBoxProfilePicture.Image = null;
                            pictureBoxProfilePicture.Tag = null;
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            string fullName = textBoxFullName.Text;
            string dob = dateTimePickerDOB.Value.ToString("yyyy-MM-dd");
            string email = textBoxEmail.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string emergencyContactNumber = textBoxEmergencyContactNumber.Text;
            string emergencyContactName = textBoxEmergencyContactName.Text;
            string address = textBoxAddress.Text;

            string profilePicturePath = pictureBoxProfilePicture.Tag?.ToString(); // Updated path after selecting new image

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("UpdateUserProfile", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", _userId);
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@EmergencyContactNumber", emergencyContactNumber);
                    command.Parameters.AddWithValue("@EmergencyContactName", emergencyContactName);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@ProfilePicturePath", string.IsNullOrEmpty(profilePicturePath) ? (object)DBNull.Value : profilePicturePath);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected < 0)
                    {
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FetchUserData();  // Refresh data after update
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadProfilePicture_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Save the selected image to the ProfilePictures folder
                        string destinationPath = Path.Combine(profilePicturesFolder, Path.GetFileName(openFileDialog.FileName));
                        File.Copy(openFileDialog.FileName, destinationPath, true);

                        // Load the selected image into the PictureBox
                        pictureBoxProfilePicture.Image = Image.FromFile(destinationPath);
                        pictureBoxProfilePicture.Tag = destinationPath; // Store the new path in the Tag property
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBoxFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Invalid Email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(textBoxPhoneNumber.Text))
            {
                MessageBox.Show("Invalid Phone Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

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

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawInitialsOnLogo()
        {
            Bitmap bitmap = new Bitmap(pictureBoxLeftLogo.Width, pictureBoxLeftLogo.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.FromArgb(114, 186, 169));

                using (Font font = new Font("Arial", 24, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(loggedInUserInitials, font);
                    float x = (bitmap.Width - textSize.Width) / 2;
                    float y = (bitmap.Height - textSize.Height) / 2;
                    g.DrawString(loggedInUserInitials, font, Brushes.White, x, y);
                }
            }

            pictureBoxLeftLogo.Image = bitmap;
        }

        // Event handler for View Profile menu item
        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileStudentView profileView = new ProfileStudentView(_userId, loggedInUserInitials);
            profileView.Show();
        }

        // Event handler for Help menu item
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpStudentView helpView = new HelpStudentView(_userId, fullName);
            helpView.Show();
        }

        // Right-click on logo to show context menu
        private void pictureBoxLeftLogo_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("View Profile", null, viewProfileToolStripMenuItem_Click);
            contextMenu.Items.Add("Help", null, helpToolStripMenuItem_Click);
            contextMenu.Show(pictureBoxLeftLogo, new Point(0, pictureBoxLeftLogo.Height));
        }
    }
}