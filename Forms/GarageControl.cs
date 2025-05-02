using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    public partial class GarageControl : UserControl
    {
        private DataTable tbl_Garages = new DataTable();
        private DataTable tbl_AssignedEmployees = new DataTable();
        private SqlConnection con;

        public GarageControl()
        {
            InitializeComponent();
            SetupDatabaseConnection();
            if (con != null)
            {
                LoadGarages(); // Load garages automatically on form load
                SetupAssignedEmployeesGrid();
            }
        }

        private void SetupDatabaseConnection()
        {
            try
            {
                con = new SqlConnection(
                    @"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to set up database connection: " + ex.Message);
                con = null;
            }
        }

        private void LoadGarages()
        {
            if (con == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Garage", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                tbl_Garages.Clear();
                tbl_Garages.Columns.Clear();

                tbl_Garages.Columns.Add("GarageID", typeof(int)).ColumnName = "ID";
                tbl_Garages.Columns.Add("Garage_Name", typeof(string)).ColumnName = "Garage Name";
                tbl_Garages.Columns.Add("Address", typeof(string));
                tbl_Garages.Columns.Add("City", typeof(string));
                tbl_Garages.Columns.Add("State", typeof(string));
                tbl_Garages.Columns.Add("Manager_Name", typeof(string)).ColumnName = "Manager";
                tbl_Garages.Columns.Add("Garage_Phone_Number", typeof(string)).ColumnName = "Phone Number";
                tbl_Garages.Columns.Add("Vehicle_Count", typeof(int)).ColumnName = "Vehicle Count";

                DataRow row;
                bool hasData = false;
                while (reader.Read())
                {
                    hasData = true;
                    row = tbl_Garages.NewRow();
                    row["ID"] = reader["GarageID"] != DBNull.Value ? Convert.ToInt32(reader["GarageID"]) : 0;
                    row["Garage Name"] = reader["Garage_Name"] != DBNull.Value ? reader["Garage_Name"].ToString() : "";
                    row["Address"] = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : "";
                    row["City"] = reader["City"] != DBNull.Value ? reader["City"].ToString() : "";
                    row["State"] = reader["State"] != DBNull.Value ? reader["State"].ToString() : "";
                    row["Manager"] = reader["Manager_Name"] != DBNull.Value ? reader["Manager_Name"].ToString() : "";
                    row["Phone Number"] = reader["Garage_Phone_Number"] != DBNull.Value ? reader["Garage_Phone_Number"].ToString() : "";
                    row["Vehicle Count"] = reader["Vehicle_Count"] != DBNull.Value ? Convert.ToInt32(reader["Vehicle_Count"]) : 0;
                    tbl_Garages.Rows.Add(row);
                }

                reader.Close();
                dgvGarages.DataSource = tbl_Garages;

                dgvGarages.Columns["ID"].Width = 50;
                dgvGarages.Columns["Garage Name"].Width = 150;
                dgvGarages.Columns["Address"].Width = 200;
                dgvGarages.Columns["City"].Width = 100;
                dgvGarages.Columns["State"].Width = 100;
                dgvGarages.Columns["Manager"].Width = 150;
                dgvGarages.Columns["Phone Number"].Width = 120;
                dgvGarages.Columns["Vehicle Count"].Width = 80;

                if (!hasData)
                {
                    MessageBox.Show("No garages found in the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading garages: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void SetupAssignedEmployeesGrid()
        {
            tbl_AssignedEmployees.Columns.Clear();
            tbl_AssignedEmployees.Columns.Add("EmployeeID", typeof(int)).ColumnName = "Employee ID";
            tbl_AssignedEmployees.Columns.Add("Name", typeof(string));
            tbl_AssignedEmployees.Columns.Add("Role", typeof(string));
            dgvAssignedEmployees.DataSource = tbl_AssignedEmployees;
        }

        private void LoadAssignedEmployees(int garageId)
        {
            if (con == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }

            tbl_AssignedEmployees.Clear();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT e.EmployeeID, e.Name, e.Role " +
                    "FROM Employee e " +
                    "JOIN Employee_Works_For_Garage ewg ON e.EmployeeID = ewg.EmployeeID " +
                    "WHERE ewg.GarageID = @GarageID", con);
                cmd.Parameters.AddWithValue("@GarageID", garageId);
                SqlDataReader reader = cmd.ExecuteReader();

                bool hasData = false;
                while (reader.Read())
                {
                    hasData = true;
                    DataRow row = tbl_AssignedEmployees.NewRow();
                    row["Employee ID"] = reader["EmployeeID"] != DBNull.Value ? Convert.ToInt32(reader["EmployeeID"]) : 0;
                    row["Name"] = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : "";
                    row["Role"] = reader["Role"] != DBNull.Value ? reader["Role"].ToString() : "";
                    tbl_AssignedEmployees.Rows.Add(row);
                }

                reader.Close();
                dgvAssignedEmployees.DataSource = tbl_AssignedEmployees;

                dgvAssignedEmployees.Columns["Employee ID"].Width = 80;
                dgvAssignedEmployees.Columns["Name"].Width = 150;
                dgvAssignedEmployees.Columns["Role"].Width = 150;

                if (!hasData)
                {
                    MessageBox.Show($"No employees assigned to Garage ID {garageId}.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assigned employees: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }

            if (string.IsNullOrEmpty(txtGarageName.Text) || string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtState.Text) ||
                string.IsNullOrEmpty(txtManagerName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                string.IsNullOrEmpty(txtVehicleCount.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(txtVehicleCount.Text, out int vehicleCount))
            {
                MessageBox.Show("Please enter a valid number for Vehicle Count.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Garage (Garage_Name, Address, City, State, Manager_Name, Garage_Phone_Number, Vehicle_Count) " +
                    "VALUES (@Garage_Name, @Address, @City, @State, @Manager_Name, @Garage_Phone_Number, @Vehicle_Count)", con);
                cmd.Parameters.AddWithValue("@Garage_Name", txtGarageName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@State", txtState.Text);
                cmd.Parameters.AddWithValue("@Manager_Name", txtManagerName.Text);
                cmd.Parameters.AddWithValue("@Garage_Phone_Number", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Vehicle_Count", vehicleCount);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Garage inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting garage: " + ex.Message);
                return; // Exit the method to avoid calling LoadGarages if an error occurs
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            // Call LoadGarages after the connection is closed
            LoadGarages();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }

            if (dgvGarages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a garage to update.");
                return;
            }

            if (string.IsNullOrEmpty(txtGarageName.Text) || string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtState.Text) ||
                string.IsNullOrEmpty(txtManagerName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                string.IsNullOrEmpty(txtVehicleCount.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(txtVehicleCount.Text, out int vehicleCount))
            {
                MessageBox.Show("Please enter a valid number for Vehicle Count.");
                return;
            }

            var garageIdValue = dgvGarages.SelectedRows[0].Cells["ID"].Value;
            if (garageIdValue == null || !int.TryParse(garageIdValue.ToString(), out int garageId))
            {
                MessageBox.Show("Invalid Garage ID selected.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Garage SET Garage_Name = @Garage_Name, Address = @Address, City = @City, State = @State, " +
                    "Manager_Name = @Manager_Name, Garage_Phone_Number = @Garage_Phone_Number, Vehicle_Count = @Vehicle_Count " +
                    "WHERE GarageID = @GarageID", con);
                cmd.Parameters.AddWithValue("@GarageID", garageId);
                cmd.Parameters.AddWithValue("@Garage_Name", txtGarageName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@State", txtState.Text);
                cmd.Parameters.AddWithValue("@Manager_Name", txtManagerName.Text);
                cmd.Parameters.AddWithValue("@Garage_Phone_Number", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Vehicle_Count", vehicleCount);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Garage updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating garage: " + ex.Message);
                return;
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            LoadGarages();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }

            if (dgvGarages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a garage to delete.");
                return;
            }

            var garageIdValue = dgvGarages.SelectedRows[0].Cells["ID"].Value;
            if (garageIdValue == null || !int.TryParse(garageIdValue.ToString(), out int garageId))
            {
                MessageBox.Show("Invalid Garage ID selected.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Employee_Works_For_Garage WHERE GarageID = @GarageID;" +
                    "DELETE FROM Garage WHERE GarageID = @GarageID", con);
                cmd.Parameters.AddWithValue("@GarageID", garageId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Garage deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting garage: " + ex.Message);
                return;
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            LoadGarages();
            tbl_AssignedEmployees.Clear(); // Clear the assigned employees grid
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Garage", con);
                int count = (int)cmd.ExecuteScalar();
                MessageBox.Show($"Total garages: {count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting garages: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnAssignEmployee_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }

            if (dgvGarages.SelectedRows.Count > 0 && !string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                if (!int.TryParse(txtEmployeeID.Text, out int employeeId))
                {
                    MessageBox.Show("Please enter a valid Employee ID.");
                    return;
                }

                var garageIdValue = dgvGarages.SelectedRows[0].Cells["ID"].Value;
                if (garageIdValue == null || !int.TryParse(garageIdValue.ToString(), out int garageId))
                {
                    MessageBox.Show("Invalid Garage ID selected.");
                    return;
                }

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Employee_Works_For_Garage (EmployeeID, GarageID) VALUES (@EmployeeID, @GarageID)", con);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    cmd.Parameters.AddWithValue("@GarageID", garageId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee assigned to garage successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error assigning employee: " + ex.Message);
                    return;
                }
                finally
                {
                    if (con != null && con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

                LoadAssignedEmployees(garageId);
            }
            else
            {
                MessageBox.Show("Please select a garage and enter an Employee ID.");
            }
        }

        private void dgvGarages_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGarages.SelectedRows.Count > 0)
            {
                var row = dgvGarages.SelectedRows[0];
                txtGarageName.Text = row.Cells["Garage Name"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtCity.Text = row.Cells["City"].Value?.ToString() ?? "";
                txtState.Text = row.Cells["State"].Value?.ToString() ?? "";
                txtManagerName.Text = row.Cells["Manager"].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells["Phone Number"].Value?.ToString() ?? "";
                txtVehicleCount.Text = row.Cells["Vehicle Count"].Value?.ToString() ?? "";
                if (int.TryParse(row.Cells["ID"].Value?.ToString(), out int garageId))
                {
                    LoadAssignedEmployees(garageId);
                }
                else
                {
                    MessageBox.Show("Invalid Garage ID selected.");
                }
            }
        }

        private void dgvGarages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvGarages.Rows[e.RowIndex].Selected = true;
                var row = dgvGarages.Rows[e.RowIndex];
                txtGarageName.Text = row.Cells["Garage Name"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtCity.Text = row.Cells["City"].Value?.ToString() ?? "";
                txtState.Text = row.Cells["State"].Value?.ToString() ?? "";
                txtManagerName.Text = row.Cells["Manager"].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells["Phone Number"].Value?.ToString() ?? "";
                txtVehicleCount.Text = row.Cells["Vehicle Count"].Value?.ToString() ?? "";
                if (int.TryParse(row.Cells["ID"].Value?.ToString(), out int garageId))
                {
                    LoadAssignedEmployees(garageId);
                }
                else
                {
                    MessageBox.Show("Invalid Garage ID selected.");
                }
            }
        }
    }
}