namespace P2
{
    partial class AdicionarLivro
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBoxCapa = new System.Windows.Forms.PictureBox();
            this.btnInserirCapa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_resenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownNota = new System.Windows.Forms.NumericUpDown();
            this.panelFavoritar = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFavoritar = new System.Windows.Forms.RadioButton();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNota)).BeginInit();
            this.panelFavoritar.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBoxCapa
            // 
            this.pictureBoxCapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCapa.Location = new System.Drawing.Point(70, 71);
            this.pictureBoxCapa.Name = "pictureBoxCapa";
            this.pictureBoxCapa.Size = new System.Drawing.Size(152, 188);
            this.pictureBoxCapa.TabIndex = 4;
            this.pictureBoxCapa.TabStop = false;
            // 
            // btnInserirCapa
            // 
            this.btnInserirCapa.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirCapa.Location = new System.Drawing.Point(70, 265);
            this.btnInserirCapa.Name = "btnInserirCapa";
            this.btnInserirCapa.Size = new System.Drawing.Size(152, 34);
            this.btnInserirCapa.TabIndex = 5;
            this.btnInserirCapa.Text = "Inserir Capa";
            this.btnInserirCapa.UseVisualStyleBackColor = true;
            this.btnInserirCapa.Click += new System.EventHandler(this.btnInserirCapa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Título";
            // 
            // txt_titulo
            // 
            this.txt_titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_titulo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(255, 94);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(266, 19);
            this.txt_titulo.TabIndex = 12;
            // 
            // txt_autor
            // 
            this.txt_autor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_autor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_autor.Location = new System.Drawing.Point(255, 146);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(266, 19);
            this.txt_autor.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Autor";
            // 
            // txt_resenha
            // 
            this.txt_resenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_resenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resenha.Location = new System.Drawing.Point(255, 201);
            this.txt_resenha.Multiline = true;
            this.txt_resenha.Name = "txt_resenha";
            this.txt_resenha.Size = new System.Drawing.Size(266, 98);
            this.txt_resenha.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Resenha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gênero";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGenero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Acadêmico/Científico",
            "Ação",
            "Autoajuda ",
            "Autobiografia",
            "Biografia",
            "Comédia",
            "Drama",
            "Espiritualidade ou Religioso",
            "Fantasia",
            "Ficção científica",
            "Poesia",
            "Romance",
            "Suspense",
            "Terror",
            "",
            ""});
            this.comboBoxGenero.Location = new System.Drawing.Point(70, 349);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(205, 28);
            this.comboBoxGenero.TabIndex = 18;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(316, 349);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(205, 28);
            this.comboBoxStatus.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Favoritar";
            // 
            // numericUpDownNota
            // 
            this.numericUpDownNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownNota.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNota.Location = new System.Drawing.Point(70, 414);
            this.numericUpDownNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNota.Name = "numericUpDownNota";
            this.numericUpDownNota.ReadOnly = true;
            this.numericUpDownNota.Size = new System.Drawing.Size(204, 22);
            this.numericUpDownNota.TabIndex = 24;
            this.numericUpDownNota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelFavoritar
            // 
            this.panelFavoritar.Controls.Add(this.radioButton2);
            this.panelFavoritar.Controls.Add(this.radioButtonFavoritar);
            this.panelFavoritar.Controls.Add(this.label7);
            this.panelFavoritar.Location = new System.Drawing.Point(316, 392);
            this.panelFavoritar.Name = "panelFavoritar";
            this.panelFavoritar.Size = new System.Drawing.Size(203, 44);
            this.panelFavoritar.TabIndex = 25;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(99, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 24);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButtonFavoritar
            // 
            this.radioButtonFavoritar.AutoSize = true;
            this.radioButtonFavoritar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFavoritar.Location = new System.Drawing.Point(3, 18);
            this.radioButtonFavoritar.Name = "radioButtonFavoritar";
            this.radioButtonFavoritar.Size = new System.Drawing.Size(50, 24);
            this.radioButtonFavoritar.TabIndex = 24;
            this.radioButtonFavoritar.TabStop = true;
            this.radioButtonFavoritar.Text = "Sim";
            this.radioButtonFavoritar.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
            this.btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadastrar.Location = new System.Drawing.Point(205, 475);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(164, 32);
            this.btn_cadastrar.TabIndex = 40;
            this.btn_cadastrar.Text = "Adicionar Livro";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // AdicionarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(254)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.panelFavoritar);
            this.Controls.Add(this.numericUpDownNota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_resenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserirCapa);
            this.Controls.Add(this.pictureBoxCapa);
            this.Controls.Add(this.linkLabel1);
            this.Name = "AdicionarLivro";
            this.Text = "Adicionar Livro";
            this.Load += new System.EventHandler(this.AdicionarLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNota)).EndInit();
            this.panelFavoritar.ResumeLayout(false);
            this.panelFavoritar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBoxCapa;
        private System.Windows.Forms.Button btnInserirCapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_resenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownNota;
        private System.Windows.Forms.Panel panelFavoritar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButtonFavoritar;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}