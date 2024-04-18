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
    public partial class SetOrder : Form
    {
        public SetOrder()
        {
            InitializeComponent();
        }

        string Path = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = BeautyShop; Integrated Security = true";
        private SqlConnection connection = null;

        private void InsertOrder()
        {
            connection = new SqlConnection(Path);
            connection.Open();

            using(SqlCommand command = new SqlCommand("insert into MyOrders(SurnameNamePatronymic, Name, Date, Master) values (@SNP, @Name, @Date, @Master)", connection))
            {
                command.Parameters.AddWithValue("@SNP", GlobalHelper.Login);
                command.Parameters.AddWithValue("@Name", label1.Text);
                command.Parameters.AddWithValue("@Date", guna2DateTimePicker1.Value);
                command.Parameters.AddWithValue("@Master", guna2ComboBox1.Text);

                command.ExecuteNonQuery();
                var result = MessageBox.Show("Заказ успешно сформирован!", "Сообщение", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }

            connection.Close();
        }

        private void SetOrder_Load(object sender, EventArgs e)
        {
            label1.Text = GlobalHelper.Service;
            guna2TextBox1.Text = GlobalHelper.Cost;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InsertOrder();           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
