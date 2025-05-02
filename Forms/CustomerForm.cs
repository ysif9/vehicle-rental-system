using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            Load += CustomerForm_Load;
        }

        SqlConnection conn = new SqlConnection(@"Server=MSI,1433;Initial Catalog=DatabaseProject;Integrated Security=True");

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
                    customerDataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertCustomer", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@Customer_Name", customer_name_textbox.Text);
                    cmd.Parameters.AddWithValue("@Address", address_textbox.Text);
                    cmd.Parameters.AddWithValue("@Date_of_Birth", dob_picker.Value);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(age_textbox.Text));
                    cmd.Parameters.AddWithValue("@Email", email_textbox.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", phone_textbox.Text);
                    cmd.Parameters.AddWithValue("@Password", password_textbox.Text);
                    cmd.Parameters.AddWithValue("@License_Number", license_number_textbox.Text);
                    cmd.Parameters.AddWithValue("@License_Expiry_Date", license_expiry_picker.Value);
                    cmd.Parameters.AddWithValue("@License_Personal_Photo", license_photo_textbox.Text);

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

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateCustomer", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(customer_id_textbox.Text));
                    cmd.Parameters.AddWithValue("@Customer_Name", customer_name_textbox.Text);
                    cmd.Parameters.AddWithValue("@Address", address_textbox.Text);
                    cmd.Parameters.AddWithValue("@Date_of_Birth", dob_picker.Value);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(age_textbox.Text));
                    cmd.Parameters.AddWithValue("@Email", email_textbox.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", phone_textbox.Text);
                    cmd.Parameters.AddWithValue("@Password", password_textbox.Text);
                    cmd.Parameters.AddWithValue("@License_Number", license_number_textbox.Text);
                    cmd.Parameters.AddWithValue("@License_Expiry_Date", license_expiry_picker.Value);
                    cmd.Parameters.AddWithValue("@License_Personal_Photo", license_photo_textbox.Text);

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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteCustomer", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(customer_id_textbox.Text));

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

        private void search_btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}