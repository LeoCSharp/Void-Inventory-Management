﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using GastosPessoais.Data_Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GastosPessoais.Categoria
{
    public partial class form_categoria : DevExpress.XtraEditors.XtraForm
    {
        private readonly Conexao conexao = new Conexao();
        SqlCommand cm = new SqlCommand();
        public form_categoria()
        {
            InitializeComponent();
            CarregarCategoria();
        }
        public void CarregarCategoria()
        {
            try
            {
                SqlConnection conn = conexao.AbrirConexao();
                cm = new SqlCommand("select * from tb_categoria", conn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // Supondo que você tenha um GridView chamado gridViewCategoria
                gridCategoria.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }

        private void btnCategoriaAdicionar_Click(object sender, EventArgs e)
        {
            form_categoria_gerenciar AddCategoria = new form_categoria_gerenciar();
            AddCategoria.btnSalvar.Enabled = true;
            AddCategoria.btnAtualizar.Enabled = false;
            AddCategoria.txtCategoriaName.Enabled = true;
            AddCategoria.ShowDialog();
            CarregarCategoria();
        }

        private void viewCategoria_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupCategoria.ShowPopup(gridCategoria.PointToScreen(e.Point));
            }
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idCategoriaObject = viewCategoria.GetRowCellValue(viewCategoria.FocusedRowHandle, "cat_id");
            int idCategoria = Convert.ToInt32(idCategoriaObject);


            form_categoria_gerenciar EditCategoria = new form_categoria_gerenciar();
            EditCategoria.btnSalvar.Enabled = false;
            EditCategoria.btnAtualizar.Enabled = true;
            EditCategoria.lblIdCategoria.Text = idCategoria.ToString();
            EditCategoria.txtCategoriaName.Text = viewCategoria.GetRowCellValue(viewCategoria.FocusedRowHandle, "cat_nome").ToString();
            EditCategoria.txtCategoriaName.Enabled = true;
            EditCategoria.ShowDialog();

            CarregarCategoria();
        }

        private void btnDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var idCategoriaObject = viewCategoria.GetRowCellValue(viewCategoria.FocusedRowHandle, "cat_id");
            int idCategoria = Convert.ToInt32(idCategoriaObject);

            if (XtraMessageBox.Show("Deseja deletar a categoria?", "Deletar categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = conexao.AbrirConexao();
                    {
                        cm = new SqlCommand("DELETE FROM tb_categoria WHERE cat_id = @id", conn);
                        cm.Parameters.AddWithValue("@id", idCategoria);
                        cm.ExecuteNonQuery();

                    }
                    XtraMessageBox.Show("Categoria deletada com sucesso!");
                    CarregarCategoria();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao deletar Categoria: " + ex.Message);
                }
            }
        }
    }
}
