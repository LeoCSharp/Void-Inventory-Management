using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GastosPessoais.Clientes
{
    public partial class form_clientes_gerenciar : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-A7R1DL8\\SQLEXPRESS;Initial Catalog=gastos_pessoais;Persist Security Info=True;User ID=sa;Password=123leo;TrustServerCertificate=True");
        SqlCommand cmd = new SqlCommand();

        public form_clientes_gerenciar()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampoCliente();
        }

        private void LimparCampoCliente()
        {
            txtClienteName.Clear();
            txtClienteTelefone.Clear();
            
        }

        private bool IsValidarDadosPreenchidosClientes()
        {
            if (txtClienteName.Text == "")
            {
                XtraMessageBox.Show("Campo Cliente é obrigatório!");
                txtClienteName.Focus();
                return false;
            }
            if (txtClienteTelefone.Text == "")
            {
                XtraMessageBox.Show("Campo Telefone é obrigatório!");
                txtClienteTelefone.Focus();
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region VALIDACOES
            if (!IsValidarDadosPreenchidosClientes())
            {
                return; // Interrompe a execução se a validação falhar
            }
            #endregion

            try
            {
                if (XtraMessageBox.Show("Deseja adicionar este cliente ? ", "Adicionar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    using (conexao)
                    {
                        cmd = new SqlCommand(
                            "insert into tb_clientes (cl_nome, cl_telefone) values (@cliente, @telefone)",
                            conexao);
                        cmd.Parameters.AddWithValue("@cliente", txtClienteName.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtClienteTelefone.Text);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        XtraMessageBox.Show("Cliente cadastrado com sucesso!");
                        LimparCampoCliente();
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Deseja atualizar este cliente?", "Atualizar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (conexao)
                    {
                        cmd = new SqlCommand("update tb_clientes set cl_nome = @nome, cl_telefone = @telefone where cl_id = @id", conexao);
                        //cmd.Parameters.AddWithValue("@id", idCliente); //Jeito 1
                        cmd.Parameters.AddWithValue("@id", lblIdCliente.Text); //Jeito 2
                        cmd.Parameters.AddWithValue("@nome", txtClienteName.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtClienteTelefone.Text);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        this.Close();
                    }
                    XtraMessageBox.Show("Cliente atualizado com sucesso!");

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
                // Aqui você pode adicionar código para registrar o erro em um log, se necessário.
            }
        }

        private void txtClienteTelefone_Click(object sender, EventArgs e)
        {
            if(txtClienteTelefone.EditValue == null)
            {
                txtClienteTelefone.SelectionStart = 0;
            }
        }
    }
}