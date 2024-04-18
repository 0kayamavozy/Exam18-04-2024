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
    public partial class MyOrders : Form
    {
        public MyOrders()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        string Path = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = BeautyShop; Integrated Security = true";
        private SqlConnection connection = null;

        private void SelectOrder()
        {
            connection = new SqlConnection(Path);
            connection.Open();
            using (SqlCommand command = new SqlCommand("select * from MyOrders where SurnameNamePatronymic = @Login", connection))
            {
                command.Parameters.AddWithValue("@Login", GlobalHelper.Login);

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                _DataGrid.DataSource = dt;
            }
            

            connection.Close();
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            SelectOrder();
        }
    }
}
