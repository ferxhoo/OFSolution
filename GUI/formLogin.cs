using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formLogin : Form
    {

        #region propiedades de personalizacion
        private const int DISTANCIA_MINIMA = 10; // Distancia mínima para activar el ajuste a la esquina
        #endregion

        #region constructor
        public formLogin()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }
        #endregion

        #region Configuracion Inicial
        public void ConfiguracionInicial()
        {
            this.DoubleBuffered = true;
            LimpiarLabel();
            LimpiarTextBox();
        }

        public void LimpiarLabel()
        {
            InformacionCampoUsuario.Text = string.Empty;
            InformacionCampoPassword.Text = string.Empty;
        }

        public void LimpiarTextBox()
        {
            txtUsuario.Texts = string.Empty;
            txtPassword.Texts = string.Empty;
        }
        #endregion

        #region funciones de redimencionamiento
        private void MinimizarFormulario()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonQuarterRightScreen(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void ButtonQuarterLeftScreen(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void ButtonQuarterTopRightScreen(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void ButtonQuarterTopLeftScreen(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
            this.Location = new Point(0, 0);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                MinimizarFormulario();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D1))
            {
                ButtonQuarterTopLeftScreen(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D2))
            {
                ButtonQuarterTopRightScreen(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D3))
            {
                ButtonQuarterLeftScreen(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D4))
            {
                ButtonQuarterRightScreen(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                this.CenterToScreen();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region barra de titulos
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            MinimizarFormulario();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X <= DISTANCIA_MINIMA && e.Y <= DISTANCIA_MINIMA) // Esquina superior izquierda
                {
                    ButtonQuarterTopLeftScreen(sender, e);
                }
                else if (e.X >= this.Width - DISTANCIA_MINIMA && e.Y <= DISTANCIA_MINIMA) // Esquina superior derecha
                {
                    ButtonQuarterTopRightScreen(sender, e);
                }
                else if (e.X <= DISTANCIA_MINIMA && e.Y >= this.Height - DISTANCIA_MINIMA) // Esquina inferior izquierda
                {
                    ButtonQuarterLeftScreen(sender, e);
                }
                else if (e.X >= this.Width - DISTANCIA_MINIMA && e.Y >= this.Height - DISTANCIA_MINIMA) // Esquina inferior derecha
                {
                    ButtonQuarterRightScreen(sender, e);
                }
                else
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
        #endregion

        #region botones de login 
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            List<Usuario> listaUsuario = new ServicioUsuario().Listar();

            Usuario usuario = new ServicioUsuario().Listar().Where(u => u.nombreUsuario == txtUsuario.Texts && u.clave == txtPassword.Texts).FirstOrDefault();

            if (usuario != null)
            {
                formMenuPrincipal menu = new formMenuPrincipal(usuario);
                menu.Show();
                this.Hide();

                menu.FormClosing += frm_closing;
            }
            else
            {
                InformacionCampoUsuario.ForeColor = Color.Red;
                InformacionCampoUsuario.Text = "No se encontro el usuario";
            }


        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Texts = string.Empty;
            txtPassword.Texts = string.Empty;
            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfiguracionInicial();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
