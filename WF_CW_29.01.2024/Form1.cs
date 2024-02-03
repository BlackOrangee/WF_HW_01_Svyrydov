using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW_29._01._2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)).ToString();
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)).ToString();
            label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = (Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text)).ToString();
            label1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = (Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text)).ToString();
            label1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = (Int32.Parse(textBox3.Text) * 9 / 5 + 32).ToString();
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = ((Int32.Parse(textBox4.Text) - 32) * 5 / 9).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //textBox5

            string str = textBox5.Text;

            int size = Int32.Parse(textBox6.Text);

            List<string> symb = new List<string>();

            foreach (Char c in str)
            {
                symb.Add(c.ToString());
            }

            Random random1 = new Random(symb.Count);

            Random random2 = new Random(size);


        }
    }
}
