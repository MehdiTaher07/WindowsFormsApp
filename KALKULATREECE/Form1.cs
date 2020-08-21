using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KALKULATREECE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("GOAL!");
            Button b = new Button();
            b = (Button)sender;
            txtResult.Text = int.Parse(txtResult.Text +b.Text).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
        char op = '+';
        int nbr1 = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            nbr1 = int.Parse(txtResult.Text);
            Button b = new Button();
            b = (Button)sender;
            op =char.Parse(b.Text);
            txtResult.Clear();

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (op == '+')
            {
                txtResult.Text = (nbr1 + int.Parse(txtResult.Text)).ToString();
            }
            else
            if (op == '-')
            {
                txtResult.Text = (nbr1 - int.Parse(txtResult.Text)).ToString();
            }
            else
            if (op == '*')
            {
                txtResult.Text = (nbr1 * int.Parse(txtResult.Text)).ToString();
            }
            else
            if (op == '/')
            {
                try
                {
                    txtResult.Text = (nbr1 / int.Parse(txtResult.Text)).ToString();
                }
                catch(DivideByZeroException eD)
                {
                    MessageBox.Show(eD.Message);
                }
                
            }
        }
    }
}
