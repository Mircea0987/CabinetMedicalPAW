using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical
{
    public partial class CabinetFormChart : Form
    {
        private List<Cabinet> cabinets;
        public CabinetFormChart(List<Cabinet> cabinets)
        {
            InitializeComponent();
            this.cabinets = cabinets;
        }

        private void CabinetFormChart_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Titles.Add("Capacitate cabinet");

            foreach(var cabinet in cabinets)
            {
                chart1.Series[0].Points.AddXY(cabinet.Nume,cabinet.Capacitate);
            }
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }
    }
}
