using _20210402homework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form2 : Form
    {
        private OrderService os;
        public Form2(OrderService os)
        {
            InitializeComponent();
            this.os = os;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");
            bs_Customer.Add(customer1);
            bs_Customer.Add(customer2);
            comboBox1.DataSource = null;
            comboBox1.DataSource = bs_Customer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for(i = 1; ; i++)
            {
                if (os.QueryOrderByID((uint)i).Count > 0) continue;
                break;
            }
            os.AddOrder(new Order(i, bs_Customer.Current as Customer));
            Close();
        }
    }
}
