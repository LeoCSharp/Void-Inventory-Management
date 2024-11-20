using System;
using System.Windows.Forms;

namespace GastosPessoais
{
    public partial class form_login : DevExpress.XtraEditors.XtraForm
    {
        public form_login()
        {
            InitializeComponent();
            this.KeyDown += form_login_KeyDown;
        }
        private void form_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Close the form
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenha.Checked)
            {
                txtPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void lblLimpar_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }
    }
}