using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_4
{
    class Program
    {
        static bool KTTamGiac(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap canh a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            int c = int.Parse(Console.ReadLine());

            
            if (KTTamGiac(a, b, c))
            {
                int p = a + b + c;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("Ba so a, b, c tao thanh mot tam giac.");
                Console.WriteLine("Chu vi tam giac la: " + p);
                Console.WriteLine("Dien tich tam giac la: " + s);
            }
            else
            {
                Console.WriteLine("Ba so a, b, c khong tao thanh mot tam giac.");
            }
            Console.ReadKey();
        }
    }
}
