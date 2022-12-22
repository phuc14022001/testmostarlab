using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Candidate
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Ngay { get; set; }
        public float Toan { get; set; }
        public float Van { get; set; }
        public float Anh { get; set; }
        public Candidate() { }
        public Candidate(string ma, string ten, string ngay, float toan, float van, float anh)
        {
            Ma = ma;
            Ten = ten;
            Ngay = ngay;
            Toan = toan;
            Van = van;
            Anh = anh;
        }
        public void nhap()
        {
            Console.WriteLine("nhap ma sinh vien : ");
            Ma = Console.ReadLine();
            Console.WriteLine("nhap ho ten : ");
            Ten= Console.ReadLine();
            Console.WriteLine("nhap ngay sinh : ");
            Ngay= Console.ReadLine();
            Console.WriteLine("nhap diem Toan : ");
            Toan= int.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem Van : ");
            Van = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem Anh : ");
            Anh = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            
            Console.WriteLine($"{Ma,10}{Ten,10}{Ngay,10}{Toan,10}{Van,10}{Anh,10}");
        }
    }
}
