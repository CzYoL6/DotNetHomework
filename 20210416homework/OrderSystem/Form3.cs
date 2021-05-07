using _20210402homework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form3 : Form
    {
        private Order thisOrder;
        public Form3(Order thisOrder)
        {
            InitializeComponent();
            this.thisOrder = thisOrder;
        }

        private void bs_goods_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Product apple = new Product(1, "apple", 10.0f);
            Product egg = new Product(2, "egg", 1.2f);
            Product milk = new Product(3, "milk", 50f);
            bs_goods.Add(apple);
            bs_goods.Add(egg);
            bs_goods.Add(milk);
            cbB_GoodName.DataSource = null;
            cbB_GoodName.DataSource = bs_goods;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var h = (from a in thisOrder.orderDetails
                    where a.TheProduct.Equals(bs_goods.Current as Product)
                    select a).ToArray();
            
            if (h.Length > 0)
            {
                h[0].Quantity += Convert.ToInt32(textBox1.Text);
            }
            else
            {
                OrderDetail newOrderDetail = new OrderDetail(bs_goods.Current as Product, Convert.ToInt32(textBox1.Text));
                thisOrder.addOrderDetail(newOrderDetail);
            }
            
            //MessageBox.Show(thisOrder.orderDetails.ToString());
            Close();
        }
    }
}
