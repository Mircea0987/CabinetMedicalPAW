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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Text = "Meniu Principal";
            this.BackColor = ColorTranslator.FromHtml("#f0f0f0");
        }

        private void rETETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReteteForm rf1 = new ReteteForm();
            rf1.Show();
            this.Hide();
        }

        private void cABINETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CabinetForm cbf = new CabinetForm();
            cbf.Show();
            this.Hide();

        }

        private void mEDICIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediciForm m = new MediciForm();
            m.Show();
            this.Hide();
        }

        private void pACIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientForm pf = new PacientForm();
            pf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pentru a naviga foloseste din meniu o sectiune!", "Salutare!", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
