namespace GUI
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.BarraTitulos = new System.Windows.Forms.Panel();
            this.LogoBarraTitulo = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelLoginBajo = new System.Windows.Forms.Panel();
            this.btnCerrar = new GUI.Componentes_Personalizad.ButtonOFSolution();
            this.btnCancelar = new GUI.Componentes_Personalizad.ButtonOFSolution();
            this.btnIngresar = new GUI.Componentes_Personalizad.ButtonOFSolution();
            this.txtPassword = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.txtUsuario = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.InformacionCampoPassword = new System.Windows.Forms.Label();
            this.InformacionCampoUsuario = new System.Windows.Forms.Label();
            this.BarraTitulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBarraTitulo)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelLoginBajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulos
            // 
            this.BarraTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.BarraTitulos.Controls.Add(this.LogoBarraTitulo);
            this.BarraTitulos.Controls.Add(this.Titulo);
            this.BarraTitulos.Controls.Add(this.btnMinimizar);
            this.BarraTitulos.Controls.Add(this.btnClose);
            this.BarraTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulos.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulos.Name = "BarraTitulos";
            this.BarraTitulos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BarraTitulos.Size = new System.Drawing.Size(400, 30);
            this.BarraTitulos.TabIndex = 1;
            this.BarraTitulos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulos_MouseDown);
            // 
            // LogoBarraTitulo
            // 
            this.LogoBarraTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoBarraTitulo.Image = global::GUI.Properties.Resources.IconoTitulo_Sin_Fondo__OFSolution;
            this.LogoBarraTitulo.Location = new System.Drawing.Point(5, 0);
            this.LogoBarraTitulo.Name = "LogoBarraTitulo";
            this.LogoBarraTitulo.Size = new System.Drawing.Size(30, 30);
            this.LogoBarraTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBarraTitulo.TabIndex = 3;
            this.LogoBarraTitulo.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Tai Le", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(41, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(66, 16);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "OFSolution";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 20;
            this.btnMinimizar.Location = new System.Drawing.Point(320, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 30);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(360, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 30);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(400, 220);
            this.panelLogo.TabIndex = 2;
            // 
            // Logo
            // 
            this.Logo.Image = global::GUI.Properties.Resources.OFSolution___Claro;
            this.Logo.Location = new System.Drawing.Point(62, -30);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(276, 300);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // panelLoginBajo
            // 
            this.panelLoginBajo.Controls.Add(this.btnCerrar);
            this.panelLoginBajo.Controls.Add(this.btnCancelar);
            this.panelLoginBajo.Controls.Add(this.btnIngresar);
            this.panelLoginBajo.Controls.Add(this.txtPassword);
            this.panelLoginBajo.Controls.Add(this.txtUsuario);
            this.panelLoginBajo.Controls.Add(this.InformacionCampoPassword);
            this.panelLoginBajo.Controls.Add(this.InformacionCampoUsuario);
            this.panelLoginBajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginBajo.Location = new System.Drawing.Point(0, 250);
            this.panelLoginBajo.Name = "panelLoginBajo";
            this.panelLoginBajo.Size = new System.Drawing.Size(400, 350);
            this.panelLoginBajo.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.Red;
            this.btnCerrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnCerrar.BorderRadius = 40;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(75, 242);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(250, 40);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(75, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(250, 40);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnIngresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnIngresar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnIngresar.BorderRadius = 40;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(75, 150);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(250, 40);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(75, 80);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtPassword.PlaceholderText = "Contraseña";
            this.txtPassword.Size = new System.Drawing.Size(250, 35);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtUsuario.BorderRadius = 15;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(75, 15);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtUsuario.PlaceholderText = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 35);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = true;
            // 
            // InformacionCampoPassword
            // 
            this.InformacionCampoPassword.AutoSize = true;
            this.InformacionCampoPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacionCampoPassword.Location = new System.Drawing.Point(95, 118);
            this.InformacionCampoPassword.Name = "InformacionCampoPassword";
            this.InformacionCampoPassword.Size = new System.Drawing.Size(41, 15);
            this.InformacionCampoPassword.TabIndex = 13;
            this.InformacionCampoPassword.Text = "label1";
            // 
            // InformacionCampoUsuario
            // 
            this.InformacionCampoUsuario.AutoSize = true;
            this.InformacionCampoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacionCampoUsuario.Location = new System.Drawing.Point(95, 53);
            this.InformacionCampoUsuario.Name = "InformacionCampoUsuario";
            this.InformacionCampoUsuario.Size = new System.Drawing.Size(34, 15);
            this.InformacionCampoUsuario.TabIndex = 11;
            this.InformacionCampoUsuario.Text = "label";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.panelLoginBajo);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.BarraTitulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OFSolution";
            this.BarraTitulos.ResumeLayout(false);
            this.BarraTitulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBarraTitulo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelLoginBajo.ResumeLayout(false);
            this.panelLoginBajo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulos;
        private System.Windows.Forms.PictureBox LogoBarraTitulo;
        private System.Windows.Forms.Label Titulo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelLoginBajo;
        private Componentes_Personalizad.TextBoxOFSolution txtUsuario;
        private System.Windows.Forms.Label InformacionCampoPassword;
        private System.Windows.Forms.Label InformacionCampoUsuario;
        private Componentes_Personalizad.ButtonOFSolution btnIngresar;
        private Componentes_Personalizad.TextBoxOFSolution txtPassword;
        private Componentes_Personalizad.ButtonOFSolution btnCerrar;
        private Componentes_Personalizad.ButtonOFSolution btnCancelar;
    }
}