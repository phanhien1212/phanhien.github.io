using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0},", i);
                }
            }
            Console.ReadKey();
        }
    }
}
