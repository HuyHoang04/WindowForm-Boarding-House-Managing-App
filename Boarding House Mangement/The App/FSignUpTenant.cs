using Class;
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

namespace FinalProject
{
    public partial class FSignUpTenant : Form
    {
        public FSignUpTenant()
        {
            InitializeComponent();
        }
        private void Reload()
        {
            ConnectionManager.Current.openConnection();
            string query = "SELECT * FROM Tenant_Contracts";
            SqlCommand command = new SqlCommand(query, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewTenantContract.DataSource = dataTable;

            ConnectionManager.Current.openConnection();
            string query1 = "SELECT * FROM Tenant_Bills";
            SqlCommand command1 = new SqlCommand(query1, ConnectionManager.Current.getConnection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            dataGridViewTenantBill.DataSource = dataTable1;
        }
        private void FSignUpTenant_Load(object sender, EventArgs e)
        {

            Reload();
        }
    }
}
