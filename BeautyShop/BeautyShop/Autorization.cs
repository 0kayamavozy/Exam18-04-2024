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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SelectAuto();
        }

        string Path = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = BeautyShop; Integrated Security = true";
        private SqlConnection connection = null;

        private void InsertData()
        {
            connection = new SqlConnection(Path);
            connection.Open();

            using(SqlCommand command = new SqlCommand("insert into Clients(NameSurnamePatronymic, Phone, Mail) values (@NSP, @Phone, @Mail)", connection))
            {
                command.Parameters.AddWithValue("@NSP", guna2TextBox6.Text);
                command.Parameters.AddWithValue("@Phone", guna2TextBox5.Text);
                command.Parameters.AddWithValue("@Mail", guna2TextBox4.Text);

                command.ExecuteNonQuery();
            }
            MessageBox.Show("+");
            connection.Close();
        }

        private void SelectAuto()
        {
            connection = new SqlConnection(Path);

            connection.Open();
            using(SqlCommand command = new SqlCommand("select * from Clients", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string login = reader.GetString(1);
                    GlobalHelper.Login = login;

                    string pass = reader.GetString(2);
                    if(guna2TextBox1.Text == login && guna2TextBox2.Text == pass)
                    {
                        var result = MessageBox.Show("Авторизация успешна!", "Сообщение", MessageBoxButtons.OK);

                        GlobalHelper.IsAuto = true;

                        if (result == DialogResult.OK)
                        {
                            Form1 form1 = new Form1();
                            Close();
                            form1.Show();
                        }
                        break;
                    }
                }
            }
            connection.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            InsertData();
        }
    }
}
