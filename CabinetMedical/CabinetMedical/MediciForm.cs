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
    public partial class MediciForm : Form
    {
        BindingList<Medici> mediciList = new BindingList<Medici> ();

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CabinetMedical;Integrated Security=True;Connect Timeout=30;Encrypt=False");
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
                    return;

                }

                string telefon = textBox2.Text;

                if(telefon.Length !=10)
                {
                    errorProvider1.SetError(textBox2, "Telefonul trebuie sa fie valid (10 numere)");
                    return;

                }
                string email = textBox3.Text;
                
                if(email.Length == 0)
                {
                    errorProvider1.SetError(textBox3, "Email trebuie sa fie valid!");
                    return;

                }

                string nume = textBox5.Text;
                
                if(nume.Length == 0)
                {
                    errorProvider1.SetError(textBox5, "Numele trebuie sa fie valid!");
                    return;

                }

                string prenume = textBox6.Text;

                if(prenume.Length == 0)
                {
                    errorProvider1.SetError(textBox6, "Prenumele trebuie sa fie valid!");
                    return;

                }

                string CNP = textBox7.Text;
                if(CNP.Length !=13) {

                    errorProvider1.SetError(textBox7, "CNP trebuie sa aiba 13 caractere!");
                    return;


                }

                double salariul = double.Parse(textBox4.Text.Trim());

                if(salariul<2500)
                {
                    errorProvider1.SetError(textBox4, "Salariul trebuie sa fie peste/egal cu salariul minim!");
                    return;

                }

                SqlCommand cmd = new SqlCommand("INSERT INTO medici(Specializare,Nume,Prenume," +
                    "CNP,email,salariul,telefon) VALUES(@specializare,@nume,@prenume,@CNP,@email,@salariul,@telefon)",connection);

                connection.Open();

                cmd.Parameters.AddWithValue("@specializare", specializare);
                cmd.Parameters.AddWithValue("@nume",nume);
                cmd.Parameters.AddWithValue("@prenume",prenume);
                cmd.Parameters.AddWithValue("@CNP",CNP);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@salariul",salariul);
                cmd.Parameters.AddWithValue("@telefon", telefon);

                cmd.ExecuteNonQuery();

                connection.Close();
               
                Medici m = new Medici(specializare,telefon,email,nume,prenume,CNP,salariul);

                mediciList.Add(m);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();

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
                lvi.SubItems.Add(m.Salariul.ToString());

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

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK) { 
            
                StreamWriter w = new StreamWriter(saveFileDialog1.FileName);

                foreach(Medici m in mediciList)
                {
                    w.WriteLine(m.ToString());
                }
                w.Close();
                MessageBox.Show("Salvare cu succes!","Salvare a fost facuta!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eroare","Problema la salvare!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void bINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.bin)|*.bin";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, mediciList);

                fs.Close();
                MessageBox.Show("Scriere reusita!");
            }
            else
            {
                MessageBox.Show("Eroare!", "Problema la scriere!", MessageBoxButtons.OKCancel);
            }
        }

        private void tXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";

            if(openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {

                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                textBox8.Text += sr.ReadToEnd();

                sr.Close();
                MessageBox.Show("Reusit!","Citire reuista!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("EROARE!","Eroare la citire!",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void bINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.bin)|*.bin";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                List<MediciForm> mediciList = (List<MediciForm>)bf.Deserialize(fs);

                foreach(MediciForm m in mediciList)
                {
                    textBox8.Text+= m.ToString() + Environment.NewLine;
                }
                fs.Close();
                MessageBox.Show("Reusit!","S-a citit cu succes!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eroare!","Problema la citire!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void cHARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediciFormChart mfc = new MediciFormChart(mediciList);
            mfc.Show();

        }

        private void bAZEDEDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediciFormBD mfbd = new MediciFormBD();
            mfbd.Show();
        }
    }
}
