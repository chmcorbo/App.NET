namespace CAVE
{
    partial class FrmCadUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.MaskedTextBox();
            this.txbLogin = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.MaskedTextBox();
            this.txbSenha = new System.Windows.Forms.MaskedTextBox();
            this.txbConfirSenha = new System.Windows.Forms.MaskedTextBox();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.cbAtivo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perfil";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Location = new System.Drawing.Point(103, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 48);
            this.panel1.TabIndex = 4;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(169, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(88, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(7, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirma Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ativo";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(68, 36);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(29, 22);
            this.txbID.TabIndex = 0;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(68, 67);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(109, 22);
            this.txbLogin.TabIndex = 1;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(68, 104);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(335, 22);
            this.txbNome.TabIndex = 2;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(69, 185);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PromptChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(93, 22);
            this.txbSenha.TabIndex = 4;
            // 
            // txbConfirSenha
            // 
            this.txbConfirSenha.Location = new System.Drawing.Point(301, 190);
            this.txbConfirSenha.Name = "txbConfirSenha";
            this.txbConfirSenha.PromptChar = '*';
            this.txbConfirSenha.Size = new System.Drawing.Size(93, 22);
            this.txbConfirSenha.TabIndex = 5;
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(68, 146);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(197, 24);
            this.cbPerfil.TabIndex = 3;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoCompleteCustomSource.AddRange(new string[] {
            "Sim",
            "Não"});
            this.cbAtivo.FormattingEnabled = true;
            this.cbAtivo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbAtivo.Location = new System.Drawing.Point(68, 230);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(94, 24);
            this.cbAtivo.TabIndex = 6;
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 358);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.txbConfirSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCadUsuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmCadUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txbID;
        private System.Windows.Forms.MaskedTextBox txbLogin;
        private System.Windows.Forms.MaskedTextBox txbNome;
        private System.Windows.Forms.MaskedTextBox txbSenha;
        private System.Windows.Forms.MaskedTextBox txbConfirSenha;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.ComboBox cbAtivo;
    }
}