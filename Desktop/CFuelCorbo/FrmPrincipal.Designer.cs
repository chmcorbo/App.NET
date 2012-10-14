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
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.lançamentoToolStripMenuItem,
            this.consultasToolStripMenuItem,
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
            this.combustívelToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.combustívelToolStripMenuItem.Text = "Combustível";
            // 
            // postoToolStripMenuItem
            // 
            this.postoToolStripMenuItem.Name = "postoToolStripMenuItem";
            this.postoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.postoToolStripMenuItem.Text = "Posto";
            this.postoToolStripMenuItem.Click += new System.EventHandler(this.postoToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
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
            // mySqlConnection1
            // 
            this.mySqlConnection1.ConnectionString = "Server=localhost;Database=cfuelcorbo;Uid=root;Pwd=henrique;";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}

