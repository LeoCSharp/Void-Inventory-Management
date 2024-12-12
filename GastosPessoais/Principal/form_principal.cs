using DevExpress.XtraEditors;
using GastosPessoais.Categoria;
using GastosPessoais.Clientes;
using GastosPessoais.Data_Base;
using GastosPessoais.Pedidos;
using GastosPessoais.Produtos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;

namespace GastosPessoais
{
    public partial class form_principal : DevExpress.XtraEditors.XtraForm
    {
        private readonly Conexao conexao = new Conexao();
        SqlCommand cm = new SqlCommand();
        public form_principal()
        {
            InitializeComponent();
            this.FormClosed += form_principal_FormClosed;
            CarregarGraficoPedidosSemanal();
            //CarregarGraficoPedidosMensal();

        }
        public void showChildForminPanel(object Form)               // Cria um método para mostrar os formulários filhos no painel principal do formulário principal 
        {
            if (this.pnlPrincipal.Controls.Count > 0)
            {
                this.pnlPrincipal.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_usuarios());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_clientes());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_categoria());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_produtos());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_pedidos());
        }
        private void form_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CarregarGraficoPedidosSemanal()
        {
            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    string query = @"
                WITH cte AS (
                  SELECT CONVERT(DATE, ped_data) as dia, COUNT(*) as count -- Seleciona a data(sem a hora) e a quantidade de pedidos
                  FROM tb_pedidos
                  WHERE ped_data BETWEEN  -- Filtra os pedidos da semana passada
                    DATEADD(week, DATEDIFF(week, 0, GETDATE())-1, 0)
                    AND
                    DATEADD(week, DATEDIFF(week, 0, GETDATE())-1, 6)
                  GROUP BY CONVERT(DATE, ped_data)  -- Agrupa por data sem a hora
                )
                SELECT DATENAME(WEEKDAY, dia) as day_of_week, count -- Pega o nome do dia da semana e a quantidade de pedidos
                FROM cte
                ORDER BY dia -- Ordena os dias da semana "; 

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    chartControlPedidos.DataSource = dt;

                    // Configura os eixos
                    chartControlPedidos.Series.Clear();
                    DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Dias Da Semana", DevExpress.XtraCharts.ViewType.Bar);
                    series.ArgumentDataMember = "day_of_week"; // Nome do dia
                    series.ValueDataMembers.AddRange(new string[] { "count" }); // Quantidade de pedidos

                    chartControlPedidos.Series.Add(series);
                    
                    // Adiciona título ao gráfico
                    chartControlPedidos.Titles.Clear();
                    chartControlPedidos.Titles.Add(new DevExpress.XtraCharts.ChartTitle
                    {
                        Text = "VENDAS"
                    });
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao carregar o gráfico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DESCOBRIR PORQUE DA ERRO NO day_of_week QUANDO IMPLEMENTADO !

        //private void CarregarGraficoPedidosMensal()
        //{
        //    using (SqlConnection conn = conexao.AbrirConexao())
        //    {
        //        string query = @"
        //        WITH cte AS (
        //          SELECT CONVERT(DATE, ped_data) as dia, COUNT(*) as count -- Seleciona a data(sem a hora) e a quantidade de pedidos
        //          FROM tb_pedidos
        //          WHERE ped_data BETWEEN  -- Filtra os pedidos do mês passado
        //            DATEADD(month, DATEDIFF(month, 0, GETDATE())-1, 0)
        //            AND
        //            DATEADD(month, DATEDIFF(month, 0, GETDATE())-1, 30)
        //          GROUP BY CONVERT(DATE, ped_data)  -- Agrupa por data sem a hora
        //        )
        //        SELECT DAY(dia) as day_of_month, count -- Pega o dia do mês e a quantidade de pedidos
        //        FROM cte
        //        ORDER BY dia -- Ordena os dias do mês";
        //        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        chartControlPedidos.DataSource = dt;
        //        // Configura os eixos
        //        chartControlPedidos.Series.Clear();
        //        DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Mês", DevExpress.XtraCharts.ViewType.Bar);
        //        series.ArgumentDataMember = "day_of_month"; // Dia do mês
        //        series.ValueDataMembers.AddRange(new string[] { "count" }); // Quantidade de pedidos
        //        chartControlPedidos.Series.Add(series);
        //        // Adiciona título ao gráfico
        //        chartControlPedidos.Titles.Clear();
        //        chartControlPedidos.Titles.Add(new DevExpress.XtraCharts.ChartTitle
        //        {
        //            Text = "VENDAS"
        //        });
        //    }
        //}
    }
}