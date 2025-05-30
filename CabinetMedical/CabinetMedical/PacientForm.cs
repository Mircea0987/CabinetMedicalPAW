using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CabinetMedical
{
    public partial class PacientForm : Form
    {
        List<Pacient> pacientList = new List<Pacient>();
        public PacientForm()
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
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void mEDICIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediciForm mf = new MediciForm();
            mf.Show();
            this.Close();
        }

        private void cABINETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CabinetForm cf = new CabinetForm();
            cf.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nume = textBox1.Text;
                string prenume = textBox2.Text;
                string cnp = textBox3.Text;
                DateTime dataNasterii = dateTimePicker1.Value;

                if (string.IsNullOrWhiteSpace(nume))
                {
                    errorProvider1.SetError(textBox1, "Introduceți un nume valid.");
                }

                if (string.IsNullOrWhiteSpace(prenume))
                {
                    errorProvider1.SetError(textBox2, "Introduceți un prenume valid.");
                }

                if (cnp.Length != 13)
                {
                    errorProvider1.SetError(textBox3, "CNP-ul trebuie să conțină exact 13 cifre.");
                }

                Pacient p = new Pacient(dataNasterii, nume, prenume, cnp);
                pacientList.Add(p);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EROARE", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (Pacient p in pacientList)
            {
                ListViewItem item = new ListViewItem(p.Prenume);
                item.SubItems.Add(p.Nume);

                item.SubItems.Add(p.CNP);
                item.SubItems.Add(p.DataNasterii.ToShortDateString());

                listView1.Items.Add(item);

            }
        }
    }
}


