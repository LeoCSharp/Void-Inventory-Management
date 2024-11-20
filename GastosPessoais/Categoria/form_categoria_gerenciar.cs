using DevExpress.XtraEditors;
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

namespace GastosPessoais.Categoria
{
    public partial class form_categoria_gerenciar : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-A7R1DL8\\SQLEXPRESS;Initial Catalog=gastos_pessoais;Persist Security Info=True;User ID=sa;Password=123leo;TrustServerCertificate=True");
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
                        using (conexao)
                        {
                            SqlCommand cmd = new SqlCommand(
                                "insert into tb_categoria (cat_nome) values (@categoria)",
                                conexao);
                            cmd.Parameters.AddWithValue("@categoria", txtCategoriaName.Text);
                            conexao.Open();
                            cmd.ExecuteNonQuery();
                            conexao.Close();
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
                        using (conexao)
                        {
                            SqlCommand cmd = new SqlCommand(
                                "update tb_categoria set cat_nome = @categoria where cat_id = @id",
                                conexao);
                            cmd.Parameters.AddWithValue("@categoria", txtCategoriaName.Text);
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(lblIdCategoria.Text));
                            conexao.Open();
                            cmd.ExecuteNonQuery();
                            conexao.Close();
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