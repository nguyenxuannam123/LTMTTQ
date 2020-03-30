using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoGaSoCho
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b1, c1, a2, b2, c2;
            float D, Dx, Dy, x, y;
            Console.WriteLine("a1*x + b1*y = c1\n");
            Console.WriteLine("a2*x + b2*y = cc\n");
            Console.Write("\nNhap a1: "); a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap b1: "); b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap c1: "); c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap a2: "); a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap b2: "); b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap c2: "); c2 = Convert.ToInt32(Console.ReadLine());
            D = a1 * b2 - a2 * b1;
            Dx = c1 * b2 - c2 * b1;
            Dy = a1 * c2 - a2 * c1;
            if (D == 0)
            {
                if (Dx + Dy == 0)
                    Console.WriteLine("He phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("He phuong trinh vo nghiem");
            }
            else
            {
                x = Dx / D;
                y = Dy / D;
                Console.WriteLine("He phuong trinh co nghiem (x, y) = ({0}, {1})", x, y);
            }
            Console.ReadKey();
        }
    }
}
