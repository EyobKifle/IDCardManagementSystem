using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace Demo2
{
    public partial class IdCardHistoryDean : Form
    {
        private DataTable _dataTable;
        private string _loggedInUserInitials;
        private int userId;
        private string fullName;

        public IdCardHistoryDean(string loggedInUserInitials, int userId)
        {
            InitializeComponent();
            this._loggedInUserInitials = loggedInUserInitials;
            this.userId = userId;

            // Load the image from resources into the left PictureBox
            pictureBoxLeftLogo.Image = Properties.Resources.download;
            pictureBoxLeftLogo.SizeMode = PictureBoxSizeMode.Zoom;

            // Draw initials on the right PictureBox with #72BAA9 background
            DrawInitialsOnLogo(pictureBoxRightLogo, _loggedInUserInitials, Color.FromArgb(0x72, 0xBA, 0xA9));

            // Initialize the context menu
            InitializeContextMenu();

            // Attach event handlers
            pictureBoxRightLogo.Click += PictureBoxRightLogo_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // Ensure the form loads data when it is shown
            this.Load += IdCardHistoryDean_Load;
        }

        private void InitializeContextMenu()
        {
            contextMenuRightLogo = new ContextMenuStrip();

            ToolStripMenuItem viewProfileMenuItem = new ToolStripMenuItem("View Profile");
            ToolStripMenuItem helpMenuItem = new ToolStripMenuItem("Help");

            viewProfileMenuItem.Click += ViewProfileMenuItem_Click;
            helpMenuItem.Click += HelpMenuItem_Click;

            contextMenuRightLogo.Items.Add(viewProfileMenuItem);
            contextMenuRightLogo.Items.Add(helpMenuItem);

            pictureBoxRightLogo.ContextMenuStrip = contextMenuRightLogo;
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

        private void PictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            contextMenuRightLogo.Show(pictureBoxRightLogo, new Point(0, pictureBoxRightLogo.Height));
        }

        private void ViewProfileMenuItem_Click(object sender, EventArgs e)
        {
            ProfileDeanView profileView = new ProfileDeanView(userId, _loggedInUserInitials);
            profileView.Show();
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            HelpDeanView helpView = new HelpDeanView(userId, fullName);
            helpView.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                progressBarLoading.Visible = true;

                string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GetRequestHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            _dataTable = new DataTable();
                            adapter.Fill(_dataTable);
                        }
                    }
                }
                dataGridViewRequestHistory.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBarLoading.Visible = false;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                dataGridViewRequestHistory.DataSource = _dataTable;
            }
            else
            {
                var filteredRows = _dataTable.AsEnumerable()
                    .Where(row =>
                        row.Field<string>("StudentName").ToLower().Contains(searchTerm) ||
                        row.Field<string>("StudentID").ToLower().Contains(searchTerm) ||
                        row.Field<string>("Status").ToLower().Contains(searchTerm) ||
                        row.Field<DateTime>("RequestDate").ToString("yyyy-MM-dd").Contains(searchTerm)
                    );

                if (filteredRows.Any())
                {
                    DataTable filteredTable = filteredRows.CopyToDataTable();
                    dataGridViewRequestHistory.DataSource = filteredTable;
                }
                else
                {
                    dataGridViewRequestHistory.DataSource = null;
                }
            }
        }

        private void IdCardHistoryDean_Load(object sender, EventArgs e)
        {
            // Ensure LoadDataFromDatabase is called when the form is loaded
            LoadDataFromDatabase();
        }
    }
}