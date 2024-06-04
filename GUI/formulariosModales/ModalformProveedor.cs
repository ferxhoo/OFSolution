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
using System.Windows.Forms;

namespace GUI.formulariosModales
{
    public partial class ModalformProveedor : Form
    {

        public Proveedor proveedorSeleccionado { get; set; }

        public ModalformProveedor()
        {
            InitializeComponent();
        }

        private void ModalformProveedor_Load(object sender, EventArgs e)
        {
            CargarCmbBuscar();
            CargarDataTable();
        }

        private void CargarCmbBuscar()
        {
            //cargar combobox busqueda
            foreach (DataGridViewColumn columna in dgvProveedores.Columns)
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
            dgvProveedores.Rows.Clear();

            // Mostrar todos los usuarios
            List<Proveedor> lista = new ServicioProveedor().Listar();

            foreach (Proveedor item in lista)
            {
                dgvProveedores.Rows.Add(new object[] {
                    "",
                    item.idProveedor,
                    item.documento,
                    item.nombreCompleto,
                    item.razonSocial,
                });
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionComboBox)cmbBusqueda.SelectedItem).Valor.ToString();

            if (dgvProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProveedores.Rows)
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
            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

            dgvProveedores.ClearSelection();

        }
    }
}
