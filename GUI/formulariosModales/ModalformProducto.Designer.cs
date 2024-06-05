namespace GUI.formulariosModales
{
    partial class ModalformProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulos = new System.Windows.Forms.Panel();
            this.LogoBarraTitulo = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel = new System.Windows.Forms.Panel();
            this.panelOFSolution1 = new GUI.Componentes_Personalizad.PanelOFSolution();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBusqueda = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.btnLimpiarBusqueda = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.btnBuscar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.txtBuscar = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraTitulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBarraTitulo)).BeginInit();
            this.panel.SuspendLayout();
            this.panelOFSolution1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulos
            // 
            this.BarraTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.BarraTitulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarraTitulos.Controls.Add(this.LogoBarraTitulo);
            this.BarraTitulos.Controls.Add(this.Titulo);
            this.BarraTitulos.Controls.Add(this.btnMinimizar);
            this.BarraTitulos.Controls.Add(this.btnClose);
            this.BarraTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulos.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulos.Name = "BarraTitulos";
            this.BarraTitulos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BarraTitulos.Size = new System.Drawing.Size(800, 30);
            this.BarraTitulos.TabIndex = 4;
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
            this.btnMinimizar.Location = new System.Drawing.Point(718, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 28);
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
            this.btnClose.Location = new System.Drawing.Point(758, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.panelOFSolution1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 30);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(8);
            this.panel.Size = new System.Drawing.Size(800, 572);
            this.panel.TabIndex = 6;
            // 
            // panelOFSolution1
            // 
            this.panelOFSolution1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.panelOFSolution1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.panelOFSolution1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelOFSolution1.BorderRadius = 20;
            this.panelOFSolution1.BorderSize = 0;
            this.panelOFSolution1.Controls.Add(this.panel8);
            this.panelOFSolution1.Controls.Add(this.panel5);
            this.panelOFSolution1.Controls.Add(this.panel4);
            this.panelOFSolution1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOFSolution1.Location = new System.Drawing.Point(8, 8);
            this.panelOFSolution1.Name = "panelOFSolution1";
            this.panelOFSolution1.Size = new System.Drawing.Size(782, 554);
            this.panelOFSolution1.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tableLayoutPanel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(782, 514);
            this.panel8.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvProductos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 514);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.label11);
            this.panel14.Controls.Add(this.cmbBusqueda);
            this.panel14.Controls.Add(this.btnLimpiarBusqueda);
            this.panel14.Controls.Add(this.btnBuscar);
            this.panel14.Controls.Add(this.txtBuscar);
            this.panel14.Controls.Add(this.label10);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(23, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(736, 92);
            this.panel14.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Buscar Por:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.cmbBusqueda.BorderSize = 1;
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbBusqueda.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbBusqueda.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.Location = new System.Drawing.Point(212, 44);
            this.cmbBusqueda.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Padding = new System.Windows.Forms.Padding(1);
            this.cmbBusqueda.Size = new System.Drawing.Size(201, 32);
            this.cmbBusqueda.TabIndex = 35;
            this.cmbBusqueda.Texts = "";
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
            this.btnLimpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnLimpiarBusqueda.IconColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBusqueda.IconSize = 25;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(674, 45);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(41, 32);
            this.btnLimpiarBusqueda.TabIndex = 34;
            this.btnLimpiarBusqueda.TextColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(627, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 32);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.BorderSize = 2;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(419, 45);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtBuscar.PlaceholderText = "Buscar...";
            this.txtBuscar.Size = new System.Drawing.Size(195, 31);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.Texts = "";
            this.txtBuscar.UnderlinedStyle = true;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(734, 38);
            this.label10.TabIndex = 2;
            this.label10.Text = "Lista de Productos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 534);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(782, 20);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(782, 20);
            this.panel4.TabIndex = 0;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idProducto,
            this.codigo,
            this.nombre,
            this.idCategoria,
            this.categoria,
            this.stock,
            this.precioCompra,
            this.precioVenta});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(23, 112);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 49;
            this.dgvProductos.RowTemplate.Height = 30;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(736, 399);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            this.dgvProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProductos_CellPainting);
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
            this.stock.Visible = false;
            this.stock.Width = 50;
            // 
            // precioCompra
            // 
            this.precioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioCompra.HeaderText = "Precio de Compra";
            this.precioCompra.MinimumWidth = 100;
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            this.precioCompra.Visible = false;
            // 
            // precioVenta
            // 
            this.precioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioVenta.HeaderText = "Precio de Venta";
            this.precioVenta.MinimumWidth = 100;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            this.precioVenta.Visible = false;
            // 
            // ModalformProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.BarraTitulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalformProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalformProducto";
            this.Load += new System.EventHandler(this.ModalformProducto_Load);
            this.BarraTitulos.ResumeLayout(false);
            this.BarraTitulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBarraTitulo)).EndInit();
            this.panel.ResumeLayout(false);
            this.panelOFSolution1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraTitulos;
        private System.Windows.Forms.PictureBox LogoBarraTitulo;
        private System.Windows.Forms.Label Titulo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel;
        private Componentes_Personalizad.PanelOFSolution panelOFSolution1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label11;
        private Componentes_Personalizad.ComboBoxOFSolution cmbBusqueda;
        private Componentes_Personalizad.IconButtonOFSolution btnLimpiarBusqueda;
        private Componentes_Personalizad.IconButtonOFSolution btnBuscar;
        private Componentes_Personalizad.TextBoxOFSolution txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
    }
}