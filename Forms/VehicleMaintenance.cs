using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    public partial class VehicleMaintenance : Form
    {
        public VehicleMaintenance()
        {
            InitializeComponent();
            Load += VehicleMaintenance_Load;
        }

        SqlConnection conn = new SqlConnection(@"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True");

        private void VehicleMaintenance_Load(object sender, EventArgs e)
        {
            LoadTable("Vehicle_Needs_Maintenance");
        }

        private void LoadTable(string tableName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    string query = $"SELECT * FROM {tableName}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error loading data: " + ex.Message);
            }
        }

        
        // private void VehicleSearchButton_Click(object sender, EventArgs e)
        // {
        //     string searchText = vehicleSearchTextBox.Text.Trim();
        //     if (!string.IsNullOrEmpty(searchText))
        //     {
        //         string condition = $"Make LIKE '%{searchText}%' OR Model LIKE '%{searchText}%'";
        //         LoadTable(condition);
        //     }
        //     else
        //     {
        //         LoadTable();
        //     }
        // }

        private void vehicleInsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertVehicleNeedsMaintenance", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@Maintenance_Number", int.Parse(maintenanceTextBox.Text));
                    cmd.Parameters.AddWithValue("@CarID", int.Parse(carTextBox.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle maintenance record inserted successfully.");
                    LoadTable("Vehicle_Needs_Maintenance");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting vehicle maintenance record: " + ex.Message);
            }
        }

        private void vehicleUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to update.");
                    return;
                }

                int oldMaintenanceNumber = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Maintenance_Number"].Value);
                int oldCarID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CarID"].Value);

                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateVehicleNeedsMaintenance", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@Old_Maintenance_Number", oldMaintenanceNumber);
                    cmd.Parameters.AddWithValue("@Old_CarID", oldCarID);
                    cmd.Parameters.AddWithValue("@New_Maintenance_Number", int.Parse(maintenanceTextBox.Text));
                    cmd.Parameters.AddWithValue("@New_CarID", int.Parse(carTextBox.Text));

                    con.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    MessageBox.Show(affectedRows > 0 ? "Record updated successfully." : "Record not found.");
                    LoadTable("Vehicle_Needs_Maintenance");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vehicle maintenance record: " + ex.Message);
            }
        }

        private void vehicleDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }

                int maintenanceNumber = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Maintenance_Number"].Value);
                int carID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CarID"].Value);

                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteVehicleNeedsMaintenance", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@Maintenance_Number", maintenanceNumber);
                    cmd.Parameters.AddWithValue("@CarID", carID);

                    con.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    MessageBox.Show(affectedRows > 0 ? "Record deleted successfully." : "Record not found.");
                    LoadTable("Vehicle_Needs_Maintenance");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting vehicle maintenance record: " + ex.Message);
            }
        }

    }
}
