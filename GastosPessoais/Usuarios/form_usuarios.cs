using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GastosPessoais.Usuarios;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GastosPessoais
{
    public partial class form_usuarios : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-A7R1DL8\\SQLEXPRESS;Initial Catalog=gastos_pessoais;Persist Security Info=True;User ID=sa;Password=123leo;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();

        public form_usuarios()
        {
            InitializeComponent();
            CarregarUsuario();
        }
        public void CarregarUsuario()
        {
            try
            {
                // Abre a conexão
                conexao.Open();
                cm = new SqlCommand("select * from tb_usuarios", conexao);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Supondo que você tenha um GridView chamado gridViewUsuarios
                gridUsuarios.DataSource = dt;
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

        private void btnUsuarioAdicionar_Click(object sender, EventArgs e)
        {
            form_usuarios_gerenciar AddUsuario = new form_usuarios_gerenciar();
            AddUsuario.btnSalvar.Enabled = true;
            AddUsuario.btnAtualizar.Enabled = false;
            AddUsuario.txtUserName.Enabled = true;
            AddUsuario.ShowDialog();
            CarregarUsuario();
        }

        void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idUsuarioObject = viewUsuarios.GetRowCellValue(viewUsuarios.FocusedRowHandle, "us_id");
            int idUsuario = Convert.ToInt32(idUsuarioObject);

            form_usuarios_gerenciar EditUsuario = new form_usuarios_gerenciar();
            EditUsuario.btnSalvar.Enabled = false;
            EditUsuario.btnAtualizar.Enabled = true;
            EditUsuario.lblIdUsuario.Text = idUsuario.ToString();
            EditUsuario.txtUserName.Text = viewUsuarios.GetRowCellValue(viewUsuarios.FocusedRowHandle, "us_usuario").ToString();
            EditUsuario.txtUserNomeCompleto.Text = viewUsuarios.GetRowCellValue(viewUsuarios.FocusedRowHandle, "us_nomecompleto").ToString();
            EditUsuario.txtUserSenha.Text = viewUsuarios.GetRowCellValue(viewUsuarios.FocusedRowHandle, "us_senha").ToString();
            EditUsuario.txtUserTelefone.Text = viewUsuarios.GetRowCellValue(viewUsuarios.FocusedRowHandle, "us_telefone").ToString();
            EditUsuario.txtUserName.Enabled = false;
            
            EditUsuario.ShowDialog();

            CarregarUsuario();
        }

        private void viewUsuarios_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupUsuarios.ShowPopup(gridUsuarios.PointToScreen(e.Point));
            }
        }

        private void btnDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idUsuarioObject = viewUsuarios.GetRowCellValue(viewUsuarios.FocusedRowHandle, "us_id");
            int idUsuario = Convert.ToInt32(idUsuarioObject);

            if (XtraMessageBox.Show("Deseja deletar o usuário?", "Deletar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-A7R1DL8\\SQLEXPRESS;Initial Catalog=gastos_pessoais;Persist Security Info=True;User ID=sa ;Password=123leo;TrustServerCertificate=True"))
                    {
                        conexao.Open();
                        using (SqlCommand cm = new SqlCommand("DELETE FROM tb_usuarios WHERE us_id = @id", conexao))
                        {
                            cm.Parameters.AddWithValue("@id", idUsuario);
                            cm.ExecuteNonQuery();
                        }
                    }
                    XtraMessageBox.Show("Usuário deletado com sucesso!");
                    CarregarUsuario();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao deletar usuário: " + ex.Message);
                }
            }
        }

    }
}