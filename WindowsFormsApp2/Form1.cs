using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a, b;
            int num=0;
            double result = 1;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox3.Text);

            if (radioButton1.Checked)
            {
                num = 1;
                textBox2.Text = "+";
            }                
            else if (radioButton2.Checked)
            {
                num = 2;
                textBox2.Text = "-";
            }                
            else if (radioButton3.Checked)
            {
                num = 3;
                textBox2.Text = "*";
            }                
            else if (radioButton4.Checked)
            {
                num = 4;
                textBox2.Text = "/";
            }                
            else if (radioButton5.Checked)
            {
                num = 5;
                textBox2.Text = "%";
            }
            else if(radioButton6.Checked)
            {
                num = 6;
                textBox2.Text = "^";
            }
                
            switch (num)
            {
                case 1: // +
                    result = a + b;
                    break;
                case 2: // -
                    result = a - b;
                    break;
                case 3: // *
                    result = a * b;
                    break;
                case 4: // /
                    result = a / b;
                    break;
                case 5: // %
                    result = a % b;
                    break;
                case 6: // ^
                    for (int i = 0; i < b; i++)
                    {
                        result *= a;
                    }                    
                    break;
                default:
                    break;
            }
            textBox4.Text = result.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        
    }
}
