using BLL;
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
    public partial class formClientes : Form
    {
        public formClientes()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            CargarCmbEstado();
            CargarCmbBuscar();
            CargarDataTable();
            Limpiar();
            LimpiarMensajes();
        }

        private void CargarCmbEstado()
        {
            //cargar combobox estado
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 0, Texto = "Inactivo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;
        }

        private void CargarCmbBuscar()
        {
            //cargar combobox busqueda
            foreach (DataGridViewColumn columna in dgvClientes.Columns)
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
            dgvClientes.Rows.Clear();

            // Mostrar todos los usuarios
            List<Cliente> lista = new ServicioCliente().Listar();

            foreach (Cliente item in lista)
            {
                dgvClientes.Rows.Add(new object[] {
                    "",
                    item.idCliente,
                    item.documento,
                    item.nombreCompleto,
                    item.correo,
                    item.telefono,
                    item.estado == true ? "Activo" : "Inactivo",
                    item.estado == true ? 1 : 0
                });
            }
        }

        private void dgvClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

            dgvClientes.ClearSelection();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    Cliente cliente = ObtenerClienteDeFila(dgvClientes.Rows[indice]);
                    ActualizarControlesCliente(cliente, indice);
                }
            }
        }

        private Cliente ObtenerClienteDeFila(DataGridViewRow fila)
        {
            Cliente cliente = new Cliente
            {
                idCliente = Convert.ToInt32(fila.Cells["idCliente"].Value),
                documento = fila.Cells["documento"].Value.ToString(),
                nombreCompleto = fila.Cells["nombreCompleto"].Value.ToString(),
                correo = fila.Cells["correo"].Value.ToString(),
                telefono = fila.Cells["telefono"].Value.ToString(),
                estado = Convert.ToInt32(fila.Cells["valorEstado"].Value) == 1
            };

            return cliente;
        }

        private void ActualizarControlesCliente(Cliente cliente, int indice)
        {
            txtIndice.Text = indice.ToString();
            txtId.Text = cliente.idCliente.ToString();
            txtDocumento.Texts = cliente.documento;
            txtNombre.Texts = cliente.nombreCompleto;
            txtCorreo.Texts = cliente.correo;
            txtTelefono.Texts = cliente.telefono;

            cmbEstado.SelectedIndex = ObtenerIndiceComboBox(cmbEstado, cliente.estado ? 1 : 0);


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

            Cliente nuevoCliente = CrearNuevoCliente();

            if (nuevoCliente.idCliente == 0)
            {
                RegistrarCliente(nuevoCliente);
            }
            else
            {
                EditarCliente(nuevoCliente);
            }
        }

        private bool VerificarCampos()
        {
            bool hayCampoVacio = false;

            hayCampoVacio |= VerificarCampoVacio(txtDocumento, lblDocumento, "documento");
            hayCampoVacio |= VerificarCampoVacio(txtNombre, lblNombre, "nombre");
            hayCampoVacio |= VerificarCampoVacio(txtCorreo, lblCorreo, "correo");
            hayCampoVacio |= VerificarCampoVacio(txtTelefono, lblTelefono, "teléfono");

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

        private Cliente CrearNuevoCliente()
        {
            return new Cliente()
            {
                idCliente = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                documento = txtDocumento.Texts,
                nombreCompleto = txtNombre.Texts,
                correo = txtCorreo.Texts,
                telefono = txtTelefono.Texts,
                estado = Convert.ToInt32(((OpcionComboBox)cmbEstado.SelectedItem).Valor) == 1
            };
        }

        private void RegistrarCliente(Cliente cliente)
        {
            string mensaje = string.Empty;
            int idClienteGenerado = new ServicioCliente().Registrar(cliente, out mensaje);

            if (idClienteGenerado != 0)
            {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "Cliente registrado con éxito.";
                ActualizarUI();
            }
            else
            {
                lblCheck.ForeColor = Color.Red;
                lblCheck.Text = mensaje;
            }
        }

        private void EditarCliente(Cliente cliente)
        {
            string mensaje = string.Empty;
            bool resultado = new ServicioCliente().Editar(cliente, out mensaje);

            if (resultado)
            {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "Cliente editado con éxito.";
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
            lblDocumento.Text = string.Empty;
            lblNombre.Text = string.Empty;
            lblCorreo.Text = string.Empty;
            lblTelefono.Text = string.Empty;
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
            txtDocumento.Texts = string.Empty;
            txtNombre.Texts = string.Empty;
            txtCorreo.Texts = string.Empty;
            txtTelefono.Texts = string.Empty;
            cmbEstado.SelectedIndex = 0;

            txtDocumento.Select();
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.FromArgb(23, 145, 200);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el cliente", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Cliente eliminarCliente = new Cliente()
                    {
                        idCliente = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new ServicioCliente().Eliminar(eliminarCliente, out mensaje);

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

            if (dgvClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvClientes.Rows)
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
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
