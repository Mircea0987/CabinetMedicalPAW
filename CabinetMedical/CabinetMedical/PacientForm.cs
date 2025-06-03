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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CabinetMedical
{
    public partial class PacientForm : Form
    {
        List<Pacient> pacientList = new List<Pacient>();

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CabinetMedical;Integrated Security=True;Connect Timeout=30;Encrypt=False");
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
                if(dataNasterii > DateTime.Now)
                {
                    errorProvider1.SetError(dateTimePicker1, "Data nasterii trebuie sa fie valida!");
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Pacienti(nume_pacient,data_nasterii,prenume_pacient,CNP)" +
                    "VALUES(@nume_pacient,@data_nasterii,@prenume_pacient,@CNP)", connection);


                connection.Open();

                cmd.Parameters.AddWithValue("@nume_pacient", nume);
                cmd.Parameters.AddWithValue("@data_nasterii", dataNasterii);
                cmd.Parameters.AddWithValue("@prenume_pacient", prenume);
                cmd.Parameters.AddWithValue("@CNP", cnp);

                cmd.ExecuteNonQuery();
                
                connection.Close();

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

        private void gOBACKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void cABINETToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CabinetForm c = new CabinetForm();
            c.Show();
            this.Close();
        }

        private void mEDICIToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                foreach(Pacient p in pacientList)
                {
                    sw.WriteLine(p.ToString());
                }
                sw.Close();
                MessageBox.Show("Salvare a fost facuta!");
            }
            else
            {
                MessageBox.Show("Eroare","Salvare esuata",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void tXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);

                textBox4.Text += streamReader.ReadToEnd() + Environment.NewLine;

                streamReader.Close();
                MessageBox.Show("Citirea a fost facuta!");
            }
            else
            {
                MessageBox.Show("Eroare!","Citire esuata!",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void bINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.bin)|*.bin";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName,FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, pacientList);

                fs.Close();
                MessageBox.Show("Salvare reusita!");
            }
            else
            {
                MessageBox.Show("Eroare!", "Problema la salvare!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void bINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.bin)|*.bin";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                List<Pacient> pacientList =(List<Pacient>)bf.Deserialize(fs);

                foreach (Pacient p in pacientList)
                {
                    textBox4.Text += p.ToString();
                }

                fs.Close();
                MessageBox.Show("Citire reusita!","Citire efectuata cu succes!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eroare!","Citire nereusita!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                listView1.Items.Clear();
            }
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void bAZEDEDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientFormBD pacientFormBD = new PacientFormBD();
            pacientFormBD.Show();
        }

        private void cHARTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}


