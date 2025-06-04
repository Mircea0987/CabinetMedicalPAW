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
        private BindingList<Medici> mediciBinding = new BindingList<Medici>();
        public MediciFormChart(BindingList<Medici> mediciList)
        {
            InitializeComponent();
            mediciBinding = mediciList;


            mediciBinding.ListChanged += MediciBinding_ListChanged;

        }
        private void MediciBinding_ListChanged(object sender, ListChangedEventArgs e)
        {
            actualizeazaGrafic(); 
        }

        private void MediciFormChart_Load(object sender, EventArgs e)
        {
            actualizeazaGrafic();


        }
        private void actualizeazaGrafic()
        {
            chart1.Series["Salarii"].Points.Clear();

            foreach (Medici m in mediciBinding)
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
