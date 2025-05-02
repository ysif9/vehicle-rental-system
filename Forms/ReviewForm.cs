using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
            Load += ReviewsForm_Load;
        }

        SqlConnection conn = new SqlConnection(@"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True");

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            LoadTable("Reviews");
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
                    dgvReviews.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(conn.ConnectionString))
                {
                    var cmd = new SqlCommand("InsertReview", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@RentalID", int.Parse(txtRentalID.Text));
                    cmd.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@Feedback", txtFeedback.Text);
                    cmd.Parameters.AddWithValue("@Rating", int.Parse(txtRating.Text));
                    cmd.Parameters.AddWithValue("@Checked_By", int.Parse(txtCheckedBy.Text));
                    cmd.Parameters.AddWithValue("@Check_Report", txtCheckReport.Text);

                    con.Open();
                    int newReviewID = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show($"Review inserted successfully. ReviewID: {newReviewID}");
                    LoadTable("Reviews");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting review: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(conn.ConnectionString))
                {
                    var cmd = new SqlCommand("UpdateReview", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@ReviewID", int.Parse(txtReviewID.Text));
                    cmd.Parameters.AddWithValue("@RentalID", int.Parse(txtRentalID.Text));
                    cmd.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@Feedback", txtFeedback.Text);
                    cmd.Parameters.AddWithValue("@Rating", int.Parse(txtRating.Text));
                    cmd.Parameters.AddWithValue("@Checked_By", int.Parse(txtCheckedBy.Text));
                    cmd.Parameters.AddWithValue("@Check_Report", txtCheckReport.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0 ? "Review updated successfully." : "Review not found.");
                    LoadTable("Reviews");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating review: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(conn.ConnectionString))
                {
                    var cmd = new SqlCommand("DeleteReview", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@ReviewID", int.Parse(txtReviewID.Text));

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0 ? "Review deleted successfully." : "Review not found.");
                    LoadTable("Reviews");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting review: " + ex.Message);
            }
        }
    }
}
