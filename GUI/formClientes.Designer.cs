namespace GUI
{
    partial class formClientes
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
            this.TLPForm = new System.Windows.Forms.TableLayoutPanel();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.panelOFSolution1 = new GUI.Componentes_Personalizad.PanelOFSolution();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBusqueda = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.txtBuscar = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.btnBuscar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.btnLimpiarBusqueda = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelRegistro = new GUI.Componentes_Personalizad.PanelOFSolution();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCheck = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cmbEstado = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTelefono = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCorreo = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDocumento = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnGuardar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnEliminar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.iconButtonOFSolution1 = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.iconButtonOFSolution2 = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.lblTituloRegistro = new System.Windows.Forms.Label();
            this.TLPForm.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            this.panelOFSolution1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel14.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPForm
            // 
            this.TLPForm.AutoScroll = true;
            this.TLPForm.AutoScrollMinSize = new System.Drawing.Size(1255, 735);
            this.TLPForm.BackColor = System.Drawing.Color.White;
            this.TLPForm.ColumnCount = 2;
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPForm.Controls.Add(this.panelConsulta, 1, 0);
            this.TLPForm.Controls.Add(this.panelRegistro, 0, 0);
            this.TLPForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPForm.Location = new System.Drawing.Point(0, 0);
            this.TLPForm.Name = "TLPForm";
            this.TLPForm.Padding = new System.Windows.Forms.Padding(5);
            this.TLPForm.RowCount = 1;
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.Size = new System.Drawing.Size(1261, 741);
            this.TLPForm.TabIndex = 2;
            // 
            // panelConsulta
            // 
            this.panelConsulta.AutoScroll = true;
            this.panelConsulta.BackColor = System.Drawing.Color.White;
            this.panelConsulta.Controls.Add(this.panelOFSolution1);
            this.panelConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsulta.Location = new System.Drawing.Point(303, 8);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelConsulta.Size = new System.Drawing.Size(954, 729);
            this.panelConsulta.TabIndex = 1;
            // 
            // panelOFSolution1
            // 
            this.panelOFSolution1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.panelOFSolution1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.panelOFSolution1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelOFSolution1.BorderRadius = 20;
            this.panelOFSolution1.BorderSize = 0;
            this.panelOFSolution1.Controls.Add(this.panel4);
            this.panelOFSolution1.Controls.Add(this.panel5);
            this.panelOFSolution1.Controls.Add(this.panel3);
            this.panelOFSolution1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOFSolution1.Location = new System.Drawing.Point(1, 0);
            this.panelOFSolution1.Name = "panelOFSolution1";
            this.panelOFSolution1.Size = new System.Drawing.Size(953, 729);
            this.panelOFSolution1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(953, 689);
            this.panel4.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvClientes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 689);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idCliente,
            this.documento,
            this.nombreCompleto,
            this.correo,
            this.telefono,
            this.estado,
            this.valorEstado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(23, 113);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 49;
            this.dgvClientes.RowTemplate.Height = 30;
            this.dgvClientes.Size = new System.Drawing.Size(907, 573);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvClientes_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 35F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 35;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 35;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.MinimumWidth = 6;
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            this.idCliente.Width = 120;
            // 
            // documento
            // 
            this.documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documento.HeaderText = "N° Documento";
            this.documento.MinimumWidth = 140;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCompleto.HeaderText = "Nombre Completo";
            this.nombreCompleto.MinimumWidth = 200;
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 200;
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.MinimumWidth = 100;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 80;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
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
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.tableLayoutPanel2);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(23, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(907, 80);
            this.panel14.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.81749F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.182509F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(905, 78);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 20);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(216, 38);
            this.label10.TabIndex = 1;
            this.label10.Text = "Lista de Clientes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(254, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 38);
            this.label11.TabIndex = 2;
            this.label11.Text = "Buscar Por:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.cmbBusqueda.BorderSize = 1;
            this.cmbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbBusqueda.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbBusqueda.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.Location = new System.Drawing.Point(341, 23);
            this.cmbBusqueda.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Padding = new System.Windows.Forms.Padding(1);
            this.cmbBusqueda.Size = new System.Drawing.Size(204, 32);
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
            this.txtBuscar.Location = new System.Drawing.Point(551, 23);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtBuscar.PlaceholderText = "Buscar...";
            this.txtBuscar.Size = new System.Drawing.Size(196, 31);
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
            this.btnBuscar.Location = new System.Drawing.Point(753, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 32);
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
            this.btnLimpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnLimpiarBusqueda.IconColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBusqueda.IconSize = 25;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(805, 23);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(50, 32);
            this.btnLimpiarBusqueda.TabIndex = 33;
            this.btnLimpiarBusqueda.TextColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 709);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(953, 20);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 20);
            this.panel3.TabIndex = 0;
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
            this.panelRegistro.Controls.Add(this.panel7);
            this.panelRegistro.Controls.Add(this.panel6);
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
            this.panelRegistro.Size = new System.Drawing.Size(289, 729);
            this.panelRegistro.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtIndice);
            this.panel13.Controls.Add(this.txtId);
            this.panel13.Controls.Add(this.lblCheck);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 332);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(4);
            this.panel13.Size = new System.Drawing.Size(289, 263);
            this.panel13.TabIndex = 41;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(106, 120);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(35, 22);
            this.txtIndice.TabIndex = 16;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 120);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 22);
            this.txtId.TabIndex = 15;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // lblCheck
            // 
            this.lblCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCheck.Location = new System.Drawing.Point(4, 4);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCheck.Size = new System.Drawing.Size(281, 16);
            this.lblCheck.TabIndex = 12;
            this.lblCheck.Text = "Exitoso!!";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.cmbEstado);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 276);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel12.Size = new System.Drawing.Size(289, 56);
            this.panel12.TabIndex = 40;
            // 
            // cmbEstado
            // 
            this.cmbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.cmbEstado.BorderSize = 1;
            this.cmbEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbEstado.ForeColor = System.Drawing.Color.DimGray;
            this.cmbEstado.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbEstado.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbEstado.Location = new System.Drawing.Point(10, 19);
            this.cmbEstado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Padding = new System.Windows.Forms.Padding(1);
            this.cmbEstado.Size = new System.Drawing.Size(269, 34);
            this.cmbEstado.TabIndex = 0;
            this.cmbEstado.Texts = "";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(10, 3);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(269, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Estado";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTelefono);
            this.panel7.Controls.Add(this.lblTelefono);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 217);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(6);
            this.panel7.Size = new System.Drawing.Size(289, 59);
            this.panel7.TabIndex = 38;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtTelefono.BorderRadius = 15;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(6, 6);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtTelefono.PlaceholderText = "Teléfono";
            this.txtTelefono.Size = new System.Drawing.Size(277, 31);
            this.txtTelefono.TabIndex = 30;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = true;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(6, 38);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTelefono.Size = new System.Drawing.Size(277, 15);
            this.lblTelefono.TabIndex = 31;
            this.lblTelefono.Text = "label7";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtCorreo);
            this.panel6.Controls.Add(this.lblCorreo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 158);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(6);
            this.panel6.Size = new System.Drawing.Size(289, 59);
            this.panel6.TabIndex = 37;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtCorreo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtCorreo.BorderRadius = 15;
            this.txtCorreo.BorderSize = 2;
            this.txtCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(6, 6);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtCorreo.PlaceholderText = "Correo";
            this.txtCorreo.Size = new System.Drawing.Size(277, 31);
            this.txtCorreo.TabIndex = 30;
            this.txtCorreo.Texts = "";
            this.txtCorreo.UnderlinedStyle = true;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(6, 38);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCorreo.Size = new System.Drawing.Size(277, 15);
            this.lblCorreo.TabIndex = 31;
            this.lblCorreo.Text = "label6";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(289, 59);
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
            this.txtNombre.PlaceholderText = "Nombre Completo";
            this.txtNombre.Size = new System.Drawing.Size(277, 31);
            this.txtNombre.TabIndex = 30;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = true;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNombre.Size = new System.Drawing.Size(277, 15);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.lblDocumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(289, 59);
            this.panel1.TabIndex = 32;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDocumento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtDocumento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtDocumento.BorderRadius = 15;
            this.txtDocumento.BorderSize = 2;
            this.txtDocumento.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(6, 6);
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocumento.PasswordChar = false;
            this.txtDocumento.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDocumento.PlaceholderText = "N° Documento";
            this.txtDocumento.Size = new System.Drawing.Size(277, 31);
            this.txtDocumento.TabIndex = 30;
            this.txtDocumento.Texts = "";
            this.txtDocumento.UnderlinedStyle = true;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(6, 38);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDocumento.Size = new System.Drawing.Size(277, 15);
            this.lblDocumento.TabIndex = 31;
            this.lblDocumento.Text = "label2";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnGuardar);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 595);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 5, 10, 3);
            this.panel11.Size = new System.Drawing.Size(289, 43);
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
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(269, 35);
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
            this.panel10.Size = new System.Drawing.Size(289, 43);
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
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(269, 35);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnEliminar);
            this.panel9.Controls.Add(this.iconButtonOFSolution1);
            this.panel9.Controls.Add(this.iconButtonOFSolution2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 681);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10, 5, 10, 3);
            this.panel9.Size = new System.Drawing.Size(289, 43);
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
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(269, 35);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // iconButtonOFSolution1
            // 
            this.iconButtonOFSolution1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.iconButtonOFSolution1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.iconButtonOFSolution1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButtonOFSolution1.BorderRadius = 25;
            this.iconButtonOFSolution1.BorderSize = 0;
            this.iconButtonOFSolution1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonOFSolution1.FlatAppearance.BorderSize = 0;
            this.iconButtonOFSolution1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOFSolution1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonOFSolution1.ForeColor = System.Drawing.Color.White;
            this.iconButtonOFSolution1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButtonOFSolution1.IconColor = System.Drawing.Color.White;
            this.iconButtonOFSolution1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOFSolution1.IconSize = 30;
            this.iconButtonOFSolution1.Location = new System.Drawing.Point(10, 5);
            this.iconButtonOFSolution1.Name = "iconButtonOFSolution1";
            this.iconButtonOFSolution1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.iconButtonOFSolution1.Size = new System.Drawing.Size(269, 35);
            this.iconButtonOFSolution1.TabIndex = 16;
            this.iconButtonOFSolution1.Text = "Guardar";
            this.iconButtonOFSolution1.TextColor = System.Drawing.Color.White;
            this.iconButtonOFSolution1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOFSolution1.UseVisualStyleBackColor = false;
            // 
            // iconButtonOFSolution2
            // 
            this.iconButtonOFSolution2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.iconButtonOFSolution2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.iconButtonOFSolution2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButtonOFSolution2.BorderRadius = 29;
            this.iconButtonOFSolution2.BorderSize = 0;
            this.iconButtonOFSolution2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonOFSolution2.FlatAppearance.BorderSize = 0;
            this.iconButtonOFSolution2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOFSolution2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonOFSolution2.ForeColor = System.Drawing.Color.White;
            this.iconButtonOFSolution2.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButtonOFSolution2.IconColor = System.Drawing.Color.White;
            this.iconButtonOFSolution2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOFSolution2.IconSize = 30;
            this.iconButtonOFSolution2.Location = new System.Drawing.Point(10, 5);
            this.iconButtonOFSolution2.Name = "iconButtonOFSolution2";
            this.iconButtonOFSolution2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.iconButtonOFSolution2.Size = new System.Drawing.Size(269, 35);
            this.iconButtonOFSolution2.TabIndex = 17;
            this.iconButtonOFSolution2.Text = "Limpiar";
            this.iconButtonOFSolution2.TextColor = System.Drawing.Color.White;
            this.iconButtonOFSolution2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOFSolution2.UseVisualStyleBackColor = false;
            // 
            // lblTituloRegistro
            // 
            this.lblTituloRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegistro.Location = new System.Drawing.Point(0, 0);
            this.lblTituloRegistro.Name = "lblTituloRegistro";
            this.lblTituloRegistro.Padding = new System.Windows.Forms.Padding(5);
            this.lblTituloRegistro.Size = new System.Drawing.Size(289, 40);
            this.lblTituloRegistro.TabIndex = 0;
            this.lblTituloRegistro.Text = "Información de Clientes";
            this.lblTituloRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 741);
            this.Controls.Add(this.TLPForm);
            this.Name = "formClientes";
            this.Text = "formClientes";
            this.Load += new System.EventHandler(this.formClientes_Load);
            this.TLPForm.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelOFSolution1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel14.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPForm;
        private System.Windows.Forms.Panel panelConsulta;
        private Componentes_Personalizad.PanelOFSolution panelOFSolution1;
        private Componentes_Personalizad.PanelOFSolution panelRegistro;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Panel panel12;
        private Componentes_Personalizad.ComboBoxOFSolution cmbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private Componentes_Personalizad.TextBoxOFSolution txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel panel6;
        private Componentes_Personalizad.TextBoxOFSolution txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Panel panel2;
        private Componentes_Personalizad.TextBoxOFSolution txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel1;
        private Componentes_Personalizad.TextBoxOFSolution txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Panel panel11;
        private Componentes_Personalizad.IconButtonOFSolution btnGuardar;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTituloRegistro;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Componentes_Personalizad.ComboBoxOFSolution cmbBusqueda;
        private Componentes_Personalizad.TextBoxOFSolution txtBuscar;
        private Componentes_Personalizad.IconButtonOFSolution btnBuscar;
        private Componentes_Personalizad.IconButtonOFSolution btnLimpiarBusqueda;
        private Componentes_Personalizad.IconButtonOFSolution btnEliminar;
        private Componentes_Personalizad.IconButtonOFSolution iconButtonOFSolution1;
        private Componentes_Personalizad.IconButtonOFSolution iconButtonOFSolution2;
        private Componentes_Personalizad.IconButtonOFSolution btnLimpiar;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorEstado;
    }
}