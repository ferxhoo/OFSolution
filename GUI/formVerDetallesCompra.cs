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
    public partial class formVerDetallesCompra : Form
    {
        public formVerDetallesCompra()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Resize += new EventHandler(formVerDetallesCompra_Resize);

            // Agregar manejadores de eventos para el DataGridView
            dgvDetallesCompra.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvDetallesCompra_DataBindingComplete);
            dgvDetallesCompra.Click += new EventHandler(dgvDetallesCompra_Click);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compra compra = new ServicioCompra().ObtenerCompra(txtBuscarDoc.Texts);

            if (compra.idCompra != 0)
            {
                txtNumeroDoc.Text = compra.numeroDocumento;
                dtpFecha.Text = compra.fechaRegistro;
                txtTipoDoc.Texts = compra.tipoDocumento;
                txtUsuarioResponsable.Texts = compra.usuario.nombreCompleto;
                txtDocumentoProveedor.Texts = compra.proveedor.documento;
                txtProveedor.Texts = compra.proveedor.razonSocial;

                dgvDetallesCompra.Rows.Clear();
                foreach (DetalleCompra detallesCompra in compra.detallesCompra)
                {
                    dgvDetallesCompra.Rows.Add(new object[] {
                    detallesCompra.producto.nombre,
                    detallesCompra.cantidad,
                    detallesCompra.precioCompra,
                    detallesCompra.montoTotal
                });
                }

                txtTotal.Texts = compra.montoTotal.ToString("0.00");

                // Limpiar la selección del DataGridView después de cargar los datos
                dgvDetallesCompra.ClearSelection();
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtNumeroDoc.Text = "";
            dtpFecha.Text = "";
            txtTipoDoc.Texts = "";
            txtUsuarioResponsable.Texts = "";
            txtDocumentoProveedor.Texts = "";
            txtProveedor.Texts = "";

            dgvDetallesCompra.Rows.Clear();
            txtTotal.Texts = "0.00";

            // Limpiar la selección del DataGridView
            dgvDetallesCompra.ClearSelection();
        }

        // Manejador del evento DataBindingComplete
        private void dgvDetallesCompra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDetallesCompra.ClearSelection();
        }

        // Manejador del evento Click
        private void dgvDetallesCompra_Click(object sender, EventArgs e)
        {
            dgvDetallesCompra.ClearSelection();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (txtTipoDoc.Texts == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.plantillaCompraOFSolution.ToString();
            Negocio datos = new ServicioNegocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", datos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", datos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", datos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDoc.Texts.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtNumeroDoc.Text);


            Texto_Html = Texto_Html.Replace("@docproveedor", txtDocumentoProveedor.Texts);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtProveedor.Texts);
            Texto_Html = Texto_Html.Replace("@fecharegistro", dtpFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuarioResponsable.Texts);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvDetallesCompra.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["precioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtTotal.Texts);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtNumeroDoc.Text);
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
