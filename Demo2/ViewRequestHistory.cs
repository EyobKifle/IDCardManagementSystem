using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Demo2
{
    public partial class ViewRequestHistoryView : Form
    {
        // Private fields for connection and user information
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;
        private string loggedInUserInitials;
        private int userId;
       private string fullName;

        public ViewRequestHistoryView( int userId, string initials)
        {
            InitializeComponent();
            this.userId = userId;
            loggedInUserInitials = initials; // Use passed initials directly

            // Draw initials only on the right logo
            DrawInitialsOnLogo(pictureBoxRightLogo, loggedInUserInitials, Color.FromArgb(0x72, 0xBA, 0xA9));

            // Attach events
            pictureBoxRightLogo.Click += PictureBoxRightLogo_Click;

            // Load data from the database into the DataGridView
            LoadDataFromDatabase();


            // Attach event handler for the Back button
            btnBack.Click += BtnBack_Click;

            // Initialize dropdown menu on the left logo
            InitializeDropdownMenu();
        }

        private void ViewRequestHistoryView_Load(object sender, EventArgs e)
        {
            // Perform necessary actions when the form loads, such as loading data from the database
            LoadDataFromDatabase();
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

        // Right logo click event handler (initials logo)
        private void PictureBoxRightLogo_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("View Profile", null, (s, ev) => OpenProfileView());
            contextMenu.Items.Add("Help", null, (s, ev) => OpenHelpView());
            contextMenu.Show(pictureBoxRightLogo, new Point(0, pictureBoxRightLogo.Height));
        }

   

        private void OpenProfileView()
        {
            // Create an instance of ProfileView and pass the necessary data
            ProfileStudentView profileStudentView = new ProfileStudentView(userId, loggedInUserInitials);
            profileStudentView.Show(); // Show the ProfileView form
        }
        private void OpenHelpView()
        {
            HelpStudentView helpView = new HelpStudentView(userId, loggedInUserInitials);
            helpView.Show();
        }


        // Back button click event handler
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current view
        }

        // Method to load data from the database into the DataGridView
        private void LoadDataFromDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GetRequestHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Set the DataGridView's DataSource to the fetched data
                        dataGridViewRequestHistory.DataSource = dataTable;

                        // Set the correct headers for the columns you want to show
                        SetColumnHeaders();

                        // Hide any columns that are not in the desired list
                        HideUnwantedColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message in case of failure
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to set column headers for DataGridView
        private void SetColumnHeaders()
        {
            if (dataGridViewRequestHistory.Columns.Contains("RequestID"))
            {
                dataGridViewRequestHistory.Columns["RequestID"].HeaderText = "Request ID";
            }

            if (dataGridViewRequestHistory.Columns.Contains("RequestType"))
            {
                dataGridViewRequestHistory.Columns["RequestType"].HeaderText = "Request Type";
            }

            if (dataGridViewRequestHistory.Columns.Contains("StudentName"))
            {
                dataGridViewRequestHistory.Columns["StudentName"].HeaderText = "Student Name";
            }

            if (dataGridViewRequestHistory.Columns.Contains("Status"))
            {
                dataGridViewRequestHistory.Columns["Status"].HeaderText = "Status";
            }

            if (dataGridViewRequestHistory.Columns.Contains("Reason"))
            {
                dataGridViewRequestHistory.Columns["Reason"].HeaderText = "Reason";
            }

            if (dataGridViewRequestHistory.Columns.Contains("RequestDate"))
            {
                dataGridViewRequestHistory.Columns["RequestDate"].HeaderText = "Date Requested";
            }
        }

        // Method to hide unwanted columns in the DataGridView
        private void HideUnwantedColumns()
        {
            foreach (DataGridViewColumn column in dataGridViewRequestHistory.Columns)
            {
                // If the column name is not in the list of columns to be shown, hide it
                if (!new[] { "RequestID", "RequestType", "StudentName", "Status", "Reason", "RequestDate" }.Contains(column.Name))
                {
                    column.Visible = false;
                }
            }
        }

        // Method to initialize the dropdown menu on the left logo
        private void InitializeDropdownMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("View Profile", null, (s, ev) => OpenProfileView());
            contextMenu.Items.Add("Help", null, (s, ev) => OpenHelpView());

            pictureBoxLeftLogo.ContextMenuStrip = contextMenu;
            pictureBoxLeftLogo.MouseClick += (sender, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenu.Show(pictureBoxLeftLogo, e.Location);
                }
            };
        }
    }
}
