using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(saveFileDialog1.FileName);

                foreach(Cabinet c in cabinetList)
                {
                    sr.WriteLine(c.ToString());
                }
                sr.Close();
                MessageBox.Show("Scriere cu succes!", "Scrierea a fost realizata cu succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Eroare!", "A avut loc o eroare!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); ;
            }
        }

        private void bINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.bin)|*.bin";

            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, this);
                fs.Close();
                MessageBox.Show("Succes!", "Scrierea a fost realizata cu succes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eroare!","A avut loc o eroare!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void tXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)}*.txt";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                textBox5.Text += sr.ReadToEnd();

                sr.Close();
                MessageBox.Show("Citire cu succes!", "Citirea a fost realizata cu succes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eroare!", "Citirea nu a fost realizata cu succes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
