namespace P2
{
    partial class ExibirLivro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxCapaExibir = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapaExibir)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCapaExibir
            // 
            this.pictureBoxCapaExibir.Location = new System.Drawing.Point(26, 8);
            this.pictureBoxCapaExibir.Name = "pictureBoxCapaExibir";
            this.pictureBoxCapaExibir.Size = new System.Drawing.Size(85, 118);
            this.pictureBoxCapaExibir.TabIndex = 0;
            this.pictureBoxCapaExibir.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Location = new System.Drawing.Point(9, 128);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(121, 48);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExibirLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pictureBoxCapaExibir);
            this.Name = "ExibirLivro";
            this.Size = new System.Drawing.Size(140, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapaExibir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCapaExibir;
        private System.Windows.Forms.Label lbl_titulo;
    }
}
