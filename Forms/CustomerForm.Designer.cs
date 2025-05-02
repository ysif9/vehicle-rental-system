namespace VehicleRentalSystem
{
    partial class CustomerForm
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
            this.customerInsertButton = new System.Windows.Forms.Button();
            this.customerUpdateButton = new System.Windows.Forms.Button();
            this.customerDeleteButton = new System.Windows.Forms.Button();
            this.customerSearchButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();

            this.customer_id_textbox = new System.Windows.Forms.TextBox();
            this.customer_name_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.dob_picker = new System.Windows.Forms.DateTimePicker();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.license_number_textbox = new System.Windows.Forms.TextBox();
            this.license_expiry_picker = new System.Windows.Forms.DateTimePicker();
            this.license_photo_textbox = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();

            // You would add positioning and sizing logic here for each control

            // CustomerForm
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.customerInsertButton);
            this.Controls.Add(this.customerUpdateButton);
            this.Controls.Add(this.customerDeleteButton);
            this.Controls.Add(this.customerSearchButton);
            this.Controls.Add(this.customerDataGridView);

            this.Controls.Add(this.customer_id_textbox);
            this.Controls.Add(this.customer_name_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.dob_picker);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.license_number_textbox);
            this.Controls.Add(this.license_expiry_picker);
            this.Controls.Add(this.license_photo_textbox);

            this.Name = "CustomerForm";
            this.Text = "Customer Form";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button customerInsertButton;
        private System.Windows.Forms.Button customerUpdateButton;
        private System.Windows.Forms.Button customerDeleteButton;
        private System.Windows.Forms.Button customerSearchButton;
        private System.Windows.Forms.DataGridView customerDataGridView;

        private System.Windows.Forms.TextBox customer_id_textbox;
        private System.Windows.Forms.TextBox customer_name_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.DateTimePicker dob_picker;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox license_number_textbox;
        private System.Windows.Forms.DateTimePicker license_expiry_picker;
        private System.Windows.Forms.TextBox license_photo_textbox;
    }
}
