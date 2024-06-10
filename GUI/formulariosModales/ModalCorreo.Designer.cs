namespace GUI.formulariosModales
{
    partial class ModalCorreo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.BarraTitulos = new System.Windows.Forms.Panel();
            this.LogoBarraTitulo = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAsunto = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.txtCorreo = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.txtMensaje = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.btnEnviar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.BarraTitulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBarraTitulo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.BarraTitulos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 560);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 30);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(762, 41);
            this.label10.TabIndex = 45;
            this.label10.Text = "Enviar Factura Al Correo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BarraTitulos
            // 
            this.BarraTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.BarraTitulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarraTitulos.Controls.Add(this.LogoBarraTitulo);
            this.BarraTitulos.Controls.Add(this.Titulo);
            this.BarraTitulos.Controls.Add(this.btnClose);
            this.BarraTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulos.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulos.Name = "BarraTitulos";
            this.BarraTitulos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BarraTitulos.Size = new System.Drawing.Size(762, 30);
            this.BarraTitulos.TabIndex = 40;
            this.BarraTitulos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulos_MouseDown);
            // 
            // LogoBarraTitulo
            // 
            this.LogoBarraTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoBarraTitulo.Image = global::GUI.Properties.Resources.IconoTitulo_Sin_Fondo__OFSolution;
            this.LogoBarraTitulo.Location = new System.Drawing.Point(5, 0);
            this.LogoBarraTitulo.Name = "LogoBarraTitulo";
            this.LogoBarraTitulo.Size = new System.Drawing.Size(30, 28);
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
            this.btnClose.Location = new System.Drawing.Point(720, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtAsunto);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.txtMensaje);
            this.panel2.Location = new System.Drawing.Point(45, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 441);
            this.panel2.TabIndex = 44;
            // 
            // txtAsunto
            // 
            this.txtAsunto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAsunto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtAsunto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtAsunto.BorderRadius = 15;
            this.txtAsunto.BorderSize = 2;
            this.txtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(39, 103);
            this.txtAsunto.Multiline = false;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAsunto.PasswordChar = false;
            this.txtAsunto.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtAsunto.PlaceholderText = "Asunto";
            this.txtAsunto.Size = new System.Drawing.Size(394, 33);
            this.txtAsunto.TabIndex = 40;
            this.txtAsunto.Texts = "";
            this.txtAsunto.UnderlinedStyle = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtCorreo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtCorreo.BorderRadius = 15;
            this.txtCorreo.BorderSize = 2;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(39, 42);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtCorreo.PlaceholderText = "Destinatario...";
            this.txtCorreo.Size = new System.Drawing.Size(394, 33);
            this.txtCorreo.TabIndex = 39;
            this.txtCorreo.Texts = "";
            this.txtCorreo.UnderlinedStyle = true;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMensaje.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtMensaje.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtMensaje.BorderRadius = 15;
            this.txtMensaje.BorderSize = 2;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(39, 196);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMensaje.PasswordChar = false;
            this.txtMensaje.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtMensaje.PlaceholderText = "Mensaje...";
            this.txtMensaje.Size = new System.Drawing.Size(394, 214);
            this.txtMensaje.TabIndex = 38;
            this.txtMensaje.Texts = "";
            this.txtMensaje.UnderlinedStyle = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEnviar.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnEnviar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnEnviar.BorderRadius = 31;
            this.btnEnviar.BorderSize = 0;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.IconChar = FontAwesome.Sharp.IconChar.EnvelopeCircleCheck;
            this.btnEnviar.IconColor = System.Drawing.Color.White;
            this.btnEnviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnviar.IconSize = 40;
            this.btnEnviar.Location = new System.Drawing.Point(569, 436);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(151, 95);
            this.btnEnviar.TabIndex = 42;
            this.btnEnviar.TextColor = System.Drawing.Color.White;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Asunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mensaje:";
            // 
            // ModalCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalCorreo";
            this.Load += new System.EventHandler(this.ModalCorreo_Load);
            this.panel1.ResumeLayout(false);
            this.BarraTitulos.ResumeLayout(false);
            this.BarraTitulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBarraTitulo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel BarraTitulos;
        private System.Windows.Forms.PictureBox LogoBarraTitulo;
        private System.Windows.Forms.Label Titulo;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel2;
        private Componentes_Personalizad.TextBoxOFSolution txtCorreo;
        private Componentes_Personalizad.TextBoxOFSolution txtMensaje;
        private Componentes_Personalizad.IconButtonOFSolution btnEnviar;
        private Componentes_Personalizad.TextBoxOFSolution txtAsunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}