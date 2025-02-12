using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Demo2
{
    public partial class RequestReplacementForm : Form
    {
        private int userId;
        private string loggedInUserInitials;
        private string fullName; 
        private string studentEmail;
        private string studentId;
        private string selectedReason;
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;

        // Constructor for RequestReplacementForm, passing the user ID
        public RequestReplacementForm(int userId, string loggedInUserInitials)
        {
            InitializeComponent();
            this.fullName = fullName; // Assign fullName correctly
            this.userId = userId; // Initialize the user ID
            this.loggedInUserInitials = loggedInUserInitials;
        }

        // Method to initialize functionalities
        private void InitializeFunctionality()
        {
            // Draw initials on the left logo
            if (!string.IsNullOrEmpty(fullName))
            {
                string initials = GetInitials(fullName);
                DrawInitialsOnLogo(initials); // Pass initials to DrawInitialsOnLogo
            }

            buttonStolen.Focus(); // Set default focus to the "Stolen" button
            pictureBoxUpload.Image = Properties.Resources.DefaultImage; // Set a default image
        }

        // Method to draw initials on the logo
        private void DrawInitialsOnLogo(string initials)
        {
            // Create a bitmap with the same size as the PictureBox
            Bitmap bitmap = new Bitmap(pictureBoxLeftLogo.Width, pictureBoxLeftLogo.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Set the background color to (114, 186, 169)
                g.Clear(Color.FromArgb(114, 186, 169));

                // Draw the initials
                using (Font font = new Font("Arial", 24, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(initials, font);
                    float x = (bitmap.Width - textSize.Width) / 2;
                    float y = (bitmap.Height - textSize.Height) / 2;
                    g.DrawString(initials, font, Brushes.White, x, y);
                }
            }

            // Assign the bitmap to the PictureBox
            pictureBoxLeftLogo.Image = bitmap;
        }

        // Method to get initials from student name
        private string GetInitials(string name)
        {
            string[] words = name.Split(' ');
            string initials = string.Empty;
            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    initials += word[0].ToString().ToUpper();
                }
            }
            return initials;
        }

        private void RequestReplacementForm_Load(object sender, EventArgs e)
        {
            // Fetch student information from the database
            FetchStudentInfo(userId);

            // Initialize all the necessary functionality
            InitializeFunctionality();
        }

        private void FetchStudentInfo(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("FetchStudentDetails", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", userId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fullName = reader["FullName"].ToString();
                                studentEmail = reader["Email"].ToString(); // Store email from DB
                                studentId = reader["StudentID"].ToString(); // Fetch and store the StudentID
                            }
                            else
                            {
                                MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close(); // Close form if student is not found
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching student info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void pictureBoxUpload_Click(object sender, EventArgs e)
        {
            // Open a file dialog to allow the user to upload an image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Ensure only one image is selected
                    if (pictureBoxUpload.Image != null)
                    {
                        MessageBox.Show("You can only upload one picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Load the selected image into the pictureBoxUpload
                    pictureBoxUpload.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void buttonStolen_Click(object sender, EventArgs e)
        {
            selectedReason = "Stolen/Lost";
            MessageBox.Show("You selected 'Stolen Or Lost'. Please upload a photo for verification.", "Stolen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDamaged_Click(object sender, EventArgs e)
        {
            selectedReason = "Damaged";
            MessageBox.Show("You selected 'Damaged'. Please upload a photo for verification.", "Damaged", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Ensure fullName is not null or empty
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Student name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure a reason is selected
            if (string.IsNullOrEmpty(selectedReason))
            {
                MessageBox.Show("Please select 'Stolen/Lost' or 'Damaged' before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure image is uploaded
            string evidencePath = SaveUploadedImage();
            if (string.IsNullOrEmpty(evidencePath))
            {
                MessageBox.Show("Please upload an image as evidence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save the request to the database
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SaveIDRequest", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        command.Parameters.AddWithValue("@StudentName", fullName);
                        command.Parameters.AddWithValue("@StudentEmail", studentEmail);
                        command.Parameters.AddWithValue("@Reason", selectedReason); // Use selectedReason
                        command.Parameters.AddWithValue("@EvidencePath", evidencePath);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Clear the form and close the current form
            ClearForm();
            this.Close();
        }

        private string SaveUploadedImage()
        {
            // Save the uploaded image to a folder and return the file path
            if (pictureBoxUpload.Image != null)
            {
                string uploadsDirectory = Path.Combine(Application.StartupPath, "Uploads");

                // Ensure the directory exists
                if (!Directory.Exists(uploadsDirectory))
                {
                    Directory.CreateDirectory(uploadsDirectory);
                }

                string imagePath = Path.Combine(uploadsDirectory, Guid.NewGuid().ToString() + ".jpg");
                pictureBoxUpload.Image.Save(imagePath);
                return imagePath;
            }
            return null;
        }

        // Event handler for View Profile menu item
        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileStudentView profileView = new ProfileStudentView(userId, loggedInUserInitials);
            profileView.Show();
        }

        // Event handler for Help menu item
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpStudentView helpView = new HelpStudentView(userId, loggedInUserInitials);
            helpView.Show();
        }

        private void pictureBoxLeftLogo_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("View Profile", null, viewProfileToolStripMenuItem_Click);
            contextMenu.Items.Add("Help", null, helpToolStripMenuItem_Click);
            contextMenu.Show(pictureBoxLeftLogo, new Point(0, pictureBoxLeftLogo.Height));
        }

        private void ClearForm()
        {
            // Clear the form fields and reset the pictureBox image
            pictureBoxUpload.Image = Properties.Resources.DefaultImage;
            buttonStolen.Focus();
        }
    }
}
