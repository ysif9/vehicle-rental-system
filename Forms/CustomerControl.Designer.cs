namespace VehicleRentalSystem.Forms
{
    partial class CustomerControl
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReviewID = new System.Windows.Forms.Label();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLicensePhoto = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCheckedBy = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblCheckReport = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReviewID
            // 
            this.lblReviewID.Location = new System.Drawing.Point(20, 50);
            this.lblReviewID.Name = "lblReviewID";
            this.lblReviewID.Size = new System.Drawing.Size(100, 20);
            this.lblReviewID.TabIndex = 0;
            this.lblReviewID.Text = "Customer Name";
            // 
            // lblRentalID
            // 
            this.lblRentalID.Location = new System.Drawing.Point(20, 80);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(100, 20);
            this.lblRentalID.TabIndex = 2;
            this.lblRentalID.Text = "Address";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(20, 110);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(100, 20);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Date Of Birth";
            // 
            // lblFeedback
            // 
            this.lblFeedback.Location = new System.Drawing.Point(20, 140);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(100, 20);
            this.lblFeedback.TabIndex = 6;
            this.lblFeedback.Text = "Age";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.Controls.Add(this.txtCustomerID);
            this.groupBoxDetails.Controls.Add(this.dtpExpiry);
            this.groupBoxDetails.Controls.Add(this.dtpBirth);
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Controls.Add(this.txtLicenseNumber);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Controls.Add(this.label3);
            this.groupBoxDetails.Controls.Add(this.txtLicensePhoto);
            this.groupBoxDetails.Controls.Add(this.lblReviewID);
            this.groupBoxDetails.Controls.Add(this.txtCustomerName);
            this.groupBoxDetails.Controls.Add(this.lblRentalID);
            this.groupBoxDetails.Controls.Add(this.txtAddress);
            this.groupBoxDetails.Controls.Add(this.lblCustomerName);
            this.groupBoxDetails.Controls.Add(this.lblFeedback);
            this.groupBoxDetails.Controls.Add(this.txtAge);
            this.groupBoxDetails.Controls.Add(this.lblRating);
            this.groupBoxDetails.Controls.Add(this.txtEmail);
            this.groupBoxDetails.Controls.Add(this.lblCheckedBy);
            this.groupBoxDetails.Controls.Add(this.txtPhoneNumber);
            this.groupBoxDetails.Controls.Add(this.lblCheckReport);
            this.groupBoxDetails.Controls.Add(this.txtPassword);
            this.groupBoxDetails.Location = new System.Drawing.Point(2, 12);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(620, 230);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Customer Details";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(150, 20);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(129, 20);
            this.txtCustomerID.TabIndex = 23;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.Location = new System.Drawing.Point(465, 80);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(129, 20);
            this.dtpExpiry.TabIndex = 21;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(150, 110);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(129, 20);
            this.dtpBirth.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(335, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "License Number";
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(465, 50);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(129, 20);
            this.txtLicenseNumber.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(335, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "License Expiry";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(335, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "License Photo";
            // 
            // txtLicensePhoto
            // 
            this.txtLicensePhoto.Location = new System.Drawing.Point(465, 110);
            this.txtLicensePhoto.Name = "txtLicensePhoto";
            this.txtLicensePhoto.Size = new System.Drawing.Size(129, 20);
            this.txtLicensePhoto.TabIndex = 19;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(150, 50);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(129, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(150, 80);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(129, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(150, 140);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(129, 20);
            this.txtAge.TabIndex = 7;
            // 
            // lblRating
            // 
            this.lblRating.Location = new System.Drawing.Point(20, 170);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(100, 20);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblCheckedBy
            // 
            this.lblCheckedBy.Location = new System.Drawing.Point(20, 200);
            this.lblCheckedBy.Name = "lblCheckedBy";
            this.lblCheckedBy.Size = new System.Drawing.Size(100, 20);
            this.lblCheckedBy.TabIndex = 10;
            this.lblCheckedBy.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 200);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(129, 20);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // lblCheckReport
            // 
            this.lblCheckReport.Location = new System.Drawing.Point(335, 20);
            this.lblCheckReport.Name = "lblCheckReport";
            this.lblCheckReport.Size = new System.Drawing.Size(100, 20);
            this.lblCheckReport.TabIndex = 12;
            this.lblCheckReport.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(465, 20);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(22, 260);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(222, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1170, 189);
            this.dataGridView1.TabIndex = 9;
            // 
            // CustomerControl
            // 
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBoxDetails);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(703, 481);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerID;

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.DateTimePicker dtpExpiry;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLicensePhoto;

        private System.Windows.Forms.Label lblReviewID;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCheckedBy;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblCheckReport;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
