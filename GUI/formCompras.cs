using BLL;
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
        private bool editando = false;

        public formCompras(Usuario usuario = null)
        {
            responsableCompra = usuario;
            InitializeComponent();
            this.Resize += new EventHandler(formCompras_Resize);
        }

        private void formCompras_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            CargarCmbTipoDoc();
            LimpiarCamposCompra();
        }

        private void CargarCmbTipoDoc()
        {
            cmbDocFactura.Items.Add(new OpcionComboBox() { Valor = "Factura", Texto = "Factura" });
            cmbDocFactura.Items.Add(new OpcionComboBox() { Valor = "Boleta", Texto = "Boleta" });
            cmbDocFactura.DisplayMember = "Texto";
            cmbDocFactura.ValueMember = "Valor";
            cmbDocFactura.SelectedIndex = 0;
        }

        private void LimpiarCamposCompra()
        {
            dtpFecha.Text = DateTime.Now.ToString();
            txtIdProducto.Text = "0";
            txtIdProveedor.Text = "0";
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
        }

        private void BuscarProveedor()
        {
            using (var modal = new ModalformProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    AsignarProveedor(modal.proveedorSeleccionado);
                }
                else
                {
                    txtDocumentoProveedor.Select();
                }
            }
        }

        private void AsignarProveedor(Proveedor proveedor)
        {
            txtIdProveedor.Text = proveedor.idProveedor.ToString();
            txtDocumentoProveedor.Texts = proveedor.documento;
            txtProveedor.Texts = proveedor.razonSocial;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BuscarProducto()
        {
            using (var modal = new ModalformProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    AsignarProducto(modal.productoSeleccionado);
                    nupCantidad.Value = 0;
                    nupCantidad.UpButton();
                }
                else
                {
                    txtCodigoProducto.Select();
                }
            }
        }

        private void AsignarProducto(Producto producto)
        {
            txtIdProducto.Text = producto.idProducto.ToString();
            txtCodigoProducto.Texts = producto.codigo;
            txtNombreProducto.Texts = producto.nombre;
            txtPrecioCompra.Select();
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BuscarProductoPorCodigo();
            }
        }

        private void BuscarProductoPorCodigo()
        {
            Producto producto = new ServicioProducto().Listar().FirstOrDefault(p => p.codigo == txtCodigoProducto.Texts && p.estado == true);

            if (producto != null)
            {
                AsignarProducto(producto);
                txtCodigoProducto.BackColor = Color.Honeydew;
                nupCantidad.Value = 0;
                nupCantidad.UpButton();
            }
            else
            {
                LimpiarProductoNoEncontrado();
            }
        }

        private void LimpiarProductoNoEncontrado()
        {
            txtCodigoProducto.BackColor = Color.MistyRose;
            txtIdProducto.Text = "0";
            txtNombreProducto.Texts = "";
            nupCantidad.Value = 0;
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        private void AgregarDetalle()
        {
            if (!ValidarDatosProducto(out decimal preciocompra, out decimal precioventa)) return;

            if (ProductoExisteEnDetalle() && !editando)
            {
                MessageBox.Show("El producto ya existe en el detalle", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (editando)
            {
                EditarProductoDetalle(preciocompra);
            }
            else
            {
                AgregarProductoDetalle(preciocompra, precioventa);
            }

            calcularTotal();
            limpiarProducto();
            txtCodigoProducto.Select();
        }

        private bool ValidarDatosProducto(out decimal preciocompra, out decimal precioventa)
        {
            preciocompra = 0;
            precioventa = 0;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!decimal.TryParse(txtPrecioCompra.Texts, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCompra.Select();
                return false;
            }

            if (!decimal.TryParse(txtPrecioVenta.Texts, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Select();
                return false;
            }

            return true;
        }

        private bool ProductoExisteEnDetalle()
        {
            foreach (DataGridViewRow fila in dgvDetallesCompra.Rows)
            {
                if (fila.Cells["idProducto"].Value != null && fila.Cells["idProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void EditarProductoDetalle(decimal preciocompra)
        {
            if (dgvDetallesCompra.CurrentCell != null)
            {
                int indice = dgvDetallesCompra.CurrentCell.RowIndex;
                if (indice >= 0)
                {
                    DataGridViewRow filaSeleccionada = dgvDetallesCompra.Rows[indice];
                    ActualizarFilaProducto(filaSeleccionada, preciocompra);
                    btnAgregarDetalle.Text = "Agregar Producto";
                    editando = false;
                    habilitarCamposProducto(true);
                }
            }
        }

        private void ActualizarFilaProducto(DataGridViewRow fila, decimal preciocompra)
        {
            fila.Cells["codigo"].Value = txtCodigoProducto.Texts;
            fila.Cells["producto"].Value = txtNombreProducto.Texts;
            fila.Cells["precioCompra"].Value = txtPrecioCompra.Texts;
            fila.Cells["precioVenta"].Value = txtPrecioVenta.Texts;
            fila.Cells["cantidad"].Value = nupCantidad.Value.ToString();
            fila.Cells["subtotal"].Value = (nupCantidad.Value * preciocompra).ToString("0.00");
        }

        private void AgregarProductoDetalle(decimal preciocompra, decimal precioventa)
        {
            dgvDetallesCompra.Rows.Add(new object[] {
            null,
            txtIdProducto.Text,
            txtCodigoProducto.Texts,
            txtNombreProducto.Texts,
            nupCantidad.Value.ToString(),
            preciocompra.ToString("0.00"),
            precioventa.ToString("0.00"),
            (nupCantidad.Value * preciocompra).ToString("0.00")
        });
        }

        private void limpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodigoProducto.Texts = "";
            txtCodigoProducto.BackColor = Color.WhiteSmoke;
            txtNombreProducto.Texts = "";
            txtPrecioCompra.Texts = "";
            txtPrecioVenta.Texts = "";
            nupCantidad.Value = 0;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvDetallesCompra.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value.ToString());
                }
            }
            txtTotal.Texts = total.ToString("0.00");
        }

        private void dgvDetallesCompra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                DrawImageInCell(e, Properties.Resources.Check_OF);
            }
            else if (e.ColumnIndex == 8)
            {
                DrawImageInCell(e, Properties.Resources.IconoBorrar);
            }

            dgvDetallesCompra.ClearSelection();
        }

        private void DrawImageInCell(DataGridViewCellPaintingEventArgs e, Image image)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            var w = image.Width;
            var h = image.Height;
            var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
            e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
            e.Handled = true;
        }

        private void dgvDetallesCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SeleccionarProducto(e.RowIndex);
            }
            else if (dgvDetallesCompra.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                EliminarProducto(e.RowIndex);
                txtCodigoProducto.Texts = string.Empty;
                txtCodigoProducto.Select();
            }
        }

        private void SeleccionarProducto(int indice)
        {
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvDetallesCompra.Rows[indice];
                AsignarProductoSeleccionado(filaSeleccionada);
                habilitarCamposProducto(false);
                btnAgregarDetalle.Text = "Editar Detalle";
                editando = true;
            }
        }

        private void AsignarProductoSeleccionado(DataGridViewRow fila)
        {
            txtIdProducto.Text = fila.Cells["idProducto"].Value.ToString();
            txtCodigoProducto.Texts = fila.Cells["codigo"].Value.ToString();
            txtNombreProducto.Texts = fila.Cells["producto"].Value.ToString();
            txtPrecioCompra.Texts = fila.Cells["precioCompra"].Value.ToString();
            txtPrecioVenta.Texts = fila.Cells["precioVenta"].Value.ToString();
            nupCantidad.Value = Convert.ToInt32(fila.Cells["cantidad"].Value);
        }

        private void EliminarProducto(int indice)
        {
            if (indice >= 0)
            {
                dgvDetallesCompra.Rows.RemoveAt(indice);
                calcularTotal();

                if (editando)
                {
                    limpiarProducto();
                    btnAgregarDetalle.Text = "Agregar Producto";
                    editando = false;
                    habilitarCamposProducto(true);
                }
            }
        }

        private void dgvDetallesCompra_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetallesCompra.SelectedCells.Count > 0)
            {
                int indice = dgvDetallesCompra.SelectedCells[0].RowIndex;
                if (indice >= 0)
                {
                    DataGridViewRow filaSeleccionada = dgvDetallesCompra.Rows[indice];
                    if (filaSeleccionada.Cells["codigo"].Value != null)
                    {
                        txtCodigoProducto.Texts = filaSeleccionada.Cells["codigo"].Value.ToString();
                    }
                }
            }
        }

        private void habilitarCamposProducto(bool habilitar)
        {
            txtIdProducto.Enabled = habilitar;
            txtCodigoProducto.Enabled = habilitar;
            txtNombreProducto.Enabled = habilitar;
            txtPrecioCompra.Select();
        }

        private void formCompras_Resize(object sender, EventArgs e)
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

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaDecimal(e, txtPrecioCompra.Texts);
        }

        private void txtprecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaDecimal(e, txtPrecioVenta.Texts);
        }

        private void ValidarEntradaDecimal(KeyPressEventArgs e, string texto)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (e.KeyChar == ',' && !texto.Contains(','))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvDetallesCompra.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("idProducto", typeof(int));
            detalle_compra.Columns.Add("precioCompra", typeof(decimal));
            detalle_compra.Columns.Add("precioVenta", typeof(decimal));
            detalle_compra.Columns.Add("cantidad", typeof(int));
            detalle_compra.Columns.Add("montoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvDetallesCompra.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
               Convert.ToInt32(row.Cells["idProducto"].Value.ToString()),
               row.Cells["precioCompra"].Value.ToString(),
               row.Cells["precioVenta"].Value.ToString(),
               row.Cells["cantidad"].Value.ToString(),
               row.Cells["subtotal"].Value.ToString()
                    });

            }

            int idCorrelativo = new ServicioCompra().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            Compra compra = new Compra()
            {
                usuario = new Usuario() { idUsuario = responsableCompra.idUsuario },
                proveedor = new Proveedor() { idProveedor = Convert.ToInt32(txtIdProveedor.Text) },
                tipoDocumento = ((OpcionComboBox)cmbDocFactura.SelectedItem).Texto,
                numeroDocumento = numeroDocumento,
                montoTotal = Convert.ToDecimal(txtTotal.Texts)
            };

            string mensaje = string.Empty;
            bool respuesta = new ServicioCompra().Registrar(compra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txtIdProveedor.Text = "0";
                txtDocumentoProveedor.Text = "";
                txtDocumentoProveedor.Text = "";
                dgvDetallesCompra.Rows.Clear();
                calcularTotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


    }
}
