using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class PaymentForm
    {
        private IContainer components = null;
        private GroupBox groupBoxDetails;
        private Label lblTotalPrice, lblPaymentStatus, lblPaymentDate, lblCustomerID, lblRentalID;
        private TextBox txtTotalPrice, txtPaymentStatus, txtCustomerID, txtRentalID, txtSearch;
        private DateTimePicker dtpPaymentDate;
        private Button btnSearch, btnInsert, btnUpdate, btnDelete;
        private DataGridView dgvPayments;

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
            components = new System.ComponentModel.Container();
            groupBoxDetails = new GroupBox();
            lblTotalPrice = new Label();
            txtTotalPrice = new TextBox();
            lblPaymentStatus = new Label();
            txtPaymentStatus = new TextBox();
            lblPaymentDate = new Label();
            dtpPaymentDate = new DateTimePicker();
            lblCustomerID = new Label();
            txtCustomerID = new TextBox();
            lblRentalID = new Label();
            txtRentalID = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvPayments = new DataGridView();

            // PaymentForm 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Text = "Payment";

            // groupBoxDetails
            groupBoxDetails.Text = "Payment Details";
            groupBoxDetails.Location = new Point(10, 10);
            groupBoxDetails.Size = new Size(770, 125);

            // lblTotalPrice
            lblTotalPrice.Text = "Total Price";
            lblTotalPrice.Location = new Point(20, 25);
            lblTotalPrice.Size = new Size(120, 20);

            // txtTotalPrice
            txtTotalPrice.Location = new Point(150, 25);
            txtTotalPrice.Size = new Size(150, 20);

            // lblPaymentStatus
            lblPaymentStatus.Text = "Payment Status";
            lblPaymentStatus.Location = new Point(400, 25);
            lblPaymentStatus.Size = new Size(120, 20);

            // txtPaymentStatus
            txtPaymentStatus.Location = new Point(530, 25);
            txtPaymentStatus.Size = new Size(150, 20);

            // lblPaymentDate
            lblPaymentDate.Text = "Payment Date";
            lblPaymentDate.Location = new Point(20, 65);
            lblPaymentDate.Size = new Size(120, 20);

            // dtpPaymentDate
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(150, 65);
            dtpPaymentDate.Size = new Size(150, 20);

            // lblCustomerID
            lblCustomerID.Text = "Customer ID";
            lblCustomerID.Location = new Point(400, 65);
            lblCustomerID.Size = new Size(120, 20);

            // txtCustomerID
            txtCustomerID.Location = new Point(530, 65);
            txtCustomerID.Size = new Size(150, 20);

            // lblRentalID
            lblRentalID.Text = "Rental ID";
            lblRentalID.Location = new Point(20, 100);
            lblRentalID.Size = new Size(120, 20);

            // txtRentalID
            txtRentalID.Location = new Point(150, 100);
            txtRentalID.Size = new Size(150, 20);

            // Add controls to groupBox
            groupBoxDetails.Controls.Add(lblTotalPrice);
            groupBoxDetails.Controls.Add(txtTotalPrice);
            groupBoxDetails.Controls.Add(lblPaymentStatus);
            groupBoxDetails.Controls.Add(txtPaymentStatus);
            groupBoxDetails.Controls.Add(lblPaymentDate);
            groupBoxDetails.Controls.Add(dtpPaymentDate);
            groupBoxDetails.Controls.Add(lblCustomerID);
            groupBoxDetails.Controls.Add(txtCustomerID);
            groupBoxDetails.Controls.Add(lblRentalID);
            groupBoxDetails.Controls.Add(txtRentalID);

            // Search TextBox
            txtSearch.Location = new Point(10, 150);
            txtSearch.Size = new Size(200, 20);

            // Buttons
            btnSearch.Text = "Search";
            btnSearch.Location = new Point(220, 150);
            btnInsert.Text = "Insert";
            btnInsert.Location = new Point(320, 150);
            btnUpdate.Text = "Update";
            btnUpdate.Location = new Point(420, 150);
            btnDelete.Text = "Delete";
            btnDelete.Location = new Point(520, 150);

            // DataGridView
            dgvPayments.Location = new Point(10, 190);
            dgvPayments.Size = new Size(770, 230);

            // Add controls to form
            this.Controls.Add(groupBoxDetails);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnSearch);
            this.Controls.Add(btnInsert);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(dgvPayments);
        }
    }
}