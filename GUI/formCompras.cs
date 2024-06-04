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
        public formCompras()
        {
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
    }

}
