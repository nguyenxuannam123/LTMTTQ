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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn thoát chứ!!!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtChieuDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                e.Handled = true;
            }
        }

        private void txtChieuRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                e.Handled = true;
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtChieuDai.Text = "";
            txtChieuRong.Text = "";
            txtDienTich.Text = "";
            txtChieuDai.Focus();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(txtChieuDai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chiều dài!!!!");
                txtChieuDai.Focus();
            }else if (txtChieuRong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chiều rộng!!!!");
                txtChieuRong.Focus();
            }
            else
            {
                decimal dai, rong, dienTich;
                dai = Convert.ToDecimal(txtChieuDai.Text);
                rong = Convert.ToDecimal(txtChieuRong.Text);
                if(dai <= 0)
                {
                    MessageBox.Show("Chiều dài phải lớn hơn 0");
                    txtChieuDai.Focus();
                }else if(rong <= 0)
                {
                    MessageBox.Show("Chiều rộng phải lớn hơn 0");
                    txtChieuRong.Focus();
                }else if(dai < rong)
                {
                    MessageBox.Show("Chiều dài phải lớn hơn chiều rộng");
                    txtChieuDai.Focus();
                }
                else
                {
                    dienTich = dai * rong;
                    txtDienTich.Text = dienTich.ToString();
                }
            }
        }

        private void txtChieuDai_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
