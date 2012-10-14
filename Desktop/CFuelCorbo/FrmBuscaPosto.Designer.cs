namespace CFuelCorbo
{
    partial class FrmBuscaPosto
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
            this.SuspendLayout();
            // 
            // cbChave
            // 
            this.cbChave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChave.Items.AddRange(new object[] {
            "Nome",
            "Bairro"});
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            // 
            // FrmBuscaPosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(566, 349);
            this.Name = "FrmBuscaPosto";
            this.Text = "Consulta de Posto";
            this.Load += new System.EventHandler(this.frmPesquisaBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
