#region Importaciones necesarias
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
#endregion

namespace GUI.Componentes_Personalizad
{
    public class ButtonOFSolution : Button
    {
        #region Campos de Componente
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.FromArgb(108, 196, 228);
        #endregion

        #region Propiedades de Componente
        [Category("Propiedades Personalizadas")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        [Category("Propiedades Personalizadas")]
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }

        [Category("Propiedades Personalizadas")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }

        [Category("Propiedades Personalizadas")]
        public Color BackgroundColor { get { return this.BackColor; } set { this.BackColor = value; } }

        [Category("Propiedades Personalizadas")]
        public Color TextColor { get { return this.ForeColor; } set { this.ForeColor = value; } }
        #endregion

        #region Configuracion Inicial del boton
        public ButtonOFSolution()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }
        #endregion

        #region Metodos
        // Método que ajusta el radio del borde
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
            {
                BorderRadius = this.Height;
            }
        }

        // Método para obtener la ruta de la figura con bordes redondeados
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float scale = radius * 0.9F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, scale, scale, 180, 90);
            path.AddArc(rect.Width - scale, rect.Y, scale, scale, 270, 90);
            path.AddArc(rect.Width - scale, rect.Height - scale, scale, scale, 0, 90);
            path.AddArc(rect.X, rect.Height - scale, scale, scale, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Método sobrescrito para pintar el botón
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 1F, this.Height - 1F);

            if (borderRadius > 2) // Botón redondeado
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Superficie del botón
                    this.Region = new Region(pathSurface);
                    // Dibujar borde de la superficie para un resultado HD
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    // Borde del botón
                    if (borderSize >= 1)
                    {
                        // Dibujar borde del control
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // Botón normal
            {
                // Superficie del botón
                this.Region = new Region(rectSurface);
                // Borde del botón
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        #endregion

        #region Eventos Personalizados
        // Evento para manejar la creación del control
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        // Evento para manejar cambios en el color de fondo
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            this.Invalidate();
        }

        // Evento para manejar cambios en el color de texto
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            this.Invalidate();
        }

        // Evento para manejar cambios en el color de fondo del contenedor
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion
    }
}
