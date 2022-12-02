using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ3_3УП_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void f(double x, out double y)
        {
            if (x < 1) y = (x * x - 1) * (x * x - 1);
            else if (x > 1) y = 1 / ((1 + x) * (1 + x));
            else y = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double h;
            a = double.Parse(numericUpDown1.Text);
            b = double.Parse(numericUpDown2.Text);
            h = double.Parse(numericUpDown3.Text);
            for (double i = a; i <= b; i += h)
            {
                f(i, out double y);
                richTextBox1.Text += ("f (" + i + ") =" + y) + "\n";
            }
        }
    }
}
