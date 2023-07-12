using System;
using System.Windows.Forms;

namespace Zadanie_wielomian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, y1;
            double x2, y2;
            double x3, y3;
            double numer, x;
            double l0, l1, l2, W;

            if (double.TryParse(textBox1.Text, out numer)) x1 = numer;
            else x1 = 0;
            if (double.TryParse(textBox2.Text, out numer)) x2 = numer;
            else x2 = 0;
            if (double.TryParse(textBox3.Text, out numer)) x3 = numer;
            else x3 = 0;

            if (double.TryParse(textBox4.Text, out numer)) y1 = numer;
            else y1 = 0;
            if (double.TryParse(textBox5.Text, out numer)) y2 = numer;
            else y2 = 0;
            if (double.TryParse(textBox6.Text, out numer)) y3 = numer;
            else y3 = 0;

            if (double.TryParse(textBox11.Text, out numer)) x = numer;
            else x = 0;

            l0 = ((x - x2) / (x1 - x2)) * ((x - x3) / (x1 - x3));
            l1 = ((x - x1) / (x2 - x1)) * ((x - x3) / (x2 - x3));
            l2 = ((x - x1) / (x3 - x1)) * ((x - x2) / (x3 - x2));

            W = y1 * (l0) + y2 * (l1) + y3 * (l2);

            l0 = Math.Round(l0, 2);
            l1 = Math.Round(l1, 2);
            l2 = Math.Round(l2, 2);
            W = Math.Round(W, 2);

            textBox7.Text = l0.ToString();
            textBox8.Text = l1.ToString();
            textBox9.Text = l2.ToString();
            textBox10.Text = W.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox11.Text = "";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
