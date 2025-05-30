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
    public partial class MediciForm : Form
    {
        List<Medici> mediciList = new List<Medici> ();
        public MediciForm()
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
                string specializare = textBox1.Text;

                if(specializare.Length == 0)
                {
                    errorProvider1.SetError(textBox1, "Specializarea trebuie sa fie valida!");
                }

                string telefon = textBox2.Text;

                if(telefon.Length !=10)
                {
                    errorProvider1.SetError(textBox2, "Telefonul trebuie sa fie valid (10 numere)");
                }
                string email = textBox3.Text;
                
                if(email.Length == 0)
                {
                    errorProvider1.SetError(textBox3, "Email trebuie sa fie valid!");
                }

                string nume = textBox5.Text;
                
                if(nume.Length == 0)
                {
                    errorProvider1.SetError(textBox5, "Numele trebuie sa fie valid!");
                }

                string prenume = textBox6.Text;

                if(prenume.Length == 0)
                {
                    errorProvider1.SetError(textBox6, "Prenumele trebuie sa fie valid!");
                }

                string CNP = textBox7.Text;
                if(CNP.Length !=13) {

                    errorProvider1.SetError(textBox7, "CNP trebuie sa aiba 13 caractere!");

                }
                Medici m = new Medici(specializare,telefon, email,nume,prenume,CNP);

                mediciList.Add(m);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"EROARE",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (Medici m in mediciList)
            {
                ListViewItem lvi = new ListViewItem(m.Specializare);
                lvi.SubItems.Add(m.Telefon);
                lvi.SubItems.Add(m.Email);
                lvi.SubItems.Add(m.Nume);
                lvi.SubItems.Add(m.Prenume);
                lvi.SubItems.Add(m.CNP);

                listView1.Items.Add(lvi);
            }
        }

        private void rETETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReteteForm rf = new ReteteForm();
            rf.ShowDialog();
            this.Close();
        }

        private void cABINETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CabinetForm cf = new CabinetForm();
            cf.Show();
            this.Close();
        }

        private void pACIENTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientForm pf = new PacientForm();
            pf.Show();
            this.Close();
        }
    }
}
