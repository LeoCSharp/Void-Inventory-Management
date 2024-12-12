using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using GastosPessoais.Data_Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GastosPessoais.Clientes
{
    public partial class form_clientes : DevExpress.XtraEditors.XtraForm
    {
        private readonly Conexao conexao = new Conexao();
        SqlCommand cm = new SqlCommand();
        public form_clientes()
        {
            InitializeComponent();
            CarregarClientes();
        }
        public void CarregarClientes()
        {
            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    cm = new SqlCommand("select * from tb_clientes", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridClientes.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }

        private void btnClientesAdicionar_Click(object sender, EventArgs e)
        {
            form_clientes_gerenciar AddCliente = new form_clientes_gerenciar();
            AddCliente.btnSalvar.Enabled = true;
            AddCliente.btnAtualizar.Enabled = false;
            AddCliente.txtClienteName.Enabled = true;
            AddCliente.ShowDialog();
            CarregarClientes();
        }

        private void btnDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idClienteObject = viewClientes.GetRowCellValue(viewClientes.FocusedRowHandle, "cl_id");
            int idCliente = Convert.ToInt32(idClienteObject);

            if (XtraMessageBox.Show("Deseja deletar o cliente?", "Deletar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = conexao.AbrirConexao())
                    {
                        using (SqlCommand cm = new SqlCommand("DELETE FROM tb_clientes WHERE cl_id = @id", conn))
                        {
                            cm.Parameters.AddWithValue("@id", idCliente);
                            cm.ExecuteNonQuery();
                        }
                    }
                    XtraMessageBox.Show("Cliente deletado com sucesso!");
                    CarregarClientes();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao deletar Cliente: " + ex.Message);
                }
            }
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idClienteObject = viewClientes.GetRowCellValue(viewClientes.FocusedRowHandle, "cl_id");
            int idCliente = Convert.ToInt32(idClienteObject);

            form_clientes_gerenciar EditCliente = new form_clientes_gerenciar();
            EditCliente.btnSalvar.Enabled = false;
            EditCliente.btnAtualizar.Enabled = true;
            EditCliente.lblIdCliente.Text = idCliente.ToString();
            EditCliente.txtClienteName.Text = viewClientes.GetRowCellValue(viewClientes.FocusedRowHandle, "cl_nome").ToString();
            EditCliente.txtClienteTelefone.Text = viewClientes.GetRowCellValue(viewClientes.FocusedRowHandle, "cl_telefone").ToString();
            EditCliente.ShowDialog();

            CarregarClientes();
        }

        private void viewClientes_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupClientes.ShowPopup(gridClientes.PointToScreen(e.Point));
            }
        }
    }
}