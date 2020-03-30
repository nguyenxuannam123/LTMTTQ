using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            int ChieuDai, ChieuRong , ChuVi, DienTich; 
            Console.Clear();
            Console.WriteLine("************Tinh chu vi & dien tich*************");
            Console.Write("Nhap chieu dai: " );
            ChieuDai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            ChieuRong = Convert.ToInt32(Console.ReadLine());
            ChuVi = (ChieuDai + ChieuRong) * 2;
            DienTich = ChieuDai * ChieuRong;
            Console.WriteLine("Chu vi = " + ChuVi);
            Console.WriteLine("Dien tich = " + DienTich);
            Console.ReadLine();
        }
    }
}
