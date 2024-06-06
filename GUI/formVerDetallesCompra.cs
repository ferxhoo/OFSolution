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
    public partial class formVerDetallesCompra : Form
    {
        public formVerDetallesCompra()
        {
            InitializeComponent();
            this.Resize += new EventHandler(formVerDetallesCompra_Resize);
        }

        private void formVerDetallesCompra_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            if (panelPrincipal != null && panelCentrado != null)
            {
                panelCentrado.Width = 1261; // Mantener el ancho fijo
                panelCentrado.Height = panelPrincipal.Height >= 741 ? panelPrincipal.Height : 741;

                int x = (panelPrincipal.Width > 1261) ? (panelPrincipal.Width - 1261) / 2 : 0;
                int y = (panelPrincipal.Height > 741) ? (panelPrincipal.Height - panelCentrado.Height) / 2 : 0;

                panelCentrado.Location = new Point(x, y);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {

        }
    }
}
