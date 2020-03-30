using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public double x1,x2;
        public string c;
        
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            x1 = x2 = 0;
            c = "";
            this.Width = 300; this.Height = 330;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "9";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (x1 == 0) x1 = double.Parse(textBox1.Text);
            else x1 *= double.Parse(textBox1.Text);
            c = "*";
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (x1 == 0) x1 = double.Parse(textBox1.Text);
            else x1 += double.Parse(textBox1.Text);
            c = "-";
            textBox1.Text = "0";


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1 += double.Parse(textBox1.Text);
            c = "+";
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            x1 = x2 = 0;
            c = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < textBox1.TextLength - 1; i++)
            {
                s += textBox1.Text[i];

            }
            textBox1.Text = s;
            if (textBox1.Text == "") textBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x1 += double.Parse(textBox1.Text);
            c = "+";
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bool a = false;
            for (int i = 0; i < textBox1.TextLength; i++)
                if (textBox1.Text[i] == ',') { a = true; break; }
            if (!a) textBox1.Text += ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (c == "+") { x2 = double.Parse(textBox1.Text); textBox1.Text = x1 + x2 + ""; x1 = x2 = 0; c = ""; }
            if (c == "-") { x2 = double.Parse(textBox1.Text); textBox1.Text = x1 - x2 + ""; x1 = x2 = 0; c = ""; }
            if (c == "*") { x2 = double.Parse(textBox1.Text); textBox1.Text = x1 * x2 + ""; x1 = x2 = 0; c = ""; }
            if (c == "/") { x2 = double.Parse(textBox1.Text); textBox1.Text = x1 / x2 + ""; x1 = x2 = 0; c = ""; }
            if (c == "y√x") { x2 = double.Parse(textBox1.Text); textBox1.Text = Math.Pow(x2, 1 / x1)+""; x1 = x2 = 0; c = ""; }
            if (c == "x^y") { x2 = double.Parse(textBox1.Text); textBox1.Text = Math.Pow(x1,x2) + ""; x1 = x2 = 0; c = ""; }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (x1 == 0) x1 = double.Parse(textBox1.Text);
            else x1 /= double.Parse(textBox1.Text);
            c = "/";
            textBox1.Text = "0";

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 300; this.Height = 330;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = double.Parse(textBox1.Text) * (-1) + "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 0.5) + "";
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Width = 577; this.Height = 330;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text)*0.01) + "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = 1/double.Parse(textBox1.Text) + "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double a = 1;
            for(int i = 1 ; i <= int.Parse(textBox1.Text) ; i++)
            {
                a = a * i;
            }

            textBox1.Text = a + "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            x1 = double.Parse(textBox1.Text);
            c = "y√x";
            textBox1.Text = "0";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double a = 3;
            textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 1 / a) + "";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(10, double.Parse(textBox1.Text)) + "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2) + "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            x1 = double.Parse(textBox1.Text);
            c = "x^y";
            textBox1.Text = "0";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 3) + "";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Log10(double.Parse(textBox1.Text)) + "";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text=Math.Log(double.Parse(textBox1.Text),double.Parse(Math.E.ToString()))+"";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(double.Parse(textBox1.Text)) + "";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(double.Parse(textBox1.Text)) + "";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tan(double.Parse(textBox1.Text)) + "";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = double.Parse(Math.E.ToString() )* double.Parse(textBox1.Text) + "";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sinh(double.Parse(textBox1.Text)) + "";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cosh(double.Parse(textBox1.Text)) + "";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tanh(double.Parse(textBox1.Text)) + "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "0";
        }
    }
}
