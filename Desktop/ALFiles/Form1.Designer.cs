namespace ALFiles
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbdAbrirPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.btnMontarLista = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.lvFileList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoMedia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lbCaminhoArquivoMidia = new System.Windows.Forms.Label();
            this.txtCaminhoArqMedia = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnLocalizarMusica = new System.Windows.Forms.Button();
            this.btnListarArtistas = new System.Windows.Forms.Button();
            this.btnListarAlbuns = new System.Windows.Forms.Button();
            this.btnListarMusicas = new System.Windows.Forms.Button();
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.btnAlterarConfig = new System.Windows.Forms.Button();
            this.btnCopiarArqFTP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbrir.Location = new System.Drawing.Point(679, 67);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(64, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCaminho.Location = new System.Drawing.Point(12, 68);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(661, 20);
            this.txtCaminho.TabIndex = 2;
            this.txtCaminho.TextChanged += new System.EventHandler(this.txtCaminho_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caminho";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fbdAbrirPasta
            // 
            this.fbdAbrirPasta.Description = "Abrir Pasta";
            this.fbdAbrirPasta.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbdAbrirPasta.SelectedPath = "C:\\Users\\henrique";
            this.fbdAbrirPasta.ShowNewFolderButton = false;
            // 
            // btnMontarLista
            // 
            this.btnMontarLista.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMontarLista.Location = new System.Drawing.Point(749, 68);
            this.btnMontarLista.Name = "btnMontarLista";
            this.btnMontarLista.Size = new System.Drawing.Size(75, 23);
            this.btnMontarLista.TabIndex = 4;
            this.btnMontarLista.Text = "Montar Lista";
            this.btnMontarLista.UseVisualStyleBackColor = true;
            this.btnMontarLista.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(749, 444);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 365);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(167, 97);
            this.treeView1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Montar treeview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvFileList
            // 
            this.lvFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvFileList.FullRowSelect = true;
            this.lvFileList.GridLines = true;
            this.lvFileList.Location = new System.Drawing.Point(12, 137);
            this.lvFileList.Name = "lvFileList";
            this.lvFileList.Size = new System.Drawing.Size(812, 193);
            this.lvFileList.TabIndex = 8;
            this.lvFileList.UseCompatibleStateImageBehavior = false;
            this.lvFileList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mídia";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Artista";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Album";
            this.columnHeader3.Width = 373;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Musica";
            this.columnHeader4.Width = 259;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descrição da mídia";
            // 
            // txtDescricaoMedia
            // 
            this.txtDescricaoMedia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoMedia.Location = new System.Drawing.Point(14, 111);
            this.txtDescricaoMedia.Name = "txtDescricaoMedia";
            this.txtDescricaoMedia.Size = new System.Drawing.Size(411, 20);
            this.txtDescricaoMedia.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Listar array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Limpar array";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(278, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Inclusão nova mídia";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(401, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Gravar mídia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(492, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Excluir mídia";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbCaminhoArquivoMidia
            // 
            this.lbCaminhoArquivoMidia.AutoSize = true;
            this.lbCaminhoArquivoMidia.Location = new System.Drawing.Point(11, 9);
            this.lbCaminhoArquivoMidia.Name = "lbCaminhoArquivoMidia";
            this.lbCaminhoArquivoMidia.Size = new System.Drawing.Size(150, 13);
            this.lbCaminhoArquivoMidia.TabIndex = 19;
            this.lbCaminhoArquivoMidia.Text = "Caminho do arquivo de mídias";
            // 
            // txtCaminhoArqMedia
            // 
            this.txtCaminhoArqMedia.Location = new System.Drawing.Point(13, 26);
            this.txtCaminhoArqMedia.Name = "txtCaminhoArqMedia";
            this.txtCaminhoArqMedia.ReadOnly = true;
            this.txtCaminhoArqMedia.Size = new System.Drawing.Size(811, 20);
            this.txtCaminhoArqMedia.TabIndex = 20;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(573, 336);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "xml";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(611, 336);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 23);
            this.button8.TabIndex = 23;
            this.button8.Text = "Localizar Obj";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(718, 336);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 23);
            this.button9.TabIndex = 24;
            this.button9.Text = "Localizar Música";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(197, 365);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 23);
            this.button10.TabIndex = 25;
            this.button10.Text = "Listar Medias";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnLocalizarMusica
            // 
            this.btnLocalizarMusica.Location = new System.Drawing.Point(641, 365);
            this.btnLocalizarMusica.Name = "btnLocalizarMusica";
            this.btnLocalizarMusica.Size = new System.Drawing.Size(106, 23);
            this.btnLocalizarMusica.TabIndex = 26;
            this.btnLocalizarMusica.Text = "Localizar Música";
            this.btnLocalizarMusica.UseVisualStyleBackColor = true;
            this.btnLocalizarMusica.Click += new System.EventHandler(this.btnLocalizarMusica_Click);
            // 
            // btnListarArtistas
            // 
            this.btnListarArtistas.Location = new System.Drawing.Point(308, 365);
            this.btnListarArtistas.Name = "btnListarArtistas";
            this.btnListarArtistas.Size = new System.Drawing.Size(105, 23);
            this.btnListarArtistas.TabIndex = 25;
            this.btnListarArtistas.Text = "Listar Artistas";
            this.btnListarArtistas.UseVisualStyleBackColor = true;
            this.btnListarArtistas.Click += new System.EventHandler(this.btnListarArtistas_Click);
            // 
            // btnListarAlbuns
            // 
            this.btnListarAlbuns.Location = new System.Drawing.Point(419, 365);
            this.btnListarAlbuns.Name = "btnListarAlbuns";
            this.btnListarAlbuns.Size = new System.Drawing.Size(105, 23);
            this.btnListarAlbuns.TabIndex = 25;
            this.btnListarAlbuns.Text = "Listar Albuns";
            this.btnListarAlbuns.UseVisualStyleBackColor = true;
            this.btnListarAlbuns.Click += new System.EventHandler(this.btnListarAlbuns_Click);
            // 
            // btnListarMusicas
            // 
            this.btnListarMusicas.Location = new System.Drawing.Point(530, 365);
            this.btnListarMusicas.Name = "btnListarMusicas";
            this.btnListarMusicas.Size = new System.Drawing.Size(105, 23);
            this.btnListarMusicas.TabIndex = 25;
            this.btnListarMusicas.Text = "Listar Músicas";
            this.btnListarMusicas.UseVisualStyleBackColor = true;
            this.btnListarMusicas.Click += new System.EventHandler(this.btnListarMusicas_Click);
            // 
            // cbLista
            // 
            this.cbLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Items.AddRange(new object[] {
            "Teste1",
            "Teste2"});
            this.cbLista.Location = new System.Drawing.Point(197, 404);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(327, 21);
            this.cbLista.TabIndex = 28;
            // 
            // btnAlterarConfig
            // 
            this.btnAlterarConfig.Location = new System.Drawing.Point(531, 401);
            this.btnAlterarConfig.Name = "btnAlterarConfig";
            this.btnAlterarConfig.Size = new System.Drawing.Size(142, 23);
            this.btnAlterarConfig.TabIndex = 29;
            this.btnAlterarConfig.Text = "Alterar configurações";
            this.btnAlterarConfig.UseVisualStyleBackColor = true;
            this.btnAlterarConfig.Click += new System.EventHandler(this.btnAlterarConfig_Click);
            // 
            // btnCopiarArqFTP
            // 
            this.btnCopiarArqFTP.Location = new System.Drawing.Point(678, 402);
            this.btnCopiarArqFTP.Name = "btnCopiarArqFTP";
            this.btnCopiarArqFTP.Size = new System.Drawing.Size(142, 23);
            this.btnCopiarArqFTP.TabIndex = 29;
            this.btnCopiarArqFTP.Text = "Copiar arquivo FTP";
            this.btnCopiarArqFTP.UseVisualStyleBackColor = true;
            this.btnCopiarArqFTP.Click += new System.EventHandler(this.btnCopiarArqFTP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "label3";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(836, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCopiarArqFTP);
            this.Controls.Add(this.btnAlterarConfig);
            this.Controls.Add(this.cbLista);
            this.Controls.Add(this.btnLocalizarMusica);
            this.Controls.Add(this.btnListarMusicas);
            this.Controls.Add(this.btnListarAlbuns);
            this.Controls.Add(this.btnListarArtistas);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtCaminhoArqMedia);
            this.Controls.Add(this.lbCaminhoArquivoMidia);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescricaoMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvFileList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMontarLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnAbrir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assembler list files";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMontarLista;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvFileList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricaoMedia;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog fbdAbrirPasta;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lbCaminhoArquivoMidia;
        private System.Windows.Forms.TextBox txtCaminhoArqMedia;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnLocalizarMusica;
        private System.Windows.Forms.Button btnListarArtistas;
        private System.Windows.Forms.Button btnListarAlbuns;
        private System.Windows.Forms.Button btnListarMusicas;
        private System.Windows.Forms.ComboBox cbLista;
        private System.Windows.Forms.Button btnAlterarConfig;
        private System.Windows.Forms.Button btnCopiarArqFTP;
        private System.Windows.Forms.Label label3;
    }
}

