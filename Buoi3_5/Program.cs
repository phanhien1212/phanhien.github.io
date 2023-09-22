using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int soSinhVien = int.Parse(Console.ReadLine());
            string[] dssinhvien = new string[soSinhVien];
            for(int i = 0; i < soSinhVien; i++)
            {
                Console.Write("Nhap ten cua sinh vien {i+1}: ");
                dssinhvien[i]= Console.ReadLine();
                 
            }
            Console.WriteLine("Danh sach sinh vien");
            foreach(string sinhvien in dssinhvien)
            {
                Console.WriteLine(sinhvien);
            }
            Console.ReadKey();

        }
    }
}
