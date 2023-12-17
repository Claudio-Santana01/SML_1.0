namespace P2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txtb_usuario = new System.Windows.Forms.TextBox();
            this.mtxt_senha = new System.Windows.Forms.MaskedTextBox();
            this.linklb_cadastro = new System.Windows.Forms.LinkLabel();
            this.lb_ainda = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(255)))), ((int)(((byte)(188)))));
            this.btn_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_entrar.Location = new System.Drawing.Point(246, 405);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(103, 32);
            this.btn_entrar.TabIndex = 56;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txtb_usuario
            // 
            this.txtb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb_usuario.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_usuario.Location = new System.Drawing.Point(92, 229);
            this.txtb_usuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtb_usuario.Name = "txtb_usuario";
            this.txtb_usuario.Size = new System.Drawing.Size(404, 24);
            this.txtb_usuario.TabIndex = 55;
            // 
            // mtxt_senha
            // 
            this.mtxt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_senha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_senha.Location = new System.Drawing.Point(91, 293);
            this.mtxt_senha.Name = "mtxt_senha";
            this.mtxt_senha.Size = new System.Drawing.Size(405, 25);
            this.mtxt_senha.TabIndex = 51;
            // 
            // linklb_cadastro
            // 
            this.linklb_cadastro.ActiveLinkColor = System.Drawing.Color.White;
            this.linklb_cadastro.AutoSize = true;
            this.linklb_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklb_cadastro.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_cadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklb_cadastro.LinkColor = System.Drawing.Color.White;
            this.linklb_cadastro.Location = new System.Drawing.Point(325, 438);
            this.linklb_cadastro.Name = "linklb_cadastro";
            this.linklb_cadastro.Size = new System.Drawing.Size(95, 18);
            this.linklb_cadastro.TabIndex = 49;
            this.linklb_cadastro.TabStop = true;
            this.linklb_cadastro.Text = "Cadastre-se";
            this.linklb_cadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_cadastro_LinkClicked);
            // 
            // lb_ainda
            // 
            this.lb_ainda.AutoSize = true;
            this.lb_ainda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ainda.Location = new System.Drawing.Point(176, 440);
            this.lb_ainda.Name = "lb_ainda";
            this.lb_ainda.Size = new System.Drawing.Size(156, 16);
            this.lb_ainda.TabIndex = 48;
            this.lb_ainda.Text = "Ainda não tem cadastro? ";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(88, 272);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(53, 18);
            this.lb_senha.TabIndex = 44;
            this.lb_senha.Text = "Senha";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(88, 209);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(62, 18);
            this.lb_usuario.TabIndex = 42;
            this.lb_usuario.Text = "Usuário";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(237, 106);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(112, 38);
            this.lb_login.TabIndex = 41;
            this.lb_login.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(254)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txtb_usuario);
            this.Controls.Add(this.mtxt_senha);
            this.Controls.Add(this.linklb_cadastro);
            this.Controls.Add(this.lb_ainda);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.lb_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "SML 1.0";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txtb_usuario;
        private System.Windows.Forms.MaskedTextBox mtxt_senha;
        private System.Windows.Forms.LinkLabel linklb_cadastro;
        private System.Windows.Forms.Label lb_ainda;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_login;
    }
}