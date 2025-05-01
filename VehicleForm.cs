using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class VehicleForm : Form
    {
        // Your connection string to SQL Server
        private readonly string connectionString = "Data Source=.;Initial Catalog=project;Integrated Security=True";

        public VehicleForm()
        {
            InitializeComponent();
            LoadVehicles();
        }

        // INSERT vehicle
        private void InsertVehicle()
        {

            if (!string.IsNullOrWhiteSpace(txtCarID.Text))
            {
                MessageBox.Show("You cannot enter CarID manually. It is auto-generated.");
                return;
            }

            if (!int.TryParse(txtModelYear.Text, out int modelYear) ||
                !int.TryParse(txtNumberOfSeats.Text, out int seats) ||
                !int.TryParse(txtGarageID.Text, out int garageId))
            {
                MessageBox.Show("Please enter valid numeric and date values.");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Vehicle (Brand, Model_Name, Model_Year, Type, Color, Number_of_Seats, License_Expiry_Date, License_Number, GarageID, Availability_Status)
                         VALUES (@Brand, @Model_Name, @Model_Year, @Type, @Color, @Number_of_Seats, @License_Expiry_Date, @License_Number, @GarageID, @Availability_Status)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@Model_Name", txtModelName.Text);
                    cmd.Parameters.AddWithValue("@Model_Year", modelYear);
                    cmd.Parameters.AddWithValue("@Type", txtType.Text);
                    cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                    cmd.Parameters.AddWithValue("@Number_of_Seats", seats);
                    cmd.Parameters.AddWithValue("@License_Expiry_Date", dtpLicenseExpiry.Value);
                    cmd.Parameters.AddWithValue("@License_Number", txtLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@GarageID", garageId);
                    cmd.Parameters.AddWithValue("@Availability_Status", txtStatus.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Vehicle inserted successfully.");
                    LoadVehicles();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting vehicle: " + ex.Message);
            }
        }


        // UPDATE vehicle
        private void UpdateVehicle()
        {

            if (!int.TryParse(txtCarID.Text, out int carId) ||
                !int.TryParse(txtModelYear.Text, out int modelYear) ||
                !int.TryParse(txtNumberOfSeats.Text, out int seats) ||
                !int.TryParse(txtGarageID.Text, out int garageId))
            {
                MessageBox.Show("Please enter valid numeric and date values.");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Vehicle SET 
                    Brand = @Brand,
                    Model_Name = @Model_Name,
                    Model_Year = @Model_Year,
                    Type = @Type,   
                    Color = @Color,
                    Number_of_Seats = @Number_of_Seats,
                    License_Expiry_Date = @License_Expiry_Date,
                    License_Number = @License_Number,
                    GarageID = @GarageID,
                    Availability_Status = @Availability_Status
                    WHERE CarID = @CarID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CarID", carId);
                    cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@Model_Name", txtModelName.Text);
                    cmd.Parameters.AddWithValue("@Model_Year", modelYear);
                    cmd.Parameters.AddWithValue("@Type", txtType.Text);
                    cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                    cmd.Parameters.AddWithValue("@Number_of_Seats", seats);
                    cmd.Parameters.AddWithValue("@License_Expiry_Date", dtpLicenseExpiry.Value);
                    cmd.Parameters.AddWithValue("@License_Number", txtLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@GarageID", garageId);
                    cmd.Parameters.AddWithValue("@Availability_Status", txtStatus.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Vehicle updated successfully.");
                        LoadVehicles();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No vehicle found with the specified CarID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating vehicle: " + ex.Message);
            }
        }

        // DELETE vehicle
        private void DeleteVehicle()
        {
            if (!int.TryParse(txtCarID.Text, out int carId))
            {
                MessageBox.Show("Please enter valid numeric and date values.");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Vehicle WHERE CarID = @CarID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CarID", carId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Vehicle deleted.");
                    LoadVehicles();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting vehicle: " + ex.Message);
            }
        }

        // LOAD vehicles into DataGridView
        private void LoadVehicles()
        {
            try { 
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Vehicle";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading vehicles: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtCarID.Clear();
            txtBrand.Clear();
            txtModelName.Clear();
            txtModelYear.Clear();
            txtType.Clear();
            txtColor.Clear();
            txtNumberOfSeats.Clear();
            dtpLicenseExpiry.Value = DateTime.Today;
            txtLicenseNumber.Clear();
            txtGarageID.Clear();
            txtStatus.Clear();
        }


        // SEARCH vehicle
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCarID.Text, out int carId))
            {
                MessageBox.Show("Please enter valid numeric and date values.");
                return;
            }
            try { 
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Vehicle WHERE CarID = @CarID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CarID", carId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtBrand.Text = reader["Brand"].ToString();
                    txtModelName.Text = reader["Model_Name"].ToString();
                    txtModelYear.Text = reader["Model_Year"].ToString();
                    txtType.Text = reader["Type"].ToString();
                    txtColor.Text = reader["Color"].ToString();
                    txtNumberOfSeats.Text = reader["Number_of_Seats"].ToString();
                    dtpLicenseExpiry.Text = reader["License_Expiry_Date"].ToString();
                    txtLicenseNumber.Text = reader["License_Number"].ToString();
                    txtGarageID.Text = reader["GarageID"].ToString();
                    txtStatus.Text = reader["Availability_Status"].ToString();
                }
                else
                {
                    MessageBox.Show("Vehicle not found.");
                }

                con.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching vehicle: " + ex.Message);
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            InsertVehicle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateVehicle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteVehicle();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}