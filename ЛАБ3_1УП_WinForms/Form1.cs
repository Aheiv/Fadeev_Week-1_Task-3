using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ3_1УП_WinForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double chetnechet(int y)
        {
            if (Math.Abs(y) % 10 == 0 || Math.Abs(y) % 10 == 2 || Math.Abs(y) % 10 == 4 || Math.Abs(y) % 10 == 6 || Math.Abs(y) % 10 == 8)
            {
                textBox1.Text = "чётное";
                y = y / 2;
            }
            else
            {
                textBox1.Text = "нечётное";
                y = 0;
            }
            return y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(numericUpDown1.Text);
            textBox2.Text = chetnechet(a).ToString();
        }
    }
}
