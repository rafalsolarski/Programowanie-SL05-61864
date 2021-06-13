using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            float a, b;
            b = 0;
            
            if(float.TryParse(textBox1.Text, out a))
            {
                if (checkBox1.Checked&&checkBox2.Checked)
                {
                    MessageBox.Show("blad", "blad", MessageBoxButtons.OK);
                }
                else if(checkBox1.Checked)
                {
                    a = float.Parse(textBox1.Text);
                    label3.Text = (a - 100).ToString();
                }
                else if (checkBox2.Checked && radioButton1.Checked)
                {
                    a = float.Parse(textBox1.Text);
                    b = a * 80 / 100;
                    label3.Text = b.ToString();
                }
                else if (checkBox2.Checked && radioButton2.Checked)
                {
                    a = float.Parse(textBox1.Text);
                    b = a * 95 / 100;
                    label3.Text = b.ToString();
                }
                
            }
          
        }
    }
}
