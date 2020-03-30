using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, wellcom to c# 2017 programming:");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked");
        }

        private void btnClickMe_MouseEnter(object sender, EventArgs e)
        {
            btnClickMe.BackColor = Color.Aqua;
        }

        private void btnClickMe_MouseHover(object sender, EventArgs e)
        {
            //btnClickMe.BackColor = Color.Red;
        }

        private void btnClickMe_MouseLeave(object sender, EventArgs e)
        {
            btnClickMe.BackColor = Color.FromArgb(255, 0, 255) ;
        }
    }
}
