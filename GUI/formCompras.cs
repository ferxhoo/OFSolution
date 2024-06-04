using ENTITY;
using GUI.formulariosModales;
using GUI.Utility;
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
    public partial class formCompras : Form
    {

        private Usuario responsableCompra = null;

        public formCompras(Usuario usuario = null)
        {
            responsableCompra = usuario;
            InitializeComponent();
            this.Resize += new EventHandler(formCompras_Resize);
        }
        #region code para centrar un div xd
        private void formCompras_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            if (panelPrincipal != null && panelCentrado != null)
            {
                // Ajustar el tamaño del panel centrado solo en altura
                panelCentrado.Width = 1261; // Mantener el ancho fijo
                panelCentrado.Height = panelPrincipal.Height >= 741 ? panelPrincipal.Height : 741;

                // Calcular la nueva posición para centrar el panel si el panelPrincipal es más grande
                int x = (panelPrincipal.Width > 1261) ? (panelPrincipal.Width - 1261) / 2 : 0;
                int y = (panelPrincipal.Height > 741) ? (panelPrincipal.Height - panelCentrado.Height) / 2 : 0;

                // Establecer la nueva posición del panel centrado
                panelCentrado.Location = new Point(x, y);
            }
        }
        #endregion

        private void formCompras_Load(object sender, EventArgs e)
        {
            CargarCmbTipoDoc();
            string fecha = dtpFecha.Text;
            txtIdProducto.Text = "0";
            txtIdProveedor.Text = "0";
        }

        private void CargarCmbTipoDoc()
        {
            cmbDocFactura.Items.Add(new OpcionComboBox() { Valor = "Factura", Texto = "Factura" });
            cmbDocFactura.Items.Add(new OpcionComboBox() { Valor = "Boleta", Texto = "Boleta" });
            cmbDocFactura.DisplayMember = "Texto";
            cmbDocFactura.ValueMember = "Valor";
            cmbDocFactura.SelectedIndex = 0;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new ModalformProveedor())
            {
                var resultado = modal.ShowDialog();
            }
        }
    }

}
