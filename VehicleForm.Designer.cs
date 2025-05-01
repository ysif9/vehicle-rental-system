using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class VehicleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            txtCarID = new TextBox();
            txtLicenseNumber = new TextBox();
            txtNumberOfSeats = new TextBox();
            txtColor = new TextBox();
            txtType = new TextBox();
            txtModelYear = new TextBox();
            txtModelName = new TextBox();
            txtBrand = new TextBox();
            txtStatus = new TextBox();
            txtGarageID = new TextBox();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearchBar = new TextBox();
            dtpLicenseExpiry = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 49);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "CarID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 87);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 122);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 3;
            label4.Text = "Model_Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(546, 189);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 4;
            label5.Text = "Availability_Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(546, 87);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 5;
            label6.Text = "License_Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 269);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 6;
            label7.Text = "Number_of_Seats";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 164);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 7;
            label8.Text = "Model_Year";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(546, 49);
            label9.Name = "label9";
            label9.Size = new Size(166, 25);
            label9.TabIndex = 8;
            label9.Text = "License_Expiry_Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 233);
            label10.Name = "label10";
            label10.Size = new Size(55, 25);
            label10.TabIndex = 9;
            label10.Text = "Color";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(546, 153);
            label11.Name = "label11";
            label11.Size = new Size(86, 25);
            label11.TabIndex = 10;
            label11.Text = "GarageID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 198);
            label12.Name = "label12";
            label12.Size = new Size(49, 25);
            label12.TabIndex = 11;
            label12.Text = "Type";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpLicenseExpiry);
            groupBox1.Controls.Add(txtCarID);
            groupBox1.Controls.Add(txtLicenseNumber);
            groupBox1.Controls.Add(txtNumberOfSeats);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(txtType);
            groupBox1.Controls.Add(txtModelYear);
            groupBox1.Controls.Add(txtModelName);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(txtGarageID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(47, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 312);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vehicle Details";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(94, 43);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(366, 31);
            txtCarID.TabIndex = 23;
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(718, 87);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(366, 31);
            txtLicenseNumber.TabIndex = 21;
            // 
            // txtNumberOfSeats
            // 
            txtNumberOfSeats.Location = new Point(184, 269);
            txtNumberOfSeats.Name = "txtNumberOfSeats";
            txtNumberOfSeats.Size = new Size(366, 31);
            txtNumberOfSeats.TabIndex = 20;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(89, 233);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(366, 31);
            txtColor.TabIndex = 19;
            // 
            // txtType
            // 
            txtType.Location = new Point(83, 198);
            txtType.Name = "txtType";
            txtType.Size = new Size(366, 31);
            txtType.TabIndex = 18;
            // 
            // txtModelYear
            // 
            txtModelYear.Location = new Point(136, 164);
            txtModelYear.Name = "txtModelYear";
            txtModelYear.Size = new Size(366, 31);
            txtModelYear.TabIndex = 17;
            // 
            // txtModelName
            // 
            txtModelName.Location = new Point(151, 122);
            txtModelName.Name = "txtModelName";
            txtModelName.Size = new Size(366, 31);
            txtModelName.TabIndex = 16;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(94, 88);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(366, 31);
            txtBrand.TabIndex = 15;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(704, 189);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(366, 31);
            txtStatus.TabIndex = 14;
            // 
            // txtGarageID
            // 
            txtGarageID.Location = new Point(638, 152);
            txtGarageID.Name = "txtGarageID";
            txtGarageID.Size = new Size(366, 31);
            txtGarageID.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 407);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1129, 373);
            dataGridView1.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(633, 358);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(776, 358);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(920, 358);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1064, 358);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(47, 358);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(580, 31);
            txtSearchBar.TabIndex = 18;
            // 
            // dtpLicenseExpiry
            // 
            dtpLicenseExpiry.Format = DateTimePickerFormat.Short;
            dtpLicenseExpiry.Location = new Point(718, 41);
            dtpLicenseExpiry.Name = "dtpLicenseExpiry";
            dtpLicenseExpiry.Size = new Size(366, 31);
            dtpLicenseExpiry.TabIndex = 24;
            dtpLicenseExpiry.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // VehicleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 792);
            Controls.Add(txtSearchBar);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "VehicleForm";
            Text = "Vehicle Rental App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox groupBox1;
        private TextBox txtLicenseNumber;
        private TextBox txtNumberOfSeats;
        private TextBox txtColor;
        private TextBox txtType;
        private TextBox txtModelYear;
        private TextBox txtModelName;
        private TextBox txtBrand;
        private TextBox txtStatus;
        private TextBox txtGarageID;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearchBar;
        private TextBox txtCarID;
        private DateTimePicker dtpLicenseExpiry;
    }
}
