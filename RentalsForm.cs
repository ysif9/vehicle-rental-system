using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class RentalsForm : Form
    {
        public RentalsForm()
        {
            InitializeComponent();
            Load += RentalsForm_Load;
        }
        
        private void RentalsForm_Load(object sender, EventArgs e)
        {
            LoadTable("Rental");
        }

        SqlConnection conn =
            new SqlConnection(
                @"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True");

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

        
        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(conn.ConnectionString))
                {
                    var cmd = new SqlCommand("InsertRental", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@StartDate", start_datepicker.Value);
                    cmd.Parameters.AddWithValue("@EndDate", end_datepicker.Value);
                    cmd.Parameters.AddWithValue("@Status", status_box.SelectedItem?.ToString() ?? "Pending");
                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(customer_id_textbox.Text));

                    con.Open();
                    int newRentalId = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show($"Rental inserted successfully. RentalID: {newRentalId}");
                }

                LoadTable("Rental");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }


        private void search_btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateRental", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@RentalID", int.Parse(rental_id_textbox.Text));
                    cmd.Parameters.AddWithValue("@StartDate", start_datepicker.Value);
                    cmd.Parameters.AddWithValue("@EndDate", end_datepicker.Value);
                    cmd.Parameters.AddWithValue("@Status", status_box.SelectedItem?.ToString() ?? "Pending");
                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(customer_id_textbox.Text));

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0 ? "Rental updated successfully." : "Rental not found.");
                    LoadTable("Rental");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteRental", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@RentalID", int.Parse(rental_id_textbox.Text));

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0 ? "Rental deleted successfully." : "Rental not found.");
                    LoadTable("Rental");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}