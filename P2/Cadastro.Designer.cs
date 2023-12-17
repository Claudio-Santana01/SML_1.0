namespace P2
{
    partial class Cadastro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label data_NascimentoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonteLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel1;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label data_NascimentoLabel1;
            System.Windows.Forms.Label senhaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.linklb_login = new System.Windows.Forms.LinkLabel();
            this.lb_possui = new System.Windows.Forms.Label();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.lb_datanasc = new System.Windows.Forms.Label();
            this.lb_confirme = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_cadastro = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._SML_1_0DataSet = new P2._SML_1_0DataSet();
            this.usuarioTableAdapter = new P2._SML_1_0DataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new P2._SML_1_0DataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox1 = new System.Windows.Forms.TextBox();
            this.data_NascimentoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            data_NascimentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonteLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel1 = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            data_NascimentoLabel1 = new System.Windows.Forms.Label();
            senhaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SML_1_0DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // data_NascimentoLabel
            // 
            data_NascimentoLabel.AutoSize = true;
            data_NascimentoLabel.Location = new System.Drawing.Point(63, 378);
            data_NascimentoLabel.Name = "data_NascimentoLabel";
            data_NascimentoLabel.Size = new System.Drawing.Size(0, 13);
            data_NascimentoLabel.TabIndex = 39;
            data_NascimentoLabel.Click += new System.EventHandler(this.data_NascimentoLabel_Click);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(120, 179);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(0, 13);
            nomeLabel.TabIndex = 40;
            nomeLabel.Click += new System.EventHandler(this.nomeLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(108, 255);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(0, 13);
            emailLabel.TabIndex = 41;
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // telefonteLabel
            // 
            telefonteLabel.AutoSize = true;
            telefonteLabel.Location = new System.Drawing.Point(347, 375);
            telefonteLabel.Name = "telefonteLabel";
            telefonteLabel.Size = new System.Drawing.Size(0, 13);
            telefonteLabel.TabIndex = 42;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(350, 385);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(0, 13);
            telefoneLabel.TabIndex = 45;
            // 
            // emailLabel1
            // 
            emailLabel1.AutoSize = true;
            emailLabel1.Location = new System.Drawing.Point(108, 241);
            emailLabel1.Name = "emailLabel1";
            emailLabel1.Size = new System.Drawing.Size(0, 13);
            emailLabel1.TabIndex = 48;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(104, 309);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(0, 13);
            senhaLabel.TabIndex = 49;
            // 
            // data_NascimentoLabel1
            // 
            data_NascimentoLabel1.AutoSize = true;
            data_NascimentoLabel1.Location = new System.Drawing.Point(102, 377);
            data_NascimentoLabel1.Name = "data_NascimentoLabel1";
            data_NascimentoLabel1.Size = new System.Drawing.Size(0, 13);
            data_NascimentoLabel1.TabIndex = 50;
            // 
            // senhaLabel1
            // 
            senhaLabel1.AutoSize = true;
            senhaLabel1.Location = new System.Drawing.Point(336, 311);
            senhaLabel1.Name = "senhaLabel1";
            senhaLabel1.Size = new System.Drawing.Size(0, 13);
            senhaLabel1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 1;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
            this.btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadastrar.Location = new System.Drawing.Point(246, 435);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(103, 32);
            this.btn_cadastrar.TabIndex = 39;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // linklb_login
            // 
            this.linklb_login.ActiveLinkColor = System.Drawing.Color.White;
            this.linklb_login.AutoSize = true;
            this.linklb_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklb_login.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_login.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklb_login.LinkColor = System.Drawing.Color.White;
            this.linklb_login.Location = new System.Drawing.Point(356, 470);
            this.linklb_login.Name = "linklb_login";
            this.linklb_login.Size = new System.Drawing.Size(48, 18);
            this.linklb_login.TabIndex = 32;
            this.linklb_login.TabStop = true;
            this.linklb_login.Text = "Login";
            this.linklb_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_login_LinkClicked);
            // 
            // lb_possui
            // 
            this.lb_possui.AutoSize = true;
            this.lb_possui.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_possui.Location = new System.Drawing.Point(177, 470);
            this.lb_possui.Name = "lb_possui";
            this.lb_possui.Size = new System.Drawing.Size(185, 16);
            this.lb_possui.TabIndex = 31;
            this.lb_possui.Text = "Já possui cadastro? Realize o ";
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(316, 334);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(66, 18);
            this.lb_telefone.TabIndex = 30;
            this.lb_telefone.Text = "Telefone";
            // 
            // lb_datanasc
            // 
            this.lb_datanasc.AutoSize = true;
            this.lb_datanasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datanasc.Location = new System.Drawing.Point(90, 334);
            this.lb_datanasc.Name = "lb_datanasc";
            this.lb_datanasc.Size = new System.Drawing.Size(151, 18);
            this.lb_datanasc.TabIndex = 29;
            this.lb_datanasc.Text = "Data de Nascimento";
            // 
            // lb_confirme
            // 
            this.lb_confirme.AutoSize = true;
            this.lb_confirme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirme.Location = new System.Drawing.Point(316, 273);
            this.lb_confirme.Name = "lb_confirme";
            this.lb_confirme.Size = new System.Drawing.Size(134, 18);
            this.lb_confirme.TabIndex = 28;
            this.lb_confirme.Text = "Confirme a Senha";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(88, 273);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(53, 18);
            this.lb_senha.TabIndex = 27;
            this.lb_senha.Text = "Senha";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(90, 209);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(48, 18);
            this.lb_email.TabIndex = 26;
            this.lb_email.Text = "Email";
            // 
            // lb_cadastro
            // 
            this.lb_cadastro.AutoSize = true;
            this.lb_cadastro.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro.Location = new System.Drawing.Point(199, 73);
            this.lb_cadastro.Name = "lb_cadastro";
            this.lb_cadastro.Size = new System.Drawing.Size(183, 38);
            this.lb_cadastro.TabIndex = 24;
            this.lb_cadastro.Text = "CADASTRO";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this._SML_1_0DataSet;
            // 
            // _SML_1_0DataSet
            // 
            this._SML_1_0DataSet.DataSetName = "_SML_1_0DataSet";
            this._SML_1_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = P2._SML_1_0DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(91, 161);
            this.nomeTextBox.Multiline = true;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(400, 28);
            this.nomeTextBox.TabIndex = 48;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(91, 230);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(400, 28);
            this.emailTextBox.TabIndex = 49;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(93, 294);
            this.senhaTextBox.Multiline = true;
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(180, 28);
            this.senhaTextBox.TabIndex = 50;
            // 
            // senhaTextBox1
            // 
            this.senhaTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox1.Location = new System.Drawing.Point(316, 294);
            this.senhaTextBox1.Multiline = true;
            this.senhaTextBox1.Name = "senhaTextBox1";
            this.senhaTextBox1.Size = new System.Drawing.Size(180, 28);
            this.senhaTextBox1.TabIndex = 52;
            // 
            // data_NascimentoTextBox
            // 
            this.data_NascimentoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_NascimentoTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_NascimentoTextBox.Location = new System.Drawing.Point(91, 357);
            this.data_NascimentoTextBox.Mask = "00/00/0000";
            this.data_NascimentoTextBox.Name = "data_NascimentoTextBox";
            this.data_NascimentoTextBox.Size = new System.Drawing.Size(182, 25);
            this.data_NascimentoTextBox.TabIndex = 55;
            this.data_NascimentoTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefoneTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTextBox.Location = new System.Drawing.Point(319, 357);
            this.telefoneTextBox.Mask = "(00) 00000-0000";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(177, 25);
            this.telefoneTextBox.TabIndex = 56;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(254)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(590, 561);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.data_NascimentoTextBox);
            this.Controls.Add(senhaLabel1);
            this.Controls.Add(this.senhaTextBox1);
            this.Controls.Add(data_NascimentoLabel1);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(emailLabel1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(telefonteLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(data_NascimentoLabel);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.linklb_login);
            this.Controls.Add(this.lb_possui);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.lb_datanasc);
            this.Controls.Add(this.lb_confirme);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_cadastro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "SML 1.0";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SML_1_0DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.LinkLabel linklb_login;
        private System.Windows.Forms.Label lb_possui;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.Label lb_datanasc;
        private System.Windows.Forms.Label lb_confirme;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_cadastro;
        private _SML_1_0DataSet _SML_1_0DataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private _SML_1_0DataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private _SML_1_0DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox senhaTextBox1;
        private System.Windows.Forms.MaskedTextBox data_NascimentoTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
    }
}