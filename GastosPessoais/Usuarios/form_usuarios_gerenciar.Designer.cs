namespace GastosPessoais.Usuarios
{
    partial class form_usuarios_gerenciar
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
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtUserNomeCompleto = new DevExpress.XtraEditors.TextEdit();
            this.txtUserSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtUserTelefone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.lblIdUsuario = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserReSenha = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNomeCompleto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserReSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(135, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(382, 28);
            this.txtUserName.TabIndex = 0;
            // 
            // txtUserNomeCompleto
            // 
            this.txtUserNomeCompleto.Location = new System.Drawing.Point(135, 69);
            this.txtUserNomeCompleto.Name = "txtUserNomeCompleto";
            this.txtUserNomeCompleto.Size = new System.Drawing.Size(382, 28);
            this.txtUserNomeCompleto.TabIndex = 1;
            // 
            // txtUserSenha
            // 
            this.txtUserSenha.Location = new System.Drawing.Point(135, 119);
            this.txtUserSenha.Name = "txtUserSenha";
            this.txtUserSenha.Size = new System.Drawing.Size(382, 28);
            this.txtUserSenha.TabIndex = 2;
            // 
            // txtUserTelefone
            // 
            this.txtUserTelefone.Location = new System.Drawing.Point(135, 219);
            this.txtUserTelefone.Name = "txtUserTelefone";
            this.txtUserTelefone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtUserTelefone.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtUserTelefone.Properties.MaskSettings.Set("mask", "(00) 00000-0000");
            this.txtUserTelefone.Size = new System.Drawing.Size(382, 28);
            this.txtUserTelefone.TabIndex = 3;
            this.txtUserTelefone.Click += new System.EventHandler(this.txtUserTelefone_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Usuário :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Nome Completo :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Senha :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 227);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Telefone :";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.Location = new System.Drawing.Point(223, 280);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 41);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnAtualizar.Appearance.Options.UseBackColor = true;
            this.btnAtualizar.Location = new System.Drawing.Point(327, 280);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 41);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Location = new System.Drawing.Point(431, 280);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(87, 41);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "LIMPAR";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Location = new System.Drawing.Point(2, 307);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(70, 13);
            this.lblIdUsuario.TabIndex = 11;
            this.lblIdUsuario.Text = "Id do Usuario";
            this.lblIdUsuario.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 177);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Re-Digite a Senha";
            // 
            // txtUserReSenha
            // 
            this.txtUserReSenha.Location = new System.Drawing.Point(135, 169);
            this.txtUserReSenha.Name = "txtUserReSenha";
            this.txtUserReSenha.Size = new System.Drawing.Size(382, 28);
            this.txtUserReSenha.TabIndex = 12;
            // 
            // form_usuarios_gerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 350);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtUserReSenha);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUserTelefone);
            this.Controls.Add(this.txtUserSenha);
            this.Controls.Add(this.txtUserNomeCompleto);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_usuarios_gerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form_clientes_gerenciar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNomeCompleto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserReSenha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.SimpleButton btnSalvar;
        public DevExpress.XtraEditors.SimpleButton btnAtualizar;
        public DevExpress.XtraEditors.SimpleButton simpleButton3;
        public DevExpress.XtraEditors.TextEdit txtUserName;
        public DevExpress.XtraEditors.TextEdit txtUserNomeCompleto;
        public DevExpress.XtraEditors.TextEdit txtUserSenha;
        public DevExpress.XtraEditors.TextEdit txtUserTelefone;
        public DevExpress.XtraEditors.LabelControl lblIdUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit txtUserReSenha;
    }
}