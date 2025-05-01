using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class ReviewForm
    {
        private IContainer components = null;
        private GroupBox groupBoxDetails;
        private Label lblRentalID, lblCustomerName, lblFeedback, lblRating, lblCheckedBy, lblCheckReport;
        private TextBox txtRentalID, txtCustomerName, txtRating, txtCheckedBy, txtFeedback, txtCheckReport, txtSearch;
        private Button btnSearch, btnInsert, btnUpdate, btnDelete;
        private DataGridView dgvReviews;

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
            lblRentalID = new Label();
            txtRentalID = new TextBox();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblFeedback = new Label();
            txtFeedback = new TextBox();
            lblRating = new Label();
            txtRating = new TextBox();
            lblCheckedBy = new Label();
            txtCheckedBy = new TextBox();
            lblCheckReport = new Label();
            txtCheckReport = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvReviews = new DataGridView();

            // ReviewForm 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Text = "ReviewForm";

            // groupBoxDetails
            groupBoxDetails.Text = "Review Details";
            groupBoxDetails.Location = new Point(10, 10);
            groupBoxDetails.Size = new Size(770, 170);

            // lblRentalID
            lblRentalID.Text = "Rental ID";
            lblRentalID.Location = new Point(20, 25);
            lblRentalID.Size = new Size(120, 20);

            // txtRentalID
            txtRentalID.Location = new Point(150, 25);
            txtRentalID.Size = new Size(150, 20);

            // lblCustomerName
            lblCustomerName.Text = "Customer Name";
            lblCustomerName.Location = new Point(400, 25);
            lblCustomerName.Size = new Size(120, 20);

            // txtCustomerName
            txtCustomerName.Location = new Point(530, 25);
            txtCustomerName.Size = new Size(150, 20);

            // lblFeedback
            lblFeedback.Text = "Feedback";
            lblFeedback.Location = new Point(20, 65);
            lblFeedback.Size = new Size(120, 20);

            // txtFeedback
            txtFeedback.Location = new Point(150, 65);
            txtFeedback.Size = new Size(530, 20);

            // lblRating
            lblRating.Text = "Rating";
            lblRating.Location = new Point(20, 105);
            lblRating.Size = new Size(120, 20);

            // txtRating
            txtRating.Location = new Point(150, 105);
            txtRating.Size = new Size(150, 20);

            // lblCheckedBy
            lblCheckedBy.Text = "Checked By (EmployeeID)";
            lblCheckedBy.Location = new Point(400, 105);
            lblCheckedBy.Size = new Size(120, 20);

            // txtCheckedBy
            txtCheckedBy.Location = new Point(530, 105);
            txtCheckedBy.Size = new Size(150, 20);

            // lblCheckReport
            lblCheckReport.Text = "Check Report";
            lblCheckReport.Location = new Point(20, 145);
            lblCheckReport.Size = new Size(120, 20);

            // txtCheckReport
            txtCheckReport.Location = new Point(150, 145);
            txtCheckReport.Size = new Size(530, 20);

            // Add controls to groupBox
            groupBoxDetails.Controls.Add(lblRentalID);
            groupBoxDetails.Controls.Add(txtRentalID);
            groupBoxDetails.Controls.Add(lblCustomerName);
            groupBoxDetails.Controls.Add(txtCustomerName);
            groupBoxDetails.Controls.Add(lblFeedback);
            groupBoxDetails.Controls.Add(txtFeedback);
            groupBoxDetails.Controls.Add(lblRating);
            groupBoxDetails.Controls.Add(txtRating);
            groupBoxDetails.Controls.Add(lblCheckedBy);
            groupBoxDetails.Controls.Add(txtCheckedBy);
            groupBoxDetails.Controls.Add(lblCheckReport);
            groupBoxDetails.Controls.Add(txtCheckReport);

            // Search TextBox
            txtSearch.Location = new Point(10, 190);
            txtSearch.Size = new Size(200, 20);

            // Buttons
            btnSearch.Text = "Search";
            btnSearch.Location = new Point(220, 190);
            btnInsert.Text = "Insert";
            btnInsert.Location = new Point(320, 190);
            btnUpdate.Text = "Update";
            btnUpdate.Location = new Point(420, 190);
            btnDelete.Text = "Delete";
            btnDelete.Location = new Point(520, 190);

            // DataGridView
            dgvReviews.Location = new Point(10, 230);
            dgvReviews.Size = new Size(770, 200);

            // Add controls to form
            this.Controls.Add(groupBoxDetails);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnSearch);
            this.Controls.Add(btnInsert);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(dgvReviews);
        }
    }
}