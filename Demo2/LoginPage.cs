using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2
{
    public partial class LoginPage : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;

        public LoginPage()
        {
            InitializeComponent();
            AddPlaceholderText(emailTextBox, "Email");
            AddPlaceholderText(passwordTextBox, "Password");
        }

        private void AddPlaceholderText(TextBox textBox, string placeholderText)
        {
            // Add placeholder text
            if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == placeholderText)
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
                if (textBox == passwordTextBox) textBox.UseSystemPasswordChar = false;
            }

            // Handle focus events to remove placeholder text
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = string.Empty;
                    textBox.ForeColor = SystemColors.WindowText;
                    if (textBox == passwordTextBox) textBox.UseSystemPasswordChar = true;
                }
            };

            // Handle leave events to restore placeholder text
            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                    if (textBox == passwordTextBox) textBox.UseSystemPasswordChar = false;
                }
            };
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || email == "Email" || password == "Password")
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate credentials
            if (ValidateUserCredentials(email, password, out string role, out string fullName, out int userId))
            {
                OpenDashboard(role, fullName, userId);
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUserCredentials(string email, string password, out string role, out string fullName, out int userId)
        {
            role = string.Empty;
            fullName = string.Empty;
            userId = -1;

            string query = "ValidateLogin";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = Convert.ToInt32(reader["UserID"]);
                                role = reader["Role"].ToString();
                                fullName = $"{reader["FirstName"]} {reader["LastName"]}";
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        private void OpenDashboard(string role, string fullName, int userId)
        {
            switch (role)
            {
                case "Student":
                    // Fetch studentId using userId
                    string studentId = GetStudentIdByUserId(userId);
                    if (string.IsNullOrEmpty(studentId))
                    {
                        MessageBox.Show("Unable to fetch student ID. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Login successful! Opening Student Dashboard...");
                    StudentDashboardView studentDashboard = new StudentDashboardView(fullName, userId, studentId);
                    studentDashboard.Show();
                    this.Hide();
                    break;

                case "Dean":
                    MessageBox.Show("Login successful! Opening Dean Dashboard...");
                    DeanDashboardView deanDashboard = new DeanDashboardView(fullName, userId);
                    deanDashboard.Show();
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("Invalid role assigned to user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private string GetStudentIdByUserId(int userId)
        {
            string studentId = null;
            string query = "GetStudentIdByUserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserId", userId);

                        // Execute the stored procedure
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            studentId = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching student ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return studentId;
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Failed to request password reset. Please try again.");
        }
    }
}