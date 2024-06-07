using BLL;
using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class formVentas : Form
    {
        private Usuario responsableVenta = null;
        private bool editando = false;

        public formVentas(Usuario usuario = null)
        {
            responsableVenta = usuario;
            InitializeComponent();
            this.Resize += new EventHandler(formVentas_Resize);
        }

        private void formVentas_Resize(object sender, EventArgs e)
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

        private void formVentas_Load(object sender, EventArgs e)
        {
            CargarCmbTipoDoc();
            LimpiarCamposVenta();
        }

        private void CargarCmbTipoDoc()
        {
            cmbDocFactura.Items.Add(new OpcionComboBox() { Valor = "Factura", Texto = "Factura" });
            cmbDocFactura.Items.Add(new OpcionComboBox() { Valor = "Boleta", Texto = "Boleta" });
            cmbDocFactura.DisplayMember = "Texto";
            cmbDocFactura.ValueMember = "Valor";
            cmbDocFactura.SelectedIndex = 0;
        }

        private void LimpiarCamposVenta()
        {
            dtpFecha.Text = DateTime.Now.ToString();
            txtIdProducto.Text = "0";
            txtIdCliente.Text = "0";
            txtIdMesero.Text = "0";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            using (var modal = new ModalformCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    AsignarCliente(modal.clienteSeleccionado);
                }
                else
                {
                    txtDocumentoCliente.Select();
                }
            }
        }

        private void AsignarCliente(Cliente cliente)
        {
            txtIdCliente.Text = cliente.idCliente.ToString();
            txtDocumentoCliente.Texts = cliente.documento;
            txtCliente.Texts = cliente.nombreCompleto;
        }

        private void btnBuscarMesero_Click(object sender, EventArgs e)
        {
            BuscarMesero();
        }

        private void BuscarMesero()
        {
            using (var modal = new ModalformMesero())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    AsignarMesero(modal.meseroSeleccionado);
                }
                else
                {
                    txtDocMesero.Select();
                }
            }
        }

        private void AsignarMesero(Mesero mesero)
        {
            txtIdMesero.Text = mesero.idMesero.ToString();
            txtDocMesero.Texts = mesero.documento;
            txtMesero.Texts = mesero.nombreCompleto;
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
            txtPrecioVenta.Texts = producto.precioVenta.ToString("0.00");
            txtStock.Texts = producto.stock.ToString();
            nupCantidad.Value = 0;
            nupCantidad.UpButton();
            nupCantidad.Select();
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
            txtPrecioVenta.Texts = "0,00";
            txtStock.Texts = "0";
            nupCantidad.Value = 0;
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        private void AgregarDetalle()
        {
            if (!ValidarDatosProducto(out decimal precioventa)) return;

            if (ProductoExisteEnDetalle() && !editando)
            {
                MessageBox.Show("El producto ya existe en el detalle", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (editando)
            {
                EditarProductoDetalle(precioventa);
            }
            else
            {
                bool respuesta = new ServicioVenta().RestarStock(
                Convert.ToInt32(txtIdProducto.Text),
                Convert.ToInt32(nupCantidad.Value.ToString()));

                if (respuesta)
                {
                    AgregarProductoDetalle(precioventa);
                }

                calcularTotal();
                limpiarProducto();
                txtCodigoProducto.Select();
            }
        }

        private bool ValidarDatosProducto(out decimal precioventa)
        {
            precioventa = 0;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (Convert.ToInt32(txtStock.Texts) < Convert.ToInt32(nupCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            foreach (DataGridViewRow fila in dgvDetallesVenta.Rows)
            {
                if (fila.Cells["idProducto"].Value != null && fila.Cells["idProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void EditarProductoDetalle(decimal precio)
        {
            if (dgvDetallesVenta.CurrentCell != null)
            {
                int indice = dgvDetallesVenta.CurrentCell.RowIndex;
                if (indice >= 0)
                {
                    DataGridViewRow filaSeleccionada = dgvDetallesVenta.Rows[indice];

                    // Obtener la cantidad anterior
                    int cantidadAnterior = Convert.ToInt32(filaSeleccionada.Cells["cantidad"].Value);
                    int nuevaCantidad = Convert.ToInt32(nupCantidad.Value);

                    // Calcular la diferencia y ajustar el stock
                    int diferenciaCantidad = nuevaCantidad - cantidadAnterior;
                    bool respuesta = new ServicioVenta().RestarStock(
                        Convert.ToInt32(txtIdProducto.Text), diferenciaCantidad);

                    if (respuesta)
                    {
                        ActualizarFilaProducto(filaSeleccionada, precio);
                        calcularTotal();
                    }

                    btnAgregarDetalle.Text = "Agregar Producto";
                    editando = false;
                    habilitarCamposProducto(true);
                    limpiarProducto();
                    txtCodigoProducto.Select();
                }
            }
        }

        private void ActualizarFilaProducto(DataGridViewRow fila, decimal precio)
        {
            fila.Cells["codigo"].Value = txtCodigoProducto.Texts;
            fila.Cells["producto"].Value = txtNombreProducto.Texts;
            fila.Cells["cantidad"].Value = nupCantidad.Value.ToString();
            fila.Cells["precioVenta"].Value = txtPrecioVenta.Texts;
            fila.Cells["subtotal"].Value = (nupCantidad.Value * precio).ToString("0.00");
        }

        private void AgregarProductoDetalle(decimal precioventa)
        {
            dgvDetallesVenta.Rows.Add(new object[] {
        null,
        txtIdProducto.Text,
        txtCodigoProducto.Texts,
        txtNombreProducto.Texts,
        nupCantidad.Value.ToString(),
        precioventa.ToString("0.00"),
        (nupCantidad.Value * precioventa).ToString("0.00")
    });
        }


        private void limpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodigoProducto.Texts = "";
            txtCodigoProducto.BackColor = Color.WhiteSmoke;
            txtNombreProducto.Texts = "";
            txtStock.Texts = "";
            txtPrecioVenta.Texts = "";
            nupCantidad.Value = 0;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value.ToString());
                }
            }
            txtTotal.Texts = total.ToString("0.00");
            calcularcambio();
        }

        private void habilitarCamposProducto(bool habilitar)
        {
            txtIdProducto.Enabled = habilitar;
            txtCodigoProducto.Enabled = habilitar;
            txtNombreProducto.Enabled = habilitar;
            nupCantidad.Select();
        }

        private void dgvDetallesVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                DrawImageInCell(e, Properties.Resources.Check_OF);
            }
            else if (e.ColumnIndex == 7)
            {
                DrawImageInCell(e, Properties.Resources.IconoBorrar);
            }

            dgvDetallesVenta.ClearSelection();
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

        private void dgvDetallesVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SeleccionarProducto(e.RowIndex);
            }
            else if (dgvDetallesVenta.Columns[e.ColumnIndex].Name == "btnEliminar")
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
                DataGridViewRow filaSeleccionada = dgvDetallesVenta.Rows[indice];
                AsignarProductoSeleccionado(filaSeleccionada);
                habilitarCamposProducto(false);
                btnAgregarDetalle.Text = "Editar Detalle";
                editando = true;
            }
        }

        private void AsignarProductoSeleccionado(DataGridViewRow fila)
        {
            ServicioProducto servicio = new ServicioProducto();

            // Asignar valores a los campos de texto desde la fila seleccionada
            txtIdProducto.Text = fila.Cells["idProducto"].Value.ToString();
            txtCodigoProducto.Texts = fila.Cells["codigo"].Value.ToString();
            txtNombreProducto.Texts = fila.Cells["producto"].Value.ToString();
            txtPrecioVenta.Texts = fila.Cells["precioVenta"].Value.ToString();

            // Validar y asignar el valor de la cantidad
            if (int.TryParse(fila.Cells["cantidad"].Value.ToString(), out int cantidad))
            {
                nupCantidad.Value = cantidad;
            }
            else
            {
                // Manejar el caso en el que la cantidad no sea un número válido
                nupCantidad.Value = 0; // O cualquier valor predeterminado que consideres apropiado
            }

            // Obtener el ID del producto desde la fila seleccionada
            int idProducto = Convert.ToInt32(fila.Cells["idProducto"].Value);

            // Obtener el stock del producto usando LINQ
            var producto = servicio.Listar().FirstOrDefault(p => p.idProducto == idProducto);
            if (producto != null)
            {
                txtStock.Texts = producto.stock.ToString();
            }
            else
            {
                // Manejar el caso en el que el producto no se encuentre
                txtStock.Texts = "0";
            }
        }

        private void EliminarProducto(int indice)
        {
            if (indice >= 0)
            {
                bool respuesta = new ServicioVenta().SumarStock(
                        Convert.ToInt32(dgvDetallesVenta.Rows[indice].Cells["idProducto"].Value.ToString()),
                        Convert.ToInt32(dgvDetallesVenta.Rows[indice].Cells["cantidad"].Value.ToString()));

                if (respuesta)
                {
                    dgvDetallesVenta.Rows.RemoveAt(indice);
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
        }

        private void dgvDetallesVenta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetallesVenta.SelectedCells.Count > 0)
            {
                int indice = dgvDetallesVenta.SelectedCells[0].RowIndex;
                if (indice >= 0)
                {
                    DataGridViewRow filaSeleccionada = dgvDetallesVenta.Rows[indice];
                    if (filaSeleccionada.Cells["codigo"].Value != null)
                    {
                        txtCodigoProducto.Texts = filaSeleccionada.Cells["codigo"].Value.ToString();
                    }
                }
            }
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

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaDecimal(e, txtPrecioVenta.Texts);
        }

        private void txtCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaDecimal(e, txtCambio.Texts);
        }

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaDecimal(e, txtPagaCon.Texts);
        }

        private void calcularcambio()
        {
            if (txtTotal.Texts.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotal.Texts);

            if (txtPagaCon.Texts.Trim() == "")
            {
                txtPagaCon.Texts = "0";
            }

            if (decimal.TryParse(txtPagaCon.Texts.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtCambio.Texts = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtCambio.Texts = cambio.ToString("0.00");
                }
            }
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }


        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {

        }

    }
}
