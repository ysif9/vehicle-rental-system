using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class VehicleRentalControl : UserControl
    {
        public VehicleRentalControl()
        {
            InitializeComponent();
            LoadTable();
        }

        private readonly string connectionString = @"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True";

        private void InsertRentalVehicle()
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtCarID.Text) ||
                string.IsNullOrWhiteSpace(txtRentalID.Text) ||
                string.IsNullOrWhiteSpace(txtDailyPrice.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            if (!int.TryParse(txtCarID.Text, out int carId) || carId <= 0)
            {
                MessageBox.Show("CarID must be a valid positive number.");
                return;
            }

            if (!int.TryParse(txtRentalID.Text, out int rentalId) || rentalId <= 0)
            {
                MessageBox.Show("RentalID must be a valid positive number.");
                return;
            }

            if (!decimal.TryParse(txtDailyPrice.Text, out decimal dailyPrice) || dailyPrice < 0)
            {
                MessageBox.Show("Daily price must be a non-negative number.");
                return;
            }

            // Insert
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("InsertVehicleRental", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CarID", carId);
                    cmd.Parameters.AddWithValue("@RentalID", rentalId);
                    cmd.Parameters.AddWithValue("@Daily_price", dailyPrice);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle rental inserted successfully.");
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void UpdateRentalVehicle()
        {
            // Validate daily price
            if (!decimal.TryParse(txtDailyPrice.Text, out decimal dailyPrice) || dailyPrice < 0)
            {
                MessageBox.Show("Daily price must be a valid non-negative number.");
                return;
            }

            // Get current values from form
            int.TryParse(txtCarID.Text, out int carId);
            int.TryParse(txtRentalID.Text, out int rentalId);

            // Prevent editing IDs
            // if (carId != originalCarID || rentalId != originalRentalID)
            // {
            //     MessageBox.Show("You are not allowed to change CarID or RentalID during update.");
            //     txtCarID.Text = originalCarID.ToString();
            //     txtRentalID.Text = originalRentalID.ToString();
            //     return;
            // }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("UpdateVehicleRental", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Daily_price", dailyPrice);
                    cmd.Parameters.AddWithValue("@CarID", carId);
                    cmd.Parameters.AddWithValue("@RentalID", rentalId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0 ? "Update successful." : "No matching record found.");
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message);
            }
        }

        private void DeleteRentalVehicle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("DeleteVehicleRental", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CarID", int.Parse(txtCarID.Text));
                    cmd.Parameters.AddWithValue("@RentalID", int.Parse(txtRentalID.Text));

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Delete successful." : "No record found to delete.");
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadTable()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Vehicle_Offered_For_Rental", conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading table: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtRentalID.Text = row.Cells["RentalID"].Value.ToString();
                txtCarID.Text = row.Cells["CarID"].Value.ToString();
                txtDailyPrice.Text = row.Cells["Daily_Price"].Value.ToString();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Vehicle_Offered_For_Rental WHERE 1=1";
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (int.TryParse(txtCarID.Text, out int carId))
                {
                    query += " AND CarID = @CarID";
                    parameters.Add(new SqlParameter("@CarID", carId));
                }

                if (int.TryParse(txtRentalID.Text, out int rentalId))
                {
                    query += " AND RentalID = @RentalID";
                    parameters.Add(new SqlParameter("@RentalID", rentalId));
                }

                if (parameters.Count == 0)
                {
                    MessageBox.Show("Please enter at least CarID or RentalID to search.");
                    return;
                }
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertRentalVehicle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRentalVehicle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRentalVehicle();
        }

    }
}
