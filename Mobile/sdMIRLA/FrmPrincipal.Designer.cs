namespace sdMIRLA
{
    partial class FrmPrincipal
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
            this.miConsultas = new System.Windows.Forms.MenuItem();
            this.miConsEquipe = new System.Windows.Forms.MenuItem();
            this.miConsMaterial = new System.Windows.Forms.MenuItem();
            this.miSair = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.miConsultas);
            this.mainMenu1.MenuItems.Add(this.miSair);
            // 
            // miConsultas
            // 
            this.miConsultas.MenuItems.Add(this.miConsEquipe);
            this.miConsultas.MenuItems.Add(this.miConsMaterial);
            this.miConsultas.Text = "Consultas";
            // 
            // miConsEquipe
            // 
            this.miConsEquipe.Text = "Equipe";
            this.miConsEquipe.Click += new System.EventHandler(this.miConsEquipe_Click);
            // 
            // miConsMaterial
            // 
            this.miConsMaterial.Text = "Material";
            this.miConsMaterial.Click += new System.EventHandler(this.miConsMaterial_Click);
            // 
            // miSair
            // 
            this.miSair.Text = "Sair";
            this.miSair.Click += new System.EventHandler(this.miSair_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.Text = "Sistema Aniel Mobile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Condensed", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 49);
            this.label2.Text = "Terminal de Consultas do Aniel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Condensed", 8F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(18, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.Text = "Selecione a opção desejada";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(131F, 131F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "FrmPrincipal";
            this.Text = "Controle de Assinantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem miConsultas;
        private System.Windows.Forms.MenuItem miConsEquipe;
        private System.Windows.Forms.MenuItem miConsMaterial;
        private System.Windows.Forms.MenuItem miSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

