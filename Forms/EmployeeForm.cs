using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        // dah el Employee form, law 3ayez tbd2 b el form dah awel ma el app yft7, ro7 3ala Program.cs w khally Application.Run(new EmployeeForm());
        // law 3ayez tft7 el MaintenanceForm awel haga, bas 3adelha le Application.Run(new MaintenanceForm());
        // kol haga fel navigation mawgooda fel Program.cs, shof el comments hnak :)

        // hena el controls beta3t el form, kol haga lelha textbox aw control
        // (fields are now in the designer)
        // el connection string, 3ashan n3raf nconnect el db
        private string connectionString = @"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True";

        public EmployeeForm()
        {
            // hena bna3ml setup lel UI mn el designer
            InitializeComponent();
            // b3d keda bn-load el data
            WireUpEvents();
            LoadEmployees();
        }

        // move event handler wiring here
        private void WireUpEvents()
        {
            btnInsert.Click += (s, e) => InsertEmployee();
            btnUpdate.Click += (s, e) => UpdateEmployee();
            btnDelete.Click += (s, e) => DeleteEmployee();
            dataGridView.SelectionChanged += (s, e) => FillFieldsFromGrid();
        }

        // deh el function ely btshel el data mn el db w t7otha fel grid
        private void LoadEmployees()
        {
            try
            {
                // awel 7aga bnms7 el rows el adema
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // hena bnst3ml el procedure ely esmo GetAllEmployees
                    using (SqlCommand cmd = new SqlCommand("GetAllEmployees", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // kol row mn el db byzhar fel grid
                                dataGridView.Rows.Add(
                                    reader["EmployeeID"],
                                    reader["Name"],
                                    reader["Role"],
                                    reader["Age"],
                                    reader["Salary"],
                                    Convert.ToDateTime(reader["Enrollment_Date"]).ToString("yyyy-MM-dd")
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // hena el error handling, law 7asal ay moshkela fel db aw el connection
                MessageBox.Show("Error loading employees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // deh el insert, lama tedos 3ala el button, el data btdkhol el db
        private void InsertEmployee()
        {
            // validation 2abl ma n3ml insert
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtRole.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                // validation error, el user lazem y3ml kda
                MessageBox.Show("Please fill all fields except EmployeeID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check en el name w el role fehom letters w spaces bas
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z ]+$"))
            {
                // validation error, el esm lazem ykon letters bas
                MessageBox.Show("Name must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(txtRole.Text, @"^[a-zA-Z ]+$"))
            {
                // validation error, el role lazem ykon letters bas
                MessageBox.Show("Role must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                // validation error, el age lazem ykon rakam sah
                MessageBox.Show("Age must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary < 0)
            {
                // validation error, el salary lazem ykon rakam sah
                MessageBox.Show("Salary must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // hena bnb3at el values mn el textboxes lel procedure
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Role", txtRole.Text);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Salary", salary);
                        cmd.Parameters.AddWithValue("@Enrollment_Date", dtEnroll.Value.Date);
                        cmd.ExecuteNonQuery();
                    }
                }
                // b3d ma n3ml insert, bn-refresh el grid
                LoadEmployees();
            }
            catch (SqlException ex)
            {
                // sql error, y3ni feh moshkela fel query aw constraints
                MessageBox.Show("DB Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // ay error tanya
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // deh el update, lazem tkon m3lm 3ala row mn el grid
        private void UpdateEmployee()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                // validation error, lazem t3ml select
                MessageBox.Show("Select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtRole.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                // validation error, el user lazem y3ml kda
                MessageBox.Show("Please fill all fields except EmployeeID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check en el name w el role fehom letters w spaces bas
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z ]+$"))
            {
                // validation error, el esm lazem ykon letters bas
                MessageBox.Show("Name must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(txtRole.Text, @"^[a-zA-Z ]+$"))
            {
                // validation error, el role lazem ykon letters bas
                MessageBox.Show("Role must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                // validation error, el age lazem ykon rakam sah
                MessageBox.Show("Age must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary < 0)
            {
                // validation error, el salary lazem ykon rakam sah
                MessageBox.Show("Salary must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", id);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Role", txtRole.Text);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Salary", salary);
                        cmd.Parameters.AddWithValue("@Enrollment_Date", dtEnroll.Value.Date);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadEmployees();
            }
            catch (SqlException ex)
            {
                // sql error, y3ni feh moshkela fel query aw constraints
                MessageBox.Show("DB Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // ay error tanya
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // deh el delete, btmshy el row ely m3lm 3aleh
        private void DeleteEmployee()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                // validation error, lazem t3ml select
                MessageBox.Show("Select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadEmployees();
            }
            catch (SqlException ex)
            {
                // sql error, y3ni feh moshkela fel query aw constraints
                MessageBox.Show("DB Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // ay error tanya
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // deh 3ashan lama t3ml select 3ala row, el data ttzhar fel textboxes
        private void FillFieldsFromGrid()
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            var row = dataGridView.SelectedRows[0];
            txtEmployeeID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtRole.Text = row.Cells[2].Value.ToString();
            txtAge.Text = row.Cells[3].Value.ToString();
            txtSalary.Text = row.Cells[4].Value.ToString();
            dtEnroll.Value = DateTime.Parse(row.Cells[5].Value.ToString());
        }
    }
}
