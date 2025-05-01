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
                    const string query =
                        @"INSERT INTO Rental (Start_Date, End_Date, Rental_Status, CustomerID)
                             VALUES (@StartDate, @EndDate, @Status, @CustomerID)";
                    var cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StartDate", start_datepicker.Value);
                    cmd.Parameters.AddWithValue("@EndDate", end_datepicker.Value);
                    cmd.Parameters.AddWithValue("@Status", status_box.SelectedItem?.ToString() ?? "Pending");
                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(customer_id_textbox.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Rental inserted successfully.");
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
                    string query = @"UPDATE Rental 
                             SET Start_Date = @StartDate, 
                                 End_Date = @EndDate, 
                                 Rental_Status = @Status, 
                                 CustomerID = @CustomerID 
                             WHERE RentalID = @RentalID";

                    SqlCommand cmd = new SqlCommand(query, con);
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
                    string query = "DELETE FROM Rental WHERE RentalID = @RentalID";
                    SqlCommand cmd = new SqlCommand(query, con);
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