namespace CFuelCorboMobile
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.miVeiculos = new System.Windows.Forms.MenuItem();
            this.miPostos = new System.Windows.Forms.MenuItem();
            this.miAbastecimentos = new System.Windows.Forms.MenuItem();
            this.miSair = new System.Windows.Forms.MenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.miSair);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.Text = "Selecione uma opção";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.miVeiculos);
            this.menuItem1.MenuItems.Add(this.miPostos);
            this.menuItem1.MenuItems.Add(this.miAbastecimentos);
            this.menuItem1.Text = "Opções";
            // 
            // miVeiculos
            // 
            this.miVeiculos.Text = "Veículos";
            // 
            // miPostos
            // 
            this.miPostos.Text = "Postos";
            // 
            // miAbastecimentos
            // 
            this.miAbastecimentos.Text = "Abastecimentos";
            // 
            // miSair
            // 
            this.miSair.Text = "Sair";
            this.miSair.Click += new System.EventHandler(this.miSair_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Menu Principal";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "FrmMenu";
            this.Text = "CFuelCorbo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem miVeiculos;
        private System.Windows.Forms.MenuItem miPostos;
        private System.Windows.Forms.MenuItem miAbastecimentos;
        private System.Windows.Forms.MenuItem miSair;
        private System.Windows.Forms.Label label2;
    }
}