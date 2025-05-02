namespace VehicleRentalSystem.Forms
{
    partial class RentalsControl
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
            this.rental_details = new System.Windows.Forms.GroupBox();
            this.rental_id_textbox = new System.Windows.Forms.TextBox();
            this.rental_id = new System.Windows.Forms.Label();
            this.status_box = new System.Windows.Forms.ComboBox();
            this.end_datepicker = new System.Windows.Forms.DateTimePicker();
            this.start_datepicker = new System.Windows.Forms.DateTimePicker();
            this.customer_id_textbox = new System.Windows.Forms.TextBox();
            this.end_date = new System.Windows.Forms.Label();
            this.rental_status = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.rental_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rental_details
            // 
            this.rental_details.Controls.Add(this.rental_id_textbox);
            this.rental_details.Controls.Add(this.rental_id);
            this.rental_details.Controls.Add(this.status_box);
            this.rental_details.Controls.Add(this.end_datepicker);
            this.rental_details.Controls.Add(this.start_datepicker);
            this.rental_details.Controls.Add(this.customer_id_textbox);
            this.rental_details.Controls.Add(this.end_date);
            this.rental_details.Controls.Add(this.rental_status);
            this.rental_details.Controls.Add(this.start_date);
            this.rental_details.Controls.Add(this.customer_id);
            this.rental_details.Location = new System.Drawing.Point(12, 12);
            this.rental_details.Name = "rental_details";
            this.rental_details.Size = new System.Drawing.Size(683, 184);
            this.rental_details.TabIndex = 0;
            this.rental_details.TabStop = false;
            this.rental_details.Text = "Rental Details";
            // 
            // rental_id_textbox
            // 
            this.rental_id_textbox.Location = new System.Drawing.Point(156, 19);
            this.rental_id_textbox.Name = "rental_id_textbox";
            this.rental_id_textbox.Size = new System.Drawing.Size(167, 20);
            this.rental_id_textbox.TabIndex = 9;
            // 
            // rental_id
            // 
            this.rental_id.Location = new System.Drawing.Point(26, 22);
            this.rental_id.Name = "rental_id";
            this.rental_id.Size = new System.Drawing.Size(97, 27);
            this.rental_id.TabIndex = 8;
            this.rental_id.Text = "Rental ID";
            // 
            // status_box
            // 
            this.status_box.FormattingEnabled = true;
            this.status_box.Items.AddRange(new object[] { "Pending", "Active", "Completed", "Cancelled" });
            this.status_box.Location = new System.Drawing.Point(156, 142);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(167, 21);
            this.status_box.TabIndex = 7;
            // 
            // end_datepicker
            // 
            this.end_datepicker.CustomFormat = "dd/MM/yyyy";
            this.end_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_datepicker.Location = new System.Drawing.Point(156, 93);
            this.end_datepicker.Name = "end_datepicker";
            this.end_datepicker.Size = new System.Drawing.Size(167, 20);
            this.end_datepicker.TabIndex = 6;
            // 
            // start_datepicker
            // 
            this.start_datepicker.CustomFormat = "dd/MM/yyyy";
            this.start_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_datepicker.Location = new System.Drawing.Point(156, 55);
            this.start_datepicker.Name = "start_datepicker";
            this.start_datepicker.Size = new System.Drawing.Size(167, 20);
            this.start_datepicker.TabIndex = 5;
            // 
            // customer_id_textbox
            // 
            this.customer_id_textbox.Location = new System.Drawing.Point(486, 19);
            this.customer_id_textbox.Name = "customer_id_textbox";
            this.customer_id_textbox.Size = new System.Drawing.Size(167, 20);
            this.customer_id_textbox.TabIndex = 4;
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(26, 99);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(97, 27);
            this.end_date.TabIndex = 3;
            this.end_date.Text = "End Date";
            // 
            // rental_status
            // 
            this.rental_status.Location = new System.Drawing.Point(26, 145);
            this.rental_status.Name = "rental_status";
            this.rental_status.Size = new System.Drawing.Size(97, 27);
            this.rental_status.TabIndex = 2;
            this.rental_status.Text = "Rental Status";
            // 
            // start_date
            // 
            this.start_date.Location = new System.Drawing.Point(26, 61);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(97, 27);
            this.start_date.TabIndex = 1;
            this.start_date.Text = "Start Date";
            // 
            // customer_id
            // 
            this.customer_id.Location = new System.Drawing.Point(367, 22);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(97, 27);
            this.customer_id.TabIndex = 0;
            this.customer_id.Text = "Customer ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 218);
            this.dataGridView1.TabIndex = 1;
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(29, 202);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(74, 22);
            this.insert_btn.TabIndex = 4;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(139, 202);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(62, 22);
            this.update_btn.TabIndex = 5;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(235, 202);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(60, 21);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // RentalsControl
            // 
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rental_details);
            this.Name = "RentalsControl";
            this.Size = new System.Drawing.Size(701, 452);
            this.rental_details.ResumeLayout(false);
            this.rental_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox rental_id_textbox;
        private System.Windows.Forms.Label rental_id;

        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;

        private System.Windows.Forms.TextBox customer_id_textbox;
        private System.Windows.Forms.Label customer_id;
        
        private System.Windows.Forms.DateTimePicker start_datepicker;
        private System.Windows.Forms.DateTimePicker end_datepicker;
        private System.Windows.Forms.ComboBox status_box;

        private System.Windows.Forms.Label rental_status;
        private System.Windows.Forms.Label end_date;

        private System.Windows.Forms.Label start_date;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.GroupBox rental_details;

        #endregion
    }
}