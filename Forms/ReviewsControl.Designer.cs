namespace VehicleRentalSystem.Forms
{
    partial class ReviewsControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblReviewID = new System.Windows.Forms.Label();
            this.txtReviewID = new System.Windows.Forms.TextBox();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblCheckedBy = new System.Windows.Forms.Label();
            this.txtCheckedBy = new System.Windows.Forms.TextBox();
            this.lblCheckReport = new System.Windows.Forms.Label();
            this.txtCheckReport = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.lblReviewID);
            this.groupBoxDetails.Controls.Add(this.txtReviewID);
            this.groupBoxDetails.Controls.Add(this.lblRentalID);
            this.groupBoxDetails.Controls.Add(this.txtRentalID);
            this.groupBoxDetails.Controls.Add(this.lblCustomerName);
            this.groupBoxDetails.Controls.Add(this.txtCustomerName);
            this.groupBoxDetails.Controls.Add(this.lblFeedback);
            this.groupBoxDetails.Controls.Add(this.txtFeedback);
            this.groupBoxDetails.Controls.Add(this.lblRating);
            this.groupBoxDetails.Controls.Add(this.txtRating);
            this.groupBoxDetails.Controls.Add(this.lblCheckedBy);
            this.groupBoxDetails.Controls.Add(this.txtCheckedBy);
            this.groupBoxDetails.Controls.Add(this.lblCheckReport);
            this.groupBoxDetails.Controls.Add(this.txtCheckReport);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(400, 250);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Review Details";
            // 
            // lblReviewID
            // 
            this.lblReviewID.Location = new System.Drawing.Point(20, 20);
            this.lblReviewID.Name = "lblReviewID";
            this.lblReviewID.Size = new System.Drawing.Size(100, 20);
            this.lblReviewID.TabIndex = 0;
            this.lblReviewID.Text = "Review ID";
            // 
            // txtReviewID
            // 
            this.txtReviewID.Location = new System.Drawing.Point(150, 20);
            this.txtReviewID.Name = "txtReviewID";
            this.txtReviewID.Size = new System.Drawing.Size(200, 20);
            this.txtReviewID.TabIndex = 1;
            // 
            // lblRentalID
            // 
            this.lblRentalID.Location = new System.Drawing.Point(20, 50);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(100, 20);
            this.lblRentalID.TabIndex = 2;
            this.lblRentalID.Text = "Rental ID";
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(150, 50);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(200, 20);
            this.txtRentalID.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(20, 80);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(100, 20);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(150, 80);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 5;
            // 
            // lblFeedback
            // 
            this.lblFeedback.Location = new System.Drawing.Point(20, 110);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(100, 20);
            this.lblFeedback.TabIndex = 6;
            this.lblFeedback.Text = "Feedback";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(150, 110);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(200, 20);
            this.txtFeedback.TabIndex = 7;
            // 
            // lblRating
            // 
            this.lblRating.Location = new System.Drawing.Point(20, 140);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(100, 20);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "Rating";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(150, 140);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(200, 20);
            this.txtRating.TabIndex = 9;
            // 
            // lblCheckedBy
            // 
            this.lblCheckedBy.Location = new System.Drawing.Point(20, 170);
            this.lblCheckedBy.Name = "lblCheckedBy";
            this.lblCheckedBy.Size = new System.Drawing.Size(100, 20);
            this.lblCheckedBy.TabIndex = 10;
            this.lblCheckedBy.Text = "Checked By";
            // 
            // txtCheckedBy
            // 
            this.txtCheckedBy.Location = new System.Drawing.Point(150, 170);
            this.txtCheckedBy.Name = "txtCheckedBy";
            this.txtCheckedBy.Size = new System.Drawing.Size(200, 20);
            this.txtCheckedBy.TabIndex = 11;
            // 
            // lblCheckReport
            // 
            this.lblCheckReport.Location = new System.Drawing.Point(20, 200);
            this.lblCheckReport.Name = "lblCheckReport";
            this.lblCheckReport.Size = new System.Drawing.Size(100, 20);
            this.lblCheckReport.TabIndex = 12;
            this.lblCheckReport.Text = "Check Report";
            // 
            // txtCheckReport
            // 
            this.txtCheckReport.Location = new System.Drawing.Point(150, 200);
            this.txtCheckReport.Name = "txtCheckReport";
            this.txtCheckReport.Size = new System.Drawing.Size(200, 20);
            this.txtCheckReport.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(430, 20);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(430, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(430, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvReviews
            // 
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(12, 270);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.Size = new System.Drawing.Size(824, 200);
            this.dgvReviews.TabIndex = 17;
            // 
            // ReviewsControl
            // 
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBoxDetails);
            this.Name = "ReviewsControl";
            this.Size = new System.Drawing.Size(839, 481);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label lblReviewID;
        private System.Windows.Forms.TextBox txtReviewID;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblCheckedBy;
        private System.Windows.Forms.TextBox txtCheckedBy;
        private System.Windows.Forms.Label lblCheckReport;
        private System.Windows.Forms.TextBox txtCheckReport;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvReviews;
    }
}
