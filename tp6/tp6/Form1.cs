using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox5.Text = "";
            Double[] A = new Double[4];
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (Double.TryParse(textBox1.Text, out A[0]) &&
                    Double.TryParse(textBox2.Text, out A[1]) &&
                    Double.TryParse(textBox3.Text, out A[2]) &&
                    Double.TryParse(textBox4.Text, out A[3]))
                {
                    double sum = 0;
                    for (int i = 0; i < A.Length; ++i)
                        if (A[i] < 0) sum += A[i];
                    textBox5.Text = sum.ToString();
                    if (textBox5.Text != "")
                        richTextBox1.Text = "Success!";
                }
                else
                    richTextBox1.Text = "Values is not parsed to Double!";
            }
            else
                richTextBox1.Text = "Empty field!";
        }
    }
}
