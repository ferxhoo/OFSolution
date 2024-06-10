using BLL;
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

        private IconButton currentBtn = null;
        private Form currentFormSecundario = null;
        private Color borderLeftColor = Color.Transparent;

        private Dictionary<IconButton, Color> originalColors = new Dictionary<IconButton, Color>();

        private MenuSnapAsisstOFSolution menuSnap;

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
        public formMenuPrincipal(Usuario usuarioLogueado)
        //public formMenuPrincipal(Usuario usuarioLogueado = null)
        {

            InitializeComponent();
            this.DoubleBuffered = true;

            //if (usuarioLogueado == null)
            //    usuarioActual = new Usuario() { nombreCompleto = "User Root", idUsuario = 1 };
            //else usuarioActual = usuarioActual = usuarioLogueado;

            usuarioActual = usuarioLogueado;

            customizeDesing();

            menuSnap = new MenuSnapAsisstOFSolution(this);

            AssignPaintEventToMenuButtons();
            
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.FormClosing += new FormClosingEventHandler(formMenuPrincipal_FormClosing);
        }

        private void formMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentFormSecundario is formVentas ventasForm && ventasForm.HasUnsavedChanges())
            {
                var result = MessageBox.Show("Hay cambios no guardados en el formulario de ventas. ¿Desea revertir los cambios antes de salir?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    ventasForm.RevertirCambios();
                    
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; 
                }
            }

            if (currentFormSecundario is formCompras comprasForm && comprasForm.HasUnsavedChanges())
            {
                var result = MessageBox.Show("Hay cambios no guardados en el formulario de ventas. ¿Desea revertir los cambios antes de salir?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    comprasForm.RevertirCambios();

                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Cancelar el cierre del formulario principal
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActivateButton(IconButton senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = senderBtn;

                if (!originalColors.ContainsKey(currentBtn))
                {
                    originalColors[currentBtn] = currentBtn.BackColor;
                }

                borderLeftColor = color;

                currentBtn.Padding = new Padding(10, 0, 0, 0); 
                currentBtn.BackColor = Color.FromArgb(37, 36, 81); 
                currentBtn.ForeColor = color; 
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color; 
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                currentBtn.Invalidate();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
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
            if (currentFormSecundario is formVentas ventasForm && ventasForm.HasUnsavedChanges())
            {
                var result = MessageBox.Show("¿Desea salir sin guardar? Se revertirán los cambios realizados.", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    ventasForm.RevertirCambios();
                }
                else
                {
                    ActivateButton(btnRegistrarVenta, RGBColors.ColorSeleccion);
                    panelFacturas.Visible = true;
                    panelVentas.Visible = true;
                    panelCompras.Visible = false;
                    panelReportes.Visible = false;
                    panelAjustes.Visible = false;
                    return; 
                }
            }

            if (currentFormSecundario is formCompras comprasForm && comprasForm.HasUnsavedChanges())
            {
                var result = MessageBox.Show("¿Desea salir sin guardar? Se revertirán los cambios realizados.", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    comprasForm.RevertirCambios();
                }
                else
                {
                    ActivateButton(btnRegistrarCompra, RGBColors.ColorSeleccion);
                    panelFacturas.Visible = true;
                    panelVentas.Visible = false;
                    panelCompras.Visible = true;
                    panelReportes.Visible = false;
                    panelAjustes.Visible = false;
                    return; 
                }
            }

            if (currentFormSecundario != null)
            {
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

        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {
            List<Permiso> permisos = new ServicioPermiso().Listar(usuarioActual.idUsuario);
            List<IconButton> btnMenu = botonesMenu();
            foreach (IconButton item in btnMenu)
            {
                bool encontrado = permisos.Any(p => p.nombreMenu == item.Name);

                if (!encontrado)
                {
                    item.Visible = false;
                }
            }

            lblNombreUsuario.Text = usuarioActual.nombreCompleto;
        }

        public List<IconButton> botonesMenu()
        {
            List<IconButton> listaBotones = new List<IconButton>();

            listaBotones.Add(btnProductos);
            listaBotones.Add(btnFacturas);
            listaBotones.Add(btnClientes);
            listaBotones.Add(btnProveedores);
            listaBotones.Add(btnReportes);
            listaBotones.Add(btnAjustes);
            listaBotones.Add(btnSobreMi);

            return listaBotones;
        }

        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            Point menuPosition = btnMaximizar.PointToScreen(new Point(0, btnMaximizar.Height));
            menuSnap.ShowMenu(this, menuPosition);

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
                Point menuPosition = btnMaximizar.PointToScreen(new Point(0, btnMaximizar.Height));
                menuSnap.UpdateMenuPosition(menuPosition);
            }
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
                this.Size = new Size(1500, 820);
                this.CenterToScreen();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

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
            hideSubmenu(); 

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
            int buttonWidth = btnVentas.Width + btnCompras.Width;
            int buttonHeight = btnVentas.Height + btnCompras.Height;
            int separation = 10;
            int totalWidth = 2 * buttonWidth + separation;
            int totalHeight = buttonHeight + separation; 

            if (!panelCompras.Visible && !panelVentas.Visible)
            {
                panelFacturas.Size = new Size(totalWidth, totalHeight);
            }
            else
            {
                panelFacturas.Size = new Size(totalWidth + 197, totalHeight + 87);
            }
        }
        
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
         
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProductos, RGBColors.ColorSeleccion);
            hideSubmenu();
            OpenFormSecundario(new formProductos());
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
            OpenFormSecundario(new formVentas(usuarioActual));
        }

        private void btnVerDetalleVenta_Click(object sender, EventArgs e)
        {
            ActivateButton(btnVerDetalleVenta, RGBColors.ColorSeleccion);
            OpenFormSecundario(new formVerDetallesVenta());
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
            OpenFormSecundario(new formCompras(usuarioActual));
        }

        private void btnVerDetalleCompra_Click(object sender, EventArgs e)
        {
            ActivateButton(btnVerDetalleCompra, RGBColors.ColorSeleccion);
            OpenFormSecundario(new formVerDetallesCompra());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(btnClientes, RGBColors.ColorSeleccion);
            hideSubmenu();
            OpenFormSecundario(new formClientes());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProveedores, RGBColors.ColorSeleccion);
            hideSubmenu();
            OpenFormSecundario(new formProveedores());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReportes, RGBColors.ColorSeleccion);
            showSubmenu(panelReportes);
        }

        private void btnReportesPorVenta_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReportesPorVenta, RGBColors.ColorSeleccion);
            OpenFormSecundario(new formReporteVentas());
        }

        private void btnReportesPorCompras_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReportesPorCompras, RGBColors.ColorSeleccion);
            OpenFormSecundario(new formReporteCompras());
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAjustes, RGBColors.ColorSeleccion);
            showSubmenu(panelAjustes);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCategorias, RGBColors.ColorSeleccion);
            OpenFormSecundario(new formCategorias());
        }

        private void btnMeseros_Click(object sender, EventArgs e)
        {
            ActivateButton(btnMeseros, RGBColors.ColorSeleccion);
            OpenFormSecundario(new formMeseros());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(btnUsuarios, RGBColors.ColorSeleccion);
            OpenFormSecundario(new formUsuario());
        }

        private void btnNegocio_Click(object sender, EventArgs e)
        {
            ActivateButton(btnNegocio, RGBColors.ColorSeleccion);
            OpenFormSecundario(new formNegocio());
        }

        private void btnSobreMi_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSobreMi, RGBColors.ColorSeleccion);
            hideSubmenu();
            OpenFormSecundario(new formInformacion());
        }

    }
}
