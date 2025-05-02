using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    partial class PaymentControl
    {
        private IContainer components = null;
        private GroupBox groupBoxDetails;
        private Label lblTotalPrice, lblPaymentStatus, lblPaymentDate, lblCustomerID, lblRentalID;
        private TextBox txtTotalPrice, txtPaymentStatus, txtCustomerID, txtRentalID, txtSearch;
        private DateTimePicker dtpPaymentDate;
        private Button btnSearch, btnInsert, btnUpdate, btnDelete;
        private System.Windows.Forms.DataGridView dgvPayments;

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
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.txtPaymentStatus = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.lblTotalPrice);
            this.groupBoxDetails.Controls.Add(this.txtTotalPrice);
            this.groupBoxDetails.Controls.Add(this.lblPaymentStatus);
            this.groupBoxDetails.Controls.Add(this.txtPaymentStatus);
            this.groupBoxDetails.Controls.Add(this.lblPaymentDate);
            this.groupBoxDetails.Controls.Add(this.dtpPaymentDate);
            this.groupBoxDetails.Controls.Add(this.lblCustomerID);
            this.groupBoxDetails.Controls.Add(this.txtCustomerID);
            this.groupBoxDetails.Controls.Add(this.lblRentalID);
            this.groupBoxDetails.Controls.Add(this.txtRentalID);
            this.groupBoxDetails.Location = new System.Drawing.Point(10, 10);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(770, 125);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Payment Details";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(20, 25);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(120, 20);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(150, 25);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(150, 20);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Location = new System.Drawing.Point(400, 25);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(120, 20);
            this.lblPaymentStatus.TabIndex = 2;
            this.lblPaymentStatus.Text = "Payment Status";
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.Location = new System.Drawing.Point(530, 25);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.Size = new System.Drawing.Size(150, 20);
            this.txtPaymentStatus.TabIndex = 3;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.Location = new System.Drawing.Point(20, 65);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(120, 20);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(150, 65);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(150, 20);
            this.dtpPaymentDate.TabIndex = 5;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Location = new System.Drawing.Point(400, 65);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(120, 20);
            this.lblCustomerID.TabIndex = 6;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(530, 65);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(150, 20);
            this.txtCustomerID.TabIndex = 7;
            // 
            // lblRentalID
            // 
            this.lblRentalID.Location = new System.Drawing.Point(20, 100);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(120, 20);
            this.lblRentalID.TabIndex = 8;
            this.lblRentalID.Text = "Rental ID";
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(150, 100);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(150, 20);
            this.txtRentalID.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 150);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(220, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(320, 150);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(420, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(520, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dgvPayments
            // 
            this.dgvPayments.Location = new System.Drawing.Point(10, 190);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.Size = new System.Drawing.Size(770, 230);
            this.dgvPayments.TabIndex = 6;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellContentClick);
            // 
            // PaymentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvPayments);
            this.Name = "PaymentControl";
            this.Text = "Payment";
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}