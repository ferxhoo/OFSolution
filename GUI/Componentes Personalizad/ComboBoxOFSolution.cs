#region Importaciones necesarias
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;
#endregion

namespace GUI.Componentes_Personalizad
{

    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class ComboBoxOFSolution : UserControl
    {
        #region Campos de Componente
        private Color backColor = Color.FromArgb(255, 255, 255);
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.FromArgb(23, 145, 200);
        private int borderSize = 1;
        #endregion

        #region Componentes 
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;
        #endregion

        #region Propiedades 

        #region Propiedades Personalizadas
        [Category("Propiedades Personalizadas")]
        public new Color BackColor
        {
            get => backColor;
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
                cmbList.BackColor = listBackColor;
                this.Invalidate(); // Redibujar el control para reflejar el nuevo color de fondo
            }
        }

        [Category("Propiedades Personalizadas")]
        public Color IconColor { get => iconColor; set { iconColor = value; this.Invalidate(); /* Redibujar icono */ } }

        [Category("Propiedades Personalizadas")]
        public Color ListBackColor { get => listBackColor; set { listBackColor = value; cmbList.BackColor = listBackColor; } }

        [Category("Propiedades Personalizadas")]
        public Color ListTextColor { get => listTextColor; set { listTextColor = value; cmbList.ForeColor = listTextColor; } }

        [Category("Propiedades Personalizadas")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate(); // Redibujar el control para reflejar el nuevo color del borde
            }
        }

        [Category("Propiedades Personalizadas")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }

        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; lblText.ForeColor = value; } }

        public override Font Font { get => base.Font; set { base.Font = value; lblText.Font = value; cmbList.Font = value; } }

        [Category("Propiedades Personalizadas")]
        public string Texts { get => lblText.Text; set { lblText.Text = value; } }

        [Category("Propiedades Personalizadas")]
        public ComboBoxStyle DropDownStyle
        {
            get => cmbList.DropDownStyle;
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }
        #endregion

        #region Propiedades de datos
        [Category("Data Propiedades Personalizadas")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items { get => cmbList.Items; }

        [Category("Data Propiedades Personalizadas")]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource { get => cmbList.DataSource; set { cmbList.DataSource = value; } }

        [Category("Data Propiedades Personalizadas")]
        [DefaultValue("")]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string DisplayMember { get => cmbList.DisplayMember; set { cmbList.DisplayMember = value; } }

        [Category("Data Propiedades Personalizadas")]
        [DefaultValue("")]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string ValueMember { get => cmbList.ValueMember; set { cmbList.ValueMember = value; } }

        [Category("Data Propiedades Personalizadas")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteStringCollection AutoCompleteCustomSource { get => cmbList.AutoCompleteCustomSource; set { cmbList.AutoCompleteCustomSource = value; } }

        [Category("Data Propiedades Personalizadas")]
        [DefaultValue(AutoCompleteSource.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource { get => cmbList.AutoCompleteSource; set { cmbList.AutoCompleteSource = value; } }

        [Category("Data Propiedades Personalizadas")]
        [DefaultValue(AutoCompleteMode.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode { get => cmbList.AutoCompleteMode; set { cmbList.AutoCompleteMode = value; } }

        [Category("Data Propiedades Personalizadas")]
        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem { get => cmbList.SelectedItem; set { cmbList.SelectedItem = value; } }

        [Category("Data Propiedades Personalizadas")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => cmbList.SelectedIndex;
            set
            {
                if (cmbList.Items.Count > 0) // Ensure there are items before setting the index
                {
                    cmbList.SelectedIndex = value;
                }
            }
        }

        #endregion

        #endregion

        #region Configuracion Inicial del ComboBox
        public ComboBoxOFSolution()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            // Configuración del ComboBox (lista desplegable)
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); // Evento por defecto
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged); // Refrescar texto

            // Configuración del botón (icono)
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click); // Abrir lista desplegable
            btnIcon.Paint += new PaintEventHandler(Icon_Paint); // Dibujar icono

            // Configuración de la etiqueta (texto)
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            // Asociar eventos de la etiqueta al control de usuario
            lblText.Click += new EventHandler(Surface_Click); // Seleccionar ComboBox
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            // Configuración del control de usuario
            this.Controls.Add(lblText); // Añadir etiqueta
            this.Controls.Add(btnIcon); // Añadir botón
            this.Controls.Add(cmbList); // Añadir ComboBox
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize); // Tamaño del borde
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }
        #endregion

        #region Metodos
        // Métodos privados
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }
        #endregion

        #region Eventos

        public event EventHandler OnSelectedIndexChanged; // Evento por defecto

        // Evento por defecto
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            // Refrescar texto
            lblText.Text = cmbList.Text;
        }

        // Acción del botón
        private void Icon_Click(object sender, EventArgs e)
        {
            // Abrir lista desplegable
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            // Seleccionar ComboBox
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true; // Abrir lista desplegable
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            // Refrescar texto
            lblText.Text = cmbList.Text;
        }

        // Asociar eventos de la etiqueta al control de usuario
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        // Métodos sobrescritos
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

        #region evento de dibujo
        // Dibujar icono
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            // Campos
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;
            // Dibujar icono de flecha hacia abajo
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Dibujar el borde
                if (borderSize >= 1)
                {
                    var rectBorder = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                    e.Graphics.DrawRectangle(penBorder, rectBorder);
                }
            }
        }
        #endregion

        #endregion

    }

}
