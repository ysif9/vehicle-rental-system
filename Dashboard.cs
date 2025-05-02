using System;
using System.Windows.Forms;
using VehicleRentalSystem.Forms;

namespace VehicleRentalSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            var customerControl = new CustomerControl();
            customerControl.Dock = DockStyle.Fill;
            tabCustomer.Controls.Clear();
            tabCustomer.Controls.Add(customerControl);

            var rentalControl = new RentalsControl();
            rentalControl.Dock = DockStyle.Fill;
            tabRental.Controls.Clear();
            tabRental.Controls.Add(rentalControl);

            var paymentControl = new PaymentControl();
            paymentControl.Dock = DockStyle.Fill;
            tabPayment.Controls.Clear();
            tabPayment.Controls.Add(paymentControl);

            var maintenanceControl = new MaintenanceControl();
            maintenanceControl.Dock = DockStyle.Fill;
            tabMaintenance.Controls.Clear();
            tabMaintenance.Controls.Add(maintenanceControl);

            // var garageControl = new GarageControl();
            // garageControl.Dock = DockStyle.Fill;
            // tabGarage.Controls.Clear();
            // tabGarage.Controls.Add(garageControl);

            // var vehicleControl = new VehicleControl();
            // vehicleControl.Dock = DockStyle.Fill;
            // tabVehicle.Controls.Clear();
            // tabVehicle.Controls.Add(vehicleControl);
            //
            // var vehicleRentalControl = new VehicleRentalControl();
            // vehicleRentalControl.Dock = DockStyle.Fill;
            // tabVehicle_Offered_For_Rental.Controls.Clear();
            // tabVehicle_Offered_For_Rental.Controls.Add(vehicleRentalControl);

            var vehicleMaintenanceControl = new VehicleMaintenanceControl();
            vehicleMaintenanceControl.Dock = DockStyle.Fill;
            tabVehicle_Needs_Maintenance.Controls.Clear();
            tabVehicle_Needs_Maintenance.Controls.Add(vehicleMaintenanceControl);

            var employeeControl = new EmployeeControl();
            employeeControl.Dock = DockStyle.Fill;
            tabEmployee.Controls.Clear();
            tabEmployee.Controls.Add(employeeControl);

            var reviewsControl = new ReviewsControl();
            reviewsControl.Dock = DockStyle.Fill;
            tabReviews.Controls.Clear();
            tabReviews.Controls.Add(reviewsControl);
        }
    }
}