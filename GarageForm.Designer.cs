using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class GarageForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvGarages = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtGarageName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtManagerName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtVehicleCount = new TextBox();
            txtEmployeeID = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCount = new Button();
            btnAssignEmployee = new Button();
            dgvAssignedEmployees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGarages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvGarages
            // 
            dgvGarages.Location = new Point(12, 250);
            dgvGarages.Margin = new Padding(4, 3, 4, 3);
            dgvGarages.Name = "dgvGarages";
            dgvGarages.Size = new Size(900, 150);
            dgvGarages.TabIndex = 0;
            dgvGarages.SelectionChanged += new System.EventHandler(dgvGarages_SelectionChanged);
            dgvGarages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvGarages_CellContentClick);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Garage Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "City:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 110);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "State:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 140);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 5;
            label5.Text = "Manager Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 170);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 6;
            label6.Text = "Phone Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 200);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 7;
            label7.Text = "Vehicle Count:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 230);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 8;
            label8.Text = "Employee ID:";
            // 
            // txtGarageName
            // 
            txtGarageName.Location = new Point(100, 17);
            txtGarageName.Margin = new Padding(4, 3, 4, 3);
            txtGarageName.Name = "txtGarageName";
            txtGarageName.Size = new Size(150, 23);
            txtGarageName.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(100, 47);
            txtAddress.Margin = new Padding(4, 3, 4, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(100, 77);
            txtCity.Margin = new Padding(4, 3, 4, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 23);
            txtCity.TabIndex = 11;
            // 
            // txtState
            // 
            txtState.Location = new Point(100, 107);
            txtState.Margin = new Padding(4, 3, 4, 3);
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 23);
            txtState.TabIndex = 12;
            // 
            // txtManagerName
            // 
            txtManagerName.Location = new Point(100, 137);
            txtManagerName.Margin = new Padding(4, 3, 4, 3);
            txtManagerName.Name = "txtManagerName";
            txtManagerName.Size = new Size(150, 23);
            txtManagerName.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(100, 167);
            txtPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(150, 23);
            txtPhoneNumber.TabIndex = 14;
            // 
            // txtVehicleCount
            // 
            txtVehicleCount.Location = new Point(100, 197);
            txtVehicleCount.Margin = new Padding(4, 3, 4, 3);
            txtVehicleCount.Name = "txtVehicleCount";
            txtVehicleCount.Size = new Size(150, 23);
            txtVehicleCount.TabIndex = 15;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(100, 227);
            txtEmployeeID.Margin = new Padding(4, 3, 4, 3);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(150, 23);
            txtEmployeeID.TabIndex = 16;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(300, 20);
            btnInsert.Margin = new Padding(4, 3, 4, 3);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 27);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(385, 20);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 27);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 20);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 27);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(555, 20);
            btnCount.Margin = new Padding(4, 3, 4, 3);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(75, 27);
            btnCount.TabIndex = 20;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnAssignEmployee
            // 
            btnAssignEmployee.Location = new Point(640, 20);
            btnAssignEmployee.Margin = new Padding(4, 3, 4, 3);
            btnAssignEmployee.Name = "btnAssignEmployee";
            btnAssignEmployee.Size = new Size(100, 27);
            btnAssignEmployee.TabIndex = 21;
            btnAssignEmployee.Text = "Assign Employee";
            btnAssignEmployee.UseVisualStyleBackColor = true;
            btnAssignEmployee.Click += btnAssignEmployee_Click;
            // 
            // dgvAssignedEmployees
            // 
            dgvAssignedEmployees.Location = new Point(12, 410);
            dgvAssignedEmployees.Margin = new Padding(4, 3, 4, 3);
            dgvAssignedEmployees.Name = "dgvAssignedEmployees";
            dgvAssignedEmployees.Size = new Size(900, 150);
            dgvAssignedEmployees.TabIndex = 22;
            // 
            // GarageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 600);
            Controls.Add(dgvAssignedEmployees);
            Controls.Add(btnAssignEmployee);
            Controls.Add(btnCount);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtEmployeeID);
            Controls.Add(txtVehicleCount);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtManagerName);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtGarageName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvGarages);
            Margin = new Padding(4, 3, 4, 3);
            Name = "GarageForm";
            Text = "Garage Mangagement"; // Updated to match the target image
            ((System.ComponentModel.ISupportInitialize)dgvGarages).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvGarages;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtGarageName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtManagerName;
        private TextBox txtPhoneNumber;
        private TextBox txtVehicleCount;
        private TextBox txtEmployeeID;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCount;
        private Button btnAssignEmployee;
        private DataGridView dgvAssignedEmployees;
    }
}