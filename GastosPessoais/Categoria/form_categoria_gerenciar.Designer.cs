namespace GastosPessoais.Categoria
{
    partial class form_categoria_gerenciar
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
            this.lblIdCategoria = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCategoriaName = new DevExpress.XtraEditors.TextEdit();
            this.btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoriaName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.Location = new System.Drawing.Point(29, 99);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(79, 13);
            this.lblIdCategoria.TabIndex = 24;
            this.lblIdCategoria.Text = "Id da Categoria";
            this.lblIdCategoria.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Nome da Categoria :";
            // 
            // txtCategoriaName
            // 
            this.txtCategoriaName.Location = new System.Drawing.Point(143, 12);
            this.txtCategoriaName.Name = "txtCategoriaName";
            this.txtCategoriaName.Size = new System.Drawing.Size(407, 28);
            this.txtCategoriaName.TabIndex = 22;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnLimpar.Appearance.Options.UseBackColor = true;
            this.btnLimpar.Location = new System.Drawing.Point(472, 73);
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
            this.btnAtualizar.Location = new System.Drawing.Point(368, 73);
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
            this.btnSalvar.Location = new System.Drawing.Point(264, 73);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 41);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // form_categoria_gerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 140);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCategoriaName);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Name = "form_categoria_gerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoriaName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lblIdCategoria;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtCategoriaName;
        public DevExpress.XtraEditors.SimpleButton btnLimpar;
        public DevExpress.XtraEditors.SimpleButton btnAtualizar;
        public DevExpress.XtraEditors.SimpleButton btnSalvar;
    }
}