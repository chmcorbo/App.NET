namespace CFuelCorbo
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combustívelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abastecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estornoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaDeConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abastecimentosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivosDeConfiguraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexãoComBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.lançamentoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.testeToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combustívelToolStripMenuItem,
            this.postoToolStripMenuItem,
            this.veículoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // combustívelToolStripMenuItem
            // 
            this.combustívelToolStripMenuItem.Name = "combustívelToolStripMenuItem";
            this.combustívelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.combustívelToolStripMenuItem.Text = "Combustível";
            // 
            // postoToolStripMenuItem
            // 
            this.postoToolStripMenuItem.Name = "postoToolStripMenuItem";
            this.postoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.postoToolStripMenuItem.Text = "Posto";
            this.postoToolStripMenuItem.Click += new System.EventHandler(this.postoToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.veículoToolStripMenuItem.Text = "Veículo";
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
            // 
            // lançamentoToolStripMenuItem
            // 
            this.lançamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abastecimentoToolStripMenuItem,
            this.estornoToolStripMenuItem});
            this.lançamentoToolStripMenuItem.Name = "lançamentoToolStripMenuItem";
            this.lançamentoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.lançamentoToolStripMenuItem.Text = "Lançamento";
            // 
            // abastecimentoToolStripMenuItem
            // 
            this.abastecimentoToolStripMenuItem.Name = "abastecimentoToolStripMenuItem";
            this.abastecimentoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.abastecimentoToolStripMenuItem.Text = "Abastecimento";
            // 
            // estornoToolStripMenuItem
            // 
            this.estornoToolStripMenuItem.Name = "estornoToolStripMenuItem";
            this.estornoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.estornoToolStripMenuItem.Text = "Estorno";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaDeConsumoToolStripMenuItem,
            this.abastecimentosRealizadosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // mediaDeConsumoToolStripMenuItem
            // 
            this.mediaDeConsumoToolStripMenuItem.Name = "mediaDeConsumoToolStripMenuItem";
            this.mediaDeConsumoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.mediaDeConsumoToolStripMenuItem.Text = "Media de Consumo";
            // 
            // abastecimentosRealizadosToolStripMenuItem
            // 
            this.abastecimentosRealizadosToolStripMenuItem.Name = "abastecimentosRealizadosToolStripMenuItem";
            this.abastecimentosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.abastecimentosRealizadosToolStripMenuItem.Text = "Abastecimentos Realizados";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosDeConfiguraçãoToolStripMenuItem,
            this.conexãoComBDToolStripMenuItem});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.testeToolStripMenuItem.Text = "Teste";
            // 
            // arquivosDeConfiguraçãoToolStripMenuItem
            // 
            this.arquivosDeConfiguraçãoToolStripMenuItem.Name = "arquivosDeConfiguraçãoToolStripMenuItem";
            this.arquivosDeConfiguraçãoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.arquivosDeConfiguraçãoToolStripMenuItem.Text = "Arquivos de Configuração";
            this.arquivosDeConfiguraçãoToolStripMenuItem.Click += new System.EventHandler(this.arquivosDeConfiguraçãoToolStripMenuItem_Click);
            // 
            // conexãoComBDToolStripMenuItem
            // 
            this.conexãoComBDToolStripMenuItem.Name = "conexãoComBDToolStripMenuItem";
            this.conexãoComBDToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.conexãoComBDToolStripMenuItem.Text = "Conexão com BD";
            this.conexãoComBDToolStripMenuItem.Click += new System.EventHandler(this.conexãoComBDToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 293);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.Text = "CFuelCorbo - Controle de Abastecimento - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combustívelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abastecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estornoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaDeConsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abastecimentosRealizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivosDeConfiguraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexãoComBDToolStripMenuItem;

    }
}

