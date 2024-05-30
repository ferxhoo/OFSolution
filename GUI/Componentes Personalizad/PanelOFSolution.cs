using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Componentes_Personalizad
{
    public class PanelOFSolution : Panel
    {
        // Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        // Properties
        [Category("Propiedades Personalizadas")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Propiedades Personalizadas")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("Propiedades Personalizadas")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Propiedades Personalizadas")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        // Constructor
        public PanelOFSolution()
        {
            this.Resize += new EventHandler(Panel_Resize);
        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
            {
                BorderRadius = this.Height;
            }
        }

        // Methods
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(0.5F, 0.5F, this.Width - 1F, this.Height - 1F);

            if (borderRadius > 2) // Rounded panel
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Panel surface
                    this.Region = new Region(pathSurface);
                    // Draw surface border for HD result
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    // Panel border
                    if (borderSize >= 1)
                    {
                        // Draw control border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // Normal panel
            {
                // Panel surface
                this.Region = new Region(rectSurface);
                // Panel border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            this.Invalidate();
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
