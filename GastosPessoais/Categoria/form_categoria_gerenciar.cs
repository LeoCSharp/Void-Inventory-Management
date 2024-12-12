using DevExpress.XtraEditors;
using GastosPessoais.Data_Base;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GastosPessoais.Categoria
{
    public partial class form_categoria_gerenciar : DevExpress.XtraEditors.XtraForm
    {
        private readonly Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public form_categoria_gerenciar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region VALIDACOES

            if (!IsValidarDadosPreenchidosCategoria())
            {
                return;
            }

            #endregion

            try
            {
                if (txtCategoriaName != null)
                {
                    if (XtraMessageBox.Show("Deseja adicionar esta categoria ? ", "Adicionar Categoria",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection conn = conexao.AbrirConexao();
                        {
                            SqlCommand cmd = new SqlCommand(
                                "insert into tb_categoria (cat_nome) values (@categoria)",
                                conn);
                            cmd.Parameters.AddWithValue("@categoria", txtCategoriaName.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            XtraMessageBox.Show("Categoria adicionada com sucesso!");
                            LimparCampoCategoria();
                            this.Close();
                        }
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
            #region VALIDACOES
            if (!IsValidarDadosPreenchidosCategoria())
            {
                return;
            }
            #endregion

            try
            {
                if (txtCategoriaName != null)
                {
                    if (XtraMessageBox.Show("Deseja atualizar esta categoria ? ", "Atualizar Categoria",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection conn = conexao.AbrirConexao();
                        {
                            SqlCommand cmd = new SqlCommand(
                                "update tb_categoria set cat_nome = @categoria where cat_id = @id",
                                conn);
                            cmd.Parameters.AddWithValue("@categoria", txtCategoriaName.Text);
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(lblIdCategoria.Text));
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            XtraMessageBox.Show("Categoria atualizada com sucesso!");
                            LimparCampoCategoria();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampoCategoria();
        }

        public bool IsValidarDadosPreenchidosCategoria()
        {
            if (txtCategoriaName.Text == "")
            {
                XtraMessageBox.Show("Campo Categoria é obrigatório!");
                txtCategoriaName.Focus();
                return false;
            }
            return true;
        }
        public void LimparCampoCategoria()
        {
            txtCategoriaName.Clear();
        }
    }
}