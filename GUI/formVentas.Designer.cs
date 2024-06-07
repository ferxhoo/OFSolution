namespace GUI
{
    partial class formVentas
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioVenta = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.txtStock = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.btnBuscarProducto = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.txtNombreProducto = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.txtCodigoProducto = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAgregarDetalle = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new GUI.Componentes_Personalizad.DateTimePickerOFSolution();
            this.cmbDocFactura = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtCliente = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.txtDocumentoCliente = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarMesero = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.txtIdMesero = new System.Windows.Forms.TextBox();
            this.txtMesero = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.txtDocMesero = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelCentrado = new System.Windows.Forms.Panel();
            this.panelOFSolution1 = new GUI.Componentes_Personalizad.PanelOFSolution();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPagaCon = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.txtCambio = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.txtTotal = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRegistrarVenta = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.dgvDetallesVenta = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelCentrado.SuspendLayout();
            this.panelOFSolution1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.groupBox3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 163);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1239, 104);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIdProducto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nupCantidad);
            this.groupBox3.Controls.Add(this.txtPrecioVenta);
            this.groupBox3.Controls.Add(this.txtStock);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.txtNombreProducto);
            this.groupBox3.Controls.Add(this.txtCodigoProducto);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1058, 95);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(181, 14);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(45, 22);
            this.txtIdProducto.TabIndex = 40;
            this.txtIdProducto.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(913, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Cantidad";
            // 
            // nupCantidad
            // 
            this.nupCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantidad.Location = new System.Drawing.Point(913, 42);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(115, 35);
            this.nupCantidad.TabIndex = 38;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecioVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtPrecioVenta.BorderFocusColor = System.Drawing.Color.Red;
            this.txtPrecioVenta.BorderRadius = 15;
            this.txtPrecioVenta.BorderSize = 2;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(570, 42);
            this.txtPrecioVenta.Multiline = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioVenta.PasswordChar = false;
            this.txtPrecioVenta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioVenta.PlaceholderText = "Precio Venta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(153, 35);
            this.txtPrecioVenta.TabIndex = 37;
            this.txtPrecioVenta.Texts = "";
            this.txtPrecioVenta.UnderlinedStyle = true;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtStock.BorderFocusColor = System.Drawing.Color.Red;
            this.txtStock.BorderRadius = 15;
            this.txtStock.BorderSize = 2;
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(740, 42);
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStock.PasswordChar = false;
            this.txtStock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStock.PlaceholderText = "Stock";
            this.txtStock.Size = new System.Drawing.Size(154, 35);
            this.txtStock.TabIndex = 36;
            this.txtStock.Texts = "";
            this.txtStock.UnderlinedStyle = true;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnBuscarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnBuscarProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnBuscarProducto.BorderRadius = 32;
            this.btnBuscarProducto.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 25;
            this.btnBuscarProducto.Location = new System.Drawing.Point(496, 42);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(46, 35);
            this.btnBuscarProducto.TabIndex = 35;
            this.btnBuscarProducto.TextColor = System.Drawing.Color.White;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtNombreProducto.BorderFocusColor = System.Drawing.Color.Red;
            this.txtNombreProducto.BorderRadius = 15;
            this.txtNombreProducto.BorderSize = 2;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(212, 42);
            this.txtNombreProducto.Multiline = false;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreProducto.PasswordChar = false;
            this.txtNombreProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreProducto.PlaceholderText = "Producto";
            this.txtNombreProducto.Size = new System.Drawing.Size(262, 35);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.Texts = "";
            this.txtNombreProducto.UnderlinedStyle = true;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtCodigoProducto.BorderFocusColor = System.Drawing.Color.Red;
            this.txtCodigoProducto.BorderRadius = 15;
            this.txtCodigoProducto.BorderSize = 2;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(14, 42);
            this.txtCodigoProducto.Multiline = false;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigoProducto.PasswordChar = false;
            this.txtCodigoProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigoProducto.PlaceholderText = "Codigo de Producto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(174, 35);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.Texts = "";
            this.txtCodigoProducto.UnderlinedStyle = true;
            this.txtCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAgregarDetalle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(1069, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(162, 95);
            this.panel4.TabIndex = 1;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btnAgregarDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btnAgregarDetalle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnAgregarDetalle.BorderRadius = 32;
            this.btnAgregarDetalle.BorderSize = 0;
            this.btnAgregarDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDetalle.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregarDetalle.IconColor = System.Drawing.Color.White;
            this.btnAgregarDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarDetalle.IconSize = 40;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(2, 2);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(158, 91);
            this.btnAgregarDetalle.TabIndex = 37;
            this.btnAgregarDetalle.Text = "Agregar Producto";
            this.btnAgregarDetalle.TextColor = System.Drawing.Color.White;
            this.btnAgregarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 729);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(8, 8);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(2);
            this.panel7.Size = new System.Drawing.Size(1239, 39);
            this.panel7.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1239, 104);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.cmbDocFactura);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpFecha.BorderSize = 0;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(7, 42);
            this.dtpFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(136, 35);
            this.dtpFecha.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.TextColor = System.Drawing.Color.White;
            // 
            // cmbDocFactura
            // 
            this.cmbDocFactura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.cmbDocFactura.BorderSize = 1;
            this.cmbDocFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocFactura.ForeColor = System.Drawing.Color.DimGray;
            this.cmbDocFactura.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDocFactura.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbDocFactura.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbDocFactura.Location = new System.Drawing.Point(148, 42);
            this.cmbDocFactura.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbDocFactura.Name = "cmbDocFactura";
            this.cmbDocFactura.Padding = new System.Windows.Forms.Padding(1);
            this.cmbDocFactura.Size = new System.Drawing.Size(200, 35);
            this.cmbDocFactura.TabIndex = 1;
            this.cmbDocFactura.Texts = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtIdCliente);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.txtDocumentoCliente);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(366, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnBuscarCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnBuscarCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnBuscarCliente.BorderRadius = 32;
            this.btnBuscarCliente.BorderSize = 0;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 25;
            this.btnBuscarCliente.Location = new System.Drawing.Point(368, 42);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(46, 35);
            this.btnBuscarCliente.TabIndex = 33;
            this.btnBuscarCliente.TextColor = System.Drawing.Color.White;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(157, 14);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(45, 22);
            this.txtIdCliente.TabIndex = 3;
            this.txtIdCliente.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtCliente.BorderFocusColor = System.Drawing.Color.Red;
            this.txtCliente.BorderRadius = 15;
            this.txtCliente.BorderSize = 2;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(155, 42);
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCliente.PasswordChar = false;
            this.txtCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCliente.PlaceholderText = "Nombre del Cliente";
            this.txtCliente.Size = new System.Drawing.Size(207, 35);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Texts = "";
            this.txtCliente.UnderlinedStyle = true;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDocumentoCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtDocumentoCliente.BorderFocusColor = System.Drawing.Color.Red;
            this.txtDocumentoCliente.BorderRadius = 15;
            this.txtDocumentoCliente.BorderSize = 2;
            this.txtDocumentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoCliente.Location = new System.Drawing.Point(8, 42);
            this.txtDocumentoCliente.Multiline = false;
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocumentoCliente.PasswordChar = false;
            this.txtDocumentoCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDocumentoCliente.PlaceholderText = "N° de Documento";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(141, 35);
            this.txtDocumentoCliente.TabIndex = 0;
            this.txtDocumentoCliente.Texts = "";
            this.txtDocumentoCliente.UnderlinedStyle = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnBuscarMesero);
            this.groupBox4.Controls.Add(this.txtIdMesero);
            this.groupBox4.Controls.Add(this.txtMesero);
            this.groupBox4.Controls.Add(this.txtDocMesero);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(803, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 95);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información del Mesero";
            // 
            // btnBuscarMesero
            // 
            this.btnBuscarMesero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnBuscarMesero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnBuscarMesero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnBuscarMesero.BorderRadius = 32;
            this.btnBuscarMesero.BorderSize = 0;
            this.btnBuscarMesero.FlatAppearance.BorderSize = 0;
            this.btnBuscarMesero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMesero.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMesero.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarMesero.IconColor = System.Drawing.Color.White;
            this.btnBuscarMesero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarMesero.IconSize = 25;
            this.btnBuscarMesero.Location = new System.Drawing.Point(368, 42);
            this.btnBuscarMesero.Name = "btnBuscarMesero";
            this.btnBuscarMesero.Size = new System.Drawing.Size(46, 35);
            this.btnBuscarMesero.TabIndex = 33;
            this.btnBuscarMesero.TextColor = System.Drawing.Color.White;
            this.btnBuscarMesero.UseVisualStyleBackColor = false;
            this.btnBuscarMesero.Click += new System.EventHandler(this.btnBuscarMesero_Click);
            // 
            // txtIdMesero
            // 
            this.txtIdMesero.Location = new System.Drawing.Point(157, 14);
            this.txtIdMesero.Name = "txtIdMesero";
            this.txtIdMesero.Size = new System.Drawing.Size(45, 22);
            this.txtIdMesero.TabIndex = 3;
            this.txtIdMesero.Visible = false;
            // 
            // txtMesero
            // 
            this.txtMesero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMesero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtMesero.BorderFocusColor = System.Drawing.Color.Red;
            this.txtMesero.BorderRadius = 15;
            this.txtMesero.BorderSize = 2;
            this.txtMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesero.Location = new System.Drawing.Point(155, 42);
            this.txtMesero.Multiline = false;
            this.txtMesero.Name = "txtMesero";
            this.txtMesero.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMesero.PasswordChar = false;
            this.txtMesero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMesero.PlaceholderText = "Nombre del Mesero";
            this.txtMesero.Size = new System.Drawing.Size(207, 35);
            this.txtMesero.TabIndex = 1;
            this.txtMesero.Texts = "";
            this.txtMesero.UnderlinedStyle = true;
            // 
            // txtDocMesero
            // 
            this.txtDocMesero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDocMesero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtDocMesero.BorderFocusColor = System.Drawing.Color.Red;
            this.txtDocMesero.BorderRadius = 15;
            this.txtDocMesero.BorderSize = 2;
            this.txtDocMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocMesero.Location = new System.Drawing.Point(8, 42);
            this.txtDocMesero.Multiline = false;
            this.txtDocMesero.Name = "txtDocMesero";
            this.txtDocMesero.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocMesero.PasswordChar = false;
            this.txtDocMesero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDocMesero.PlaceholderText = "N° de Documento";
            this.txtDocMesero.Size = new System.Drawing.Size(141, 35);
            this.txtDocMesero.TabIndex = 0;
            this.txtDocMesero.Texts = "";
            this.txtDocMesero.UnderlinedStyle = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 2);
            this.panel1.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPrincipal.Controls.Add(this.panelCentrado);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1261, 741);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelCentrado
            // 
            this.panelCentrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCentrado.Controls.Add(this.panelOFSolution1);
            this.panelCentrado.Location = new System.Drawing.Point(0, 0);
            this.panelCentrado.Name = "panelCentrado";
            this.panelCentrado.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelCentrado.Size = new System.Drawing.Size(1261, 741);
            this.panelCentrado.TabIndex = 0;
            // 
            // panelOFSolution1
            // 
            this.panelOFSolution1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.panelOFSolution1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.panelOFSolution1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelOFSolution1.BorderRadius = 20;
            this.panelOFSolution1.BorderSize = 0;
            this.panelOFSolution1.Controls.Add(this.panel3);
            this.panelOFSolution1.Controls.Add(this.panel2);
            this.panelOFSolution1.Controls.Add(this.panel1);
            this.panelOFSolution1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOFSolution1.Location = new System.Drawing.Point(3, 5);
            this.panelOFSolution1.Name = "panelOFSolution1";
            this.panelOFSolution1.Size = new System.Drawing.Size(1255, 731);
            this.panelOFSolution1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1255, 727);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 727);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.dgvDetallesVenta);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(8, 273);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4);
            this.panel6.Size = new System.Drawing.Size(1239, 446);
            this.panel6.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPagaCon);
            this.panel8.Controls.Add(this.txtCambio);
            this.panel8.Controls.Add(this.txtTotal);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(1063, 4);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(2);
            this.panel8.Size = new System.Drawing.Size(170, 362);
            this.panel8.TabIndex = 5;
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPagaCon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtPagaCon.BorderFocusColor = System.Drawing.Color.Red;
            this.txtPagaCon.BorderRadius = 15;
            this.txtPagaCon.BorderSize = 2;
            this.txtPagaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.Location = new System.Drawing.Point(8, 17);
            this.txtPagaCon.Multiline = false;
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPagaCon.PasswordChar = false;
            this.txtPagaCon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPagaCon.PlaceholderText = "Paga Con";
            this.txtPagaCon.Size = new System.Drawing.Size(149, 35);
            this.txtPagaCon.TabIndex = 4;
            this.txtPagaCon.Texts = "";
            this.txtPagaCon.UnderlinedStyle = true;
            this.txtPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagaCon_KeyDown);
            this.txtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagaCon_KeyPress);
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCambio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtCambio.BorderFocusColor = System.Drawing.Color.Red;
            this.txtCambio.BorderRadius = 15;
            this.txtCambio.BorderSize = 2;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(8, 68);
            this.txtCambio.Multiline = false;
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCambio.PasswordChar = false;
            this.txtCambio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCambio.PlaceholderText = "Cambio";
            this.txtCambio.Size = new System.Drawing.Size(149, 35);
            this.txtCambio.TabIndex = 3;
            this.txtCambio.Texts = "";
            this.txtCambio.UnderlinedStyle = true;
            this.txtCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCambio_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtTotal.BorderFocusColor = System.Drawing.Color.Red;
            this.txtTotal.BorderRadius = 15;
            this.txtTotal.BorderSize = 2;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(8, 321);
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotal.PasswordChar = false;
            this.txtTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotal.PlaceholderText = "Total a Pagar";
            this.txtTotal.Size = new System.Drawing.Size(149, 35);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Texts = "";
            this.txtTotal.UnderlinedStyle = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRegistrarVenta);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1063, 366);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8);
            this.panel5.Size = new System.Drawing.Size(170, 74);
            this.panel5.TabIndex = 4;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnRegistrarVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnRegistrarVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnRegistrarVenta.BorderRadius = 32;
            this.btnRegistrarVenta.BorderSize = 0;
            this.btnRegistrarVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.IconSize = 40;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(8, 8);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(154, 58);
            this.btnRegistrarVenta.TabIndex = 37;
            this.btnRegistrarVenta.Text = "Registrar";
            this.btnRegistrarVenta.TextColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // dgvDetallesVenta
            // 
            this.dgvDetallesVenta.AllowUserToAddRows = false;
            this.dgvDetallesVenta.AllowUserToResizeRows = false;
            this.dgvDetallesVenta.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallesVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idProducto,
            this.codigo,
            this.producto,
            this.cantidad,
            this.precioVenta,
            this.subtotal,
            this.btnEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetallesVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetallesVenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDetallesVenta.Location = new System.Drawing.Point(4, 4);
            this.dgvDetallesVenta.MultiSelect = false;
            this.dgvDetallesVenta.Name = "dgvDetallesVenta";
            this.dgvDetallesVenta.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallesVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetallesVenta.RowHeadersVisible = false;
            this.dgvDetallesVenta.RowHeadersWidth = 49;
            this.dgvDetallesVenta.RowTemplate.Height = 30;
            this.dgvDetallesVenta.Size = new System.Drawing.Size(1059, 436);
            this.dgvDetallesVenta.TabIndex = 3;
            this.dgvDetallesVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesVenta_CellContentClick);
            this.dgvDetallesVenta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDetallesVenta_CellPainting);
            this.dgvDetallesVenta.SelectionChanged += new System.EventHandler(this.dgvDetallesVenta_SelectionChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.codigo.HeaderText = "codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            this.codigo.Width = 120;
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.producto.FillWeight = 150F;
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 150;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 100;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 120;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Unitario";
            this.precioVenta.MinimumWidth = 6;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            this.precioVenta.Width = 200;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subtotal.FillWeight = 80F;
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.MinimumWidth = 80;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FillWeight = 40F;
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 40;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 40;
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 741);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "formVentas";
            this.Text = "formVentas";
            this.Load += new System.EventHandler(this.formVentas_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelCentrado.ResumeLayout(false);
            this.panelOFSolution1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private Componentes_Personalizad.TextBoxOFSolution txtPrecioVenta;
        private Componentes_Personalizad.IconButtonOFSolution btnBuscarProducto;
        private Componentes_Personalizad.TextBoxOFSolution txtNombreProducto;
        private Componentes_Personalizad.TextBoxOFSolution txtCodigoProducto;
        private System.Windows.Forms.Panel panel4;
        private Componentes_Personalizad.IconButtonOFSolution btnAgregarDetalle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Componentes_Personalizad.DateTimePickerOFSolution dtpFecha;
        private Componentes_Personalizad.ComboBoxOFSolution cmbDocFactura;
        private System.Windows.Forms.GroupBox groupBox2;
        private Componentes_Personalizad.IconButtonOFSolution btnBuscarCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private Componentes_Personalizad.TextBoxOFSolution txtCliente;
        private Componentes_Personalizad.TextBoxOFSolution txtDocumentoCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelCentrado;
        private Componentes_Personalizad.PanelOFSolution panelOFSolution1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private Componentes_Personalizad.TextBoxOFSolution txtTotal;
        private System.Windows.Forms.Panel panel5;
        private Componentes_Personalizad.IconButtonOFSolution btnRegistrarVenta;
        private System.Windows.Forms.DataGridView dgvDetallesVenta;
        private System.Windows.Forms.GroupBox groupBox4;
        private Componentes_Personalizad.IconButtonOFSolution btnBuscarMesero;
        private System.Windows.Forms.TextBox txtIdMesero;
        private Componentes_Personalizad.TextBoxOFSolution txtMesero;
        private Componentes_Personalizad.TextBoxOFSolution txtDocMesero;
        private Componentes_Personalizad.TextBoxOFSolution txtPagaCon;
        private Componentes_Personalizad.TextBoxOFSolution txtCambio;
        private Componentes_Personalizad.TextBoxOFSolution txtStock;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}