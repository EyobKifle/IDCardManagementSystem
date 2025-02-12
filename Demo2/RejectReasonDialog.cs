using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2
{
    internal class RejectReasonDialog : Form
    {
        // UI Controls
        private TextBox txtRemark; // TextBox for entering the remark
        private Button btnOK;
        private Button btnCancel;

        // Property to store the remark entered by the user
        public string Remark { get; private set; }

        // Constructor
        public RejectReasonDialog()
        {
            InitializeComponent();
        }

        // Initialize the form and its controls
        private void InitializeComponent()
        {
            // TextBox for entering the remark
            this.txtRemark = new TextBox
            {
                Location = new Point(12, 12),
                Multiline = true,
                Size = new Size(260, 100),
                TabIndex = 0
            };

            // OK Button
            this.btnOK = new Button
            {
                Location = new Point(116, 118),
                Size = new Size(75, 30),
                TabIndex = 1,
                Text = "OK"
            };
            this.btnOK.Click += new EventHandler(this.btnOK_Click);

            // Cancel Button
            this.btnCancel = new Button
            {
                Location = new Point(197, 118),
                Size = new Size(75, 30),
                TabIndex = 2,
                Text = "Cancel"
            };
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // Form settings
            this.ClientSize = new Size(284, 161);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRemark);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Enter Remark for Rejection"; // Updated dialog title
        }

        // Event handler for the OK button
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Store the remark entered by the user
            Remark = txtRemark.Text;

            // Set the dialog result to OK and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Event handler for the Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Set the dialog result to Cancel and close the form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
