using System;
class Square
{
    public float canh { get; set; }
    public Square() { }
    public Square(float canh_)
    {
        this.canh = canh_;
    }
    public void nhap()
    {
        Console.Write("nhap do dai canh :");
        canh = float.Parse(Console.ReadLine()); 
    }
    public void xuat()
    {
        Console.WriteLine("so do cua canh la :" + canh);
    }
    public void chuvi()
    {
        Console.WriteLine("chu vi =" + canh * 4);
    }
    public void dientich()
    {
        Console.WriteLine("dien tich =" + canh * canh);
    }
}

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Square a=new Square();
            a.nhap();
            Console.WriteLine("chon 1 hien thi do dai canh.");
            Console.WriteLine("chon 2 hien thi chu vi.");
            Console.WriteLine("chon 3 hien thi dien tich.");
            Console.WriteLine("chon 4 hien thi tat ca.");
            Console.Write("nhap so ban muon chon :");
            int choo;
            choo = int.Parse(Console.ReadLine());
            switch (choo)
            {
                case 1:
                    a.xuat();
                    break;
                case 2:
                    a.chuvi();
                    break;
                case 3:
                    a.dientich();
                    break;
                case 4:
                    a.xuat();
                    a.chuvi();
                    a.dientich();
                    break;
                case 5:
                    Console.WriteLine("ket thuc !!!");
                    break;  
            }
        }
    }
}
