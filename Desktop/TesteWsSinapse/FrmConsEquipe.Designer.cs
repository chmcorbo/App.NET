namespace TesteWsSinapse
{
    partial class FrmConsEquipe
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
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEquipe = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbPerfil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(131, 29);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(87, 23);
            this.BtnConsultar.TabIndex = 0;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código da Equipe";
            // 
            // txbEquipe
            // 
            this.txbEquipe.Location = new System.Drawing.Point(25, 30);
            this.txbEquipe.Name = "txbEquipe";
            this.txbEquipe.Size = new System.Drawing.Size(100, 22);
            this.txbEquipe.TabIndex = 2;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(25, 92);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(241, 22);
            this.txbNome.TabIndex = 3;
            // 
            // txbPerfil
            // 
            this.txbPerfil.Location = new System.Drawing.Point(25, 145);
            this.txbPerfil.Name = "txbPerfil";
            this.txbPerfil.Size = new System.Drawing.Size(241, 22);
            this.txbPerfil.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Perfil";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(225, 29);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmConsEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 187);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.txbPerfil);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbEquipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConsultar);
            this.Name = "FrmConsEquipe";
            this.Text = "Consulta de Equipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEquipe;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFechar;
    }
}

