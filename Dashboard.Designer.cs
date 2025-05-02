using System.ComponentModel;

namespace VehicleRentalSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.customerTab = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.tabRental = new System.Windows.Forms.TabPage();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.tabMaintenance = new System.Windows.Forms.TabPage();
            this.tabGarage = new System.Windows.Forms.TabPage();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.tabVehicle_Offered_For_Rental = new System.Windows.Forms.TabPage();
            this.tabVehicle_Needs_Maintenance = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabReviews = new System.Windows.Forms.TabPage();
            this.customerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.tabCustomer);
            this.customerTab.Controls.Add(this.tabRental);
            this.customerTab.Controls.Add(this.tabPayment);
            this.customerTab.Controls.Add(this.tabMaintenance);
            this.customerTab.Controls.Add(this.tabGarage);
            this.customerTab.Controls.Add(this.tabVehicle);
            this.customerTab.Controls.Add(this.tabVehicle_Offered_For_Rental);
            this.customerTab.Controls.Add(this.tabVehicle_Needs_Maintenance);
            this.customerTab.Controls.Add(this.tabEmployee);
            this.customerTab.Controls.Add(this.tabReviews);
            this.customerTab.Location = new System.Drawing.Point(0, 0);
            this.customerTab.Name = "customerTab";
            this.customerTab.SelectedIndex = 0;
            this.customerTab.Size = new System.Drawing.Size(1181, 555);
            this.customerTab.TabIndex = 0;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(1173, 529);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // tabRental
            // 
            this.tabRental.Location = new System.Drawing.Point(4, 22);
            this.tabRental.Name = "tabRental";
            this.tabRental.Size = new System.Drawing.Size(1131, 529);
            this.tabRental.TabIndex = 1;
            this.tabRental.Text = "Rental";
            this.tabRental.UseVisualStyleBackColor = true;
            // 
            // tabPayment
            // 
            this.tabPayment.Location = new System.Drawing.Point(4, 22);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Size = new System.Drawing.Size(1131, 529);
            this.tabPayment.TabIndex = 2;
            this.tabPayment.Text = "Payment";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // tabMaintenance
            // 
            this.tabMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tabMaintenance.Name = "tabMaintenance";
            this.tabMaintenance.Size = new System.Drawing.Size(1131, 529);
            this.tabMaintenance.TabIndex = 3;
            this.tabMaintenance.Text = "Maintenance";
            this.tabMaintenance.UseVisualStyleBackColor = true;
            // 
            // tabGarage
            // 
            this.tabGarage.Location = new System.Drawing.Point(4, 22);
            this.tabGarage.Name = "tabGarage";
            this.tabGarage.Size = new System.Drawing.Size(1131, 529);
            this.tabGarage.TabIndex = 4;
            this.tabGarage.Text = "Garage";
            this.tabGarage.UseVisualStyleBackColor = true;
            // 
            // tabVehicle
            // 
            this.tabVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Size = new System.Drawing.Size(1131, 529);
            this.tabVehicle.TabIndex = 5;
            this.tabVehicle.Text = "Vehicle";
            this.tabVehicle.UseVisualStyleBackColor = true;
            // 
            // tabVehicle_Offered_For_Rental
            // 
            this.tabVehicle_Offered_For_Rental.Location = new System.Drawing.Point(4, 22);
            this.tabVehicle_Offered_For_Rental.Name = "tabVehicle_Offered_For_Rental";
            this.tabVehicle_Offered_For_Rental.Size = new System.Drawing.Size(1131, 529);
            this.tabVehicle_Offered_For_Rental.TabIndex = 6;
            this.tabVehicle_Offered_For_Rental.Text = "Vehicle Offered For Rental";
            this.tabVehicle_Offered_For_Rental.UseVisualStyleBackColor = true;
            // 
            // tabVehicle_Needs_Maintenance
            // 
            this.tabVehicle_Needs_Maintenance.Location = new System.Drawing.Point(4, 22);
            this.tabVehicle_Needs_Maintenance.Name = "tabVehicle_Needs_Maintenance";
            this.tabVehicle_Needs_Maintenance.Size = new System.Drawing.Size(1131, 529);
            this.tabVehicle_Needs_Maintenance.TabIndex = 7;
            this.tabVehicle_Needs_Maintenance.Text = "Vehicle Needs Maintenance";
            this.tabVehicle_Needs_Maintenance.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(1131, 529);
            this.tabEmployee.TabIndex = 8;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabReviews
            // 
            this.tabReviews.Location = new System.Drawing.Point(4, 22);
            this.tabReviews.Name = "tabReviews";
            this.tabReviews.Size = new System.Drawing.Size(1131, 529);
            this.tabReviews.TabIndex = 10;
            this.tabReviews.Text = "Reviews";
            this.tabReviews.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 554);
            this.Controls.Add(this.customerTab);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.customerTab.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl customerTab;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabRental;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.TabPage tabMaintenance;
        private System.Windows.Forms.TabPage tabGarage;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.TabPage tabVehicle_Offered_For_Rental;
        private System.Windows.Forms.TabPage tabVehicle_Needs_Maintenance;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabReviews;

        #endregion
    }
}