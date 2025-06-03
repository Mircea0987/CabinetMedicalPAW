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
    public partial class ReteteFormChart : Form
    {
        List<Retete> retete  = new List<Retete>();
        public ReteteFormChart(List<Retete> reteteList)
        {
            InitializeComponent();
            this.retete = reteteList;
        }

        private void ReteteFormChart_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Nr. de medicamente per reteta");
            chart1.Series[0].Points.Clear();

            foreach(var r in retete)
            {
                chart1.Series[0].Points.AddXY(r.NumePacient, r.Medicamente.Count());
            }


        }
    }
}
