using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GastosPessoais.Usuarios
{
    public partial class form_usuarios_gerenciar : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-A7R1DL8\\SQLEXPRESS;Initial Catalog=gastos_pessoais;Persist Security Info=True;User ID=sa;Password=123leo;TrustServerCertificate=True");
        SqlCommand cmd = new SqlCommand();

        //Jeito 1
        public int idUsuario
        {
            get; set;
        }
        public form_usuarios_gerenciar()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            LimparCampoUsuario();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region VALIDACOES
            if (!IsValidarDadosPreenchidosUsuarios())
            {
                return; // Interrompe a execução se a validação falhar
            }
            #endregion

            try
            {
                if (txtUserReSenha.Text != txtUserSenha.Text)
                {
                    XtraMessageBox.Show("Senhas não conferem!");
                    txtUserReSenha.Focus();
                    return;
                }
                if (XtraMessageBox.Show("Deseja adicionar este usuário ? ", "Adicionar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    using (conexao)
                    {
                        cmd = new SqlCommand(
                            "insert into tb_usuarios (us_usuario, us_nomecompleto, us_senha, us_telefone) values (@usuario, @nomecompleto, @senha, @telefone)",
                            conexao);
                        cmd.Parameters.AddWithValue("@usuario", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@nomecompleto", txtUserNomeCompleto.Text);
                        cmd.Parameters.AddWithValue("@senha", txtUserSenha.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtUserTelefone.Text);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        XtraMessageBox.Show("Usuário cadastrado com sucesso!");
                        LimparCampoUsuario();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        public void LimparCampoUsuario()
        {
            txtUserName.Clear();
            txtUserNomeCompleto.Clear();
            txtUserSenha.Clear();
            txtUserTelefone.Clear();
            txtUserReSenha.Clear();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            #region VALIDACOES
            if (!IsValidarDadosPreenchidosUsuarios())
            {
                return; // Interrompe a execução se a validação falhar
            }

            #endregion

            try
            {
                if (txtUserReSenha.Text != txtUserSenha.Text)
                {
                    XtraMessageBox.Show("Senhas não conferem!");
                    txtUserReSenha.Focus();
                    return;
                }
                if (XtraMessageBox.Show("Deseja atualizar este usuário?", "Atualizar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (conexao)
                    {
                        cmd = new SqlCommand("update tb_usuarios set us_nomecompleto = @nomecompleto, us_senha = @senha, us_telefone = @telefone where us_id = @id", conexao);
                        //cmd.Parameters.AddWithValue("@id", idUsuario); //Jeito 1
                        cmd.Parameters.AddWithValue("@id", lblIdUsuario.Text); //Jeito 2
                        cmd.Parameters.AddWithValue("@nomecompleto", txtUserNomeCompleto.Text);
                        cmd.Parameters.AddWithValue("@senha", txtUserSenha.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtUserTelefone.Text);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        this.Close();
                    }
                    XtraMessageBox.Show("Usuário atualizado com sucesso!");

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao atualizar usuário: " + ex.Message);
            }
        }

        private void txtUserTelefone_Click(object sender, EventArgs e)
        {
            if (txtUserTelefone.EditValue == null)
            {
                txtUserTelefone.SelectionStart = 0;
            }
        }

        private bool IsValidarDadosPreenchidosUsuarios()
        {
            if (txtUserName.Text == "")
            {
                XtraMessageBox.Show("Campo Usuário é obrigatório!");
                txtUserName.Focus();
                return false;
            }
            if (txtUserNomeCompleto.Text == "")
            {
                XtraMessageBox.Show("Campo Nome Completo é obrigatório!");
                txtUserNomeCompleto.Focus();
                return false;
            }
            if (txtUserSenha.Text == "")
            {
                XtraMessageBox.Show("Campo Senha é obrigatório!");
                txtUserSenha.Focus();
                return false;
            }
            if (txtUserTelefone.Text == "")
            {
                XtraMessageBox.Show("Campo Telefone é obrigatório!");
                txtUserTelefone.Focus();
                return false;
            }
            return true;
        }

        private void form_clientes_gerenciar_Load(object sender, EventArgs e)
        {

        }
    }
}