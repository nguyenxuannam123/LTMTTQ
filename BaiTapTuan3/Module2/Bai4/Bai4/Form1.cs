using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoVaTen.Text = txtHo.Text.ToString();
        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lblHoVaTen.Text = txtHo.Text.ToString() + " " + txtTen.Text.ToString();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoVaTen.Text = txtTen.Text.ToString();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
