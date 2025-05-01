using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class RentalsForm : Form
    {
        public RentalsForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=LAPTOP-JF8UCNBK\MSSQLSERVER01,57870;Initial Catalog=DatabaseProject;Integrated Security=True");
        
        private void status_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void rental_id_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}