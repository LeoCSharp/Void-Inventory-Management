using System;
using System.Windows.Forms;
using GastosPessoais.Categoria;
using GastosPessoais.Clientes;
using GastosPessoais.Produtos;

namespace GastosPessoais
{
    public partial class form_principal : DevExpress.XtraEditors.XtraForm
    {
        public form_principal()
        {
            InitializeComponent();
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
    }
}