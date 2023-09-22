using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_6
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            //khai báo hai biến a, b vầ c là va tham số mà người dùng nhập vào
            int a, b, c;
            //khai báo biến x1, x2 là nghiệm của phương trình và biến delta
            double x1, x2, delta;
            //yêu cầu người dùng nhập vào ba số a, b, c
            Console.Write("\n Nhap vao so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            //hiển thị phương trình bậc hai mà người dùng vừa nhập dưới dạng ax^2 + bx + c = 0
            Console.WriteLine("\n Chuong trinh ban vua nhap la {0}x^2 + {1}x + {2} = 0.", a, b, c);
            //nếu a = 0 thì phương trình bậc hai trở thành phương trình bậc nhất
            if (a == 0)
            {
                //ta giải phương trình bậc nhất bx + c = 0
                if (b == 0)
                {
                    //nếu b = 0 và c = 0 thì phương trình vô số nghiệm
                    if (c == 0)
                    {
                        Console.WriteLine("\n Phuong trinh co vo so nghiem.");
                    }
                    //nếu b = 0 và c != 0 thì phương trình vô nghiệm
                    else
                    {
                        Console.WriteLine("\n Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    x1 = (double)-c / b;
                    //Sử dụng phương thứ Math.Round() để làm tròn kết quả lên 2 số thập phân
                    Console.WriteLine("\n Phuong trinh co nghiem duy nhat x = {0}", Math.Round(x1, 2));
                }
            }
            //nếu a != 0 thì ta bắt đầu giải phương trình bậc hai
            else
            {
                //tính delta
                delta = Math.Pow(b, 2) - 4 * a * c;
                //kiểm tra nếu delta < 0 thì phương trình vô nghiệm
                if (delta < 0)
                {
                    Console.WriteLine("\n Phuong trinh vo nghiem.");
                }
                //nếu delta = 0 thì phương trình có hai nghiệm kép
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("\n Phuong trinh co nghiem kep x1 = x2 = {0}", x1);
                }
                //nếu delta > 0 thì phuong trình có hai nghiệm phân biệt
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("\n Phuong trinh hai nghiem phan biet:\n X1 = {0}\n X2 = {1}", x1, x2);
                }
            }
            Console.ReadKey();
        }
    }
}
