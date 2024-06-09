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
    public partial class formCategorias : Form
    {

        public formCategorias()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void formCategorias_Load(object sender, EventArgs e)
        {
            CargarCmbEstado();
            CargarCmbBuscar();
            CargarDataTable();
            Limpiar();
            LimpiarMensajes();
        }

        private void CargarCmbEstado()
        {
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionComboBox() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;
        }

        private void CargarCmbBuscar()
        {
            foreach (DataGridViewColumn columna in dgvCategorias.Columns)
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
            dgvCategorias.Rows.Clear();

            List<Categoria> lista = new ServicioCategoria().Listar();

            foreach (Categoria item in lista)
            {
                dgvCategorias.Rows.Add(new object[] {
                    "",
                    item.idCategoria,
                    item.descripcion,
                    item.estado == true ? "Activo" : "Inactivo",
                    item.estado == true ? 1 : 0
                });
            }
        }

        private void dgvCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

            dgvCategorias.ClearSelection();

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    Categoria categoria = ObtenerCategoriaDeFila(dgvCategorias.Rows[indice]);
                    ActualizarControlesCategoria(categoria, indice);
                }
            }

        }

        private Categoria ObtenerCategoriaDeFila(DataGridViewRow fila)
        {
            Categoria categoria = new Categoria
            {
                idCategoria = Convert.ToInt32(fila.Cells["idCategoria"].Value),
                descripcion = fila.Cells["descripcion"].Value.ToString(),
                estado = Convert.ToInt32(fila.Cells["valorEstado"].Value) == 1
            };

            return categoria;
        }

        private void ActualizarControlesCategoria(Categoria categoria, int indice)
        {
            txtIndice.Text = indice.ToString();
            txtId.Text = categoria.idCategoria.ToString();
            txtDescripcion.Texts = categoria.descripcion;
            
            cmbEstado.SelectedIndex = ObtenerIndiceComboBox(cmbEstado, categoria.estado ? 1 : 0);


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
            return -1; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                return;
            }

            Categoria nuevaCategoria = CrearNuevaCategoria();

            if (nuevaCategoria.idCategoria == 0)
            {
                RegistrarCategoria(nuevaCategoria);
            }
            else
            {
                EditarCategoria(nuevaCategoria);
            }
        }

        private bool VerificarCampos()
        {
            bool hayCampoVacio = false;

            hayCampoVacio |= VerificarCampoVacio(txtDescripcion, lblDescripcion, "descripcion");
            
            return hayCampoVacio;
        }

        private bool VerificarCampoVacio(TextBoxOFSolution textBox, Label label, string campo)
        {
            bool control = false;
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                control = true;
                label.ForeColor = Color.Red;
                label.Text = $"La {campo} no puede ser vacía";
            }
            else
            {
                label.Text = "";
            }
            return control;
        }

        private Categoria CrearNuevaCategoria()
        {
            return new Categoria()
            {
                idCategoria = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                descripcion = txtDescripcion.Texts,
                estado = Convert.ToInt32(((OpcionComboBox)cmbEstado.SelectedItem).Valor) == 1
            };
        }

        private void RegistrarCategoria(Categoria nuevaCategoria)
        {
            string mensaje = string.Empty;
            int idCategoriaGenerado = new ServicioCategoria().Registrar(nuevaCategoria, out mensaje);

            if (idCategoriaGenerado != 0)
            {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "Categoria registrada con éxito.";
                ActualizarUI();
            }
            else
            {
                lblCheck.ForeColor = Color.Red;
                lblCheck.Text = mensaje;
            }
        }

        private void EditarCategoria(Categoria nuevaCategoria)
        {
            string mensaje = string.Empty;
            bool resultado = new ServicioCategoria().Editar(nuevaCategoria, out mensaje);

            if (resultado)
            {
                lblCheck.ForeColor = Color.Green;
                lblCheck.Text = "Categoria editada con éxito.";
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

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDescripcion.Texts = string.Empty;
            
            cmbEstado.SelectedIndex = 0;

            txtDescripcion.Select();
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.FromArgb(23, 145, 200);

        }

        private void LimpiarMensajes()
        {
            lblDescripcion.Text = string.Empty;
            lblCheck.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarMensajes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la Categoria", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Categoria eliminarCategoria = new Categoria()
                    {
                        idCategoria = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new ServicioCategoria().Eliminar(eliminarCategoria, out mensaje);

                    if (respuesta)
                    {
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

            if (dgvCategorias.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCategorias.Rows)
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
            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                row.Visible = true;
            }
        }

    }


}
