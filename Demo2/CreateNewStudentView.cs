using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace Demo2
{
    public partial class CreateNewStudentView : Form
    {
        // Retrieve the connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;

        private string loggedInUserInitials;
        private int userId;
        private string fullName;

        public CreateNewStudentView(string initials, int userId)
        {
            InitializeComponent();
            loggedInUserInitials = initials;
            this.userId = userId; // Initialize userId
            DrawInitialsOnLogo();
        }

        private void CreateNewStudentView_Load(object sender, EventArgs e)
        {
            // Any initialization logic can go here
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            string password = textBoxPassword.Text; // Assuming you have a textBoxPassword for the password

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("CreateStudent", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameters
                    command.Parameters.AddWithValue("@FullName", textBoxFullName.Text);
                    command.Parameters.AddWithValue("@DOB", dateTimePickerDOB.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", textBoxPhoneNumber.Text);
                    command.Parameters.AddWithValue("@EmergencyContactNumber", textBoxEmergencyContactNumber.Text);
                    command.Parameters.AddWithValue("@EmergencyContactName", textBoxEmergencyContactName.Text);
                    command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                    command.Parameters.AddWithValue("@ProfilePicturePath", string.IsNullOrEmpty(pictureBoxProfilePicture.ImageLocation) ? (object)DBNull.Value : pictureBoxProfilePicture.ImageLocation);
                    command.Parameters.AddWithValue("@Status", "Active");
                    command.Parameters.AddWithValue("@Password", password);

                    // Add output parameter for the generated student ID
                    SqlParameter studentIDParam = new SqlParameter("@StudentID", SqlDbType.VarChar, 20);
                    studentIDParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(studentIDParam);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Retrieve the generated student ID from the output parameter
                        string generatedStudentID = command.Parameters["@StudentID"].Value.ToString();

                        // Display the generated student ID in the TextBox
                        textBoxStudentID.Text = generatedStudentID;

                        MessageBox.Show($"Student created successfully! Student ID: {generatedStudentID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to create student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUploadProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select a Profile Picture"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfilePicture.ImageLocation = openFileDialog.FileName;
                pictureBoxProfilePicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void DrawInitialsOnLogo()
        {
            Bitmap bitmap = new Bitmap(pictureBoxRightLogo.Width, pictureBoxRightLogo.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Gray);
                using (Font font = new Font("Arial", 24, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(loggedInUserInitials, font);
                    float x = (bitmap.Width - textSize.Width) / 2;
                    float y = (bitmap.Height - textSize.Height) / 2;
                    g.DrawString(loggedInUserInitials, font, Brushes.White, x, y);
                }
            }
            pictureBoxRightLogo.Image = bitmap;
        }

        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("View Profile", null, (s, ev) => OpenProfileView());
            contextMenu.Items.Add("Help", null, (s, ev) => OpenHelpView());
            contextMenu.Show(pictureBoxRightLogo, new Point(0, pictureBoxRightLogo.Height));
        }

        // Open the ProfileDeanView form
        private void OpenProfileView()
        {
            ProfileDeanView profileView = new ProfileDeanView(userId, loggedInUserInitials);
            profileView.Show(); // Show the ProfileDeanView form
        }

        // Open the HelpDeanView form
        private void OpenHelpView()
        {
            HelpDeanView helpView = new HelpDeanView(userId, fullName);
            helpView.Show();
        }
    }
}