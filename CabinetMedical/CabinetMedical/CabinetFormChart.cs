using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical
{
    public partial class CabinetFormChart : Form
    {
        private List<Cabinet> cabinets;
        private PrintDocument printDocument = new PrintDocument();
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

        private void pp(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(chart1.Width, chart1.Height);
            
            chart1.DrawToBitmap(bmp,new Rectangle(0,0,bmp.Width,bmp.Height));

            e.Graphics.DrawImage(bmp, new Point(100, 100));
        }

        private void iMPRIMAREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument print = new PrintDocument();
            print.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog()
            {
                Document = print
            };
            pdlg.ShowDialog();

        }
    }
}
