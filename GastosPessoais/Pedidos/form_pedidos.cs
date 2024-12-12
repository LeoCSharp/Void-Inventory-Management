using DevExpress.XtraEditors;
using GastosPessoais.Data_Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GastosPessoais.Pedidos
{
    public partial class form_pedidos : XtraForm
    {
        private readonly Conexao conexao = new Conexao();
        private SqlCommand cm = new SqlCommand();

        public form_pedidos()
        {
            InitializeComponent();
            CarregarPedidos();
        }

        public void CarregarPedidos()
        {
            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    string query = @"
                        SELECT p.*, pr.prod_nome, c.cl_nome 
                        FROM tb_pedidos p 
                        INNER JOIN tb_produtos pr ON p.prod_id = pr.prod_id 
                        INNER JOIN tb_clientes c ON p.cl_id = c.cl_id";

                    cm = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gridPedidos.DataSource = dt;
                }

                AtualizarTotalPedidos();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao carregar pedidos: " + ex.Message);
            }
        }

        private void btnPedidosAdicionar_Click(object sender, EventArgs e)
        {
            var addPedido = new form_pedidos_gerenciar
            {
                btnPedidoAtualizar = { Enabled = false },
                btnPedidoInserir = { Enabled = true }
            };
            addPedido.ShowDialog();
            CarregarPedidos();
        }

        private void viewPedidos_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                e.Allow = false;
                popupPedidos.ShowPopup(gridPedidos.PointToScreen(e.Point));
            }
        }

        private void Atualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editPedido = MontarFormaPedidosGerenciar();
            editPedido.ShowDialog();
            CarregarPedidos();
        }

        private form_pedidos_gerenciar MontarFormaPedidosGerenciar()
        {
            var idPedido = Convert.ToInt32(viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "ped_id"));

            var editPedido = new form_pedidos_gerenciar(true);

            editPedido.lblIDPedido.Text = idPedido.ToString();
            editPedido.txtPedidoIDProduto.Text = viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "prod_id").ToString();
            editPedido.txtPedidoIDCliente.Text = viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "cl_id").ToString();
            editPedido.txtPedidoNomeCliente.Text = viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "cl_nome").ToString();
            editPedido.txtPedidoNomeProduto.Text = viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "prod_nome").ToString();
            editPedido.spinQuantidade.Value = Convert.ToDecimal(viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "ped_quantidade"));
            editPedido.txtPedidoPreco.Text = viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "ped_preco").ToString();
            editPedido.txtPedidoTotal.Text = viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "ped_total").ToString();
            editPedido.QuantidadeOriginal = Convert.ToInt32(viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "ped_quantidade"));
            editPedido.gridPedidoProduto.Enabled = false;
            editPedido.gridPedidoCliente.Enabled = false;
            
            return editPedido;
        }

        private void Excluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idPedido = Convert.ToInt32(viewPedidos.GetRowCellValue(viewPedidos.FocusedRowHandle, "ped_id"));

            if (XtraMessageBox.Show("Deseja realmente excluir este pedido?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = conexao.AbrirConexao())
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            var (produtoId, quantidadePedido) = ObterDadosPedido(conn, transaction, idPedido);

                            AtualizarQuantidadeProduto(conn, transaction, produtoId, quantidadePedido);
                            DeletarPedido(conn, transaction, idPedido);

                            transaction.Commit();
                            XtraMessageBox.Show("Pedido excluído e estoque restaurado com sucesso!");
                            CarregarPedidos();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao excluir pedido: " + ex.Message);
                }
            }
        }

        private (int produtoId, int quantidadePedido) ObterDadosPedido(SqlConnection conn, SqlTransaction transaction, int idPedido)
        {
            string query = @"SELECT prod_id, ped_quantidade FROM tb_pedidos WHERE ped_id = @id";
            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@id", idPedido);
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        throw new Exception("Pedido não encontrado.");

                    return (reader.GetInt32(0), reader.GetInt32(1));
                }
            }
        }

        private void AtualizarQuantidadeProduto(SqlConnection conn, SqlTransaction transaction, int produtoId, int quantidadePedido)
        {
            string query = @"UPDATE tb_produtos SET prod_quantidade = prod_quantidade + @quantidade WHERE prod_id = @produtoId";
            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@quantidade", quantidadePedido);
                cmd.Parameters.AddWithValue("@produtoId", produtoId);
                cmd.ExecuteNonQuery();
            }
        }

        private void DeletarPedido(SqlConnection conn, SqlTransaction transaction, int pedidoId)
        {
            string query = @"DELETE FROM tb_pedidos WHERE ped_id = @id";
            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@id", pedidoId);
                cmd.ExecuteNonQuery();
            }
        }

        private decimal CalcularTotalPedidos()
        {
            decimal total = 0;

            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    string query = "SELECT SUM(ped_total) FROM tb_pedidos";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            total = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao calcular o total dos pedidos: " + ex.Message);
            }

            return total;
        }

        private void AtualizarTotalPedidos()
        {
            decimal total = CalcularTotalPedidos();
            lblPedidoTotal.Text = total.ToString("C"); // Formata como moeda
        }
    }
}
