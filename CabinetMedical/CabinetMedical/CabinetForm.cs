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
    public partial class CabinetForm : Form
    {
        List<Cabinet> cabinetList = new List<Cabinet>();    
        public CabinetForm()
        {
            InitializeComponent();
        }

        private void gOBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string nume = textBox1.Text;

                if(nume.Length == 0)
                {
                    errorProvider1.SetError(textBox1, "Numele trebuie sa fie valid!");
                }
                string adresa = textBox2.Text;

                if(adresa.Length == 0)
                {
                    errorProvider1.SetError(textBox2, "Adresa trebuie sa fie valida!");
                }
                string telefon = textBox3.Text;

                if(telefon.Length == 0)
                {
                    errorProvider1.SetError(textBox3, "Numarul de telefon trebuie sa fie valid!");
                }
                int capacitateCabinet = int.Parse(textBox4.Text);

                if(capacitateCabinet == 0 && capacitateCabinet < 0)
                {
                    errorProvider1.SetError(textBox4, "Capacitate trebuie sa fie valida!");
                }
                Cabinet c = new Cabinet(nume, adresa, telefon, capacitateCabinet);
                cabinetList.Add(c);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"EROARE",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach(Cabinet c in cabinetList) {
                
                ListViewItem lvi = new ListViewItem(c.Nume);
                lvi.SubItems.Add(c.Adresa);
                lvi.SubItems.Add(c.Telefon);
                lvi.SubItems.Add(c.Capacitate.ToString());

                listView1.Items.Add(lvi);
            }
        }

        private void mEDICIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediciForm mf = new MediciForm();
            mf.Show();
            this.Close();
        }

        private void rETETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReteteForm rf = new ReteteForm();
            rf.Show();
            this.Close();
        }

        private void pACIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientForm pf = new PacientForm();
            pf.Show();
            this.Close();
        }
    }
}
