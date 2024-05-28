using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Componentes_Personalizad
{
    [DefaultEvent("PersonalizeTextChanged")]
    public partial class TextBoxOFSolution : UserControl
    {
        #region Campos de Componente
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.Red;
        private bool isFocused = false;
        private int borderRadius = 15;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        #endregion

        #region Configuracion Inicial
        public TextBoxOFSolution()
        {
            InitializeComponent();
            textBox.Enter += textBox_Enter;
            textBox.Leave += textBox_Leave;
        }
        #endregion

        #region Propiedades Personalizadas
        [Category("Propiedades Personalizadas")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }

        [Category("Propiedades Personalizadas")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        [Category("Propiedades Personalizadas")]
        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }

        [Category("Propiedades Personalizadas")]
        public bool PasswordChar { get => isPasswordChar; set { isPasswordChar = value; textBox.UseSystemPasswordChar = value; } }

        [Category("Propiedades Personalizadas")]
        public bool Multiline { get => textBox.Multiline; set { textBox.Multiline = value; } }

        [Category("Propiedades Personalizadas")]
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; textBox.BackColor = value; } }

        [Category("Propiedades Personalizadas")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; textBox.ForeColor = value; } }

        [Category("Propiedades Personalizadas")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Propiedades Personalizadas")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox.Text;
            }
            set
            {
                textBox.Text = value;
                SetPlaceholder();
            }
        }

        [Category("Propiedades Personalizadas")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        [Category("Propiedades Personalizadas")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Propiedades Personalizadas")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set
            {
                placeholderColor = value;
                if (isPasswordChar)
                    textBox.ForeColor = value;
            }
        }

        [Category("Propiedades Personalizadas")]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                textBox.Text = "";
                SetPlaceholder();
            }
        }
        #endregion

        #region Métodos privados
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox.Text = placeholderText;
                textBox.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox.Text = "";
                textBox.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox.UseSystemPasswordChar = true;
            }
        }
        #endregion


        #region Métodos sobrescritos
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1) // TextBox con bordes redondeados
            {
                // Campos
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth); // Establecer la región redondeada del UserControl
                    if (borderRadius > 15) SettextBoxRegion(); // Establecer la región redondeada del componente TextBox
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle) // Estilo subrayado
                    {
                        // Dibujar borde suave
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        // Dibujar borde
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else // Estilo normal
                    {
                        // Dibujar borde suave
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        // Dibujar borde
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // TextBox normal
            {
                // Dibujar borde
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;

                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle) // Estilo subrayado
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else // Estilo normal
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void SettextBoxRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox.ClientRectangle, borderRadius - borderSize);
                textBox.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox.ClientRectangle, borderSize * 2);
                textBox.Region = new Region(pathTxt);
            }
        }
        
        // Método para redondear
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        #endregion

        #region Eventos del Control de Usuario
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
        }

        // Método privado
        private void UpdateControlHeight()
        {
            if (textBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox.Multiline = true;
                textBox.MinimumSize = new Size(0, txtHeight);
                textBox.Multiline = false;

                this.Height = textBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        #endregion

        #region Eventos del TextBox

        // Evento
        public event EventHandler PersonalizeTextChanged;

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (PersonalizeTextChanged != null)
                PersonalizeTextChanged.Invoke(sender, e);
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            textBox.Focus();
        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion
    }
}
