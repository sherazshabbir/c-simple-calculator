using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace simple_calculator_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string caltotal;
        float num1;
        float num2;
        string option;
        float result;

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();

          
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("/"))
            {
                 result = num1 / num2;
            }    
                
            txtTotal.Text = result + "";
            if (!option.Equals("n^"))
            {
                result = num1 * num1;
            }
            
           

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();

        }
    

        private void button1_Click_1(object sender, EventArgs e)
       {
         // double square = double.Parse(txtTotal.Text);
          //  result = square * square;


       
        }
    }
}
