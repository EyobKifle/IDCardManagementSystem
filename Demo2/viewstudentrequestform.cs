using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace Demo2
{
    public partial class ViewStudentRequestForm : Form
    {
        private int requestId;
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;
        private ContextMenuStrip contextMenuLogo;
        private string loggedInUserInitials;
        private int userId;

        public ViewStudentRequestForm(int requestId, int userId)
        {
            InitializeComponent();
            this.requestId = requestId;
            this.userId = userId;
            FetchRequestDetails();
            InitializeContextMenu();
        }

        private void ViewStudentRequestForm_Load(object sender, EventArgs e)
        {
            FetchRequestDetails();
            InitializeContextMenu();
        }

        private void FetchRequestDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch request details using the stored procedure
                    using (SqlCommand command = new SqlCommand("GetStudentRequestDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RequestID", requestId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display request details
                                labelStudentName.Text = $"Student Name: {reader["StudentName"] ?? "N/A"}";
                                labelStudentEmail.Text = $"Student Email: {reader["StudentEmail"] ?? "N/A"}";
                                labelRequestDate.Text = $"Request Date: {(reader["RequestDate"] != DBNull.Value ? Convert.ToDateTime(reader["RequestDate"]).ToString("g") : "N/A")}";
                                labelRequestStatus.Text = $"Request Status: {reader["RequestStatus"] ?? "N/A"}";
                                labelReason.Text = $"Reason: {reader["RequestReason"] ?? "N/A"}";

                                // Load evidence image
                                string evidencePath = reader["RequestEvidencePath"] != DBNull.Value ? reader["RequestEvidencePath"].ToString() : null;
                                if (!string.IsNullOrEmpty(evidencePath) && File.Exists(evidencePath))
                                {
                                    pictureBoxEvidence.Image = Image.FromFile(evidencePath);
                                    labelEvidencePath.Text = "Evidence Image Loaded Successfully.";
                                }
                                else
                                {
                                    labelEvidencePath.Text = "Evidence Path: N/A";
                                    pictureBoxEvidence.Image = null;
                                }

                                // Fetch and load the student's profile picture using a stored procedure
                                string studentId = reader["StudentID"].ToString();
                                string studentProfilePicturePath = GetStudentProfilePicturePathUsingProcedure(studentId);
                                if (!string.IsNullOrEmpty(studentProfilePicturePath) && File.Exists(studentProfilePicturePath))
                                {
                                    pictureBoxProfile.Image?.Dispose(); // Dispose previous image
                                    pictureBoxProfile.Image = Image.FromFile(studentProfilePicturePath);
                                }
                                else
                                {
                                    pictureBoxProfile.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Request details not found.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
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

        private string GetStudentProfilePicturePathUsingProcedure(string studentId)
        {
            string profilePicturePath = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a stored procedure to fetch the student's profile picture path
                    using (SqlCommand command = new SqlCommand("GetStudentProfilePicturePath", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", studentId);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            profilePicturePath = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the student's profile picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return profilePicturePath;
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            UpdateRequestStatus("Approved", string.Empty);
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            using (RejectReasonDialog rejectReasonDialog = new RejectReasonDialog())
            {
                if (rejectReasonDialog.ShowDialog() == DialogResult.OK)
                {
                    UpdateRequestStatus("Rejected", rejectReasonDialog.Remark);
                }
            }
        }

        private void UpdateRequestStatus(string status, string rejectReason)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a stored procedure to update the request status
                    using (SqlCommand command = new SqlCommand("UpdateRequestStatus", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RequestID", requestId);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@RejectReason", status == "Rejected" ? rejectReason : (object)DBNull.Value);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Request has been {status.ToLower()}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeContextMenu()
        {
            contextMenuLogo = new ContextMenuStrip();

            ToolStripMenuItem viewProfileMenuItem = new ToolStripMenuItem("View Profile");
            ToolStripMenuItem helpMenuItem = new ToolStripMenuItem("Help");

            viewProfileMenuItem.Click += ViewProfileMenuItem_Click;
            helpMenuItem.Click += HelpMenuItem_Click;

            contextMenuLogo.Items.Add(viewProfileMenuItem);
            contextMenuLogo.Items.Add(helpMenuItem);

            pictureBoxRightLogo.ContextMenuStrip = contextMenuLogo;
        }

        private void ViewProfileMenuItem_Click(object sender, EventArgs e)
        {
            using (ProfileDeanView profileView = new ProfileDeanView(userId, loggedInUserInitials))
            {
                profileView.ShowDialog(); // Show the ProfileDeanView form
            }
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            using (HelpDeanView helpView = new HelpDeanView(userId, loggedInUserInitials))
            {
                helpView.ShowDialog(); // Show the HelpDeanView form
            }
        }

        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            contextMenuLogo.Show(pictureBoxRightLogo, new Point(0, pictureBoxRightLogo.Height)); // Show context menu on logo click
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}