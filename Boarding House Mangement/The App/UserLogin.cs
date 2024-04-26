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
                formf.Show();
            }
            else
            {
                ConnectionManager.Current = new ConnectionManager(username, password);
                FormMenuLL form = new FormMenuLL();
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
