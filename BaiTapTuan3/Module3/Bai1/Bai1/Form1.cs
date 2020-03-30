using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int SoLuong;
            decimal DonGia, ThanhTien;
            if(txtSL.Text == "")
            {
                MessageBox.Show("Chưa có nhập số lượng");
                txtSL.Focus();
            }else if(txtDonGia.Text == "")
            {
                MessageBox.Show("Chưa có nhaaoj số lượng");
                txtDonGia.Focus();
            }
            else
            {
                SoLuong = Convert.ToInt32(txtSL.Text);
                DonGia = Convert.ToDecimal(txtDonGia.Text);

                if (SoLuong <=  0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                    txtSL.Focus();
                }else if(DonGia <= 0){
                    MessageBox.Show("Đơn giá phải lớn hơn 0");
                    txtSL.Focus();
                }
                else
                {
                    ThanhTien = SoLuong * DonGia;
                    txtThanhTien.Text = ThanhTien.ToString();
                }
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                e.Handled = true;
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtThanhTien.Text = "";
            txtTenHang.Text = "";
            txtSL.Text = "";
            txtDonGia.Text = "";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn thoát chứ!!!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
