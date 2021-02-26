using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCalculator
{
    public partial class Form1 : Form
    {
        private int oper = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) oper = 1;
            else if (radioButton2.Checked) oper = 2;
            else if (radioButton3.Checked) oper = 3;
            else if (radioButton4.Checked) oper = 4;
            if (oper == -1)
            {
                MessageBox.Show("please choose an operator");
            }
            else
            {
                double ans = 0, a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text);
                switch (oper)
                {
                    case 1:
                        ans = a + b;
                        break;
                    case 2:
                        ans = a - b;
                        break;
                    case 3:
                        ans = a * b;
                        break;
                    case 4:
                        if(b == 0)
                        {
                            MessageBox.Show("sb");
                        }
                        else
                        {
                            ans = a / b;
                        }
                        break;
                }
                label2.Text = ans.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
