using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;

namespace Demo2
{
    public partial class ViewRequests : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;
        private int userId; // Dean's user ID
        private string loggedInUserInitials; // User initials for the logo
        private ContextMenuStrip contextMenuLogo; // Context menu

        public ViewRequests(int userId, string loggedInUserInitials)
        {
            InitializeComponent();
            this.userId = userId;
            this.loggedInUserInitials = loggedInUserInitials;

            // Attach click event handler for the dropdown menu on the right logo
            pictureBoxRightLogo.Click += pictureBoxRightLogo_Click;

            // Attach double-click event handler for DataGridView
            dataGridViewRequests.CellDoubleClick += DataGridViewRequests_CellDoubleClick;

            // Initialize the context menu
            InitializeContextMenu();

            // Draw initials on the right logo
            DrawInitialsOnLogo(pictureBoxRightLogo, loggedInUserInitials, Color.Blue);
        }

        private void ViewRequests_Load(object sender, EventArgs e)
        {
            LoadRequests();
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

            // Attach context menu to the right logo
            pictureBoxRightLogo.ContextMenuStrip = contextMenuLogo;
        }

        private void pictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            contextMenuLogo.Show(pictureBoxRightLogo, new Point(0, pictureBoxRightLogo.Height));
        }

        private void ViewProfileMenuItem_Click(object sender, EventArgs e)
        {
            ProfileDeanView profileView = new ProfileDeanView(userId, loggedInUserInitials);
            profileView.Show(); // Show the ProfileDeanView form
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            // Open HelpDeanView form
            HelpDeanView helpView = new HelpDeanView(userId, loggedInUserInitials);
            helpView.Show();
        }

        private void DrawInitialsOnLogo(PictureBox pictureBox, string name, Color backgroundColor)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(backgroundColor);
                Font font = new Font("Roboto", 24, FontStyle.Bold);
                Brush brush = Brushes.White;
                string initials = GetInitials(name);
                SizeF textSize = graphics.MeasureString(initials, font);
                float x = (bitmap.Width - textSize.Width) / 2;
                float y = (bitmap.Height - textSize.Height) / 2;
                graphics.DrawString(initials, font, brush, x, y);
            }
            pictureBox.Image = bitmap;
        }

        private string GetInitials(string fullName)
        {
            if (string.IsNullOrEmpty(fullName)) return "NA";

            string[] names = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (names.Length >= 2)
            {
                return $"{names[0][0]}{names[1][0]}".ToUpper();
            }
            else if (names.Length == 1)
            {
                return names[0].Substring(0, Math.Min(2, names[0].Length)).ToUpper();
            }

            return "NA";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadRequests()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GetAllStudentRequests", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridViewRequests.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int requestId = Convert.ToInt32(dataGridViewRequests.Rows[e.RowIndex].Cells["RequestID"].Value);
                ViewStudentRequestForm viewRequestForm = new ViewStudentRequestForm(requestId,userId);
                viewRequestForm.ShowDialog();
            }
        }
    }
}