using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacHamLuongGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***CAC HAM LUONG GIAC***");
            double fx;
            Console.Write("Nhap vao 1 goc: ");
            fx = Convert.ToDouble(Console.ReadLine());
            double rad = fx * Math.PI / 180;
            Console.WriteLine("Sin({0}) = {1}", fx, Math.Sin(rad));
            Console.WriteLine("Cos({0}) = {1}", fx, Math.Cos(rad));
            Console.WriteLine("Tan({0}) = {1}", fx, Math.Tan(rad));
            Console.WriteLine("Cotg({0}) = {1}",fx, 1/Math.Tan(rad));
            Console.ReadKey();
        }
    }
}
