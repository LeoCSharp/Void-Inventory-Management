using DevExpress.XtraEditors;
using GastosPessoais.Data_Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GastosPessoais.Pedidos
{
    public partial class form_pedidos_gerenciar : DevExpress.XtraEditors.XtraForm
    {

        private readonly Conexao conexao = new Conexao();
        SqlCommand cm = new SqlCommand();
        public int QuantidadeOriginal
        {
            get; set;
        }
        public form_pedidos_gerenciar(bool _isUpdating = false)
        {
            InitializeComponent();
            CarregarClientes();
            CarregarProdutos();

            viewPedidoCliente.FocusedRowChanged += viewPedidoCliente_FocusedRowChanged;
            viewPedidoProduto.FocusedRowChanged += viewPedidoProduto_FocusedRowChanged;
            spinQuantidade.EditValueChanged += spinQuantidade_EditValueChanged;

            if (_isUpdating)
            {
                btnPedidoInserir.Enabled = false;
                btnPedidoAtualizar.Enabled = true;
                txtPedidoIDCliente.Enabled = false;
                txtPedidoIDProduto.Enabled = false;
                txtPedidoNomeCliente.Enabled = false;
                txtPedidoNomeProduto.Enabled = false;
                txtPedidoPreco.Enabled = false;
                txtPedidoTotal.Enabled = false;
            }
        }

        public void CarregarClientes()
        {
            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    cm = new SqlCommand("select cl_id, cl_nome from tb_clientes WHERE CONCAT(cl_id, cl_nome) LIKE @search", conn);
                    cm.Parameters.AddWithValue("@search", "%" + txtPesquisarCliente.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridPedidoCliente.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }

        public void CarregarProdutos()

        {
            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    cm = new SqlCommand(@"
                SELECT p.prod_id, p.prod_nome,p.prod_quantidade, p.prod_preco, p.prod_descricao, c.cat_nome 
                FROM tb_produtos p
                JOIN tb_categoria c ON p.prod_fk_idcategoria = c.cat_id
                WHERE CONCAT(p.prod_id, p.prod_nome,p.prod_quantidade, p.prod_preco, p.prod_descricao, c.cat_nome) LIKE @search", conn);
                    cm.Parameters.AddWithValue("@search", "%" + txtPesquisarProduto.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Vincula os dados ao GridView
                    gridPedidoProduto.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void txtPesquisarCliente_EditValueChanged(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void txtPesquisarProduto_EditValueChanged(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void spinQuantidade_EditValueChanged(object sender, EventArgs e)
        {
            int quantidade;
            decimal preco;

            #region VALIDAÇÂO

            if (string.IsNullOrWhiteSpace(txtPedidoPreco.Text))
            {
                MessageBox.Show("O campo de preço não pode estar vazio.");
                return;
            }

            if (!int.TryParse(spinQuantidade.Value.ToString(), out quantidade))
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um número válido.");
                return;
            }

            if (!decimal.TryParse(txtPedidoPreco.Text, out preco))
            {
                MessageBox.Show("Preço inválido. Por favor, insira um número válido.");
                return;
            }

            if (quantidade <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que zero.");
                spinQuantidade.Value = spinQuantidade.Value + 1;
                return;
            }

            if (preco <= 0)
            {
                MessageBox.Show("O preço deve ser maior que zero.");
                return;
            }

            int quantidadeEmEstoque = BuscarQuantidadeProduto(Convert.ToInt32(txtPedidoIDProduto.Text));
            if (quantidade > quantidadeEmEstoque + QuantidadeOriginal)
            {
                MessageBox.Show("Quantidade indisponível em estoque.");
                spinQuantidade.Value = QuantidadeOriginal;
                return;
            }
            #endregion

            // Calcular o total
            decimal total = quantidade * preco;
            txtPedidoTotal.Text = total.ToString("F2"); // Formatar como decimal com 2 casas decimais
        }

        //Metodo para conectar ao SQL, buscar o produto pela id que esta armazenado em txtPedidoIDProduto e retornar a quantidade dele
        private int BuscarQuantidadeProduto(int idProduto)
        {
            int quantidade = 0;
            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    cm = new SqlCommand("SELECT prod_quantidade FROM tb_produtos WHERE prod_id = @id", conn);
                    cm.Parameters.AddWithValue("@id", idProduto);
                    quantidade = Convert.ToInt32(cm.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao buscar quantidade do produto: " + ex.Message);
            }
            return quantidade;
        }

        private void viewPedidoProduto_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (viewPedidoProduto.GetFocusedRowCellValue("prod_id") != null)
            {
                txtPedidoIDProduto.Text = viewPedidoProduto.GetFocusedRowCellValue("prod_id").ToString();
                txtPedidoNomeProduto.Text = viewPedidoProduto.GetFocusedRowCellValue("prod_nome").ToString();
                txtPedidoPreco.Text = viewPedidoProduto.GetFocusedRowCellValue("prod_preco").ToString();
                spinQuantidade.Value = Convert.ToDecimal(viewPedidoProduto.GetFocusedRowCellValue("prod_quantidade").ToString());
                txtPedidoTotal.Text = viewPedidoProduto.GetFocusedRowCellValue("prod_preco").ToString();
            }
        }

        private void viewPedidoCliente_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (viewPedidoCliente.GetFocusedRowCellValue("cl_id") != null)
            {
                txtPedidoIDCliente.Text = viewPedidoCliente.GetFocusedRowCellValue("cl_id").ToString();
                txtPedidoNomeCliente.Text = viewPedidoCliente.GetFocusedRowCellValue("cl_nome").ToString();
            }
        }

        private void btnPedidoInserir_Click(object sender, EventArgs e)
        {
            #region VALIDAÇÂO
            if (!IsValidarDadosPreenchidosPedido())
            {
                return;
            }
            #endregion
            try
            {
                if (XtraMessageBox.Show("Deseja adicionar este produto ? ", "Adicionar Produto",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = conexao.AbrirConexao())
                    {
                        SqlCommand cmd = new SqlCommand(
                            @"INSERT INTO tb_pedidos (ped_data, prod_id, cl_id, ped_quantidade, ped_preco, ped_total) 
                             VALUES (@ped_data, @prod_id, @cl_id, @ped_quantidade, @ped_preco, @ped_total)", conn);

                        cmd.Parameters.AddWithValue("@ped_data", DateTime.Now);
                        cmd.Parameters.AddWithValue("@prod_id", txtPedidoIDProduto.Text);
                        cmd.Parameters.AddWithValue("@cl_id", txtPedidoIDCliente.Text);
                        cmd.Parameters.AddWithValue("@ped_quantidade", Convert.ToInt32(spinQuantidade.EditValue));
                        cmd.Parameters.AddWithValue("@ped_preco", Convert.ToDecimal(txtPedidoPreco.Text));
                        cmd.Parameters.AddWithValue("@ped_total", Convert.ToDecimal(txtPedidoTotal.Text));

                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand(
                            @"UPDATE tb_produtos SET prod_quantidade = prod_quantidade - @quantidade WHERE prod_id = @prod_id", conn);
                        cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(spinQuantidade.EditValue));
                        cmd.Parameters.AddWithValue("@prod_id", txtPedidoIDProduto.Text);

                        cmd.ExecuteNonQuery();
                        XtraMessageBox.Show("Pedido adicionado com sucesso!");
                        this.Close();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LimparCampoPedido()
        {
            btnPedidoInserir.Enabled = true;
            btnPedidoAtualizar.Enabled = false;
            txtPedidoIDProduto.Clear();
            txtPedidoNomeProduto.Clear();
            txtPedidoPreco.Clear();
            spinQuantidade.EditValue = null;
            txtPedidoTotal.Clear();
            txtPedidoNomeCliente.Clear();
            txtPedidoIDCliente.Clear();
            dataPedido.EditValue = DateTime.Now;
        }

        private bool IsValidarDadosPreenchidosPedido()
        {
            if (string.IsNullOrWhiteSpace(txtPedidoIDProduto.Text))
            {
                MessageBox.Show("Selecione um produto.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPedidoNomeCliente.Text))
            {
                MessageBox.Show("Selecione um cliente.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPedidoIDCliente.Text))
            {
                MessageBox.Show("Selecione um cliente.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPedidoPreco.Text))
            {
                MessageBox.Show("O campo de preço não pode estar vazio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPedidoTotal.Text))
            {
                MessageBox.Show("O campo do valor total não pode estar vazio.");
                return false;
            }
            return true;
        }
        private void btnPedidoLimpar_Click(object sender, EventArgs e)
        {
            LimparCampoPedido();
        }
        private void dataPedido_EditValueChanged(object sender, EventArgs e)
        {
            dataPedido.EditValue = DateTime.Now;
            dataPedido.ReadOnly = true;
            dataPedido.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;

        }

        private void btnPedidoAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Deseja atualizar este produto?", "Adicionar Produto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region VALIDAÇÂO
                    // Validações de entrada
                    if (!int.TryParse(txtPedidoIDProduto.Text, out int prodId))
                    {
                        XtraMessageBox.Show("ID do Produto inválido.");
                        return;
                    }

                    if (!int.TryParse(txtPedidoIDCliente.Text, out int clId))
                    {
                        XtraMessageBox.Show("ID do Cliente inválido.");
                        return;
                    }

                    if (!int.TryParse(spinQuantidade.EditValue.ToString(), out int quantidade))
                    {
                        XtraMessageBox.Show("Quantidade inválida.");
                        return;
                    }

                    if (!decimal.TryParse(txtPedidoPreco.Text, out decimal preco))
                    {
                        XtraMessageBox.Show("Preço inválido.");
                        return;
                    }

                    if (!decimal.TryParse(txtPedidoTotal.Text, out decimal total))
                    {
                        XtraMessageBox.Show("Total inválido.");
                        return;
                    }

                    if (!int.TryParse(lblIDPedido.Text, out int pedId))
                    {
                        XtraMessageBox.Show("ID do Pedido inválido.");
                        return;
                    }


                    #endregion

                    using (SqlConnection conn = conexao.AbrirConexao())
                    {
                        SqlCommand cmd = new SqlCommand(
                            @"UPDATE tb_pedidos SET ped_data = @ped_data, prod_id = @prod_id, cl_id = @cl_id, ped_quantidade = @ped_quantidade, ped_preco = @ped_preco, ped_total = @ped_total WHERE ped_id = @ped_id", conn);

                        cmd.Parameters.AddWithValue("@ped_data", DateTime.Now);
                        cmd.Parameters.AddWithValue("@prod_id", prodId);
                        cmd.Parameters.AddWithValue("@cl_id", clId);
                        cmd.Parameters.AddWithValue("@ped_quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@ped_preco", preco);
                        cmd.Parameters.AddWithValue("@ped_total", total);
                        cmd.Parameters.AddWithValue("@ped_id", lblIDPedido.Text);

                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand(
                            @"UPDATE tb_produtos SET prod_quantidade = prod_quantidade - @quantidade WHERE prod_id = @prod_id", conn);
                        cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(spinQuantidade.EditValue));
                        cmd.Parameters.AddWithValue("@prod_id", txtPedidoIDProduto.Text);

                        cmd.ExecuteNonQuery();
                        XtraMessageBox.Show("Pedido atualizado com sucesso!");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
    }


}
