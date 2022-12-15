using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("nhap so a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so c :");
            c = int.Parse(Console.ReadLine());
            double delta;
            delta = b * b - 4 * c * a;
            if (delta >= 0)
            {
                Console.WriteLine("căn delta = " + Math.Sqrt(delta));
            }
            else
            {
                Console.WriteLine("delta âm ");
            }
        }
    }   
}

