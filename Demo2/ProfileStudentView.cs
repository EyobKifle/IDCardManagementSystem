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
    public partial class ProfileStudentView : Form
    {
        private int userId;
        private string loggedInUserInitials;
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;
        private ContextMenuStrip contextMenuLogo;

        public ProfileStudentView(int userId, string initials)
        {
            InitializeComponent();
            this.userId = userId;
            this.loggedInUserInitials = initials;

            // Updated line: Draw initials on the left logo (pictureBoxLeftLogo)
            DrawInitialsOnLogo(pictureBoxLeftLogo, loggedInUserInitials, Color.FromArgb(0x72, 0xBA, 0xA9));

            InitializeContextMenu();
            pictureBoxRightLogo.Click += pictureBoxRightLogo_Click;

            this.Load += ProfileStudentView_Load;
            SetFieldsReadOnly(true);
        }

        private void SetFieldsReadOnly(bool isReadOnly)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = isReadOnly;
                }
            }
        }

        private void InitializeContextMenu()
        {
            contextMenuLogo = new ContextMenuStrip();

            var viewProfileMenuItem = new ToolStripMenuItem("View Profile", null, ViewProfileMenuItem_Click);
            var helpMenuItem = new ToolStripMenuItem("Help", null, HelpMenuItem_Click);

            contextMenuLogo.Items.AddRange(new ToolStripItem[] { viewProfileMenuItem, helpMenuItem });

            // Set context menu on the left picture box
            pictureBoxLeftLogo.ContextMenuStrip = contextMenuLogo;

            // Optionally, you can also add a context menu to the right logo, similar to the left logo
            pictureBoxRightLogo.ContextMenuStrip = contextMenuLogo;
        }

        private void pictureBoxLeftLogo_Click(object sender, EventArgs e)
        {
            // Show the context menu when the PictureBox is clicked
            contextMenuLogo.Show(pictureBoxLeftLogo, new Point(0, pictureBoxLeftLogo.Height));
        }

        private void ViewProfileMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Profile clicked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For assistance, contact support.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProfileStudentView_Load(object sender, EventArgs e)
        {
            try
            {
                var studentDetails = FetchStudentDetails(userId);
                if (studentDetails != null)
                {
                    PopulateFields(studentDetails);
                    LoadProfilePicture(studentDetails.ProfilePicturePath);
                }
                else
                {
                    MessageBox.Show("Student details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Ensure drawing initials happens after everything is loaded
                DrawInitialsOnLogo(pictureBoxLeftLogo, loggedInUserInitials, Color.FromArgb(0x72, 0xBA, 0xA9));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PopulateFields(StudentDetails details)
        {
            txtFullName.Text = details.FullName;
            txtAge.Text = details.Age.ToString();
            txtPhoneNumber.Text = details.PhoneNumber;
            txtEmail.Text = details.Email;
            txtAddress.Text = details.Address;
            txtEmergencyContactName.Text = details.EmergencyContactName;
            txtEmergencyContactNumber.Text = details.EmergencyContactNumber;
            txtIDCard.Text = details.IDCard;
        }

        private void LoadProfilePicture(string profilePicturePath)
        {
            if (!string.IsNullOrEmpty(profilePicturePath) && File.Exists(profilePicturePath))
            {
                pictureBox.Image = Image.FromFile(profilePicturePath);
            }
            else
            {
                pictureBox.Image = Properties.Resources.DefaultImage;
            }
        }

        private StudentDetails FetchStudentDetails(int userId)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("FetchStudentDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new StudentDetails
                            {
                                FullName = reader["FullName"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]), // Read Age instead of DOB
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString(),
                                EmergencyContactName = reader["EmergencyContactName"].ToString(),
                                EmergencyContactNumber = reader["EmergencyContactNumber"].ToString(),
                                IDCard = reader["StudentID"].ToString(),
                                ProfilePicturePath = reader["ProfilePicturePath"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching student details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void DrawInitialsOnLogo(PictureBox pictureBox, string initials, Color backgroundColor)
        {
            var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(backgroundColor);
                var font = new Font("Roboto", 24, FontStyle.Bold);
                var brush = Brushes.White;
                var textSize = graphics.MeasureString(initials, font);
                var x = (bitmap.Width - textSize.Width) / 2;
                var y = (bitmap.Height - textSize.Height) / 2;
                graphics.DrawString(initials, font, brush, x, y);
            }

            pictureBox.Image = bitmap;
        }

        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            // Handle the click event here (similar to how you've handled other events)
            MessageBox.Show("Right logo clicked.");
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
    }

    public class StudentDetails
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string ProfilePicturePath { get; set; }
        public string IDCard { get; set; }
    }
}
