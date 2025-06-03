using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical
{
    public partial class MediciFormBD : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CabinetMedical;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlDataAdapter adapter = new SqlDataAdapter();

        public MediciFormBD()
        {
            InitializeComponent();
        }

        private void MediciFormBD_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Medici", connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
