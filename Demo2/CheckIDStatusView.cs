using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2
{
    public partial class CheckIDStatusView : Form
    {
        private int loggedInUserId;
        private string loggedInUserInitials;
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;

        public CheckIDStatusView(int userId, string fullName)
        {
            InitializeComponent();
            this.Load += CheckIDStatusView_Load; // Wire up the Load event
            loggedInUserId = userId;
            loggedInUserInitials = GetInitials(fullName);
            DrawInitialsOnLogo(loggedInUserInitials);
        }

        private void CheckIDStatusView_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch ID card request details using the logged-in UserID
                var idRequestDetails = FetchIdRequestDetails(loggedInUserId);
                if (idRequestDetails != null)
                {
                    DisplayIdRequestDetails(idRequestDetails);
                }
                else
                {
                    MessageBox.Show("No ID card request details found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form if no details are found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form on error
            }
        }

        private void DisplayIdRequestDetails(IdRequestDetails idRequestDetails)
        {
            // Display the StudentID
            labelStudentIdValue.Text = idRequestDetails.StudentID;

            // Display the student name
            labelStudentNameValue.Text = idRequestDetails.StudentName;

            // Display the request date in short date format (e.g., MM/dd/yyyy)
            labelIssueDateValue.Text = idRequestDetails.RequestDate.ToShortDateString();

            // Display the expiration date in short date format (e.g., MM/dd/yyyy)
            labelExpirationDateValue.Text = idRequestDetails.ExpirationDate.ToShortDateString();

            // Display the status of the ID card request
            labelStatusValue.Text = idRequestDetails.Status;

            // Display any remarks associated with the ID card request
            labelRemarksValue.Text = idRequestDetails.Remarks;
        }

        private IdRequestDetails FetchIdRequestDetails(int userId)
        {
            IdRequestDetails idRequestDetails = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("FetchLatestIDRequestDetails", conn)) // Updated stored procedure name
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idRequestDetails = new IdRequestDetails
                                {
                                    StudentID = reader["StudentID"].ToString(),
                                    StudentName = reader["StudentName"].ToString(),
                                    RequestDate = Convert.ToDateTime(reader["RequestDate"]),
                                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]),
                                    Status = reader["Status"].ToString(),
                                    Remarks = reader["Remarks"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idRequestDetails;
        }

        private string GetInitials(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "NA"; // Return "NA" if the full name is null or empty
            }

            string[] names = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (names.Length >= 2)
            {
                return $"{names[0][0]}{names[1][0]}".ToUpper(); // First letter of first and last name
            }
            else if (names.Length == 1)
            {
                return names[0].Substring(0, Math.Min(2, names[0].Length)).ToUpper(); // First 2 letters
            }
            return "NA"; // Default if no name is provided
        }

        private void DrawInitialsOnLogo(string initials)
        {
            Bitmap bitmap = new Bitmap(pictureBoxLeftLogo.Width, pictureBoxLeftLogo.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Set background color to #72BAA9
                g.Clear(Color.FromArgb(0x72, 0xBA, 0xA9));
                using (Font font = new Font("Roboto", 24, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(initials, font);
                    float x = (bitmap.Width - textSize.Width) / 2;
                    float y = (bitmap.Height - textSize.Height) / 2;
                    g.DrawString(initials, font, Brushes.White, x, y);
                }
            }
            pictureBoxLeftLogo.Image = bitmap;
        }

        // Event handler for left logo click (initials logo)
        private void pictureBoxLeftLogo_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("View Profile", null, (s, ev) => OpenProfileView());
            contextMenu.Items.Add("Help", null, (s, ev) => OpenHelpView());
            contextMenu.Show(pictureBoxLeftLogo, new Point(0, pictureBoxLeftLogo.Height));
        }

        // Event handler for right logo click
        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            // No context menu for the right logo
        }

        private void OpenProfileView()
        {
            // Open ProfileStudentView instead of ProfileDeanView
            ProfileStudentView profileView = new ProfileStudentView(loggedInUserId, loggedInUserInitials);
            profileView.Show();
        }

        private void OpenHelpView()
        {
            HelpDeanView helpView = new HelpDeanView(loggedInUserId, loggedInUserInitials);
            helpView.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form when the back button is clicked
        }
    }

    public class IdRequestDetails
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}