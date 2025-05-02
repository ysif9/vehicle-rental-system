using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
            Load += CustomerForm_Load;
        }

        SqlConnection conn = new SqlConnection(@"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True");

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadTable("Customer");
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
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertCustomer", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Date_of_Birth", dtpBirth.Value);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@License_Number", txtLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@License_Expiry_Date", dtpExpiry.Value);
                    cmd.Parameters.AddWithValue("@License_Personal_Photo", txtLicensePhoto.Text);

                    con.Open();
                    int newCustomerId = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show($"Customer inserted successfully. CustomerID: {newCustomerId}");
                }

                LoadTable("Customer");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateCustomer", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                    cmd.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Date_of_Birth", dtpBirth.Value);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@License_Number", txtLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@License_Expiry_Date", dtpExpiry.Value);
                    cmd.Parameters.AddWithValue("@License_Personal_Photo", txtLicensePhoto.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0 ? "Customer updated successfully." : "Customer not found.");
                    LoadTable("Customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteCustomer", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0 ? "Customer deleted successfully." : "Customer not found.");
                    LoadTable("Customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}