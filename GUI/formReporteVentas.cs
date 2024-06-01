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
    public partial class formReporteVentas : Form
    {
        private Panel panelPrincipal;
        private Label labelTamaño;

        public formReporteVentas()
        {
            InitializeComponent();
            InicializarComponentesPersonalizados();
            ActualizarTamañoPanel();
        }

        private void InicializarComponentesPersonalizados()
        {
            // Crear y configurar el panel
            panelPrincipal = new Panel();
            panelPrincipal.Dock = DockStyle.Fill;
            this.Controls.Add(panelPrincipal);

            // Crear y configurar el label para mostrar el tamaño
            labelTamaño = new Label();
            labelTamaño.AutoSize = true;
            labelTamaño.Location = new System.Drawing.Point(10, 10);
            panelPrincipal.Controls.Add(labelTamaño);

            // Suscribirse al evento Resize del formulario
            this.Resize += new EventHandler(FormCategorias_Resize);
        }

        private void FormCategorias_Resize(object sender, EventArgs e)
        {
            // Actualizar el tamaño del panel cuando se redimensiona el formulario
            ActualizarTamañoPanel();
        }

        private void ActualizarTamañoPanel()
        {
            // Obtener el tamaño actual del panel y actualizar el label
            int ancho = panelPrincipal.Width;
            int alto = panelPrincipal.Height;
            labelTamaño.Text = $"Tamaño del panel: {ancho} x {alto}";
        }
    }
}
