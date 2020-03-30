using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Clear();
            Console.WriteLine("***Giai va bien luan phuong trinh bac 1");
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {        
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                }
            else
            {
                Console.WriteLine("Phuong trinh co nghiem la: " + (double)-b/a);
            }
            Console.ReadLine();
        }
    }
}
