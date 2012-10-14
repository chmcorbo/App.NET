namespace RifathCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCatalogar = new System.Windows.Forms.ToolStripButton();
            this.tsbLocalizarMusica = new System.Windows.Forms.ToolStripButton();
            this.tsbEstruturaMidia = new System.Windows.Forms.ToolStripButton();
            this.tsbSobre = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCatalogar,
            this.tsbLocalizarMusica,
            this.tsbEstruturaMidia,
            this.tsbSobre,
            this.tsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(919, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCatalogar
            // 
            this.tsbCatalogar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCatalogar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCatalogar.Image")));
            this.tsbCatalogar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCatalogar.Name = "tsbCatalogar";
            this.tsbCatalogar.Size = new System.Drawing.Size(62, 22);
            this.tsbCatalogar.Text = "Catalogar";
            this.tsbCatalogar.ToolTipText = "Catalogar as músicas a partir de uma mídia";
            // 
            // tsbLocalizarMusica
            // 
            this.tsbLocalizarMusica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLocalizarMusica.Image = ((System.Drawing.Image)(resources.GetObject("tsbLocalizarMusica.Image")));
            this.tsbLocalizarMusica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLocalizarMusica.Name = "tsbLocalizarMusica";
            this.tsbLocalizarMusica.Size = new System.Drawing.Size(103, 22);
            this.tsbLocalizarMusica.Text = "Localizar músicas";
            // 
            // tsbEstruturaMidia
            // 
            this.tsbEstruturaMidia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEstruturaMidia.Image = ((System.Drawing.Image)(resources.GetObject("tsbEstruturaMidia.Image")));
            this.tsbEstruturaMidia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEstruturaMidia.Name = "tsbEstruturaMidia";
            this.tsbEstruturaMidia.Size = new System.Drawing.Size(117, 22);
            this.tsbEstruturaMidia.Text = "Estrutura das mídias";
            this.tsbEstruturaMidia.ToolTipText = "Visualizar as estruturas das mídias gravadas";
            // 
            // tsbSobre
            // 
            this.tsbSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSobre.Image = ((System.Drawing.Image)(resources.GetObject("tsbSobre.Image")));
            this.tsbSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSobre.Name = "tsbSobre";
            this.tsbSobre.Size = new System.Drawing.Size(41, 22);
            this.tsbSobre.Text = "Sobre";
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(30, 22);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 496);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPrincipal";
            this.Text = "Rifath Music - Catalogador de Músicas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCatalogar;
        private System.Windows.Forms.ToolStripButton tsbLocalizarMusica;
        private System.Windows.Forms.ToolStripButton tsbEstruturaMidia;
        private System.Windows.Forms.ToolStripButton tsbSobre;
        private System.Windows.Forms.ToolStripButton tsbSair;

    }
}