using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            Console.WriteLine("nhap so tien dien thang truoc :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so tien dien thang nay :");
            b = int.Parse(Console.ReadLine());
            x = b - a;
            double tien;
            if (x < 0)
            {
                Console.WriteLine("nhap chua dung .");
            }
            else if (0 <= x && x<= 25) {
                tien = x * 1000;
                Console.WriteLine("so tien dien la :" + tien);
            }
            else if (25 < x && x <= 75)
            {
                tien = 25*1000+(x-25)*1250;
                Console.WriteLine("so tien dien la :" + tien);
            }
            else if (75 < x && x <= 150)
            {
                tien = 25 * 1000 + 75 * 1250+(x-75)*1800;
                Console.WriteLine("so tien dien la :" + tien);
            }
            else
            {
                tien = 25 * 1000 + 75 * 1250 + 75 * 1800+(x-150)*2500;
                Console.WriteLine("so tien dien la :" + tien);
            }
        }
    }
}
