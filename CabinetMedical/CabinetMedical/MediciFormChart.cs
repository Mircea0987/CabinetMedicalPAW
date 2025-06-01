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
    public partial class MediciFormChart : Form
    {
        private List<Medici> medici;
        public MediciFormChart(List<Medici> mediciList)
        {
            InitializeComponent();
            medici = mediciList;
        }

        private void MediciFormChart_Load(object sender, EventArgs e)
        { 

            chart1.Series["Salarii"].Points.Clear();

            foreach (Medici m in medici)
            {
                chart1.Series["Salarii"].Points.AddXY(m.Nume, m.Salariul);
            }

            chart1.Series["Salarii"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void bMPToolStripMenuItem_Click(Control c,string numeFisier)
        {

       

        }

        private void bMPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
