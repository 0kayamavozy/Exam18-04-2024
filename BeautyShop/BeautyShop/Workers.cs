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

namespace BeautyShop
{
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }

        string Path = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = BeautyShop; Integrated Security = true";
        private SqlConnection connection = null;
        private SqlDataAdapter dataAdapter = null;

        private void SelectWorkers()
        {
            connection = new SqlConnection(Path);
            using (dataAdapter = new SqlDataAdapter("select * from Workers", connection))
            {
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                WorkersDataGird.DataSource = dt;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            SelectWorkers();
        }

        private void WorkersDataGird_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
