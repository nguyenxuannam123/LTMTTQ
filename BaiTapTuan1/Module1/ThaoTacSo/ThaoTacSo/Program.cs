using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaoTacSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nTong, nHieu , nTich;
            double nThuong;
            Console.Clear();
            Console.Write("{0}", "Nhap so thu nhat: ");
            nSo1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            nSo2 = Convert.ToInt32(Console.ReadLine());

            nTong = nSo1 + nSo2;
            nHieu = nSo1 - nSo2;
            nThuong = (double)nSo1 / nSo2;
            nTich = nSo1 * nSo2;
            Console.WriteLine("Tong cua: " +nSo1 + " va "  + nSo2 + " La: " + nTong);
            Console.WriteLine("Hieu cua: " + nSo1 + " tru " + nSo2 + " La: " + nHieu);
            Console.WriteLine("Thuong cua: " + nSo1 + " Chia " + nSo2 + " La: " + nThuong);
            Console.WriteLine("Tich cua: " + nSo1 + " va " + nSo2 + " La: " + nTich);
            Console.ReadLine();
        }
    }
}
