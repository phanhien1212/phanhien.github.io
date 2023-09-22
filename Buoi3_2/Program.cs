using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_2
{
    class Program
    {
        public static bool checkNamNhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                return true;
            return false;

        }
        static void Main(string[] args)
        {
            int thang = 1, nam, ngay = 0;
            Console.Write("Nhap thang: "); thang = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap nam: "); nam = Convert.ToInt16(Console.ReadLine());

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: ngay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11: ngay = 30;
                    break;
                case 2:
                    {
                        if (checkNamNhuan(nam) == true)
                            ngay = 20;
                        else ngay = 28;
                        break;
                    }

            }
            Console.Write("Ngay: " + ngay.ToString());
            Console.ReadKey();

        }
    }
}
