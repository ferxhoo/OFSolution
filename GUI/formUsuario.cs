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
//using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI
{
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void formUsuario_Load(object sender, EventArgs e)
        {
            CargarCmbEstado();
            CargarCmbRol(); 
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

        private void CargarCmbRol()
        {
            //cargar combobox rol
            List<Rol> listaRol = new ServicioRol().Listar();

            foreach (Rol item in listaRol)
            {
                cmbRol.Items.Add(new OpcionComboBox() { Valor = item.idRol, Texto = item.descripcion });
            }
            cmbRol.DisplayMember = "Texto";
            cmbRol.ValueMember = "Valor";
            cmbRol.SelectedIndex = 0;
        }

        private void CargarCmbBuscar()
        {
            //cargar combobox busqueda
            foreach (DataGridViewColumn columna in dgvUsuarios.Columns)
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
            dgvUsuarios.Rows.Clear();

            // Mostrar todos los usuarios
            List<Usuario> listaUsuario = new ServicioUsuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvUsuarios.Rows.Add(new object[] {
                    "",
                    item.idUsuario,
                    item.documento,
                    item.nombreCompleto,
                    item.nombreUsuario,
                    item.clave,
                    item.correo,
                    item.telefono,
                    item.rol.idRol,
                    item.rol.descripcion,
                    item.estado == true ? "Activo" : "Inactivo",
                    item.estado == true ? 1 : 0
                });
            }
        }


        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

            dgvUsuarios.ClearSelection();

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    Usuario usuario = ObtenerUsuarioDeFila(dgvUsuarios.Rows[indice]);
                    ActualizarControlesUsuario(usuario, indice);
                }
            }
        }

        private Usuario ObtenerUsuarioDeFila(DataGridViewRow fila)
        {
            Usuario usuario = new Usuario
            {
                idUsuario = Convert.ToInt32(fila.Cells["idUsuario"].Value),
                documento = fila.Cells["documento"].Value.ToString(),
                nombreCompleto = fila.Cells["nombreCompleto"].Value.ToString(),
                nombreUsuario = fila.Cells["nombreUsuario"].Value.ToString(),
                clave = fila.Cells["clave"].Value.ToString(),
                correo = fila.Cells["correo"].Value.ToString(),
                telefono = fila.Cells["telefono"].Value.ToString(),
                rol = new Rol() { idRol = Convert.ToInt32(fila.Cells["idRol"].Value) },
                estado = Convert.ToInt32(fila.Cells["valorEstado"].Value) == 1
            };

            return usuario;
        }

        private void ActualizarControlesUsuario(Usuario usuario, int indice)
        {
            txtIndice.Text = indice.ToString();
            txtId.Text = usuario.idUsuario.ToString();
            txtDocumento.Texts = usuario.documento;
            txtNombre.Texts = usuario.nombreCompleto;
            txtUsuario.Texts = usuario.nombreUsuario;
            txtClave.Texts = usuario.clave;
            txtConfirmarClave.Texts = usuario.clave;
            txtCorreo.Texts = usuario.correo;
            txtTelefono.Texts = usuario.telefono;

            cmbRol.SelectedIndex = ObtenerIndiceComboBox(cmbRol, usuario.rol.idRol);
            cmbEstado.SelectedIndex = ObtenerIndiceComboBox(cmbEstado, usuario.estado ? 1 : 0);


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

            if (VerificarClave())
            {
                return;
            }

            Usuario nuevoUsuario = CrearNuevoUsuario();

            if (nuevoUsuario.idUsuario == 0)
            {
                RegistrarUsuario(nuevoUsuario);
            }
            else
            {
                EditarUsuario(nuevoUsuario);
            }
        }

        private bool VerificarCampos()
        {
            bool hayCampoVacio = false;

            hayCampoVacio |= VerificarCampoVacio(txtDocumento, lblDocumento, "documento");
            hayCampoVacio |= VerificarCampoVacio(txtNombre, lblNombre, "nombre");
            hayCampoVacio |= VerificarCampoVacio(txtUsuario, lblUsuario, "usuario");
            hayCampoVacio |= VerificarCampoVacio(txtClave, lblClave, "campo contraseña");
            hayCampoVacio |= VerificarCampoVacio(txtConfirmarClave, lblConfirmar, "campo de validación");
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

        private bool VerificarClave()
        {
            bool coincide = false;
            if (txtClave.Texts != txtConfirmarClave.Texts)
            {
                lblConfirmar.ForeColor = Color.Red;
                lblConfirmar.Text = "La contraseña no coincide";
                coincide = true;
            }
            return coincide;
        }

        private Usuario CrearNuevoUsuario()
        {
            return new Usuario()
            {
                idUsuario = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                documento = txtDocumento.Texts,
                nombreCompleto = txtNombre.Texts,
                nombreUsuario = txtUsuario.Texts,
                clave = txtClave.Texts,
                correo = txtCorreo.Texts,
                telefono = txtTelefono.Texts,
                rol = new Rol() { idRol = Convert.ToInt32(((OpcionComboBox)cmbRol.SelectedItem).Valor) },
                estado = Convert.ToInt32(((OpcionComboBox)cmbEstado.SelectedItem).Valor) == 1
            };
        }

        private void RegistrarUsuario(Usuario usuario)
        {
            string mensaje = string.Empty;
            int idUsuarioGenerado = new ServicioUsuario().Registrar(usuario, out mensaje);

            if (idUsuarioGenerado != 0)
            {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "Usuario registrado con éxito.";
                ActualizarUI();
            }
            else
            {
                lblCheck.ForeColor = Color.Red;
                lblCheck.Text = mensaje;
            }
        }

        private void EditarUsuario(Usuario usuario)
        {
            string mensaje = string.Empty;
            bool resultado = new ServicioUsuario().Editar(usuario, out mensaje);

            if (resultado)
            {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "Usuario editado con éxito.";
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
            lblUsuario.Text = string.Empty;
            lblClave.Text = string.Empty;
            lblConfirmar.Text = string.Empty;
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
            txtUsuario.Texts = string.Empty;
            txtClave.Texts = string.Empty;
            txtConfirmarClave.Texts = string.Empty;
            txtCorreo.Texts = string.Empty;
            txtTelefono.Texts = string.Empty;
            cmbEstado.SelectedIndex = 0;
            cmbRol.SelectedIndex = 0;

            txtDocumento.Select();
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.FromArgb(23, 145, 200);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Usuario eliminarUsuario = new Usuario()
                    {
                        idUsuario = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new ServicioUsuario().Eliminar(eliminarUsuario, out mensaje);

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

            if (dgvUsuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsuarios.Rows)
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
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                row.Visible = true;
            }
        }


    }
}
