using BLL;
using ENTITY;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formVerDetallesVenta : Form
    {
        public formVerDetallesVenta()
        {
            InitializeComponent();
            this.Resize += new EventHandler(formVerDetallesVenta_Resize);
            // Agregar manejadores de eventos para el DataGridView
            dgvDetallesVenta.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvDetallesVenta_DataBindingComplete);
            dgvDetallesVenta.Click += new EventHandler(dgvDetallesVenta_Click);
        }

        private void formVerDetallesVenta_Resize(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Venta venta = new ServicioVenta().ObtenerVenta(txtBuscarDoc.Texts);

            if (venta != null && venta.idVenta != 0)
            {
                txtNumeroDoc.Text = venta.numeroDocumento;
                dtpFecha.Text = venta.fechaRegistro;
                txtTipoDoc.Texts = venta.tipoDocumento;
                txtUsuarioResponsable.Texts = venta.usuario.nombreCompleto;
                txtMesa.Texts = venta.numeroMesa.ToString();
                txtMesero.Texts = venta.mesero.nombreCompleto;
                txtDocumentoCliente.Texts = venta.documentoCliente;
                txtCliente.Texts = venta.nombreCliente;

                dgvDetallesVenta.Rows.Clear();

                if (venta.detallesVenta != null && venta.detallesVenta.Count > 0)
                {
                    foreach (DetalleVenta detallesVenta in venta.detallesVenta)
                    {
                        dgvDetallesVenta.Rows.Add(new object[] {
                    detallesVenta.producto.nombre,
                    detallesVenta.cantidad,
                    detallesVenta.precioVenta,
                    detallesVenta.subTotal
                });
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron detalles de la venta.");
                }

                txtPagaCon.Texts = venta.montoPago.ToString("0.00");
                txtCambio.Texts = venta.montoCambio.ToString("0.00");
                txtTotal.Texts = venta.montoTotal.ToString("0.00");

                // Limpiar la selección del DataGridView después de cargar los datos
                dgvDetallesVenta.ClearSelection();
            }
            else
            {
                MessageBox.Show("Venta no encontrada o ID de venta no válido.");
            }
        }



        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtNumeroDoc.Text = "";
            dtpFecha.Text = "";
            txtTipoDoc.Texts = "";
            txtUsuarioResponsable.Texts = "";
            txtMesa.Texts = "";
            txtMesero.Texts = "";
            txtDocumentoCliente.Texts = "";
            txtCliente.Texts = "";

            dgvDetallesVenta.Rows.Clear();
            txtPagaCon.Texts = "0.00";
            txtCambio.Texts = "0.00";
            txtTotal.Texts = "0.00";

            // Limpiar la selección del DataGridView
            dgvDetallesVenta.ClearSelection();
        }

        // Manejador del evento DataBindingComplete
        private void dgvDetallesVenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDetallesVenta.ClearSelection();
        }

        // Manejador del evento Click
        private void dgvDetallesVenta_Click(object sender, EventArgs e)
        {
            dgvDetallesVenta.ClearSelection();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (txtTipoDoc.Texts == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.plantillaVentaOFSolution.ToString();
            Negocio datos = new ServicioNegocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", datos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", datos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", datos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDoc.Texts.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtNumeroDoc.Text);


            Texto_Html = Texto_Html.Replace("@doccliente", txtDocumentoCliente.Texts);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtCliente.Texts);
            Texto_Html = Texto_Html.Replace("@fecharegistro", dtpFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuarioResponsable.Texts);
            Texto_Html = Texto_Html.Replace("@mesero", txtMesero.Texts);
            Texto_Html = Texto_Html.Replace("@mesa", txtMesa.Texts);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + Convert.ToDecimal(row.Cells["PrecioVenta"].Value).ToString("0.00") + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + Convert.ToDecimal(row.Cells["SubTotal"].Value).ToString("0.00") + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtTotal.Texts);
            Texto_Html = Texto_Html.Replace("@pagocon", txtPagaCon.Texts);
            Texto_Html = Texto_Html.Replace("@cambio", txtCambio.Texts);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtNumeroDoc.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new ServicioNegocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
