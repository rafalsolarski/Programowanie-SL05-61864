using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dom2
{
    public partial class Form1 : Form
    {
        double Cyfra;
        string Dzialanie;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void przecinek_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Cyfra = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Dzialanie = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Cyfra = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Dzialanie = "-";
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            Cyfra = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Dzialanie = "*";
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            Cyfra = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Dzialanie = "/";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double Wynik;
            double Cyfra2;
            Cyfra2 = Convert.ToDouble(textBox1.Text);

            if (Dzialanie == "+")
            {
                Wynik = Cyfra + Cyfra2;
                textBox1.Text = Convert.ToString(Wynik);
                Cyfra = Wynik;
            }
            else if (Dzialanie == "-")
            {
                Wynik = Cyfra - Cyfra2;
                textBox1.Text = Convert.ToString(Wynik);
                Cyfra = Wynik;
            }
            else if (Dzialanie == "*")
            {
                Wynik = Cyfra * Cyfra2;
                textBox1.Text = Convert.ToString(Wynik);
                Cyfra = Wynik;
            }
            else if (Dzialanie == "/")
            {
                if (Cyfra2 == 0)
                {
                    textBox1.Text = "Nie dziel przez zero";
                }
                else
                {
                    Wynik = Cyfra / Cyfra2;
                    textBox1.Text = Convert.ToString(Wynik);
                    Cyfra = Wynik;
                }
                
            }
        }
    }
}
