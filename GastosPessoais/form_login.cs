using GastosPessoais.Data_Base;
using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using GastosPessoais.Properties;
using System.Drawing;

namespace GastosPessoais
{
    public partial class form_login : DevExpress.XtraEditors.XtraForm
    {
        private readonly Conexao conexao = new Conexao();
        private SqlCommand cm = new SqlCommand();
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
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM tb_usuarios WHERE us_usuario = @us_usuario AND us_senha = @us_senha";
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@us_usuario", txtUsername.Text);
                    cm.Parameters.AddWithValue("@us_senha", txtPassword.Text);
                    SqlDataReader dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        this.Hide();
                        var form = new form_principal();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos");
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
            }
        }
    }
}