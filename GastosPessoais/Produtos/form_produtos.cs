using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
using DevExpress.CodeParser;

namespace GastosPessoais.Produtos
{
    public partial class form_produtos : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-A7R1DL8\\SQLEXPRESS;Initial Catalog=gastos_pessoais;Persist Security Info=True;User ID=sa;Password=123leo;TrustServerCertificate=True");
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
                // Abre a conexão
                conexao.Open();
                cm = new SqlCommand("select * from tb_produtos", conexao);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridProdutos.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
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
            EditProduto.ShowDialog();

            CarregarProdutos();
        }

        private void btnDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idProdutoObject = viewProdutos.GetRowCellValue(viewProdutos.FocusedRowHandle, "prod_id");
            int idProduto = Convert.ToInt32(idProdutoObject);

            if (XtraMessageBox.Show("Deseja deletar este produto ? ","Deletar Produtos", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (conexao)
                    {
                        conexao.Open();
                        cm = new SqlCommand("delete from tb_produtos where prod_id = @id", conexao);
                        cm.Parameters.AddWithValue("@id", idProduto);
                        cm.ExecuteNonQuery();
                        
                    }
                    XtraMessageBox.Show("Produto deletado com sucesso");
                    CarregarProdutos();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao deletar o produto" + ex.Message);
                }
                
            }
        }
    }
}