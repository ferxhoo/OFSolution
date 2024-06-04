using System.Windows.Forms;

namespace GUI
{
    partial class formCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelCentrado = new System.Windows.Forms.Panel();
            this.panelOFSolution1 = new GUI.Componentes_Personalizad.PanelOFSolution();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxOFSolution7 = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButtonOFSolution3 = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxOFSolution6 = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.textBoxOFSolution5 = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.iconButtonOFSolution1 = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.textBoxOFSolution4 = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.textBoxOFSolution3 = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButtonOFSolution2 = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerOFSolution1 = new GUI.Componentes_Personalizad.DateTimePickerOFSolution();
            this.comboBoxOFSolution1 = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxOFSolution2 = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.textBoxOFSolution1 = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.panelCentrado.SuspendLayout();
            this.panelOFSolution1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.panelPrincipal.TabIndex = 0;
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
            this.panel6.Controls.Add(this.dgvProductos);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(8, 273);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4);
            this.panel6.Size = new System.Drawing.Size(1239, 446);
            this.panel6.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBoxOFSolution7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(1063, 4);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(2);
            this.panel8.Size = new System.Drawing.Size(170, 362);
            this.panel8.TabIndex = 5;
            // 
            // textBoxOFSolution7
            // 
            this.textBoxOFSolution7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOFSolution7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.textBoxOFSolution7.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxOFSolution7.BorderRadius = 15;
            this.textBoxOFSolution7.BorderSize = 2;
            this.textBoxOFSolution7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSolution7.Location = new System.Drawing.Point(8, 321);
            this.textBoxOFSolution7.Multiline = false;
            this.textBoxOFSolution7.Name = "textBoxOFSolution7";
            this.textBoxOFSolution7.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxOFSolution7.PasswordChar = false;
            this.textBoxOFSolution7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOFSolution7.PlaceholderText = "Total a Pagar";
            this.textBoxOFSolution7.Size = new System.Drawing.Size(149, 35);
            this.textBoxOFSolution7.TabIndex = 2;
            this.textBoxOFSolution7.Texts = "";
            this.textBoxOFSolution7.UnderlinedStyle = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconButtonOFSolution3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1063, 366);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8);
            this.panel5.Size = new System.Drawing.Size(170, 74);
            this.panel5.TabIndex = 4;
            // 
            // iconButtonOFSolution3
            // 
            this.iconButtonOFSolution3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.iconButtonOFSolution3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.iconButtonOFSolution3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.iconButtonOFSolution3.BorderRadius = 32;
            this.iconButtonOFSolution3.BorderSize = 0;
            this.iconButtonOFSolution3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonOFSolution3.FlatAppearance.BorderSize = 0;
            this.iconButtonOFSolution3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOFSolution3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonOFSolution3.ForeColor = System.Drawing.Color.White;
            this.iconButtonOFSolution3.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.iconButtonOFSolution3.IconColor = System.Drawing.Color.White;
            this.iconButtonOFSolution3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOFSolution3.IconSize = 40;
            this.iconButtonOFSolution3.Location = new System.Drawing.Point(8, 8);
            this.iconButtonOFSolution3.Name = "iconButtonOFSolution3";
            this.iconButtonOFSolution3.Size = new System.Drawing.Size(154, 58);
            this.iconButtonOFSolution3.TabIndex = 37;
            this.iconButtonOFSolution3.Text = "Registrar";
            this.iconButtonOFSolution3.TextColor = System.Drawing.Color.White;
            this.iconButtonOFSolution3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOFSolution3.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idProducto,
            this.producto,
            this.cantidad,
            this.precioCompra,
            this.precioVenta,
            this.subtotal,
            this.btnEliminar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProductos.Location = new System.Drawing.Point(4, 4);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 49;
            this.dgvProductos.RowTemplate.Height = 30;
            this.dgvProductos.Size = new System.Drawing.Size(1059, 436);
            this.dgvProductos.TabIndex = 3;
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
            this.precioVenta.HeaderText = "precioVenta";
            this.precioVenta.MinimumWidth = 6;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            this.precioVenta.Visible = false;
            this.precioVenta.Width = 120;
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
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.textBoxOFSolution6);
            this.groupBox3.Controls.Add(this.textBoxOFSolution5);
            this.groupBox3.Controls.Add(this.iconButtonOFSolution1);
            this.groupBox3.Controls.Add(this.textBoxOFSolution4);
            this.groupBox3.Controls.Add(this.textBoxOFSolution3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1058, 95);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Producto";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 22);
            this.textBox2.TabIndex = 40;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(913, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 35);
            this.numericUpDown1.TabIndex = 38;
            // 
            // textBoxOFSolution6
            // 
            this.textBoxOFSolution6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOFSolution6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.textBoxOFSolution6.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxOFSolution6.BorderRadius = 15;
            this.textBoxOFSolution6.BorderSize = 2;
            this.textBoxOFSolution6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSolution6.Location = new System.Drawing.Point(736, 42);
            this.textBoxOFSolution6.Multiline = false;
            this.textBoxOFSolution6.Name = "textBoxOFSolution6";
            this.textBoxOFSolution6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxOFSolution6.PasswordChar = false;
            this.textBoxOFSolution6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOFSolution6.PlaceholderText = "Precio Venta";
            this.textBoxOFSolution6.Size = new System.Drawing.Size(153, 35);
            this.textBoxOFSolution6.TabIndex = 37;
            this.textBoxOFSolution6.Texts = "";
            this.textBoxOFSolution6.UnderlinedStyle = true;
            // 
            // textBoxOFSolution5
            // 
            this.textBoxOFSolution5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOFSolution5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.textBoxOFSolution5.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxOFSolution5.BorderRadius = 15;
            this.textBoxOFSolution5.BorderSize = 2;
            this.textBoxOFSolution5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSolution5.Location = new System.Drawing.Point(562, 42);
            this.textBoxOFSolution5.Multiline = false;
            this.textBoxOFSolution5.Name = "textBoxOFSolution5";
            this.textBoxOFSolution5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxOFSolution5.PasswordChar = false;
            this.textBoxOFSolution5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOFSolution5.PlaceholderText = "Precio Compra";
            this.textBoxOFSolution5.Size = new System.Drawing.Size(154, 35);
            this.textBoxOFSolution5.TabIndex = 36;
            this.textBoxOFSolution5.Texts = "";
            this.textBoxOFSolution5.UnderlinedStyle = true;
            // 
            // iconButtonOFSolution1
            // 
            this.iconButtonOFSolution1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.iconButtonOFSolution1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.iconButtonOFSolution1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.iconButtonOFSolution1.BorderRadius = 32;
            this.iconButtonOFSolution1.BorderSize = 0;
            this.iconButtonOFSolution1.FlatAppearance.BorderSize = 0;
            this.iconButtonOFSolution1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOFSolution1.ForeColor = System.Drawing.Color.White;
            this.iconButtonOFSolution1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButtonOFSolution1.IconColor = System.Drawing.Color.White;
            this.iconButtonOFSolution1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOFSolution1.IconSize = 25;
            this.iconButtonOFSolution1.Location = new System.Drawing.Point(496, 42);
            this.iconButtonOFSolution1.Name = "iconButtonOFSolution1";
            this.iconButtonOFSolution1.Size = new System.Drawing.Size(46, 35);
            this.iconButtonOFSolution1.TabIndex = 35;
            this.iconButtonOFSolution1.TextColor = System.Drawing.Color.White;
            this.iconButtonOFSolution1.UseVisualStyleBackColor = false;
            // 
            // textBoxOFSolution4
            // 
            this.textBoxOFSolution4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOFSolution4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.textBoxOFSolution4.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxOFSolution4.BorderRadius = 15;
            this.textBoxOFSolution4.BorderSize = 2;
            this.textBoxOFSolution4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSolution4.Location = new System.Drawing.Point(212, 42);
            this.textBoxOFSolution4.Multiline = false;
            this.textBoxOFSolution4.Name = "textBoxOFSolution4";
            this.textBoxOFSolution4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxOFSolution4.PasswordChar = false;
            this.textBoxOFSolution4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOFSolution4.PlaceholderText = "Producto";
            this.textBoxOFSolution4.Size = new System.Drawing.Size(262, 35);
            this.textBoxOFSolution4.TabIndex = 2;
            this.textBoxOFSolution4.Texts = "";
            this.textBoxOFSolution4.UnderlinedStyle = true;
            // 
            // textBoxOFSolution3
            // 
            this.textBoxOFSolution3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOFSolution3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.textBoxOFSolution3.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxOFSolution3.BorderRadius = 15;
            this.textBoxOFSolution3.BorderSize = 2;
            this.textBoxOFSolution3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSolution3.Location = new System.Drawing.Point(14, 42);
            this.textBoxOFSolution3.Multiline = false;
            this.textBoxOFSolution3.Name = "textBoxOFSolution3";
            this.textBoxOFSolution3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxOFSolution3.PasswordChar = false;
            this.textBoxOFSolution3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOFSolution3.PlaceholderText = "Codigo de Producto";
            this.textBoxOFSolution3.Size = new System.Drawing.Size(174, 35);
            this.textBoxOFSolution3.TabIndex = 1;
            this.textBoxOFSolution3.Texts = "";
            this.textBoxOFSolution3.UnderlinedStyle = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButtonOFSolution2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(1069, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(162, 95);
            this.panel4.TabIndex = 1;
            // 
            // iconButtonOFSolution2
            // 
            this.iconButtonOFSolution2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.iconButtonOFSolution2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.iconButtonOFSolution2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(228)))));
            this.iconButtonOFSolution2.BorderRadius = 32;
            this.iconButtonOFSolution2.BorderSize = 0;
            this.iconButtonOFSolution2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonOFSolution2.FlatAppearance.BorderSize = 0;
            this.iconButtonOFSolution2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOFSolution2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonOFSolution2.ForeColor = System.Drawing.Color.White;
            this.iconButtonOFSolution2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonOFSolution2.IconColor = System.Drawing.Color.White;
            this.iconButtonOFSolution2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOFSolution2.IconSize = 40;
            this.iconButtonOFSolution2.Location = new System.Drawing.Point(2, 2);
            this.iconButtonOFSolution2.Name = "iconButtonOFSolution2";
            this.iconButtonOFSolution2.Size = new System.Drawing.Size(158, 91);
            this.iconButtonOFSolution2.TabIndex = 37;
            this.iconButtonOFSolution2.Text = "Agregar Producto";
            this.iconButtonOFSolution2.TextColor = System.Drawing.Color.White;
            this.iconButtonOFSolution2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOFSolution2.UseVisualStyleBackColor = false;
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
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Compra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
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
            this.groupBox1.Controls.Add(this.dateTimePickerOFSolution1);
            this.groupBox1.Controls.Add(this.comboBoxOFSolution1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 23);
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
            // dateTimePickerOFSolution1
            // 
            this.dateTimePickerOFSolution1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePickerOFSolution1.BorderSize = 0;
            this.dateTimePickerOFSolution1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTimePickerOFSolution1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOFSolution1.Location = new System.Drawing.Point(14, 42);
            this.dateTimePickerOFSolution1.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePickerOFSolution1.Name = "dateTimePickerOFSolution1";
            this.dateTimePickerOFSolution1.Size = new System.Drawing.Size(183, 35);
            this.dateTimePickerOFSolution1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.dateTimePickerOFSolution1.TabIndex = 2;
            this.dateTimePickerOFSolution1.TextColor = System.Drawing.Color.White;
            // 
            // comboBoxOFSolution1
            // 
            this.comboBoxOFSolution1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.comboBoxOFSolution1.BorderSize = 1;
            this.comboBoxOFSolution1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxOFSolution1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxOFSolution1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxOFSolution1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxOFSolution1.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxOFSolution1.Location = new System.Drawing.Point(216, 42);
            this.comboBoxOFSolution1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxOFSolution1.Name = "comboBoxOFSolution1";
            this.comboBoxOFSolution1.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxOFSolution1.Size = new System.Drawing.Size(258, 35);
            this.comboBoxOFSolution1.TabIndex = 1;
            this.comboBoxOFSolution1.Texts = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBoxOFSolution2);
            this.groupBox2.Controls.Add(this.textBoxOFSolution1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(505, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Proveedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
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
            this.btnBuscar.Location = new System.Drawing.Point(496, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 35);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBoxOFSolution2
            // 
            this.textBoxOFSolution2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOFSolution2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.textBoxOFSolution2.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxOFSolution2.BorderRadius = 15;
            this.textBoxOFSolution2.BorderSize = 2;
            this.textBoxOFSolution2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSolution2.Location = new System.Drawing.Point(212, 42);
            this.textBoxOFSolution2.Multiline = false;
            this.textBoxOFSolution2.Name = "textBoxOFSolution2";
            this.textBoxOFSolution2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxOFSolution2.PasswordChar = false;
            this.textBoxOFSolution2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOFSolution2.PlaceholderText = "Razón Social";
            this.textBoxOFSolution2.Size = new System.Drawing.Size(256, 35);
            this.textBoxOFSolution2.TabIndex = 1;
            this.textBoxOFSolution2.Texts = "";
            this.textBoxOFSolution2.UnderlinedStyle = true;
            // 
            // textBoxOFSolution1
            // 
            this.textBoxOFSolution1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOFSolution1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.textBoxOFSolution1.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxOFSolution1.BorderRadius = 15;
            this.textBoxOFSolution1.BorderSize = 2;
            this.textBoxOFSolution1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOFSolution1.Location = new System.Drawing.Point(18, 42);
            this.textBoxOFSolution1.Multiline = false;
            this.textBoxOFSolution1.Name = "textBoxOFSolution1";
            this.textBoxOFSolution1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxOFSolution1.PasswordChar = false;
            this.textBoxOFSolution1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOFSolution1.PlaceholderText = "N° de Documento";
            this.textBoxOFSolution1.Size = new System.Drawing.Size(185, 35);
            this.textBoxOFSolution1.TabIndex = 0;
            this.textBoxOFSolution1.Texts = "";
            this.textBoxOFSolution1.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 729);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 2);
            this.panel1.TabIndex = 0;
            // 
            // formCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1261, 741);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "formCompras";
            this.Text = "formCompras";
            this.panelPrincipal.ResumeLayout(false);
            this.panelCentrado.ResumeLayout(false);
            this.panelOFSolution1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelPrincipal;
        private Panel panelCentrado;
        private Componentes_Personalizad.PanelOFSolution panelOFSolution1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel7;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Componentes_Personalizad.ComboBoxOFSolution comboBoxOFSolution1;
        private TextBox textBox1;
        private Componentes_Personalizad.TextBoxOFSolution textBoxOFSolution2;
        private Componentes_Personalizad.TextBoxOFSolution textBoxOFSolution1;
        private Label label3;
        private Label label2;
        private Componentes_Personalizad.DateTimePickerOFSolution dateTimePickerOFSolution1;
        private Panel panel6;
        private DataGridView dgvProductos;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewButtonColumn btnEliminar;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox groupBox3;
        private Componentes_Personalizad.IconButtonOFSolution btnBuscar;
        private Componentes_Personalizad.TextBoxOFSolution textBoxOFSolution6;
        private Componentes_Personalizad.TextBoxOFSolution textBoxOFSolution5;
        private Componentes_Personalizad.IconButtonOFSolution iconButtonOFSolution1;
        private Componentes_Personalizad.TextBoxOFSolution textBoxOFSolution4;
        private Componentes_Personalizad.TextBoxOFSolution textBoxOFSolution3;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Label label4;
        private Panel panel4;
        private Componentes_Personalizad.IconButtonOFSolution iconButtonOFSolution2;
        private Panel panel5;
        private Componentes_Personalizad.IconButtonOFSolution iconButtonOFSolution3;
        private Panel panel8;
        private Componentes_Personalizad.TextBoxOFSolution textBoxOFSolution7;
    }

}