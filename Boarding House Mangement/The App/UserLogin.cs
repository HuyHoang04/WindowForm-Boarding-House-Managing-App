using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class;
using FinalProject;

namespace The_App
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialButtonLogin_Click(object sender, EventArgs e)
        {
            string username = materialTextBoxUsername.Text;
            string password = materialTextBoxPassword.Text;
            ConnectionManager.Current = new ConnectionManager(username, password);

            if (materialRadioButtonTenant.Checked)
            {
                FSignUpTenant formf = new FSignUpTenant();
                string id = UserTNManager.GetUserId(username);
                DataTable table = TenantManager.FindTenantByID(id);
                formf.ID_Current.Text = "ID: " + table.Rows[0]["ID_t"].ToString();
                formf.NameCurrent.Text = "Name: "+ table.Rows[0]["Name"].ToString();
                formf.Show();
            }
            else
            {
                ConnectionManager.Current = new ConnectionManager(username, password);
                FormMenuLL form = new FormMenuLL();
                string id = UserLLManager.GetUserId(username);
                DataTable table = LandlordManager.FindLandlordByID(id);
                form.ID_Current.Text = "ID: " + table.Rows[0]["ID_l"].ToString();
                form.Name_Current.Text = "Name: " +table.Rows[0]["Name"].ToString();
                form.Show();
            }
        }

        private void materialRadioButtonLandlord_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButtonTenant.Checked)
            {
                materialRadioButtonLandlord.Checked = false;
            }
        }

        private void materialRadioButtonTenant_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButtonLandlord.Checked)
            {
                materialRadioButtonTenant.Checked = false;
            }


        }

        private void materialButtonCancel_Click(object sender, EventArgs e)
        {
            FormLogin.ActiveForm.Close();
        }

        private void materialExpansionPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
