using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBanKinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn thoát chứ!!!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtBanKinh.Text = "";
            txtChuVi.Text = "";
            txtBanKinh.Focus();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double bk, cv;
           
            if(txtBanKinh.Text == "")
            {
                MessageBox.Show("Uầy, bạn chưa có nhập bán kính");
                txtBanKinh.Focus();
            }
            else
            {
                bk = Convert.ToDouble(txtBanKinh.Text);
                if (bk <= 0)
                {
                    MessageBox.Show("Uầy, bán kính không được bé hơn 0 ");
                    txtBanKinh.Focus();
                }
                else
                {
                    cv =Convert.ToDouble(2 * Math.PI * bk);
                    txtChuVi.Text = cv.ToString();
                }
            }
        }

        private void txtChuVi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                e.Handled = true;
            }
        }
    }
}
