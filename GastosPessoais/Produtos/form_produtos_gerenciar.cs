﻿using DevExpress.XtraEditors;
using GastosPessoais.Data_Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GastosPessoais.Produtos
{
    public partial class form_produtos_gerenciar : DevExpress.XtraEditors.XtraForm
    {
        private readonly Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public form_produtos_gerenciar()
        {
            InitializeComponent();
            CarregarCategorias();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region VALIDACOES

            if (!IsValidarDadosPreenchidosProdutos())
            {
                return; // Interrompe a execução se a validação falhar
            }

            #endregion

            try
            {
                if (txtProdutoName != null)
                {
                    if (XtraMessageBox.Show("Deseja adicionar este produto ? ", "Adicionar Produto",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = conexao.AbrirConexao())
                        {
                            SqlCommand cmd = new SqlCommand(
                                "insert into tb_produtos (prod_nome, prod_quantidade, prod_preco, prod_descricao, prod_fk_idcategoria) values (@nome, @quantidade, @preco, @descricao, @categoria)",
                                conn);
                            cmd.Parameters.AddWithValue("@nome", txtProdutoName.Text);
                            cmd.Parameters.AddWithValue("@quantidade", txtProdutoQuantidade.Text);
                            cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtProdutoPreco.Text.Replace("R$", "")));
                            cmd.Parameters.AddWithValue("@descricao", txtProdutoDescricao.Text);
                            cmd.Parameters.AddWithValue("@categoria", Convert.ToInt32(lookProdutoCategoria.EditValue));

                            cmd.ExecuteNonQuery();
                            conn.Close();
                            XtraMessageBox.Show("Produto adicionado com sucesso!");
                            LimparCampoProduto();
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

            if (!IsValidarDadosPreenchidosProdutos())
            {
                return;
            }

            #endregion

            try
            {
                if (txtProdutoName != null)
                {
                    if (XtraMessageBox.Show("Deseja atualizar este produto?", "Atualizar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                        using (SqlConnection conn = conexao.AbrirConexao())
                        {
                            SqlCommand cmd = new SqlCommand(
                                "UPDATE tb_produtos SET prod_nome = @nome, prod_quantidade = @quantidade, prod_preco = @preco, prod_descricao = @descricao, prod_fk_idcategoria = @categoria WHERE prod_id = @id",
                                conn);
                            cmd.Parameters.AddWithValue("@nome", txtProdutoName.Text);
                            cmd.Parameters.AddWithValue("@quantidade", txtProdutoQuantidade.Text);
                            cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtProdutoPreco.Text.Replace("R$", "")));
                            cmd.Parameters.AddWithValue("@descricao", txtProdutoDescricao.Text);
                            cmd.Parameters.AddWithValue("@categoria", Convert.ToInt32(lookProdutoCategoria.EditValue));
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(lblIdProdutos.Text));
                            cmd.ExecuteNonQuery();
                            XtraMessageBox.Show("Produto atualizado com sucesso!");
                            LimparCampoProduto();
                            this.Close();
                        }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao atualizar produto" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampoProduto();
        }

        private bool IsValidarDadosPreenchidosProdutos()
        {
            if (string.IsNullOrWhiteSpace(txtProdutoName.Text))
            {
                XtraMessageBox.Show("Preencha o campo Nome do Produto");
                txtProdutoName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProdutoQuantidade.Text))
            {
                XtraMessageBox.Show("Preencha o campo Quantidade");
                txtProdutoQuantidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProdutoPreco.Text))
            {
                XtraMessageBox.Show("Preencha o campo Preço");
                txtProdutoPreco.Focus();
                return false;
            }

            if (lookProdutoCategoria.EditValue == null)
            {
                XtraMessageBox.Show("Selecione uma Categoria");
                lookProdutoCategoria.Focus();
                return false;
            }

            return true;
        }

        private void LimparCampoProduto()
        {
            txtProdutoName.Clear();
            txtProdutoQuantidade.Clear();
            txtProdutoPreco.Clear();
            txtProdutoDescricao.Clear();
            lookProdutoCategoria.EditValue = null;
        }

        private void CarregarCategorias()
        {
            using (SqlConnection conn = conexao.AbrirConexao())
            {
                string query = "SELECT * FROM tb_categoria";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Configurando o LookUpEdit
                lookProdutoCategoria.Properties.DataSource = dt;
                lookProdutoCategoria.Properties.ValueMember = "cat_id";     // O valor real (ID da categoria)
                lookProdutoCategoria.Properties.DisplayMember = "cat_nome"; // O que será exibido no LookUpEdit
                lookProdutoCategoria.Properties.NullText = "Selecione uma categoria"; // Texto padrão

                ; // Recarrega com as configurações corretas

            }


        }

        private void lookProdutoCategoria_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProdutoPreco_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblIdProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}