﻿using System;
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
    public partial class GuestBook : Form
    {
        public GuestBook()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string Path = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = BeautyShop; Integrated Security = true";
        private SqlConnection connection = null;
        private SqlDataAdapter dataAdapter = null;

        private void SelectComms()
        {
            connection = new SqlConnection(Path);
            using (dataAdapter = new SqlDataAdapter("select * from GuestBook", connection))
            {
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                _dataGrid.DataSource = dt;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void GuestBook_Load(object sender, EventArgs e)
        {
            SelectComms();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(Path);
            connection.Open();
            using (SqlCommand command = new SqlCommand("insert into GuestBook(Comment, date) values (@Name, @Date)", connection))
            {
                var Date = DateTime.Now;
                command.Parameters.AddWithValue("@Name", guna2TextBox1.Text);
                command.Parameters.AddWithValue("@Date", Date);
                command.ExecuteNonQuery();
            }
            connection.Close();
            SelectComms();
            guna2TextBox1.Text = string.Empty;
        }
    }
}
