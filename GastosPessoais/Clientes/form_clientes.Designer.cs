namespace GastosPessoais.Clientes
{
    partial class form_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_clientes));
            this.gridClientes = new DevExpress.XtraGrid.GridControl();
            this.viewClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnClientesAdicionar = new DevExpress.XtraEditors.SimpleButton();
            this.popupClientes = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeletar = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClientes.Location = new System.Drawing.Point(0, 0);
            this.gridClientes.MainView = this.viewClientes;
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(1276, 536);
            this.gridClientes.TabIndex = 1;
            this.gridClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewClientes});
            // 
            // viewClientes
            // 
            this.viewClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5});
            this.viewClientes.GridControl = this.gridClientes;
            this.viewClientes.Name = "viewClientes";
            this.viewClientes.OptionsBehavior.Editable = false;
            this.viewClientes.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.viewClientes_PopupMenuShowing);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "cl_id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cliente";
            this.gridColumn2.FieldName = "cl_nome";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Telefone";
            this.gridColumn5.FieldName = "cl_telefone";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnClientesAdicionar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 494);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1276, 42);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(306, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "GERENCIAR CLIENTES";
            // 
            // btnClientesAdicionar
            // 
            this.btnClientesAdicionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClientesAdicionar.ImageOptions.Image")));
            this.btnClientesAdicionar.Location = new System.Drawing.Point(1231, 0);
            this.btnClientesAdicionar.Name = "btnClientesAdicionar";
            this.btnClientesAdicionar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClientesAdicionar.Size = new System.Drawing.Size(40, 42);
            this.btnClientesAdicionar.TabIndex = 0;
            this.btnClientesAdicionar.Click += new System.EventHandler(this.btnClientesAdicionar_Click);
            // 
            // popupClientes
            // 
            this.popupClientes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeletar)});
            this.popupClientes.Manager = this.barManager1;
            this.popupClientes.Name = "popupClientes";
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Id = 0;
            this.btnEditar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditar.ImageOptions.SvgImage")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Caption = "Deletar";
            this.btnDeletar.Id = 1;
            this.btnDeletar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeletar.ImageOptions.SvgImage")));
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeletar_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnEditar,
            this.btnDeletar});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 536);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1276, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 536);
            // 
            // form_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 536);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_clientes";
            this.Text = "form_clientes";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView viewClientes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClientesAdicionar;
        private DevExpress.XtraBars.PopupMenu popupClientes;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnDeletar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}