namespace GastosPessoais.Clientes
{
    partial class form_clientes_gerenciar
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
            this.btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtClienteName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtClienteTelefone = new DevExpress.XtraEditors.TextEdit();
            this.lblIdCliente = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteTelefone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnLimpar.Appearance.Options.UseBackColor = true;
            this.btnLimpar.Location = new System.Drawing.Point(413, 155);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 41);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnAtualizar.Appearance.Options.UseBackColor = true;
            this.btnAtualizar.Location = new System.Drawing.Point(309, 155);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 41);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.Location = new System.Drawing.Point(205, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 41);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Cliente :";
            // 
            // txtClienteName
            // 
            this.txtClienteName.Location = new System.Drawing.Point(134, 35);
            this.txtClienteName.Name = "txtClienteName";
            this.txtClienteName.Size = new System.Drawing.Size(382, 28);
            this.txtClienteName.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Telefone :";
            // 
            // txtClienteTelefone
            // 
            this.txtClienteTelefone.Location = new System.Drawing.Point(134, 92);
            this.txtClienteTelefone.Name = "txtClienteTelefone";
            this.txtClienteTelefone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtClienteTelefone.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtClienteTelefone.Properties.MaskSettings.Set("mask", "(00) 00000-0000");
            this.txtClienteTelefone.Size = new System.Drawing.Size(382, 28);
            this.txtClienteTelefone.TabIndex = 16;
            this.txtClienteTelefone.Click += new System.EventHandler(this.txtClienteTelefone_Click);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.Location = new System.Drawing.Point(12, 220);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(66, 13);
            this.lblIdCliente.TabIndex = 18;
            this.lblIdCliente.Text = "Id do Cliente";
            this.lblIdCliente.Visible = false;
            // 
            // form_clientes_gerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 235);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtClienteTelefone);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtClienteName);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_clientes_gerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteTelefone.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnLimpar;
        public DevExpress.XtraEditors.SimpleButton btnAtualizar;
        public DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtClienteName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit txtClienteTelefone;
        public DevExpress.XtraEditors.LabelControl lblIdCliente;
    }
}