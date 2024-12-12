namespace GastosPessoais.Produtos
{
    partial class form_produtos_gerenciar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.lblIdProdutos = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtProdutoName = new DevExpress.XtraEditors.TextEdit();
            this.btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtProdutoQuantidade = new DevExpress.XtraEditors.TextEdit();
            this.txtProdutoPreco = new DevExpress.XtraEditors.TextEdit();
            this.txtProdutoDescricao = new DevExpress.XtraEditors.TextEdit();
            this.lookProdutoCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.tbcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastos_pessoaisDataSet = new GastosPessoais.gastos_pessoaisDataSet();
            this.tb_categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.tb_categoriaTableAdapter = new GastosPessoais.gastos_pessoaisDataSetTableAdapters.tb_categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookProdutoCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastos_pessoaisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProdutos
            // 
            this.lblIdProdutos.Location = new System.Drawing.Point(12, 268);
            this.lblIdProdutos.Name = "lblIdProdutos";
            this.lblIdProdutos.Size = new System.Drawing.Size(72, 13);
            this.lblIdProdutos.TabIndex = 26;
            this.lblIdProdutos.Text = "Id do Produto";
            this.lblIdProdutos.Visible = false;
            this.lblIdProdutos.Click += new System.EventHandler(this.lblIdProdutos_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Nome do Produto :";
            // 
            // txtProdutoName
            // 
            this.txtProdutoName.Location = new System.Drawing.Point(135, 16);
            this.txtProdutoName.Name = "txtProdutoName";
            this.txtProdutoName.Size = new System.Drawing.Size(382, 28);
            this.txtProdutoName.TabIndex = 22;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnLimpar.Appearance.Options.UseBackColor = true;
            this.btnLimpar.Location = new System.Drawing.Point(452, 268);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 41);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnAtualizar.Appearance.Options.UseBackColor = true;
            this.btnAtualizar.Location = new System.Drawing.Point(348, 268);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 41);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.Location = new System.Drawing.Point(244, 268);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 41);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Quantidade :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 169);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Descrição :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Preço :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(31, 215);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Categoria :";
            // 
            // txtProdutoQuantidade
            // 
            this.txtProdutoQuantidade.Location = new System.Drawing.Point(135, 63);
            this.txtProdutoQuantidade.Name = "txtProdutoQuantidade";
            this.txtProdutoQuantidade.Size = new System.Drawing.Size(382, 28);
            this.txtProdutoQuantidade.TabIndex = 31;
            // 
            // txtProdutoPreco
            // 
            this.txtProdutoPreco.Location = new System.Drawing.Point(135, 112);
            this.txtProdutoPreco.Name = "txtProdutoPreco";
            this.txtProdutoPreco.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtProdutoPreco.Properties.MaskSettings.Set("mask", "c");
            this.txtProdutoPreco.Properties.MaskSettings.Set("culture", "pt-BR");
            this.txtProdutoPreco.Properties.UseMaskAsDisplayFormat = true;
            this.txtProdutoPreco.Size = new System.Drawing.Size(382, 28);
            this.txtProdutoPreco.TabIndex = 32;
            this.txtProdutoPreco.EditValueChanged += new System.EventHandler(this.txtProdutoPreco_EditValueChanged);
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.Location = new System.Drawing.Point(135, 162);
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(382, 28);
            this.txtProdutoDescricao.TabIndex = 33;
            // 
            // lookProdutoCategoria
            // 
            this.lookProdutoCategoria.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbcategoriaBindingSource, "cat_id", true));
            this.lookProdutoCategoria.Location = new System.Drawing.Point(135, 208);
            this.lookProdutoCategoria.Name = "lookProdutoCategoria";
            this.lookProdutoCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookProdutoCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat_nome", "Categorias")});
            this.lookProdutoCategoria.Size = new System.Drawing.Size(382, 28);
            this.lookProdutoCategoria.TabIndex = 36;
            this.lookProdutoCategoria.EditValueChanged += new System.EventHandler(this.lookProdutoCategoria_EditValueChanged);
            // 
            // tbcategoriaBindingSource
            // 
            this.tbcategoriaBindingSource.DataMember = "tb_categoria";
            this.tbcategoriaBindingSource.DataSource = this.gastos_pessoaisDataSet;
            // 
            // gastos_pessoaisDataSet
            // 
            this.gastos_pessoaisDataSet.DataSetName = "gastos_pessoaisDataSet";
            this.gastos_pessoaisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_categoriaBindingSource
            // 
            this.tb_categoriaBindingSource.DataMember = "tb_categoria";
            this.tb_categoriaBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "GastosPessoais.Properties.Settings.gastos_pessoaisConnectionString";
            msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer;
            msSqlConnectionParameters1.DatabaseName = "gastos_pessoais";
            msSqlConnectionParameters1.Encrypt = DevExpress.Utils.DefaultBoolean.True;
            msSqlConnectionParameters1.ServerName = "DESKTOP-A7R1DL8\\SQLEXPRESS";
            msSqlConnectionParameters1.TrustServerCertificate = DevExpress.Utils.DefaultBoolean.True;
            this.sqlDataSource1.ConnectionParameters = msSqlConnectionParameters1;
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "cat_id";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"103\" />";
            table1.Name = "tb_categoria";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "cat_nome";
            table2.Alias = "tb_categoria_1";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"103\" />";
            table2.Name = "tb_categoria";
            columnExpression2.Table = table2;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "tb_categoria";
            relationColumnInfo1.NestedKeyColumn = "cat_id";
            relationColumnInfo1.ParentKeyColumn = "cat_nome";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9InRiX2NhdGVnb3JpYSI+PEZpZ" +
    "WxkIE5hbWU9ImNhdF9pZCIgVHlwZT0iSW50MzIiIC8+PEZpZWxkIE5hbWU9ImNhdF9ub21lIiBUeXBlP" +
    "SJTdHJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // tb_categoriaTableAdapter
            // 
            this.tb_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // form_produtos_gerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 340);
            this.Controls.Add(this.lookProdutoCategoria);
            this.Controls.Add(this.txtProdutoDescricao);
            this.Controls.Add(this.txtProdutoPreco);
            this.Controls.Add(this.txtProdutoQuantidade);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblIdProdutos);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtProdutoName);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Name = "form_produtos_gerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookProdutoCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastos_pessoaisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lblIdProdutos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtProdutoName;
        public DevExpress.XtraEditors.SimpleButton btnLimpar;
        public DevExpress.XtraEditors.SimpleButton btnAtualizar;
        public DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit txtProdutoQuantidade;
        public DevExpress.XtraEditors.TextEdit txtProdutoPreco;
        public DevExpress.XtraEditors.TextEdit txtProdutoDescricao;
        private gastos_pessoaisDataSet gastos_pessoaisDataSet;
        private System.Windows.Forms.BindingSource tbcategoriaBindingSource;
        private gastos_pessoaisDataSetTableAdapters.tb_categoriaTableAdapter tb_categoriaTableAdapter;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource tb_categoriaBindingSource;
        public DevExpress.XtraEditors.LookUpEdit lookProdutoCategoria;
    }
}