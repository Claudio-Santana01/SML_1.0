namespace P2
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbox_capas = new System.Windows.Forms.PictureBox();
            this.lnkl_direita = new System.Windows.Forms.LinkLabel();
            this.lnkl_esquerda = new System.Windows.Forms.LinkLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.adicionarLeituraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarLeiturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusFavoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLivros = new System.Windows.Forms.Panel();
            this.exibirLivro1 = new P2.ExibirLivro();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cbx_statusPrincipal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_capas)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.panelLivros.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbox_capas);
            this.splitContainer1.Panel1.Controls.Add(this.lnkl_direita);
            this.splitContainer1.Panel1.Controls.Add(this.lnkl_esquerda);
            this.splitContainer1.Panel1.Controls.Add(this.menuPrincipal);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelLivros);
            this.splitContainer1.Panel2.Controls.Add(this.cbx_statusPrincipal);
            this.splitContainer1.Size = new System.Drawing.Size(584, 561);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // pbox_capas
            // 
            this.pbox_capas.Location = new System.Drawing.Point(213, 53);
            this.pbox_capas.Name = "pbox_capas";
            this.pbox_capas.Size = new System.Drawing.Size(163, 215);
            this.pbox_capas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_capas.TabIndex = 7;
            this.pbox_capas.TabStop = false;
            // 
            // lnkl_direita
            // 
            this.lnkl_direita.AutoSize = true;
            this.lnkl_direita.Font = new System.Drawing.Font("Century Schoolbook", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkl_direita.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkl_direita.LinkColor = System.Drawing.Color.Black;
            this.lnkl_direita.Location = new System.Drawing.Point(455, 124);
            this.lnkl_direita.Name = "lnkl_direita";
            this.lnkl_direita.Size = new System.Drawing.Size(72, 77);
            this.lnkl_direita.TabIndex = 6;
            this.lnkl_direita.TabStop = true;
            this.lnkl_direita.Text = ">";
            this.lnkl_direita.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkl_direita.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkl_direita_LinkClicked);
            // 
            // lnkl_esquerda
            // 
            this.lnkl_esquerda.AutoSize = true;
            this.lnkl_esquerda.Font = new System.Drawing.Font("Century Schoolbook", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkl_esquerda.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkl_esquerda.LinkColor = System.Drawing.Color.Black;
            this.lnkl_esquerda.Location = new System.Drawing.Point(55, 124);
            this.lnkl_esquerda.Name = "lnkl_esquerda";
            this.lnkl_esquerda.Size = new System.Drawing.Size(72, 77);
            this.lnkl_esquerda.TabIndex = 5;
            this.lnkl_esquerda.TabStop = true;
            this.lnkl_esquerda.Text = "<";
            this.lnkl_esquerda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkl_esquerda_LinkClicked);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarLeituraToolStripMenuItem,
            this.visualizarLeiturToolStripMenuItem,
            this.meusFavoritosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(584, 26);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // adicionarLeituraToolStripMenuItem
            // 
            this.adicionarLeituraToolStripMenuItem.Name = "adicionarLeituraToolStripMenuItem";
            this.adicionarLeituraToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.adicionarLeituraToolStripMenuItem.Text = "Adicionar Leitura";
            this.adicionarLeituraToolStripMenuItem.Click += new System.EventHandler(this.adicionarLeituraToolStripMenuItem_Click);
            // 
            // visualizarLeiturToolStripMenuItem
            // 
            this.visualizarLeiturToolStripMenuItem.Name = "visualizarLeiturToolStripMenuItem";
            this.visualizarLeiturToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.visualizarLeiturToolStripMenuItem.Text = "Visualizar Leitura";
            this.visualizarLeiturToolStripMenuItem.Click += new System.EventHandler(this.visualizarLeiturToolStripMenuItem_Click);
            // 
            // meusFavoritosToolStripMenuItem
            // 
            this.meusFavoritosToolStripMenuItem.Name = "meusFavoritosToolStripMenuItem";
            this.meusFavoritosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.meusFavoritosToolStripMenuItem.Text = "Meus Favoritos";
            this.meusFavoritosToolStripMenuItem.Click += new System.EventHandler(this.meusFavoritosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panelLivros
            // 
            this.panelLivros.Controls.Add(this.exibirLivro1);
            this.panelLivros.Controls.Add(this.vScrollBar1);
            this.panelLivros.Location = new System.Drawing.Point(3, 29);
            this.panelLivros.Name = "panelLivros";
            this.panelLivros.Size = new System.Drawing.Size(581, 228);
            this.panelLivros.TabIndex = 1;
            // 
            // exibirLivro1
            // 
            this.exibirLivro1.BackColor = System.Drawing.Color.Silver;
            this.exibirLivro1.Location = new System.Drawing.Point(19, 21);
            this.exibirLivro1.Name = "exibirLivro1";
            this.exibirLivro1.Size = new System.Drawing.Size(140, 180);
            this.exibirLivro1.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(562, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 220);
            this.vScrollBar1.TabIndex = 0;
            // 
            // cbx_statusPrincipal
            // 
            this.cbx_statusPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_statusPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_statusPrincipal.FormattingEnabled = true;
            this.cbx_statusPrincipal.Items.AddRange(new object[] {
            "Lidos",
            "Lendo",
            "Futuras Leitura",
            "Cansei, nunca mais"});
            this.cbx_statusPrincipal.Location = new System.Drawing.Point(1, 3);
            this.cbx_statusPrincipal.Name = "cbx_statusPrincipal";
            this.cbx_statusPrincipal.Size = new System.Drawing.Size(583, 26);
            this.cbx_statusPrincipal.TabIndex = 0;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(254)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Homepage";
            this.Text = "Homepage - SML 1.0";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_capas)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panelLivros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.PictureBox pbox_capas;
        private System.Windows.Forms.LinkLabel lnkl_direita;
        private System.Windows.Forms.LinkLabel lnkl_esquerda;
        private System.Windows.Forms.ToolStripMenuItem adicionarLeituraToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbx_statusPrincipal;
        private System.Windows.Forms.ToolStripMenuItem visualizarLeiturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusFavoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panelLivros;
        private ExibirLivro exibirLivro1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}