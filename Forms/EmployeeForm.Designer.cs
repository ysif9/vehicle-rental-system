using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    partial class EmployeeForm
    {
        private System.Windows.Forms.TextBox txtEmployeeID, txtName, txtRole, txtAge, txtSalary;
        private System.Windows.Forms.DateTimePicker dtEnroll;
        private System.Windows.Forms.Button btnInsert, btnUpdate, btnDelete;
        private System.Windows.Forms.DataGridView dataGridView;

        private void InitializeComponent()
        {
            this.Text = "Employee Management";
            this.Width = 800;
            this.Height = 500;

            GroupBox groupBox = new GroupBox
            {
                Text = "Employee Details",
                Left = 10,
                Top = 10,
                Width = 760,
                Height = 130
            };
            this.Controls.Add(groupBox);

            Label lblEmployeeID = new Label { Text = "Employee ID", Left = 20, Top = 30, Width = 90 };
            txtEmployeeID = new TextBox { Left = 120, Top = 27, Width = 120, ReadOnly = true };
            Label lblName = new Label { Text = "Name", Left = 260, Top = 30, Width = 60 };
            txtName = new TextBox { Left = 320, Top = 27, Width = 120 };
            Label lblRole = new Label { Text = "Role", Left = 460, Top = 30, Width = 60 };
            txtRole = new TextBox { Left = 520, Top = 27, Width = 120 };

            Label lblAge = new Label { Text = "Age", Left = 20, Top = 70, Width = 90 };
            txtAge = new TextBox { Left = 120, Top = 67, Width = 120 };
            Label lblSalary = new Label { Text = "Salary", Left = 260, Top = 70, Width = 60 };
            txtSalary = new TextBox { Left = 320, Top = 67, Width = 120 };
            Label lblEnroll = new Label { Text = "Enrollment Date", Left = 460, Top = 70, Width = 100 };
            dtEnroll = new DateTimePicker { Left = 560, Top = 67, Width = 120 };

            groupBox.Controls.Add(lblEmployeeID);
            groupBox.Controls.Add(txtEmployeeID);
            groupBox.Controls.Add(lblName);
            groupBox.Controls.Add(txtName);
            groupBox.Controls.Add(lblRole);
            groupBox.Controls.Add(txtRole);
            groupBox.Controls.Add(lblAge);
            groupBox.Controls.Add(txtAge);
            groupBox.Controls.Add(lblSalary);
            groupBox.Controls.Add(txtSalary);
            groupBox.Controls.Add(lblEnroll);
            groupBox.Controls.Add(dtEnroll);

            btnInsert = new Button { Text = "Insert", Left = 320, Top = 153, Width = 120, Height = 35 };
            btnUpdate = new Button { Text = "Update", Left = 460, Top = 153, Width = 120, Height = 35 };
            btnDelete = new Button { Text = "Delete", Left = 600, Top = 153, Width = 120, Height = 35 };

            this.Controls.Add(btnInsert);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);

            dataGridView = new DataGridView
            {
                Location = new System.Drawing.Point(10, 190),
                Size = new System.Drawing.Size(760, 250),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dataGridView.Columns.Add("EmployeeID", "EmployeeID");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Role", "Role");
            dataGridView.Columns.Add("Age", "Age");
            dataGridView.Columns.Add("Salary", "Salary");
            dataGridView.Columns.Add("EnrollmentDate", "Enrollment Date");
            this.Controls.Add(dataGridView);
        }
    }
}