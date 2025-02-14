using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 + so2;

            txtKq.Text = tong.ToString();

        }

        private void btncong_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 + so2;

            txtKq.Text = tong.ToString();
        }
    }
}
