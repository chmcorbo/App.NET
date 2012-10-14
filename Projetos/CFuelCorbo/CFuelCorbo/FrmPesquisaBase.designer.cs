namespace FormsBase.Consultas
{
    partial class FrmBuscaBase
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lstPesquisa = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.cbChave = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o texto a ser persquisado e aperte ENTER";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(148, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(325, 20);
            this.txtPesquisa.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(479, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(398, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(479, 301);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lstPesquisa
            // 
            this.lstPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPesquisa.FullRowSelect = true;
            this.lstPesquisa.GridLines = true;
            this.lstPesquisa.Location = new System.Drawing.Point(12, 50);
            this.lstPesquisa.MultiSelect = false;
            this.lstPesquisa.Name = "lstPesquisa";
            this.lstPesquisa.Size = new System.Drawing.Size(542, 245);
            this.lstPesquisa.TabIndex = 7;
            this.lstPesquisa.UseCompatibleStateImageBehavior = false;
            this.lstPesquisa.View = System.Windows.Forms.View.Details;
            this.lstPesquisa.SelectedIndexChanged += new System.EventHandler(this.lstPesquisa_SelectedIndexChanged);
            this.lstPesquisa.DoubleClick += new System.EventHandler(this.lstPesquisa_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Coluna1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Coluna2";
            this.columnHeader2.Width = 455;
            // 
            // cbChave
            // 
            this.cbChave.FormattingEnabled = true;
            this.cbChave.Location = new System.Drawing.Point(12, 23);
            this.cbChave.Name = "cbChave";
            this.cbChave.Size = new System.Drawing.Size(121, 21);
            this.cbChave.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chave de Busca";
            // 
            // FrmBuscaBase
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChave);
            this.Controls.Add(this.lstPesquisa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscaBase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPesquisaBase";
            this.Load += new System.EventHandler(this.frmPesquisaBase_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel lblMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ComboBox cbChave;
        protected System.Windows.Forms.ListView lstPesquisa;
        protected System.Windows.Forms.ColumnHeader columnHeader1;
        protected System.Windows.Forms.ColumnHeader columnHeader2;
        protected System.Windows.Forms.StatusStrip statusStrip1;
        protected System.Windows.Forms.Button btnPesquisar;
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Button btnFechar;
        protected System.Windows.Forms.TextBox txtPesquisa;
    }
}