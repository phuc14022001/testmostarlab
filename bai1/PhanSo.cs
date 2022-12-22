using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class PhanSo
    {
        public int TuSo1 { get; set; }
        public int MauSo1 { get; set; }
        public int TuSo2 { get; set; }
        public int MauSo2 { get; set; }
        public PhanSo() { }
        public PhanSo(int tuSo1, int mauSo1, int tuSo2, int mauSo2)
        {
            TuSo1 = tuSo1;
            MauSo1 = mauSo1;
            TuSo2 = tuSo2;
            MauSo2 = mauSo2;
        }
        public void nhap()
        {
            Console.WriteLine("nhap phan so thu nhat ");
            Console.Write("nhap tu so :");
            TuSo1 = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("nhap mau so :");
                MauSo1 = int.Parse(Console.ReadLine());
            } while (MauSo1 != 0);
            Console.WriteLine("nhap phan so thu hai ");
            Console.Write("nhap tu so ");
            TuSo2 = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("nhap mau so :");
                MauSo2 = int.Parse(Console.ReadLine());
            } while (MauSo2 != 0); 
        }
        public float tong()
        {
            if(MauSo1==MauSo2)
            {
                return ((TuSo1 + TuSo2) / MauSo1);
            }
            else
            {
                return ((TuSo1 * MauSo2 + MauSo1 * TuSo2) / (MauSo1 * MauSo2));
            }
        }
        public float hieu()
        {
            if (MauSo1 == MauSo2)
            {
                return ((TuSo1 - TuSo2) / MauSo1);
            }
            else
            {
                return ((TuSo1 * MauSo2 - MauSo1 * TuSo2) / (MauSo1 * MauSo2));
            }
        }
        public float tich()
        {
            return (TuSo1 * TuSo2 / MauSo1 / MauSo2);
        }
        public float thuong()
        {
            return (TuSo1 / TuSo2 / MauSo1 * MauSo2);
        }
    }
}
