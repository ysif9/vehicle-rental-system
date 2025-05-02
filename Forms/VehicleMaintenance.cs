using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class VehicleMaintenance : Form
    {
        public VehicleMaintenance()
        {
            InitializeComponent();
            Load += VehicleMaintenance_Load;

            // Bind events
            vehicleInsertButton.Click += VehicleInsertButton_Click;
            vehicleUpdateButton.Click += VehicleUpdateButton_Click;
            vehicleDeleteButton.Click += VehicleDeleteButton_Click;
            vehicleSearchButton.Click += VehicleSearchButton_Click;
        }

        SqlConnection conn = new SqlConnection(@"Server=MSI,1433;Initial Catalog=DatabaseProject;Integrated Security=True");

        private void VehicleMaintenance_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable(string condition = "")
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    string query = "SELECT * FROM Vehicle";
                    if (!string.IsNullOrWhiteSpace(condition))
                        query += " WHERE " + condition;

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    vehicleDataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
        }

        private void VehicleInsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertVehicle", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Sample parameters (customize to your DB fields)
                    cmd.Parameters.AddWithValue("@Make", "Toyota");
                    cmd.Parameters.AddWithValue("@Model", "Corolla");
                    cmd.Parameters.AddWithValue("@Year", 2020);
                    cmd.Parameters.AddWithValue("@Status", "Available");

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle inserted successfully.");
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting vehicle: " + ex.Message);
            }
        }

        private void VehicleUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehicleDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a vehicle to update.");
                    return;
                }

                int vehicleID = Convert.ToInt32(vehicleDataGridView.SelectedRows[0].Cells["VehicleID"].Value);

                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateVehicle", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@VehicleID", vehicleID);
                    cmd.Parameters.AddWithValue("@Make", "UpdatedMake");
                    cmd.Parameters.AddWithValue("@Model", "UpdatedModel");
                    cmd.Parameters.AddWithValue("@Year", 2022);
                    cmd.Parameters.AddWithValue("@Status", "Maintenance");

                    con.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    MessageBox.Show(affectedRows > 0 ? "Vehicle updated successfully." : "Vehicle not found.");
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vehicle: " + ex.Message);
            }
        }

        private void VehicleDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehicleDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a vehicle to delete.");
                    return;
                }

                int vehicleID = Convert.ToInt32(vehicleDataGridView.SelectedRows[0].Cells["VehicleID"].Value);

                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteVehicle", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@VehicleID", vehicleID);
                    con.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    MessageBox.Show(affectedRows > 0 ? "Vehicle deleted successfully." : "Vehicle not found.");
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting vehicle: " + ex.Message);
            }
        }

        private void VehicleSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = vehicleSearchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                string condition = $"Make LIKE '%{searchText}%' OR Model LIKE '%{searchText}%'";
                LoadTable(condition);
            }
            else
            {
                LoadTable();
            }
        }
    }
}
