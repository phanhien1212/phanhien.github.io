using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Nhap so le n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Tong cac so le = " + sum);
            Console.ReadKey();
        }
    }
}
