using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblTen.Text = txtNhapTen.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhapTen.Focus();
            txtNhapTen.ForeColor = Color.Red;
            lblTen.ForeColor = Color.Red;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Red;
            txtNhapTen.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Green;
            txtNhapTen.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Blue;
            txtNhapTen.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Black ;
            txtNhapTen.ForeColor = Color.Black;
        }

        private void chkDam_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.Font = new Font(lblTen.Font.Name, lblTen.Font.Size, lblTen.Font.Style^FontStyle.Bold);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Bold);
        }

        private void chkNghien_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.Font = new Font(lblTen.Font.Name, lblTen.Font.Size, lblTen.Font.Style ^ FontStyle.Italic);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Italic);
        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.Font = new Font(lblTen.Font.Name, lblTen.Font.Size, lblTen.Font.Style ^ FontStyle.Underline);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Underline);
        }
    }
}
