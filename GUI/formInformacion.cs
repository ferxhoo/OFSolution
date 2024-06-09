using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class formInformacion : Form
    {
        public formInformacion()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += new System.EventHandler(this.Form_Load);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            for (int year = 2000; year <= currentYear; year++)
            {
                comboBoxYears.Items.Add(year);
            }
            comboBoxYears.SelectedItem = currentYear;

            comboBoxYears.OnSelectedIndexChanged += ComboBoxYears_SelectedIndexChanged;

            UpdateChart((int)comboBoxYears.SelectedItem);
        }

        private void ComboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = (int)comboBoxYears.SelectedItem;
            UpdateChart(selectedYear);
        }

        private void UpdateChart(int year)
        {
            DateTime fechaInicio = new DateTime(year, 1, 1);
            DateTime fechaFin = new DateTime(year, 12, 31);

            ServicioReporte servicioReporte = new ServicioReporte();
            List<Reporte> reporte = servicioReporte.ObtenerReporteMensual(fechaInicio, fechaFin);

            chartReport.Series.Clear();
            chartReport.ChartAreas.Clear();
            chartReport.ChartAreas.Add(new ChartArea("MainArea"));

            Series seriesVentas = new Series("TotalVentas");
            seriesVentas.ChartType = SeriesChartType.Column; 
            seriesVentas.XValueType = ChartValueType.Int32;
            seriesVentas.YValueType = ChartValueType.Double;

            Series seriesCompras = new Series("TotalCompras");
            seriesCompras.ChartType = SeriesChartType.Column;
            seriesCompras.XValueType = ChartValueType.Int32;
            seriesCompras.YValueType = ChartValueType.Double;

            Series seriesResto = new Series("Resto");
            seriesResto.ChartType = SeriesChartType.Column;
            seriesResto.XValueType = ChartValueType.Int32;
            seriesResto.YValueType = ChartValueType.Double;

            foreach (var item in reporte)
            {
                seriesVentas.Points.AddXY(item.Mes, (double)item.TotalVentas);
                seriesCompras.Points.AddXY(item.Mes, (double)item.TotalCompras);
                seriesResto.Points.AddXY(item.Mes, (double)item.Resto);
            }

            chartReport.Series.Add(seriesVentas);
            chartReport.Series.Add(seriesCompras);
            chartReport.Series.Add(seriesResto);

            chartReport.ChartAreas["MainArea"].AxisX.Title = "Mes";
            chartReport.ChartAreas["MainArea"].AxisY.Title = "Monto";
            chartReport.ChartAreas["MainArea"].RecalculateAxesScale();
        }
    }
}
