using _20210402homework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem {
    public partial class Form1 : Form {
        OrderService orderService;

        BindingSource bs_orderList = new BindingSource();
        BindingSource bs_orderDetail = new BindingSource();

        public Form1() {
            InitializeComponent();
        }

        private void AddFakeData_init() {
            orderService = new OrderService();

            Product apple = new Product(1, "apple", 10.0f);
            Product egg = new Product(2, "egg", 1.2f);
            Product milk = new Product(3, "milk", 50f);
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Order order1 = new Order(1, customer1);
            order1.addOrderDetail(new OrderDetail(apple, 80));
            order1.addOrderDetail(new OrderDetail(egg, 200));
            order1.addOrderDetail(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.addOrderDetail(new OrderDetail(egg, 200));
            order2.addOrderDetail(new OrderDetail(milk, 10));

            Order order3 = new Order(3, customer2);
            order3.addOrderDetail(new OrderDetail(apple, 80));
            order3.addOrderDetail(new OrderDetail(milk, 10));

            orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);


            bs_orderList.DataSource = orderService.orderList;
            bs_orderDetail.DataSource = ((Order)bs_orderList.Current).orderDetails;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = bs_orderDetail;
        }

        private void Form1_Load(object sender, EventArgs e) {
            AddFakeData_init();

            dataGridView1.DataSource = bs_orderList;

            dataGridView2.DataSource = bs_orderDetail;

            dataGridView1.Columns["TheCustomer"].Visible = false;

        }


        private void button7_Click(object sender, EventArgs e) {
            orderService.Sort((o1, o2) => o1.Cost.CompareTo(o2.Cost));

            dataGridView1.Update();
            dataGridView1.Refresh();
            //showingOrderList = orderService.QueryAll();
        }

        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e) {
            //MessageBox.Show("hh");
            if (bs_orderList.Current == null) return;
            bs_orderDetail.DataSource = ((Order)bs_orderList.Current).orderDetails;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = bs_orderDetail;
            txtBox_totCost.Text = ((Order)bs_orderList.Current).Cost.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_qall_Click(object sender, EventArgs e) {
            List<Order> result = orderService.QueryAll();
            bs_orderList.DataSource = result;
            dataGridView1.Refresh();
        }

        private void btn_qbyID_Click(object sender, EventArgs e) {
            try {
                List<Order> result = orderService.QueryOrderByID(Convert.ToUInt32(textBoxQuery.Text));
                bs_orderList.DataSource = result;
                dataGridView1.Refresh();
            } catch (Exception) {
                MessageBox.Show("hhh", "hhh", MessageBoxButtons.OK);
            }
            
        }

        private void btn_qbyCusName_Click(object sender, EventArgs e) {
            try {
                List<Order> result = orderService.QueryOrderByCustomerName(textBoxQuery.Text);
                bs_orderList.DataSource = result;
                dataGridView1.Refresh();
            } catch (Exception) {
                MessageBox.Show("hhh", "hhh", MessageBoxButtons.OK);
            }
        }

        private void btn_qbyCost_Click(object sender, EventArgs e) {
            try {
                List<Order> result = orderService.QueryOrderByCost(OrderService.EQUAL,Convert.ToDouble(textBoxQuery.Text));
                bs_orderList.DataSource = result;
                dataGridView1.Refresh();
            } catch (Exception) {
                MessageBox.Show("hhh", "hhh", MessageBoxButtons.OK);
            }
        }

        private void btn_DelOrder_Click(object sender, EventArgs e) {
            if(dataGridView1.SelectedRows.Count > 0) {
               // MessageBox.Show("hhh", "hhh", MessageBoxButtons.OK);
                bs_orderList.RemoveCurrent();
                dataGridView1.Refresh();
            }
        }


        private void btn_add_Click(object sender, EventArgs e) {
            //this.Hide();
            (new Form3(bs_orderList.Current as Order)).ShowDialog();
            //this.Show();
            bs_orderDetail.DataSource = null;
            bs_orderDetail.DataSource = (bs_orderList.Current as Order).orderDetails;
        }

        private void btn_Del_Click(object sender, EventArgs e) {
            if (dataGridView2.SelectedRows.Count > 0) {
                // MessageBox.Show("hhh", "hhh", MessageBoxButtons.OK);
                bs_orderDetail.RemoveCurrent();
                dataGridView2.Refresh();
            }
        }

        private void textBoxQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            //this.Hide();
            (new Form2(orderService)).ShowDialog();
           // this.Show();
            bs_orderList.DataSource = null;
            bs_orderList.DataSource = orderService.QueryAll();
            bs_orderList.MoveLast();
        }
    }
}
