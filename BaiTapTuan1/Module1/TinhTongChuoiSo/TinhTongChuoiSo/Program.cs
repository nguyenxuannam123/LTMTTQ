using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongChuoiSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n , gt;
            double S = 0;
            Console.WriteLine("***TINH TONG CHUOI SO***");
            Console.Write("Nhap x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap n : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                gt = 1;
               for(int j = 1; j <= i; j++)
                {
                    gt = gt * j; 
                }
                Console.WriteLine("gt = " + gt);
                S = S + (double)(Math.Pow(x, i)/gt);                
            }
            Console.WriteLine("S({0},{1}) = {2}", x, n, S);
            Console.ReadKey();

        }
    }
}
