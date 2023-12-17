namespace P2
{
    partial class VizualizarLivro
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_tituloVL = new System.Windows.Forms.Label();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Nota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_tituloVL
            // 
            this.lbl_tituloVL.Location = new System.Drawing.Point(112, 8);
            this.lbl_tituloVL.Name = "lbl_tituloVL";
            this.lbl_tituloVL.Size = new System.Drawing.Size(246, 48);
            this.lbl_tituloVL.TabIndex = 1;
            this.lbl_tituloVL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.Location = new System.Drawing.Point(112, 73);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(246, 48);
            this.lbl_Autor.TabIndex = 2;
            this.lbl_Autor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Location = new System.Drawing.Point(366, 8);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(67, 113);
            this.lbl_Status.TabIndex = 3;
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Nota
            // 
            this.lbl_Nota.Location = new System.Drawing.Point(439, 8);
            this.lbl_Nota.Name = "lbl_Nota";
            this.lbl_Nota.Size = new System.Drawing.Size(67, 113);
            this.lbl_Nota.TabIndex = 4;
            this.lbl_Nota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VizualizarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lbl_Nota);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Autor);
            this.Controls.Add(this.lbl_tituloVL);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VizualizarLivro";
            this.Size = new System.Drawing.Size(520, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_tituloVL;
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Nota;
    }
}
