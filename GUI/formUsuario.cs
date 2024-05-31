using BLL;
using ENTITY;
using GUI.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI
{
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
        }

        private void formUsuario_Load(object sender, EventArgs e)
        {
            //cargar combobox estado
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;

            //cargar combobox rol
            List<Rol> listaRol = new ServicioRol().Listar();

            foreach (Rol item in listaRol)
            {
                cmbRol.Items.Add(new OpcionComboBox() { Valor = item.idRol, Texto = item.descripcion });
            }
            cmbRol.DisplayMember = "Texto";
            cmbRol.ValueMember = "Valor";
            cmbRol.SelectedIndex = 0;


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


            //MOSTRAR TODOS LOS USUARIOS
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
                    item.correo ,
                    item.telefono,
                    item.rol.idRol,
                    item.rol.descripcion,
                    item.estado == true ? "Activo" : "Inactivo",
                    item.estado == true ? 1 : 0
                });
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void Limpiar()
        {
            txtId.Text = string.Empty;
            txtDocumento.Texts = string.Empty;
            txtNombre.Texts = string.Empty; 
            txtUsuario.Texts = string.Empty;    
            txtClave.Texts = string.Empty;
            txtConfirmarClave.Texts = string.Empty;
            txtCorreo.Texts = string.Empty;
            txtTelefono.Texts = string.Empty;   
            txtBuscar.Texts = string.Empty; 
            cmbBusqueda.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            cmbRol.SelectedIndex = 0;
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
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtId.Text = dgvUsuarios.Rows[indice].Cells["idUsuario"].Value.ToString();
                    txtDocumento.Texts = dgvUsuarios.Rows[indice].Cells["documento"].Value.ToString();
                    txtNombre.Texts = dgvUsuarios.Rows[indice].Cells["nombreCompleto"].Value.ToString();
                    txtUsuario.Texts = dgvUsuarios.Rows[indice].Cells["nombreUsuario"].Value.ToString();
                    txtClave.Texts = dgvUsuarios.Rows[indice].Cells["clave"].Value.ToString();
                    txtConfirmarClave.Texts = dgvUsuarios.Rows[indice].Cells["clave"].Value.ToString();
                    txtCorreo.Texts = dgvUsuarios.Rows[indice].Cells["correo"].Value.ToString();
                    txtTelefono.Texts = dgvUsuarios.Rows[indice].Cells["telefono"].Value.ToString();

                    foreach (OpcionComboBox opcionComboBox in cmbRol.Items)
                    {

                        if (Convert.ToInt32(opcionComboBox.Valor) == Convert.ToInt32(dgvUsuarios.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = cmbRol.Items.IndexOf(opcionComboBox);
                            cmbRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                    foreach (OpcionComboBox opcionComboBox in cmbEstado.Items)
                    {
                        if (Convert.ToInt32(opcionComboBox.Valor) == Convert.ToInt32(dgvUsuarios.Rows[indice].Cells["valorEstado"].Value))
                        {
                            int indice_combo = cmbEstado.Items.IndexOf(opcionComboBox);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        }
    }
}
