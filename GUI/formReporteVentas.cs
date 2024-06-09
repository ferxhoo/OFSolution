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
    public partial class formReporteVentas : Form
    {


        public formReporteVentas()
        {
            InitializeComponent();

        }

        private void formReporteVentas_Load(object sender, EventArgs e)
        {
            CargarCmbBuscar();
            CargarDataTable();
            // Añadir eventos para actualizar el DataGridView al cambiar las fechas
            dtpFechaInicio.ValueChanged += new EventHandler(DatePicker_ValueChanged);
            dtpFechaFin.ValueChanged += new EventHandler(DatePicker_ValueChanged);
        }

        private void CargarCmbBuscar()
        {
            // Limpiar los elementos existentes en el ComboBox
            cmbBusqueda.Items.Clear();

            // Añadir la opción "Todos" al ComboBox
            cmbBusqueda.Items.Add(new OpcionComboBox() { Valor = "Todos", Texto = "Todos" });

            // Añadir los nombres de las columnas al ComboBox
            foreach (DataGridViewColumn columna in dgvVenta.Columns)
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
                // Limpiar las filas existentes en el DataGridView
                dgvVenta.Rows.Clear();

                // Obtener las fechas seleccionadas en los DateTimePicker y ajustar la hora de inicio a las 00:00:00
                DateTime fechaInicio = dtpFechaInicio.Value.Date;
                DateTime fechaFin = dtpFechaFin.Value;

                // Obtener la lista de ventas entre las fechas seleccionadas
                List<Venta> lista = new ServicioFactura().ObtenerVentasEntreFechas(fechaInicio, fechaFin);

                // Obtener el total de ganancias entre las fechas seleccionadas
                decimal total = new ServicioFactura().ObtenerGananciasEntreFechas(fechaInicio, fechaFin);

                // Mostrar el total de ganancias en el control txtTotal
                txtTotal.Texts = total.ToString();

                // Cargar las ventas en el DataGridView
                foreach (var venta in lista)
                {
                    dgvVenta.Rows.Add(
                        venta.fechaRegistro,
                        venta.tipoDocumento,
                        venta.numeroDocumento,
                        venta.usuario.nombreCompleto,
                        venta.mesero.nombreCompleto,
                        venta.numeroMesa,
                        venta.documentoCliente,
                        venta.nombreCliente,
                        venta.montoPago,
                        venta.montoCambio,
                        venta.montoTotal
                    );
                }
                dgvVenta.ClearSelection();
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
                // Si la opción seleccionada es "Todos", mostrar todas las filas
                foreach (DataGridViewRow row in dgvVenta.Rows)
                {
                    row.Visible = true;
                }
            }
            else if (dgvVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVenta.Rows)
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
            // Limpiar el texto de búsqueda
            txtBuscar.Texts = string.Empty;

            // Restablecer el ComboBox a la opción predeterminada
            cmbBusqueda.SelectedIndex = 0;

            // Mostrar todas las filas en el DataGridView
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                row.Visible = true;
            }

            // Restablecer las fechas a la fecha actual
            DateTime today = DateTime.Today;
            dtpFechaInicio.Value = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0); // Fecha actual con hora 0
            dtpFechaFin.Value = today;

            // Recargar los datos en el DataGridView
            CargarDataTable();
        }

    }
}
