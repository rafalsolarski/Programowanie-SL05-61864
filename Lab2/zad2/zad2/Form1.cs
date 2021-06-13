using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox1.ForeColor = Color.Red;
            } 
            else if (radioButton5.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
            else if (radioButton6.Checked)
            {
                textBox1.ForeColor = Color.Orange;
            }
            if (radioButton7.Checked)
            {
                textBox1.Font = new Font(this.textBox1.Font.Name, this.textBox1.Font.Size, FontStyle.Bold );
            }
            if (radioButton8.Checked)
            {
                textBox1.Font = new Font(this.textBox1.Font.Name, this.textBox1.Font.Size, FontStyle.Italic);
            }
            if (radioButton9.Checked)
            {
                textBox1.Font = new Font(this.textBox1.Font.Name, this.textBox1.Font.Size, FontStyle.Underline);
            }
            if (radioButton1.Checked)
            {
                textBox1.Font = new Font("arial", 10);
            }
            if (radioButton2.Checked)
            {
                textBox1.Font = new Font("arial", 12);
            }
            if (radioButton3.Checked)
            {
                textBox1.Font = new Font("arial", 14);
            }

        }
    }
}

