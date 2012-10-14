namespace sdMIRLA
{
    partial class FrmConsMaterial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbUnidade = new System.Windows.Forms.TextBox();
            this.txbValorUnit = new System.Windows.Forms.TextBox();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.Text = "Código do Produto:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.Text = "Unidade:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.Text = "Valor Unit.:";
            this.label4.ParentChanged += new System.EventHandler(this.label4_ParentChanged);
            // 
            // txbCodigo
            // 
            this.txbCodigo.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.txbCodigo.Location = new System.Drawing.Point(119, 17);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(107, 24);
            this.txbCodigo.TabIndex = 1;
            // 
            // txbDescricao
            // 
            this.txbDescricao.BackColor = System.Drawing.SystemColors.Info;
            this.txbDescricao.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.txbDescricao.Location = new System.Drawing.Point(70, 58);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.ReadOnly = true;
            this.txbDescricao.Size = new System.Drawing.Size(156, 24);
            this.txbDescricao.TabIndex = 2;
            // 
            // txbUnidade
            // 
            this.txbUnidade.BackColor = System.Drawing.SystemColors.Info;
            this.txbUnidade.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.txbUnidade.Location = new System.Drawing.Point(70, 98);
            this.txbUnidade.Name = "txbUnidade";
            this.txbUnidade.ReadOnly = true;
            this.txbUnidade.Size = new System.Drawing.Size(156, 24);
            this.txbUnidade.TabIndex = 3;
            // 
            // txbValorUnit
            // 
            this.txbValorUnit.BackColor = System.Drawing.SystemColors.Info;
            this.txbValorUnit.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.txbValorUnit.Location = new System.Drawing.Point(70, 143);
            this.txbValorUnit.Name = "txbValorUnit";
            this.txbValorUnit.ReadOnly = true;
            this.txbValorUnit.Size = new System.Drawing.Size(156, 24);
            this.txbValorUnit.TabIndex = 4;
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Consulta";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sair";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // FrmConsMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(131F, 131F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 266);
            this.Controls.Add(this.txbValorUnit);
            this.Controls.Add(this.txbUnidade);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "FrmConsMaterial";
            this.Text = "Consulta Material";
            this.Load += new System.EventHandler(this.FrmConsMaterial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbUnidade;
        private System.Windows.Forms.TextBox txbValorUnit;
    }
}