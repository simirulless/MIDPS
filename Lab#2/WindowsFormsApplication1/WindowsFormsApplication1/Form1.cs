using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float operant1, raspuns;
        int opreatia;

        private void button4_Click(object sender, EventArgs e)
        {
            switch (opreatia)
            {
                case 1:
                    raspuns = operant1 - float.Parse(textBox1.Text);
                    textBox1.Text = raspuns.ToString();
                    break;
                case 2:
                    raspuns = operant1 + float.Parse(textBox1.Text);
                    textBox1.Text = raspuns.ToString();
                    break;
                case 3:
                    raspuns = operant1 * float.Parse(textBox1.Text);
                    textBox1.Text = raspuns.ToString();
                    break;
                case 4:
                    raspuns = operant1 / float.Parse(textBox1.Text);
                    textBox1.Text = raspuns.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operant1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            opreatia = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        public void zero()
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            zero();
            textBox1.Text = textBox1.Text + "9";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (operant1 == 0 && textBox1.TextLength > 0)
            {
                operant1 = 0; textBox1.Text = "0" ;
            }
            else if (operant1 > 0 && textBox1.TextLength > 0)
            {
                textBox1.Clear(); textBox1.Text = "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                operant1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                opreatia = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operant1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            opreatia = 3;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            operant1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            opreatia = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x;
            x = float.Parse(textBox1.Text);
            x = -x;
            textBox1.Text = x.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            float x;
            x = float.Parse(textBox1.Text);
            x = 1 / x;
            textBox1.Text = x.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double x;
            x = double.Parse(textBox1.Text);
            x = Math.Sqrt(x);
            textBox1.Text = x.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            float x;
            x = float.Parse(textBox1.Text);
            x = x * x;
            textBox1.Text = x.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            opreatia = 0;
            textBox1.Text = "0";
        }
    }
}
