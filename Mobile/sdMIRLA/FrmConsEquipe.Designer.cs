namespace sdMIRLA
{
    partial class FrmConsEquipe
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
            this.miConsultar = new System.Windows.Forms.MenuItem();
            this.miSair = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEquipe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbPerfil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.miConsultar);
            this.mainMenu1.MenuItems.Add(this.miSair);
            // 
            // miConsultar
            // 
            this.miConsultar.Text = "Consultar";
            this.miConsultar.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // miSair
            // 
            this.miSair.Text = "Sair";
            this.miSair.Click += new System.EventHandler(this.miSair_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.Text = "Digite o RE:";
            // 
            // txbEquipe
            // 
            this.txbEquipe.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.txbEquipe.Location = new System.Drawing.Point(74, 20);
            this.txbEquipe.MaxLength = 10;
            this.txbEquipe.Name = "txbEquipe";
            this.txbEquipe.Size = new System.Drawing.Size(69, 24);
            this.txbEquipe.TabIndex = 1;
            this.txbEquipe.Text = "1234567890";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.Text = "Perfil:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.SystemColors.Info;
            this.txbNome.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.txbNome.Location = new System.Drawing.Point(55, 80);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(166, 24);
            this.txbNome.TabIndex = 4;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbPerfil
            // 
            this.txbPerfil.BackColor = System.Drawing.SystemColors.Info;
            this.txbPerfil.Font = new System.Drawing.Font("Segoe Condensed", 6F, System.Drawing.FontStyle.Regular);
            this.txbPerfil.Location = new System.Drawing.Point(55, 127);
            this.txbPerfil.Name = "txbPerfil";
            this.txbPerfil.Size = new System.Drawing.Size(166, 24);
            this.txbPerfil.TabIndex = 4;
            // 
            // FrmConsEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(131F, 131F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 266);
            this.Controls.Add(this.txbPerfil);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbEquipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "FrmConsEquipe";
            this.Text = "Consulta de Equipe";
            this.Load += new System.EventHandler(this.FrmConsEquipe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem miConsultar;
        private System.Windows.Forms.MenuItem miSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEquipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbPerfil;
    }
}