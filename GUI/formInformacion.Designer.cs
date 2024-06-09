namespace GUI
{
    partial class formInformacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxYears = new GUI.Componentes_Personalizad.ComboBoxOFSolution();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1261, 641);
            this.panel2.TabIndex = 1;
            // 
            // chartReport
            // 
            chartArea2.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea2);
            this.chartReport.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartReport.Legends.Add(legend2);
            this.chartReport.Location = new System.Drawing.Point(20, 20);
            this.chartReport.Name = "chartReport";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartReport.Series.Add(series2);
            this.chartReport.Size = new System.Drawing.Size(1221, 601);
            this.chartReport.TabIndex = 6;
            this.chartReport.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxYears);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(530, 5, 530, 5);
            this.panel3.Size = new System.Drawing.Size(1261, 44);
            this.panel3.TabIndex = 8;
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            this.comboBoxYears.BorderSize = 1;
            this.comboBoxYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxYears.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxYears.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxYears.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxYears.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxYears.Location = new System.Drawing.Point(530, 5);
            this.comboBoxYears.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxYears.Size = new System.Drawing.Size(201, 34);
            this.comboBoxYears.TabIndex = 8;
            this.comboBoxYears.Texts = "";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18.15652F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label1.Size = new System.Drawing.Size(1261, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reporte Anual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formInformacion";
            this.Text = "formInformacion";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Componentes_Personalizad.ComboBoxOFSolution comboBoxYears;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.Label label1;
    }
}