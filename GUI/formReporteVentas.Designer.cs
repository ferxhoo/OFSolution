namespace GUI
{
    partial class formReporteVentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtTotal = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBusqueda = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtBuscar = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnBuscar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnLimpiarBusqueda = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new GUI.Componentes_Personalizad.DateTimePickerOFSolution();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new GUI.Componentes_Personalizad.DateTimePickerOFSolution();
            this.lblTituloRegistro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 795);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1260, 740);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.29032F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.70968F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 795);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(13, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1270, 636);
            this.panel3.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1268, 567);
            this.panel14.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dgvVenta);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(15);
            this.panel15.Size = new System.Drawing.Size(1268, 567);
            this.panel15.TabIndex = 2;
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToResizeRows = false;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaRegistro,
            this.tipoDocumento,
            this.numeroDocumento,
            this.usuarioRegistro,
            this.mesero,
            this.numeroMesa,
            this.documentoCliente,
            this.cliente,
            this.montoPago,
            this.montoCambio,
            this.montoTotal});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVenta.Location = new System.Drawing.Point(15, 15);
            this.dgvVenta.MultiSelect = false;
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVenta.RowHeadersVisible = false;
            this.dgvVenta.RowHeadersWidth = 49;
            this.dgvVenta.RowTemplate.Height = 30;
            this.dgvVenta.Size = new System.Drawing.Size(1238, 537);
            this.dgvVenta.TabIndex = 7;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.MinimumWidth = 6;
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            this.fechaRegistro.Width = 120;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.HeaderText = "Tipo Documento";
            this.tipoDocumento.MinimumWidth = 6;
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Width = 120;
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.HeaderText = "N° Documento";
            this.numeroDocumento.MinimumWidth = 6;
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.ReadOnly = true;
            this.numeroDocumento.Width = 120;
            // 
            // usuarioRegistro
            // 
            this.usuarioRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuarioRegistro.HeaderText = "Usuario Registro";
            this.usuarioRegistro.MinimumWidth = 6;
            this.usuarioRegistro.Name = "usuarioRegistro";
            this.usuarioRegistro.ReadOnly = true;
            // 
            // mesero
            // 
            this.mesero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mesero.HeaderText = "Mesero";
            this.mesero.MinimumWidth = 6;
            this.mesero.Name = "mesero";
            this.mesero.ReadOnly = true;
            // 
            // numeroMesa
            // 
            this.numeroMesa.FillWeight = 80F;
            this.numeroMesa.HeaderText = "Mesa";
            this.numeroMesa.MinimumWidth = 80;
            this.numeroMesa.Name = "numeroMesa";
            this.numeroMesa.ReadOnly = true;
            this.numeroMesa.Width = 80;
            // 
            // documentoCliente
            // 
            this.documentoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentoCliente.HeaderText = "Documento Cliente";
            this.documentoCliente.MinimumWidth = 6;
            this.documentoCliente.Name = "documentoCliente";
            this.documentoCliente.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.HeaderText = "Cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // montoPago
            // 
            this.montoPago.HeaderText = "Pago Con";
            this.montoPago.MinimumWidth = 6;
            this.montoPago.Name = "montoPago";
            this.montoPago.ReadOnly = true;
            this.montoPago.Width = 120;
            // 
            // montoCambio
            // 
            this.montoCambio.HeaderText = "Total Cambio";
            this.montoCambio.MinimumWidth = 6;
            this.montoCambio.Name = "montoCambio";
            this.montoCambio.ReadOnly = true;
            this.montoCambio.Width = 120;
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Total";
            this.montoTotal.MinimumWidth = 6;
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            this.montoTotal.Width = 120;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label3);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 567);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1268, 67);
            this.panel13.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(754, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 67);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total Ventas:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtTotal);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(1068, 0);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(15);
            this.panel16.Size = new System.Drawing.Size(200, 67);
            this.panel16.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtTotal.BorderFocusColor = System.Drawing.Color.Red;
            this.txtTotal.BorderRadius = 15;
            this.txtTotal.BorderSize = 2;
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(15, 15);
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotal.PasswordChar = false;
            this.txtTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotal.PlaceholderText = "Total";
            this.txtTotal.Size = new System.Drawing.Size(170, 35);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.Texts = "";
            this.txtTotal.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblTituloRegistro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 127);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.Size = new System.Drawing.Size(1268, 85);
            this.panel4.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(310, 15);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel8.Size = new System.Drawing.Size(943, 55);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.cmbBusqueda);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.txtBuscar);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.btnBuscar);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.btnLimpiarBusqueda);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(41, 10);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel9.Size = new System.Drawing.Size(902, 35);
            this.panel9.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(314, 35);
            this.label11.TabIndex = 41;
            this.label11.Text = "Buscar Por:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.cmbBusqueda.BorderSize = 1;
            this.cmbBusqueda.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbBusqueda.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbBusqueda.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.Location = new System.Drawing.Point(319, 0);
            this.cmbBusqueda.MaximumSize = new System.Drawing.Size(200, 33);
            this.cmbBusqueda.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Padding = new System.Windows.Forms.Padding(1);
            this.cmbBusqueda.Size = new System.Drawing.Size(200, 33);
            this.cmbBusqueda.TabIndex = 40;
            this.cmbBusqueda.Texts = "";
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(519, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(20, 35);
            this.panel11.TabIndex = 39;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.txtBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.BorderSize = 2;
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(539, 0);
            this.txtBuscar.MaximumSize = new System.Drawing.Size(226, 31);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtBuscar.PlaceholderText = "Buscar...";
            this.txtBuscar.Size = new System.Drawing.Size(226, 31);
            this.txtBuscar.TabIndex = 38;
            this.txtBuscar.Texts = "";
            this.txtBuscar.UnderlinedStyle = true;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(765, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(20, 35);
            this.panel10.TabIndex = 37;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnBuscar.BorderRadius = 28;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.Location = new System.Drawing.Point(785, 0);
            this.btnBuscar.MaximumSize = new System.Drawing.Size(45, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 33);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(830, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(20, 35);
            this.panel12.TabIndex = 35;
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiarBusqueda.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiarBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.btnLimpiarBusqueda.BorderRadius = 28;
            this.btnLimpiarBusqueda.BorderSize = 0;
            this.btnLimpiarBusqueda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnLimpiarBusqueda.IconColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBusqueda.IconSize = 25;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(850, 0);
            this.btnLimpiarBusqueda.MaximumSize = new System.Drawing.Size(47, 33);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(47, 33);
            this.btnLimpiarBusqueda.TabIndex = 34;
            this.btnLimpiarBusqueda.TextColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.dtpFechaFin);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(170, 15);
            this.panel7.MaximumSize = new System.Drawing.Size(140, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 53);
            this.panel7.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpFechaFin.BorderSize = 0;
            this.dtpFechaFin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(0, 18);
            this.dtpFechaFin.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(140, 35);
            this.dtpFechaFin.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.dtpFechaFin.TabIndex = 3;
            this.dtpFechaFin.TextColor = System.Drawing.Color.White;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(155, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 55);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.dtpFechaInicio);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(15, 15);
            this.panel5.MaximumSize = new System.Drawing.Size(140, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 53);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpFechaInicio.BorderSize = 0;
            this.dtpFechaInicio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(0, 18);
            this.dtpFechaInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(140, 35);
            this.dtpFechaInicio.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.dtpFechaInicio.TabIndex = 3;
            this.dtpFechaInicio.TextColor = System.Drawing.Color.White;
            // 
            // lblTituloRegistro
            // 
            this.lblTituloRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegistro.Location = new System.Drawing.Point(0, 0);
            this.lblTituloRegistro.Name = "lblTituloRegistro";
            this.lblTituloRegistro.Padding = new System.Windows.Forms.Padding(5);
            this.lblTituloRegistro.Size = new System.Drawing.Size(1268, 40);
            this.lblTituloRegistro.TabIndex = 1;
            this.lblTituloRegistro.Text = "Facturas de Ventas";
            this.lblTituloRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // formReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1275, 785);
            this.ClientSize = new System.Drawing.Size(1296, 795);
            this.Controls.Add(this.panel1);
            this.Name = "formReporteVentas";
            this.Text = "formReporteVentas";
            this.Load += new System.EventHandler(this.formReporteVentas_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTituloRegistro;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private Componentes_Personalizad.DateTimePickerOFSolution dtpFechaFin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private Componentes_Personalizad.DateTimePickerOFSolution dtpFechaInicio;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private Componentes_Personalizad.ComboBoxOFSolution cmbBusqueda;
        private System.Windows.Forms.Panel panel11;
        private Componentes_Personalizad.TextBoxOFSolution txtBuscar;
        private System.Windows.Forms.Panel panel10;
        private Componentes_Personalizad.IconButtonOFSolution btnBuscar;
        private System.Windows.Forms.Panel panel12;
        private Componentes_Personalizad.IconButtonOFSolution btnLimpiarBusqueda;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesero;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.Panel panel16;
        private Componentes_Personalizad.TextBoxOFSolution txtTotal;
        private System.Windows.Forms.Label label3;
    }
}