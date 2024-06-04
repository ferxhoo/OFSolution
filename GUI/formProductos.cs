using BLL;
using ClosedXML.Excel;
using ENTITY;
using GUI.Componentes_Personalizad;
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
    public partial class formProductos : Form
    {
        public formProductos()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void formProductos_Load(object sender, EventArgs e)
        {
            CargarCmbEstado();
            CargarCmbCategoria();
            CargarCmbBuscar();
            CargarDataTable();
            Limpiar();
            LimpiarMensajes();
        }

        private void CargarCmbEstado()
        {
            //cargar combobox estado
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;
        }

        private void CargarCmbCategoria()
        {
            //cargar combobox rol
            List<Categoria> listaCategoria = new ServicioCategoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                cmbCategoria.Items.Add(new OpcionComboBox() { Valor = item.idCategoria, Texto = item.descripcion });
            }
            cmbCategoria.DisplayMember = "Texto";
            cmbCategoria.ValueMember = "Valor";
            cmbCategoria.SelectedIndex = 0;
        }

        private void CargarCmbBuscar()
        {
            //cargar combobox busqueda
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {

                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cmbBusqueda.Items.Add(new OpcionComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;
        }

        private void CargarDataTable()
        {
            // Limpiar las filas existentes en el DataGridView
            dgvProductos.Rows.Clear();

            List<Producto> lista = new ServicioProducto().Listar();

            foreach (Producto item in lista)
            {
                dgvProductos.Rows.Add(new object[] {
                    "",
                    item.idProducto,
                    item.codigo,
                    item.nombre,
                    item.descripcion,
                    item.categoria.idCategoria,
                    item.categoria.descripcion,
                    item.stock,
                    item.precioCompra,
                    item.precioVenta,
                    item.estado == true ? "Activo" : "Inactivo",
                    item.estado == true ? 1 : 0
                });
            }
        }

        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Check_OF.Width;
                var h = Properties.Resources.Check_OF.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Check_OF, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            dgvProductos.ClearSelection();

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    Producto producto = ObtenerProductoDeFila(dgvProductos.Rows[indice]);
                    ActualizarControlesProducto(producto, indice);
                }
            }

        }

        private Producto ObtenerProductoDeFila(DataGridViewRow fila)
        {
            Producto producto = new Producto
            {
                idProducto = Convert.ToInt32(fila.Cells["idProducto"].Value),
                codigo = fila.Cells["codigo"].Value.ToString(),
                nombre = fila.Cells["nombre"].Value.ToString(),
                descripcion = fila.Cells["descripcion"].Value.ToString(),
                categoria = new Categoria() { idCategoria = Convert.ToInt32(fila.Cells["idCategoria"].Value) },
                stock = Convert.ToInt32(fila.Cells["stock"].Value),
                precioCompra = Convert.ToDecimal(fila.Cells["precioCompra"].Value),
                precioVenta = Convert.ToDecimal(fila.Cells["precioVenta"].Value),
                estado = Convert.ToInt32(fila.Cells["valorEstado"].Value) == 1
            };

            return producto;
        }

        private void ActualizarControlesProducto(Producto producto, int indice)
        {
            txtIndice.Text = indice.ToString();
            txtId.Text = producto.idProducto.ToString();
            txtCodigo.Texts = producto.codigo;
            txtNombre.Texts = producto.nombre;
            txtDescripcion.Texts = producto.descripcion;

            cmbCategoria.SelectedIndex = ObtenerIndiceComboBox(cmbCategoria, producto.categoria.idCategoria);
            cmbEstado.SelectedIndex = ObtenerIndiceComboBox(cmbEstado, producto.estado ? 1 : 0);


            btnGuardar.Text = "Editar";
            btnGuardar.BackColor = Color.FromArgb(108, 196, 228);

        }

        private int ObtenerIndiceComboBox(ComboBoxOFSolution comboBox, int valor)
        {
            foreach (OpcionComboBox opcionComboBox in comboBox.Items)
            {
                if (Convert.ToInt32(opcionComboBox.Valor) == valor)
                {
                    return comboBox.Items.IndexOf(opcionComboBox);
                }
            }
            return -1; // Retornar -1 si no se encuentra el valor
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                return;
            }

            Producto nuevoProducto = CrearNuevoProducto();

            if (nuevoProducto.idProducto == 0)
            {
                RegistrarProducto(nuevoProducto);
            }
            else
            {
                EditarProducto(nuevoProducto);
            }
        }

        private bool VerificarCampos()
        {
            bool hayCampoVacio = false;

            hayCampoVacio |= VerificarCampoVacio(txtCodigo, lblCodigo, "codigo");
            hayCampoVacio |= VerificarCampoVacio(txtNombre, lblNombre, "nombre");
            hayCampoVacio |= VerificarCampoVacio(txtDescripcion, lblDescripcion, "campo descripcion");
            
            return hayCampoVacio;
        }

        private bool VerificarCampoVacio(TextBoxOFSolution textBox, Label label, string campo)
        {
            bool control = false;
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                control = true;
                label.ForeColor = Color.Red;
                label.Text = $"El {campo} no puede ser vacío";
            }
            else
            {
                label.Text = "";
            }
            return control;
        }

        private Producto CrearNuevoProducto()
        {
            return new Producto()
            {
                idProducto = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                codigo = txtCodigo.Texts,
                nombre = txtNombre.Texts,
                descripcion = txtDescripcion.Texts,
                categoria = new Categoria() { idCategoria = Convert.ToInt32(((OpcionComboBox)cmbCategoria.SelectedItem).Valor) },
                estado = Convert.ToInt32(((OpcionComboBox)cmbEstado.SelectedItem).Valor) == 1
            };
        }

        private void RegistrarProducto(Producto producto)
        {
            string mensaje = string.Empty;
            int idProductoGenerado = new ServicioProducto().Registrar(producto, out mensaje);

            if (idProductoGenerado != 0)
            {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "Producto registrado con éxito.";
                ActualizarUI();
            }
            else
            {
                lblCheck.ForeColor = Color.Red;
                lblCheck.Text = mensaje;
            }
        }

        private void EditarProducto(Producto producto)
        {
            string mensaje = string.Empty;
            bool resultado = new ServicioProducto().Editar(producto, out mensaje);

            if (resultado)
            {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "Producto editado con éxito.";
                ActualizarUI();
            }
            else
            {
                lblCheck.ForeColor = Color.Red;
                lblCheck.Text = mensaje;
            }
        }

        private void ActualizarUI()
        {
            CargarDataTable();
            Limpiar();
        }

        private void LimpiarMensajes()
        {
            lblCodigo.Text = string.Empty;
            lblNombre.Text = string.Empty;
            lblDescripcion.Text = string.Empty;
            lblCheck.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarMensajes();
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtCodigo.Texts = string.Empty;
            txtNombre.Texts = string.Empty;
            txtDescripcion.Texts = string.Empty;
            cmbCategoria.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            

            txtCodigo.Select();
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.FromArgb(23, 145, 200);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Producto eliminarProducto = new Producto()
                    {
                        idProducto = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new ServicioProducto().Eliminar(eliminarProducto, out mensaje);

                    if (respuesta)
                    {
                        //dgvUsuarios.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        ActualizarUI();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionComboBox)cmbBusqueda.SelectedItem).Valor.ToString();

            if (dgvProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Texts.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Texts = string.Empty;
            cmbBusqueda.SelectedIndex = 0;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvProductos.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),

                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
        }
    }
}
