using Guna.UI2.WinForms;
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
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        public Label _Name
        {
            get { return label1; }
            set { label1 = value; }
        }

        public Guna2TextBox Cost
        {
            get { return guna2TextBox1; }
            set { guna2TextBox1 = value; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (GlobalHelper.IsAuto == true)
            {
                GlobalHelper.Service = label1.Text;
                GlobalHelper.Cost = guna2TextBox1.Text;
                SetOrder myOrders = new SetOrder();
                myOrders.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для записи необходимо авторизоваться!", "Сообщение!", MessageBoxButtons.OK);
            }
            
        }
    }
}
