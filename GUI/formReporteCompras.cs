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

namespace GUI
{
    public partial class formReporteCompras : Form
    {
        public formReporteCompras()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void formReporteCompras_Load(object sender, EventArgs e)
        {
            CargarCmbBuscar();
            CargarDataTable();
            dtpFechaInicio.ValueChanged += new EventHandler(DatePicker_ValueChanged);
            dtpFechaFin.ValueChanged += new EventHandler(DatePicker_ValueChanged);
        }

        private void CargarCmbBuscar()
        {
            cmbBusqueda.Items.Clear();

            cmbBusqueda.Items.Add(new OpcionComboBox() { Valor = "Todos", Texto = "Todos" });

            foreach (DataGridViewColumn columna in dgvCompras.Columns)
            {
                cmbBusqueda.Items.Add(new OpcionComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
            }

            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;
        }

        private void CargarDataTable()
        {
            if (cmbBusqueda.SelectedIndex == 0)
            {
                dgvCompras.Rows.Clear();

                DateTime fechaInicio = dtpFechaInicio.Value.Date;
                DateTime fechaFin = dtpFechaFin.Value;

                List<Compra> lista = new ServicioFactura().ObtenerComprasEntreFechas(fechaInicio, fechaFin);

                decimal total = new ServicioFactura().ObtenerGastosEntreFechas(fechaInicio, fechaFin);

                txtTotal.Texts = total.ToString();

                foreach (var compras in lista)
                {
                    dgvCompras.Rows.Add(
                        compras.fechaRegistro,
                        compras.tipoDocumento,
                        compras.numeroDocumento,
                        compras.usuario.nombreCompleto,
                        compras.proveedor.documento,
                        compras.proveedor.razonSocial,
                        compras.montoTotal
                    );
                }
                dgvCompras.ClearSelection();
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            CargarDataTable();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionComboBox)cmbBusqueda.SelectedItem).Valor.ToString();

            if (columnaFiltro == "Todos")
            {
                foreach (DataGridViewRow row in dgvCompras.Rows)
                {
                    row.Visible = true;
                }
            }
            else if (dgvCompras.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCompras.Rows)
                {
                    if (row.Cells[columnaFiltro].Value != null &&
                        row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Texts.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Texts = string.Empty;

            cmbBusqueda.SelectedIndex = 0;

            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                row.Visible = true;
            }

            DateTime today = DateTime.Today;
            dtpFechaInicio.Value = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0); 
            dtpFechaFin.Value = today;

            CargarDataTable();
        }

    }
}
