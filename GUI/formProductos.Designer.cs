namespace GUI
{
    partial class formProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbEstado = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmbCategoria = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.label9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnGuardar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnEliminar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblTituloRegistro = new System.Windows.Forms.Label();
            this.TLPForm = new System.Windows.Forms.TableLayoutPanel();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.panelConteinerTable = new GUI.Componentes_Personalizad.PanelOFSolution();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBusqueda = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.txtBuscar = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.btnBuscar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.btnLimpiarBusqueda = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelRegistro = new GUI.Componentes_Personalizad.PanelOFSolution();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDescargar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.TLPForm.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            this.panelConteinerTable.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstado
            // 
            this.cmbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.cmbEstado.BorderSize = 1;
            this.cmbEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.ForeColor = System.Drawing.Color.DimGray;
            this.cmbEstado.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbEstado.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbEstado.Location = new System.Drawing.Point(10, 19);
            this.cmbEstado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Padding = new System.Windows.Forms.Padding(1);
            this.cmbEstado.Size = new System.Drawing.Size(230, 34);
            this.cmbEstado.TabIndex = 0;
            this.cmbEstado.Texts = "";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(10, 3);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(230, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Estado";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cmbCategoria);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 217);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel8.Size = new System.Drawing.Size(250, 56);
            this.panel8.TabIndex = 39;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.cmbCategoria.BorderSize = 1;
            this.cmbCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCategoria.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCategoria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCategoria.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCategoria.Location = new System.Drawing.Point(10, 19);
            this.cmbCategoria.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Padding = new System.Windows.Forms.Padding(1);
            this.cmbCategoria.Size = new System.Drawing.Size(230, 34);
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.Texts = "";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(10, 3);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(230, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Categoria";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.lblCheck);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 329);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(4);
            this.panel13.Size = new System.Drawing.Size(250, 266);
            this.panel13.TabIndex = 41;
            // 
            // lblCheck
            // 
            this.lblCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(4, 4);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCheck.Size = new System.Drawing.Size(242, 16);
            this.lblCheck.TabIndex = 12;
            this.lblCheck.Text = "Exitoso!!";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.lblDescripcion);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 158);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(250, 59);
            this.panel3.TabIndex = 34;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtDescripcion.BorderRadius = 15;
            this.txtDescripcion.BorderSize = 2;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(6, 6);
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDescripcion.PlaceholderText = "Descripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(238, 31);
            this.txtDescripcion.TabIndex = 30;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.UnderlinedStyle = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.26087F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDescripcion.Size = new System.Drawing.Size(238, 15);
            this.lblDescripcion.TabIndex = 31;
            this.lblDescripcion.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(250, 59);
            this.panel2.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtNombre.BorderRadius = 15;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(6, 6);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtNombre.PlaceholderText = "Nombre de Producto";
            this.txtNombre.Size = new System.Drawing.Size(238, 31);
            this.txtNombre.TabIndex = 30;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = true;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.26087F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNombre.Size = new System.Drawing.Size(238, 15);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(250, 59);
            this.panel1.TabIndex = 32;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtCodigo.BorderRadius = 15;
            this.txtCodigo.BorderSize = 2;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(6, 6);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtCodigo.PlaceholderText = "Codigo";
            this.txtCodigo.Size = new System.Drawing.Size(238, 31);
            this.txtCodigo.TabIndex = 30;
            this.txtCodigo.Texts = "";
            this.txtCodigo.UnderlinedStyle = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.26087F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCodigo.Size = new System.Drawing.Size(238, 15);
            this.lblCodigo.TabIndex = 31;
            this.lblCodigo.Text = "label2";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnGuardar);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 595);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 5, 10, 3);
            this.panel11.Size = new System.Drawing.Size(250, 43);
            this.panel11.TabIndex = 29;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuardar.BorderRadius = 25;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.Location = new System.Drawing.Point(10, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(230, 35);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnLimpiar);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 638);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10, 5, 10, 3);
            this.panel10.Size = new System.Drawing.Size(250, 43);
            this.panel10.TabIndex = 28;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiar.BorderRadius = 29;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 30;
            this.btnLimpiar.Location = new System.Drawing.Point(10, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(230, 35);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnEliminar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 681);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10, 5, 10, 3);
            this.panel9.Size = new System.Drawing.Size(250, 43);
            this.panel9.TabIndex = 27;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminar.BorderRadius = 29;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.Location = new System.Drawing.Point(10, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(230, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.cmbEstado);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 273);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel12.Size = new System.Drawing.Size(250, 56);
            this.panel12.TabIndex = 40;
            // 
            // lblTituloRegistro
            // 
            this.lblTituloRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegistro.Location = new System.Drawing.Point(0, 0);
            this.lblTituloRegistro.Name = "lblTituloRegistro";
            this.lblTituloRegistro.Padding = new System.Windows.Forms.Padding(5);
            this.lblTituloRegistro.Size = new System.Drawing.Size(250, 40);
            this.lblTituloRegistro.TabIndex = 0;
            this.lblTituloRegistro.Text = "Información de Producto";
            this.lblTituloRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TLPForm
            // 
            this.TLPForm.AutoScroll = true;
            this.TLPForm.AutoScrollMinSize = new System.Drawing.Size(1255, 735);
            this.TLPForm.BackColor = System.Drawing.Color.White;
            this.TLPForm.ColumnCount = 2;
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPForm.Controls.Add(this.panelConsulta, 1, 0);
            this.TLPForm.Controls.Add(this.panelRegistro, 0, 0);
            this.TLPForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPForm.Location = new System.Drawing.Point(0, 0);
            this.TLPForm.Name = "TLPForm";
            this.TLPForm.Padding = new System.Windows.Forms.Padding(5);
            this.TLPForm.RowCount = 1;
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.Size = new System.Drawing.Size(1261, 741);
            this.TLPForm.TabIndex = 1;
            // 
            // panelConsulta
            // 
            this.panelConsulta.AutoScroll = true;
            this.panelConsulta.BackColor = System.Drawing.Color.White;
            this.panelConsulta.Controls.Add(this.panelConteinerTable);
            this.panelConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsulta.Location = new System.Drawing.Point(264, 8);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelConsulta.Size = new System.Drawing.Size(993, 729);
            this.panelConsulta.TabIndex = 1;
            // 
            // panelConteinerTable
            // 
            this.panelConteinerTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.panelConteinerTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.panelConteinerTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelConteinerTable.BorderRadius = 20;
            this.panelConteinerTable.BorderSize = 0;
            this.panelConteinerTable.Controls.Add(this.panelCentral);
            this.panelConteinerTable.Controls.Add(this.panelInferior);
            this.panelConteinerTable.Controls.Add(this.panelSuperior);
            this.panelConteinerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteinerTable.Location = new System.Drawing.Point(1, 0);
            this.panelConteinerTable.Name = "panelConteinerTable";
            this.panelConteinerTable.Size = new System.Drawing.Size(992, 729);
            this.panelConteinerTable.TabIndex = 5;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.tableLayoutPanel1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 20);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(992, 689);
            this.panelCentral.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 689);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.tableLayoutPanel2);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(13, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(966, 80);
            this.panel14.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbBusqueda, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscar, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscar, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLimpiarBusqueda, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(964, 78);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 20);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(198, 38);
            this.label10.TabIndex = 1;
            this.label10.Text = "Lista de Productos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(278, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 38);
            this.label11.TabIndex = 2;
            this.label11.Text = "Buscar Por:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.cmbBusqueda.BorderSize = 1;
            this.cmbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbBusqueda.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbBusqueda.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.Location = new System.Drawing.Point(396, 23);
            this.cmbBusqueda.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Padding = new System.Windows.Forms.Padding(1);
            this.cmbBusqueda.Size = new System.Drawing.Size(201, 32);
            this.cmbBusqueda.TabIndex = 3;
            this.cmbBusqueda.Texts = "";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.BorderSize = 2;
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(603, 23);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtBuscar.PlaceholderText = "Buscar...";
            this.txtBuscar.Size = new System.Drawing.Size(226, 31);
            this.txtBuscar.TabIndex = 31;
            this.txtBuscar.Texts = "";
            this.txtBuscar.UnderlinedStyle = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnBuscar.BorderRadius = 32;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.Location = new System.Drawing.Point(835, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 32);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiarBusqueda.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiarBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnLimpiarBusqueda.BorderRadius = 32;
            this.btnLimpiarBusqueda.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarBusqueda.IconColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBusqueda.IconSize = 25;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(886, 23);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(47, 32);
            this.btnLimpiarBusqueda.TabIndex = 33;
            this.btnLimpiarBusqueda.TextColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.txtIndice);
            this.panelInferior.Controls.Add(this.txtId);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 709);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(992, 20);
            this.panelInferior.TabIndex = 1;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(13, 0);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(35, 22);
            this.txtIndice.TabIndex = 14;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(54, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 22);
            this.txtId.TabIndex = 13;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(992, 20);
            this.panelSuperior.TabIndex = 0;
            // 
            // panelRegistro
            // 
            this.panelRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelRegistro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelRegistro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelRegistro.BorderRadius = 20;
            this.panelRegistro.BorderSize = 0;
            this.panelRegistro.Controls.Add(this.panel13);
            this.panelRegistro.Controls.Add(this.panel12);
            this.panelRegistro.Controls.Add(this.panel8);
            this.panelRegistro.Controls.Add(this.panel3);
            this.panelRegistro.Controls.Add(this.panel2);
            this.panelRegistro.Controls.Add(this.panel1);
            this.panelRegistro.Controls.Add(this.panel11);
            this.panelRegistro.Controls.Add(this.panel10);
            this.panelRegistro.Controls.Add(this.panel9);
            this.panelRegistro.Controls.Add(this.lblTituloRegistro);
            this.panelRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistro.Location = new System.Drawing.Point(8, 8);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelRegistro.Size = new System.Drawing.Size(250, 729);
            this.panelRegistro.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvProductos);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(13, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 573);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 498);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 17, 0, 0);
            this.panel5.Size = new System.Drawing.Size(966, 75);
            this.panel5.TabIndex = 0;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idProducto,
            this.codigo,
            this.nombre,
            this.descripcion,
            this.idCategoria,
            this.categoria,
            this.stock,
            this.precioCompra,
            this.precioVenta,
            this.estado,
            this.valorEstado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 49;
            this.dgvProductos.RowTemplate.Height = 30;
            this.dgvProductos.Size = new System.Drawing.Size(966, 498);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProductos_CellPainting);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnDescargar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 17);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(966, 58);
            this.panel6.TabIndex = 0;
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDescargar.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnDescargar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnDescargar.BorderRadius = 35;
            this.btnDescargar.BorderSize = 0;
            this.btnDescargar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnDescargar.IconColor = System.Drawing.Color.White;
            this.btnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargar.IconSize = 25;
            this.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargar.Location = new System.Drawing.Point(10, 10);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btnDescargar.Size = new System.Drawing.Size(161, 36);
            this.btnDescargar.TabIndex = 1;
            this.btnDescargar.Text = "Descargar Excel";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargar.TextColor = System.Drawing.Color.White;
            this.btnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 40F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 40;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 40;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            this.idProducto.Width = 120;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo.FillWeight = 110F;
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 110;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.FillWeight = 130F;
            this.nombre.HeaderText = "Nombre de Producto";
            this.nombre.MinimumWidth = 130;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.FillWeight = 140F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 140;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.MinimumWidth = 6;
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            this.idCategoria.Width = 120;
            // 
            // categoria
            // 
            this.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 100;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.FillWeight = 50F;
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 50;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 50;
            // 
            // precioCompra
            // 
            this.precioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioCompra.HeaderText = "Precio de Compra";
            this.precioCompra.MinimumWidth = 100;
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioVenta.HeaderText = "Precio de Venta";
            this.precioVenta.MinimumWidth = 100;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.estado.FillWeight = 80F;
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 80;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 87;
            // 
            // valorEstado
            // 
            this.valorEstado.HeaderText = "valorEstado";
            this.valorEstado.MinimumWidth = 6;
            this.valorEstado.Name = "valorEstado";
            this.valorEstado.ReadOnly = true;
            this.valorEstado.Visible = false;
            this.valorEstado.Width = 120;
            // 
            // formProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 741);
            this.Controls.Add(this.TLPForm);
            this.Name = "formProductos";
            this.Text = "formProductos";
            this.Load += new System.EventHandler(this.formProductos_Load);
            this.panel8.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.TLPForm.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelConteinerTable.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes_Personalizad.ComboBoxOFSolution cmbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private Componentes_Personalizad.ComboBoxOFSolution cmbCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Panel panel3;
        private Componentes_Personalizad.TextBoxOFSolution txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panel2;
        private Componentes_Personalizad.TextBoxOFSolution txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel1;
        private Componentes_Personalizad.TextBoxOFSolution txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panel11;
        private Componentes_Personalizad.IconButtonOFSolution btnGuardar;
        private System.Windows.Forms.Panel panel10;
        private Componentes_Personalizad.IconButtonOFSolution btnLimpiar;
        private System.Windows.Forms.Panel panel9;
        private Componentes_Personalizad.IconButtonOFSolution btnEliminar;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblTituloRegistro;
        private System.Windows.Forms.TableLayoutPanel TLPForm;
        private System.Windows.Forms.Panel panelConsulta;
        private Componentes_Personalizad.PanelOFSolution panelConteinerTable;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Componentes_Personalizad.ComboBoxOFSolution cmbBusqueda;
        private Componentes_Personalizad.TextBoxOFSolution txtBuscar;
        private Componentes_Personalizad.IconButtonOFSolution btnBuscar;
        private Componentes_Personalizad.IconButtonOFSolution btnLimpiarBusqueda;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panelSuperior;
        private Componentes_Personalizad.PanelOFSolution panelRegistro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Componentes_Personalizad.IconButtonOFSolution btnDescargar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorEstado;
    }
}