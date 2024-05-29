using ENTITY;
using FontAwesome.Sharp;
using GUI.Componentes_Personalizad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formMenuPrincipal : Form
    {

        private static Usuario usuarioActual;

        #region propiedades graficas

        #region propiedades de botones de menu
        private IconButton currentBtn;
        private Form currentFormSecundario;
        private Color borderLeftColor = Color.Transparent;
        // Almacenar los colores originales de los botones
        private Dictionary<IconButton, Color> originalColors = new Dictionary<IconButton, Color>();
        #endregion

        #region redimencionamiento
        private MenuSnapAsisstOFSolution menuSnap;

        // Constantes para el redimensionamiento
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int HTCAPTION = 2;
        private const int HTCLIENT = 1;
        private const int WM_NCHITTEST = 0x84;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        #endregion

        #endregion

        #region Configuracion Inicial del menu
        public formMenuPrincipal(Usuario usuarioLogueado)
        {
            InitializeComponent();

            usuarioActual = usuarioLogueado;
            
            customizeDesing();

            // Inicializar menuSnap
            menuSnap = new MenuSnapAsisstOFSolution(this);

            // Asignar el evento Paint a los botones del menú principal
            AssignPaintEventToMenuButtons();
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #endregion

        #region barra de titulos y redimensionamiento
        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            // Calcular la posición para mostrar el menú en la parte inferior del botón
            Point menuPosition = btnMaximizar.PointToScreen(new Point(0, btnMaximizar.Height));
            menuSnap.ShowMenu(this, menuPosition);

            // Detener el temporizador si está en ejecución
            menuSnap.StopCloseMenuTimer();
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            menuSnap.StartCloseMenuTimer();
        }

        private void formMenuPrincipal_Resize(object sender, EventArgs e)
        {
            if (menuSnap.IsMenuVisible())
            {
                // Calcular la nueva posición del menú
                Point menuPosition = btnMaximizar.PointToScreen(new Point(0, btnMaximizar.Height));
                menuSnap.UpdateMenuPosition(menuPosition);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTituloMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Llamar al método de arrastrar ventana
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if ((int)m.Result == HTCLIENT)
                {
                    Point screenPoint = new Point(m.LParam.ToInt32());
                    Point clientPoint = this.PointToClient(screenPoint);

                    if (clientPoint.X <= RESIZE_HANDLE_SIZE && clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (clientPoint.X >= this.ClientSize.Width - RESIZE_HANDLE_SIZE && clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (clientPoint.X <= RESIZE_HANDLE_SIZE && clientPoint.Y >= this.ClientSize.Height - RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else if (clientPoint.X >= this.ClientSize.Width - RESIZE_HANDLE_SIZE && clientPoint.Y >= this.ClientSize.Height - RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTLEFT;
                    else if (clientPoint.X >= this.ClientSize.Width - RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTRIGHT;
                    else if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTTOP;
                    else if (clientPoint.Y >= this.ClientSize.Height - RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTBOTTOM;
                }

                return;
            }

            base.WndProc(ref m);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.M))
            {
                btnMaximizar_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.N))
            {
                btnMinimizar_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Left))
            {
                menuSnap.ButtonLeft_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Right))
            {
                menuSnap.ButtonRight_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D1))
            {
                menuSnap.ButtonQuarterTopLeftScreen_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D2))
            {
                menuSnap.ButtonQuarterTopRightScreen_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D3))
            {
                menuSnap.ButtonQuarterLeftScreen_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D4))
            {
                menuSnap.ButtonQuarterRightScreen_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                this.Size = new Size(1100, 650);
                this.CenterToScreen();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region menudesplegable
        private void customizeDesing()
        {
            panelFacturas.Visible = false;
            panelReportes.Visible = false;
            panelAjustes.Visible = false;
            panelCompras.Visible = false;
            panelVentas.Visible = false;
        }

        private void hideSubmenu()
        {
            panelFacturas.Visible = false;
            panelReportes.Visible = false;
            panelAjustes.Visible = false;
            panelCompras.Visible = false;
            panelVentas.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            hideSubmenu(); // Oculta todos los submenús antes de mostrar el submenú deseado

            if (!subMenu.Visible)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void AdjustPanelFacturaSize()
        {
            // Si ninguno de los paneles de compras o ventas es visible
            // Ajustar el tamaño del panel de facturas para que quepa el espacio de los botones más una separación
            int buttonWidth = btnVentas.Width + btnCompras.Width;
            int buttonHeight = btnVentas.Height + btnCompras.Height;
            int separation = 10; // Separación entre botones
            int totalWidth = 2 * buttonWidth + separation; // Ancho total del panel
            int totalHeight = buttonHeight + separation; // Alto total del panel

            if (!panelCompras.Visible && !panelVentas.Visible)
            {
                panelFacturas.Size = new Size(totalWidth, totalHeight);
            }
            else
            {
                // Si alguno de los paneles de compras o ventas es visible
                // Ajustar el tamaño del panel de facturas para que coincida con el tamaño del panel
                panelFacturas.Size = new Size(totalWidth + 197, totalHeight + 87);
            }
        }
        #endregion

        #region diseño de activacion y desactivacion de botones de menu
        private void AssignPaintEventToMenuButtons()
        {
            btnProductos.Paint += new PaintEventHandler(this.Button_Paint);
            btnFacturas.Paint += new PaintEventHandler(this.Button_Paint);
            btnReportes.Paint += new PaintEventHandler(this.Button_Paint);
            btnAjustes.Paint += new PaintEventHandler(this.Button_Paint);
            btnClientes.Paint += new PaintEventHandler(this.Button_Paint);
            btnProveedores.Paint += new PaintEventHandler(this.Button_Paint);
            btnSobreMi.Paint += new PaintEventHandler(this.Button_Paint);
            btnVentas.Paint += new PaintEventHandler(this.Button_Paint);
            btnCompras.Paint += new PaintEventHandler(this.Button_Paint);
            btnRegistrarVenta.Paint += new PaintEventHandler(this.Button_Paint);
            btnVerDetalleVenta.Paint += new PaintEventHandler(this.Button_Paint);
            btnRegistrarCompra.Paint += new PaintEventHandler(this.Button_Paint);
            btnVerDetalleCompra.Paint += new PaintEventHandler(this.Button_Paint);
            btnReportesPorVenta.Paint += new PaintEventHandler(this.Button_Paint);
            btnReportesPorCompras.Paint += new PaintEventHandler(this.Button_Paint);
            btnCategorias.Paint += new PaintEventHandler(this.Button_Paint);
            btnMeseros.Paint += new PaintEventHandler(this.Button_Paint);
            btnUsuarios.Paint += new PaintEventHandler(this.Button_Paint);
            btnNegocio.Paint += new PaintEventHandler(this.Button_Paint);
        }

        private void Button_Paint(object sender, PaintEventArgs e)
        {
            IconButton btn = sender as IconButton;
            if (btn != null && btn == currentBtn)
            {
                using (Pen pen = new Pen(borderLeftColor, 10))
                {
                    e.Graphics.DrawLine(pen, 0, 0, 0, btn.Height);
                }
            }
        }

        private void ActivateButton(IconButton senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                // Desactivar el botón anterior
                DisableButton();

                // Activar el nuevo botón
                currentBtn = senderBtn;

                // Almacenar el color original si no ha sido almacenado antes
                if (!originalColors.ContainsKey(currentBtn))
                {
                    originalColors[currentBtn] = currentBtn.BackColor;
                }

                // Establecer el color del borde izquierdo
                borderLeftColor = color;

                // Ajustar el padding para dejar espacio al borde izquierdo
                currentBtn.Padding = new Padding(10, 0, 0, 0); // 10 píxeles de padding a la izquierda
                currentBtn.BackColor = Color.FromArgb(37, 36, 81); // Establecer el color de fondo
                currentBtn.ForeColor = color; // Color del texto
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color; // Color del icono
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Redibujar el botón para aplicar el borde izquierdo
                currentBtn.Invalidate();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                // Restaurar el color original del botón
                currentBtn.BackColor = originalColors[currentBtn];
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private struct RGBColors
        {
            public static Color ColorSeleccion = Color.FromArgb(24, 161, 251);
        }

        private void OpenFormSecundario(Form formSecundario)
        {
            if (currentFormSecundario != null)
            {
                // Cierra el formulario secundario actual si está abierto
                currentFormSecundario.Close();
            }
            currentFormSecundario = formSecundario;
            formSecundario.TopLevel = false;
            formSecundario.FormBorderStyle = FormBorderStyle.None;
            formSecundario.Dock = DockStyle.Fill;
            panelVistaFormularios.Controls.Add(formSecundario);
            panelVistaFormularios.Tag = formSecundario;
            formSecundario.BringToFront();
            formSecundario.Show();
        }
        #endregion

        #region eventos click de botones de menu
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProductos, RGBColors.ColorSeleccion);
            hideSubmenu();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            ActivateButton(btnFacturas, RGBColors.ColorSeleccion);
            showSubmenu(panelFacturas);
            AdjustPanelFacturaSize();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            panelVentas.Visible = true;
            panelCompras.Visible = false;
            ActivateButton(btnVentas, RGBColors.ColorSeleccion);
            AdjustPanelFacturaSize();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            ActivateButton(btnRegistrarVenta, RGBColors.ColorSeleccion);
        }

        private void btnVerDetalleVenta_Click(object sender, EventArgs e)
        {
            ActivateButton(btnVerDetalleVenta, RGBColors.ColorSeleccion);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCompras, RGBColors.ColorSeleccion);
            panelVentas.Visible = false;
            panelCompras.Visible = true;
            AdjustPanelFacturaSize();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            ActivateButton(btnRegistrarCompra, RGBColors.ColorSeleccion);
        }

        private void btnVerDetalleCompra_Click(object sender, EventArgs e)
        {
            ActivateButton(btnVerDetalleCompra, RGBColors.ColorSeleccion);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(btnClientes, RGBColors.ColorSeleccion);
            hideSubmenu();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProveedores, RGBColors.ColorSeleccion);
            hideSubmenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReportes, RGBColors.ColorSeleccion);
            showSubmenu(panelReportes);
        }

        private void btnReportesPorVenta_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReportesPorVenta, RGBColors.ColorSeleccion);
        }

        private void btnReportesPorCompras_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReportesPorCompras, RGBColors.ColorSeleccion);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAjustes, RGBColors.ColorSeleccion);
            showSubmenu(panelAjustes);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCategorias, RGBColors.ColorSeleccion);
        }

        private void btnMeseros_Click(object sender, EventArgs e)
        {
            ActivateButton(btnMeseros, RGBColors.ColorSeleccion);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(btnUsuarios, RGBColors.ColorSeleccion);
        }

        private void btnNegocio_Click(object sender, EventArgs e)
        {
            ActivateButton(btnNegocio, RGBColors.ColorSeleccion);
        }

        private void btnSobreMi_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSobreMi, RGBColors.ColorSeleccion);
        }

        #endregion

        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = usuarioActual.nombreCompleto;
        }
    }
}
