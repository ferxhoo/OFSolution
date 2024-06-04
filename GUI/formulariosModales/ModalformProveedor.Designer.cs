namespace GUI.formulariosModales
{
    partial class ModalformProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBusqueda = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.btnLimpiarBusqueda = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.btnBuscar = new GUI.Componentes_Personalizad.IconButtonOFSolution();
            this.txtBuscar = new GUI.Componentes_Personalizad.TextBoxOFSolution();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelOFSolution1 = new GUI.Componentes_Personalizad.PanelOFSolution();
            this.panel14.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.panel8.SuspendLayout();
            this.panelOFSolution1.SuspendLayout();
            this.SuspendLayout();
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
            // documento
            // 
            this.documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documento.FillWeight = 140F;
            this.documento.HeaderText = "N° Documento";
            this.documento.MinimumWidth = 140;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCompleto.FillWeight = 120F;
            this.nombreCompleto.HeaderText = "Nombre Completo";
            this.nombreCompleto.MinimumWidth = 120;
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razonSocial.FillWeight = 130F;
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.MinimumWidth = 130;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
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
            this.label10.Text = "Lista de Proveedores";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 565);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvProveedores, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 545);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idProveedor,
            this.documento,
            this.nombreCompleto,
            this.razonSocial});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedores.Location = new System.Drawing.Point(23, 112);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidth = 49;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProveedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvProveedores.RowTemplate.Height = 30;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(736, 430);
            this.dgvProveedores.TabIndex = 3;
            this.dgvProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProveedores_CellPainting);
            // 
            // idProveedor
            // 
            this.idProveedor.HeaderText = "idProveedor";
            this.idProveedor.MinimumWidth = 6;
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            this.idProveedor.Visible = false;
            this.idProveedor.Width = 120;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tableLayoutPanel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(782, 545);
            this.panel8.TabIndex = 2;
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
            this.panelOFSolution1.Location = new System.Drawing.Point(0, 0);
            this.panelOFSolution1.Name = "panelOFSolution1";
            this.panelOFSolution1.Size = new System.Drawing.Size(782, 585);
            this.panelOFSolution1.TabIndex = 2;
            // 
            // ModalformProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 585);
            this.Controls.Add(this.panelOFSolution1);
            this.MaximumSize = new System.Drawing.Size(800, 630);
            this.MinimumSize = new System.Drawing.Size(800, 630);
            this.Name = "ModalformProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalformProveedor";
            this.Load += new System.EventHandler(this.ModalformProveedor_Load);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panelOFSolution1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.Label label11;
        private Componentes_Personalizad.ComboBoxOFSolution cmbBusqueda;
        private Componentes_Personalizad.IconButtonOFSolution btnLimpiarBusqueda;
        private Componentes_Personalizad.IconButtonOFSolution btnBuscar;
        private Componentes_Personalizad.TextBoxOFSolution txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.Panel panel8;
        private Componentes_Personalizad.PanelOFSolution panelOFSolution1;
    }
}