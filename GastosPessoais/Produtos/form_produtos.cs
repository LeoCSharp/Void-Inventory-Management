using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using GastosPessoais.Data_Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GastosPessoais.Produtos
{
    public partial class form_produtos : DevExpress.XtraEditors.XtraForm
    {
        private readonly Conexao conexao = new Conexao();
        SqlCommand cm = new SqlCommand();
        public form_produtos()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        public void CarregarProdutos()

        {
            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    string query = @"
                    SELECT 
                    p.prod_id, 
                    p.prod_nome, 
                    p.prod_quantidade, 
                    p.prod_preco, 
                    p.prod_descricao, 
                    c.cat_nome 
                    FROM tb_produtos p
                    INNER JOIN tb_categoria c 
                    ON p.prod_fk_idcategoria = c.cat_id";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Vincula os dados ao GridView
                    gridProdutos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
            //try
            //{
            //    // Abre a conexão
            //    conexao.Open();
            //    cm = new SqlCommand("select * from tb_produtos inner join tb_categoria", conexao);
            //    SqlDataAdapter da = new SqlDataAdapter(cm);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    gridProdutos.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (conexao.State == ConnectionState.Open)
            //    {
            //        conexao.Close();
            //    }
            //}
        }

        private void btnProdutosAdicionar_Click(object sender, EventArgs e)
        {
            form_produtos_gerenciar formGerenciar = new form_produtos_gerenciar();
            formGerenciar.btnSalvar.Enabled = true;
            formGerenciar.btnAtualizar.Enabled = false;
            formGerenciar.ShowDialog();

            CarregarProdutos();

        }

        private void viewProdutos_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupProdutos.ShowPopup(gridProdutos.PointToScreen(e.Point));
            }
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idProdutoObject = viewProdutos.GetRowCellValue(viewProdutos.FocusedRowHandle, "prod_id");
            int idProduto = Convert.ToInt32(idProdutoObject);

            form_produtos_gerenciar EditProduto = new form_produtos_gerenciar();
            EditProduto.btnSalvar.Enabled = false;
            EditProduto.btnAtualizar.Enabled = true;
            EditProduto.lblIdProdutos.Text = idProduto.ToString();
            EditProduto.txtProdutoName.Text = viewProdutos.GetRowCellValue(viewProdutos.FocusedRowHandle, "prod_nome").ToString();
            EditProduto.txtProdutoQuantidade.Text = viewProdutos.GetRowCellValue(viewProdutos.FocusedRowHandle, "prod_quantidade").ToString();
            EditProduto.txtProdutoPreco.Text = viewProdutos.GetRowCellValue(viewProdutos.FocusedRowHandle, "prod_preco").ToString();
            EditProduto.txtProdutoDescricao.Text = viewProdutos.GetRowCellValue(viewProdutos.FocusedRowHandle, "prod_descricao").ToString();

            EditProduto.ShowDialog();

            CarregarProdutos();
        }

        private void btnDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idProdutoObject = viewProdutos.GetRowCellValue(viewProdutos.FocusedRowHandle, "prod_id");
            int idProduto = Convert.ToInt32(idProdutoObject);

            if (XtraMessageBox.Show("Deseja deletar este produto?", "Deletar Produtos", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = conexao.AbrirConexao())
                    {
                        SqlCommand cm = new SqlCommand("delete from tb_produtos where prod_id = @id", conn);
                        cm.Parameters.AddWithValue("@id", idProduto);
                        cm.ExecuteNonQuery();
                    }
                    XtraMessageBox.Show("Produto deletado com sucesso");
                    CarregarProdutos();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao deletar o produto: " + ex.Message);
                }
            }
        }
    }
}