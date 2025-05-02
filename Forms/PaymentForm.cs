using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    public partial class PaymentForm : Form
    {
        // Modify the connection string as per your SQL Server setup
        SqlConnection conn = new SqlConnection(@"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True");

        public PaymentForm()
        {
            InitializeComponent();
            LoadPayments();
        }

        private void LoadPayments()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetAllPayments", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPayments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("InsertPayment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Total_Price", decimal.Parse(txtTotalPrice.Text));
                    cmd.Parameters.AddWithValue("@Payment_Status", txtPaymentStatus.Text);
                    cmd.Parameters.AddWithValue("@Payment_Date", dtpPaymentDate.Value);
                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                    cmd.Parameters.AddWithValue("@RentalID", int.Parse(txtRentalID.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadPayments();
                    MessageBox.Show("Inserted successfully");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Insert failed: " + ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvPayments.CurrentRow != null)
                {
                    int paymentID = Convert.ToInt32(dgvPayments.CurrentRow.Cells["PaymentID"].Value);

                    using (SqlCommand cmd = new SqlCommand("UpdatePayment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                        cmd.Parameters.AddWithValue("@Total_Price", decimal.Parse(txtTotalPrice.Text));
                        cmd.Parameters.AddWithValue("@Payment_Status", txtPaymentStatus.Text);
                        cmd.Parameters.AddWithValue("@Payment_Date", dtpPaymentDate.Value);
                        cmd.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                        cmd.Parameters.AddWithValue("@RentalID", int.Parse(txtRentalID.Text));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        LoadPayments();
                        MessageBox.Show("Updated successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvPayments.CurrentRow != null)
                {
                    int paymentID = Convert.ToInt32(dgvPayments.CurrentRow.Cells["PaymentID"].Value);

                    using (SqlCommand cmd = new SqlCommand("DeletePayment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PaymentID", paymentID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        LoadPayments();
                        MessageBox.Show("Deleted successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPayments.CurrentRow != null)
            {
                txtTotalPrice.Text = dgvPayments.CurrentRow.Cells["Total_Price"].Value.ToString();
                txtPaymentStatus.Text = dgvPayments.CurrentRow.Cells["Payment_Status"].Value.ToString();
                dtpPaymentDate.Value = Convert.ToDateTime(dgvPayments.CurrentRow.Cells["Payment_Date"].Value);
                txtCustomerID.Text = dgvPayments.CurrentRow.Cells["CustomerID"].Value.ToString();
                txtRentalID.Text = dgvPayments.CurrentRow.Cells["RentalID"].Value.ToString();
            }
        }
    }
}
