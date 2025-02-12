using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Demo2
{
    public partial class StudentDashboardView : Form
    {
        private int _userId;
        private string _loggedInUserInitials;
        private string fullName;
        private string studentId;

        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;

        public StudentDashboardView(string fullName, int userId, string studentId)
        {
            InitializeComponent();
            _userId = userId;
            _loggedInUserInitials = GetInitials(fullName);
            this.fullName = fullName;
            this.studentId = studentId;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentDashboardView_FormClosing);

            DrawInitialsOnLeftLogo();
            InitializeDropdownMenu();
            AttachButtonEventHandlers();
            LoadDashboard();
        }

        private string GetInitials(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "NA";
            }

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

        private void DrawInitialsOnLeftLogo()
        {
            try
            {
                Bitmap bitmap = new Bitmap(pictureBoxLeftLogo.Width, pictureBoxLeftLogo.Height);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.FromArgb(0x72, 0xBA, 0xA9));
                    using (Font font = new Font("Roboto", 24, FontStyle.Bold))
                    {
                        SizeF textSize = g.MeasureString(_loggedInUserInitials, font);
                        float x = (bitmap.Width - textSize.Width) / 2;
                        float y = (bitmap.Height - textSize.Height) / 2;
                        g.DrawString(_loggedInUserInitials, font, Brushes.White, x, y);
                    }
                }
                pictureBoxLeftLogo.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error drawing initials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void OpenProfileView()
        {
            OpenView(typeof(ProfileStudentView), () => new ProfileStudentView(_userId, _loggedInUserInitials));
        }

        private void OpenHelpView()
        {
            OpenView(typeof(HelpStudentView), () => new HelpStudentView(_userId, _loggedInUserInitials));
        }

        private void AttachButtonEventHandlers()
        {
            buttonRequestReplacement.Click += ButtonRequestReplacement_Click;
            buttonCheckIDStatus.Click += ButtonCheckIDStatus_Click;
            buttonUpdateInformation.Click += ButtonUpdateInformation_Click;
            buttonContactInformation.Click += ButtonContactInformation_Click;
            buttonPayFee.Click += ButtonPayFee_Click;
            buttonViewRequestHistory.Click += ButtonViewRequestHistory_Click;
        }

        private void ButtonRequestReplacement_Click(object sender, EventArgs e)
        {
            OpenView(typeof(RequestReplacementForm), () => new RequestReplacementForm(_userId, _loggedInUserInitials));
        }

        private void ButtonCheckIDStatus_Click(object sender, EventArgs e)
        {
            OpenView(typeof(CheckIDStatusView), () => new CheckIDStatusView(_userId, _loggedInUserInitials));
        }

        private void ButtonUpdateInformation_Click(object sender, EventArgs e)
        {
            OpenView(typeof(UpdateProfileView), () => new UpdateProfileView(_loggedInUserInitials, _userId, fullName));
        }

        private void ButtonContactInformation_Click(object sender, EventArgs e)
        {
            OpenView(typeof(ContactInformationView), () => new ContactInformationView(_loggedInUserInitials, _userId, fullName));
        }

        private void ButtonPayFee_Click(object sender, EventArgs e)
        {
            OpenView(typeof(PayFeeView), () => new PayFeeView(_userId, _loggedInUserInitials));
        }

        private void ButtonViewRequestHistory_Click(object sender, EventArgs e)
        {
            OpenView(typeof(StudentRequestHistoryView), () => new StudentRequestHistoryView(_userId, _loggedInUserInitials, studentId));
        }

        private void OpenView(Type viewType, Func<Form> createForm)
        {
            try
            {
                Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.GetType() == viewType);

                if (existingForm == null)
                {
                    Form newForm = createForm();
                    newForm.Show();
                }
                else
                {
                    existingForm.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening view: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboard()
        {
            InitializeDashboardLayout();
        }

        private void InitializeDashboardLayout()
        {
            DrawInitialsOnLeftLogo();
        }

        private void StudentDashboardView_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void StudentDashboardView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Prevent form closing if "No" is selected
                }
                else if (result == DialogResult.Yes)
                {
                    Application.Exit(); // Exit the application if "Yes" is selected
                }
            }
        }
    }
}