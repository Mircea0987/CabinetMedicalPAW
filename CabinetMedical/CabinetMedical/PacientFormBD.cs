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
    public partial class PacientFormBD : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CabinetMedical;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlDataAdapter adapter = new SqlDataAdapter();
        public PacientFormBD()
        {
            InitializeComponent();
        }

        private void PacientFormBD_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Pacienti",connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
