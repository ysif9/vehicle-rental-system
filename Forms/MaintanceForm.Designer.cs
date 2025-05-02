using System.Windows.Forms;

// This is the auto-generated designer file for MaintenanceForm.
// Normally, Visual Studio manages this file if you use the WinForms designer.
// If you build your UI in code, you can leave this as a placeholder.

namespace VehicleRentalSystem.Forms
{
    partial class MaintenanceForm
    {
        private System.Windows.Forms.TextBox txtMaintenanceNumber, txtCompanyName, txtServicePrice;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btnInsert, btnUpdate, btnDelete;
        private System.Windows.Forms.DataGridView dataGridView;

        private void InitializeComponent()
        {
            this.Text = "Maintenance Management";
            this.Width = 800;
            this.Height = 500;

            GroupBox groupBox = new GroupBox
            {
                Text = "Maintenance Details",
                Left = 10,
                Top = 10,
                Width = 760,
                Height = 110
            };
            this.Controls.Add(groupBox);

            Label lblMaintenanceNumber = new Label { Text = "Maintenance Number", Left = 20, Top = 30, Width = 130 };
            txtMaintenanceNumber = new TextBox { Left = 160, Top = 27, Width = 120, ReadOnly = true };
            Label lblCompanyName = new Label { Text = "Company Name", Left = 300, Top = 30, Width = 100 };
            txtCompanyName = new TextBox { Left = 410, Top = 27, Width = 120 };
            Label lblServicePrice = new Label { Text = "Service Price", Left = 550, Top = 30, Width = 90 };
            txtServicePrice = new TextBox { Left = 650, Top = 27, Width = 80 };

            Label lblDate = new Label { Text = "Date", Left = 20, Top = 70, Width = 130 };
            dtDate = new DateTimePicker { Left = 160, Top = 67, Width = 120 };

            groupBox.Controls.Add(lblMaintenanceNumber);
            groupBox.Controls.Add(txtMaintenanceNumber);
            groupBox.Controls.Add(lblCompanyName);
            groupBox.Controls.Add(txtCompanyName);
            groupBox.Controls.Add(lblServicePrice);
            groupBox.Controls.Add(txtServicePrice);
            groupBox.Controls.Add(lblDate);
            groupBox.Controls.Add(dtDate);

            btnInsert = new Button { Text = "Insert", Left = 320, Top = 133, Width = 120, Height = 35 };
            btnUpdate = new Button { Text = "Update", Left = 460, Top = 133, Width = 120, Height = 35 };
            btnDelete = new Button { Text = "Delete", Left = 600, Top = 133, Width = 120, Height = 35 };

            this.Controls.Add(btnInsert);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);

            dataGridView = new DataGridView
            {
                Location = new System.Drawing.Point(10, 180),
                Size = new System.Drawing.Size(760, 250),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dataGridView.Columns.Add("MaintenanceNumber", "Maintenance Number");
            dataGridView.Columns.Add("ServicePrice", "Service Price");
            dataGridView.Columns.Add("CompanyName", "Company Name");
            dataGridView.Columns.Add("Date", "Date");
            this.Controls.Add(dataGridView);
        }
    }
}
