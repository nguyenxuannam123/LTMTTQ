using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuViDienTichTaGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***CHU VI DIEN TICH TAM GIAC***");
            int a, b, c;
            double cv, p, dt;
            do
            {
                Console.WriteLine("Nhap chieu dai 3 canh tam giac(Chieu dai 3 canh lon hon 0) ");
                Console.Write("Canh a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Canh b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Canh c = ");
                c = Convert.ToInt32(Console.ReadLine());
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    Console.WriteLine("Ba canh a, b, c khong tao thanh tam giac");
                }
            } while (a + b <= c || a + c <= b || b + c <= a);
            cv = (double) a + b + c;
            p = (double) cv / 2;
            dt = (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Chu vi = " + cv);
            Console.WriteLine("Dien tich = " + dt);
            Console.ReadKey();

        }
    }
}
