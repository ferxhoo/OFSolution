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
    public partial class ModalformCliente : Form
    {

        public Cliente clienteSeleccionado  { get; set; }

        public ModalformCliente()
        {
            InitializeComponent();
        }

        private void ModalformCliente_Load(object sender, EventArgs e)
        {
            CargarCmbBuscar();
            CargarDataTable();
            dgvClientes.ClearSelection();
        }

        private void CargarCmbBuscar()
        {
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
            dgvClientes.Rows.Clear();

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
                });
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
        }

        private void HandleCellClick(DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum >= 0)
            {
                clienteSeleccionado = new Cliente()
                {
                    idCliente = Convert.ToInt32(dgvClientes.Rows[iRow].Cells["idCliente"].Value.ToString()),
                    documento = dgvClientes.Rows[iRow].Cells["documento"].Value.ToString(),
                    nombreCompleto = dgvClientes.Rows[iRow].Cells["nombreCompleto"].Value.ToString(),
                    correo = dgvClientes.Rows[iRow].Cells["correo"].Value.ToString(),
                    telefono = dgvClientes.Rows[iRow].Cells["telefono"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(e);
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

    }
}
