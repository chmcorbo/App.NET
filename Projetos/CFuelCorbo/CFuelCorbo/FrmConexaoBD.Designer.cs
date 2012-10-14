namespace CFuelCorbo
{
    partial class FrmConexaoBD
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
            this.BtnTesteConexao = new System.Windows.Forms.Button();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTesteConexao
            // 
            this.BtnTesteConexao.Location = new System.Drawing.Point(94, 99);
            this.BtnTesteConexao.Name = "BtnTesteConexao";
            this.BtnTesteConexao.Size = new System.Drawing.Size(100, 23);
            this.BtnTesteConexao.TabIndex = 3;
            this.BtnTesteConexao.Text = "Testar Conexão";
            this.BtnTesteConexao.UseVisualStyleBackColor = true;
            this.BtnTesteConexao.Click += new System.EventHandler(this.button1_Click);
            // 
            // mySqlConnection1
            // 
            this.mySqlConnection1.ConnectionString = "Server=localhost;Database=cfuelcorbo;Uid=root;Pwd=henrique;";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(94, 129);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(100, 23);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmConexaoBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnTesteConexao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConexaoBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmConexaoBD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTesteConexao;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Button BtnFechar;
    }
}