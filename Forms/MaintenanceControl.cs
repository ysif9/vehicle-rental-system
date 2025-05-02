// dah el Maintenance form, law 3ayez tbd2 b el form dah awel ma el app yft7, ro7 3ala Program.cs w khally Application.Run(new MaintenanceControl());
// law 3ayez tft7 el EmployeeControl awel haga, bas 3adelha le Application.Run(new EmployeeControl());
// kol haga fel navigation mawgooda fel Program.cs, shof el comments hnak :)
//

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    public partial class MaintenanceControl : UserControl
    {
        // hena el controls beta3t el form, kol haga lelha textbox aw control
        // (fields are now in the designer)
        // el connection string, 3ashan n3raf nconnect el db
        
        SqlConnection connectionString = new SqlConnection(@"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True");
        public MaintenanceControl()
        {
            // hena bna3ml setup lel UI mn el designer
            InitializeComponent();
            // b3d keda bn-load el data
            WireUpEvents();
            LoadMaintenance();
        }

        // move event handler wiring here
        private void WireUpEvents()
        {
            btnInsert.Click += (s, e) => InsertMaintenance();
            btnUpdate.Click += (s, e) => UpdateMaintenance();
            btnDelete.Click += (s, e) => DeleteMaintenance();
            dataGridView.SelectionChanged += (s, e) => FillFieldsFromGrid();
        }

        // deh el function ely btshel el data mn el db w t7otha fel grid
        private void LoadMaintenance()
        {
            try
            {
                // awel 7aga bnms7 el rows el adema
                dataGridView.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString.ConnectionString))
                {
                    conn.Open();
                    // hena bnst3ml el procedure ely esmo GetAllMaintenance
                    using (SqlCommand cmd = new SqlCommand("GetAllMaintenance", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // kol row mn el db byzhar fel grid
                                dataGridView.Rows.Add(
                                    reader["Maintenance_Number"],
                                    reader["Service_Price"],
                                    reader["Company_Name"],
                                    Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd")
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // hena el error handling, law 7asal ay moshkela fel db aw el connection
                MessageBox.Show("Error loading maintenance records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // deh el insert, lama tedos 3ala el button, el data btdkhol el db
        private void InsertMaintenance()
        {
            // validation 2abl el insert
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) || string.IsNullOrWhiteSpace(txtServicePrice.Text))
            {
                // validation error, el user lazem y3ml kda
                MessageBox.Show("Please fill all fields except Maintenance Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check en el company name feha letters w spaces bas
            if (!Regex.IsMatch(txtCompanyName.Text, @"^[a-zA-Z ]+$"))
            {
                // validation error, el esm lazem ykon letters bas
                MessageBox.Show("Company Name must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtServicePrice.Text, out decimal price) || price < 0)
            {
                // validation error, el price lazem ykon rakam sah
                MessageBox.Show("Service Price must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertMaintenance", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // hena bnb3at el values mn el textboxes lel procedure
                        cmd.Parameters.AddWithValue("@Service_Price", price);
                        cmd.Parameters.AddWithValue("@Company_Name", txtCompanyName.Text);
                        cmd.Parameters.AddWithValue("@Date", dtDate.Value.Date);
                        cmd.ExecuteNonQuery();
                    }
                }
                // b3d ma n3ml insert, bn-refresh el grid
                LoadMaintenance();
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
        private void UpdateMaintenance()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                // validation error, lazem t3ml select
                MessageBox.Show("Select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) || string.IsNullOrWhiteSpace(txtServicePrice.Text))
            {
                // validation error, el user lazem y3ml kda
                MessageBox.Show("Please fill all fields except Maintenance Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check en el company name feha letters w spaces bas
            if (!Regex.IsMatch(txtCompanyName.Text, @"^[a-zA-Z ]+$"))
            {
                // validation error, el esm lazem ykon letters bas
                MessageBox.Show("Company Name must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtServicePrice.Text, out decimal price) || price < 0)
            {
                // validation error, el price lazem ykon rakam sah
                MessageBox.Show("Service Price must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateMaintenance", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Maintenance_Number", id);
                        cmd.Parameters.AddWithValue("@Service_Price", price);
                        cmd.Parameters.AddWithValue("@Company_Name", txtCompanyName.Text);
                        cmd.Parameters.AddWithValue("@Date", dtDate.Value.Date);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadMaintenance();
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
        private void DeleteMaintenance()
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
                using (SqlConnection conn = new SqlConnection(connectionString.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteMaintenance", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Maintenance_Number", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadMaintenance();
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
            txtMaintenanceNumber.Text = row.Cells[0].Value.ToString();
            txtServicePrice.Text = row.Cells[1].Value.ToString();
            txtCompanyName.Text = row.Cells[2].Value.ToString();
            dtDate.Value = DateTime.Parse(row.Cells[3].Value.ToString());
        }
    }
}
