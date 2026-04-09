using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Form1: Form
    {
        private readonly sqlConnection conn;
        private readonly string connectionString = "Data Source=RIZOO\\MUHAMMADRIO; Initial Catalog=DBAkademikADO; Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            conn = new sqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
