using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeautyShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (GlobalHelper.IsAuto == false)
            {
                guna2Button2.Visible = false;
            }
            else
            {
                guna2Button2.Visible = true;
            }
        }

        string Path = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = BeautyShop; Integrated Security = true";
        private SqlConnection connection = null;


        // ИЗВЛЕЧЕНИЕ ДАННЫХ ИЗ БАЗЫ

        private void SelectHair()  // пракмахерские услуги
        {
            
            connection = new SqlConnection(Path);
            connection.Open();

            using (SqlCommand command = new SqlCommand("select * from Hairdress", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Card card = new Card();
                    card._Name.Text = reader.GetString(0);
                    card.Cost.Text = reader.GetInt32(1).ToString();
                    PanelHair.Controls.Add(card);
                }
            }

            connection.Close();
        }

        private void SelectNail() // ногтевые услуги
        {
            connection = new SqlConnection(Path);
            connection.Open();

            using (SqlCommand command = new SqlCommand("select * from Nails", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Card card = new Card();
                    card._Name.Text = reader.GetString(0);
                    card.Cost.Text = reader.GetInt32(1).ToString();
                    PanelNail.Controls.Add(card);
                }
            }

            connection.Close();
        }

        private void SelectSPA() // спа
        {
            connection = new SqlConnection(Path);
            connection.Open();

            using (SqlCommand command = new SqlCommand("select * from SPA", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Card card = new Card();
                    card._Name.Text = reader.GetString(0);
                    card.Cost.Text = reader.GetInt32(1).ToString();
                    PanelSpa.Controls.Add(card);
                }
            }

            connection.Close();
        }

        private void SelectMakeUP() // визажист
        {
            connection = new SqlConnection(Path);
            connection.Open();

            using (SqlCommand command = new SqlCommand("select * from MakeUp", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Card card = new Card();
                    card._Name.Text = reader.GetString(0);
                    card.Cost.Text = reader.GetInt32(1).ToString();
                    PanelMakeUp.Controls.Add(card);
                }
            }

            connection.Close();
        }

        private void SelectSolarium() // солярий
        {
            connection = new SqlConnection(Path);
            connection.Open();

            using (SqlCommand command = new SqlCommand("select * from Solarium", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Card card = new Card();
                    card._Name.Text = reader.GetString(0);
                    card.Cost.Text = reader.GetInt32(1).ToString();
                    PanelSpa.Controls.Add(card);
                }
            }

            connection.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectHair();
            SelectNail();
            SelectSPA();
            SelectMakeUP();
            SelectSolarium();
        }

        // ФОРМА АВТОРИЗАЦИИ / РЕГИСТРАЦИИ
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            Hide();
        }

        // ФОРМА СОТРУДНИКОВ
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Workers workers = new Workers();
            workers.Show();
            Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            contacts.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (GlobalHelper.IsAuto == true)
            {
                GuestBook book = new GuestBook();
                book.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Для добавления комментария необходимо авторизоваться!", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MyOrders orders = new MyOrders();
            orders.Show();
            Hide();
        }
    }
}
