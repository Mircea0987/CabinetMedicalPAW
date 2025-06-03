using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical
{
    public partial class ReteteForm : Form
    {
        List<Retete> reteList = new List<Retete>();

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CabinetMedical;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public ReteteForm()
        {
            InitializeComponent();
        }

        private void gOBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                String nume = textBox1.Text;
                if(nume.Length == 0)
                {
                    errorProvider1.SetError(textBox1, "Numele trebuie sa fie valid!");
                }
                String[] medicamente = textBox2.Text.Split(',');

                string medicamenteText = string.Join(",", medicamente); //BD nu stie sa faca conversia string[] => string

                if(medicamente.Length == 0)
                {
                    errorProvider1.SetError(textBox2, "Medicamentele trebuie sa fie valide!");
                }

                DateTime dateEmitere = dateTimePicker1.Value.Date;

                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Retete(nume_reteta,data_emitere," +
                    "medicamente) VALUES(@nume_reteta,@data_emitere,@medicamente)", connection);

                cmd.Parameters.AddWithValue("@nume_reteta", nume);
                cmd.Parameters.AddWithValue("@data_emitere", dateEmitere);
                cmd.Parameters.AddWithValue("@medicamente", medicamenteText);

                cmd.ExecuteNonQuery();

                connection.Close();

                Retete r = new Retete(nume, dateEmitere, medicamente);
                reteList.Add(r);

                textBox1.Clear();
                textBox2.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Retete r in reteList) { 

                ListViewItem lvi = new ListViewItem(r.NumePacient);
                lvi.SubItems.Add(r.DataEmitere.ToString());
                lvi.SubItems.Add(string.Join(", ", r.Medicamente));

                listView1.Items.Add(lvi);
            }
        }

        private void mEDICIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediciForm mf = new MediciForm();
            mf.Show();
            this.Close();
        }

        private void pACIENTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientForm pf = new PacientForm();
            pf.Show();
            this.Close();
        }

        private void cABINETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CabinetForm cf = new CabinetForm();
            cf.Show();
            this.Close();
        }

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                foreach(Retete r in reteList)
                {
                    sw.WriteLine(r.ToString());
                }
                sw.Close();
                MessageBox.Show("Succes!", "Scrierea a fost realizata cu succes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eroare!", "Scrierea nu a fost realizata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void bINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.bin)|*.bin";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, reteList);

                fs.Close();
                MessageBox.Show("Succes!", "Citirea a fost realizata cu succes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eroare!", "Eroare la citirea din fisier!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void tXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";

            if(openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                textBox3.Text += sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("Succes!", "Citire realizata cu succes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eroare!", "Eroare la citirea din fisier!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void bAZADEDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReteteFormBD rfbd = new ReteteFormBD();
            rfbd.Show();
        }

        private void cHARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReteteFormChart reteteFormChart = new ReteteFormChart(reteList);
            reteteFormChart.Show();
        }
    }
}
