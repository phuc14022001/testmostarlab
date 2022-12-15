using System;
using System.Collections.Generic;
using System.Linq;

namespace bai4
{
    class Program
    {
        interface INews{
            void display();
        }
        class News : INews
        {
            public int id { get; set; }
            public string title { get; set; }
            public string publishDate { get; set; }
            public string author { get; set; }
            public string content { get; set; }
            public float averageRate ;
            public float AverageRate { get { return averageRate; } }
            public List<int> rateList = new List<int>(3);
            public void calculate()
            {
                averageRate = (float)rateList.Average();
                Console.WriteLine($"AverageRate: {averageRate}");
            }
            public void nhap()
            {
                Console.Write("nhap id :");
                id = int.Parse(Console.ReadLine());
                Console.Write("nhap title :");
                title = Console.ReadLine();
                Console.Write("nhap publishDate :");
                publishDate = Console.ReadLine();
                Console.Write("nhap author :");
                author = Console.ReadLine();
                Console.Write("nhap content :");
                content = Console.ReadLine();
                Console.Write("nhap 3 averageRate :");
                for (int i = 0; i < rateList.Capacity; i++)
                {
                    rateList.Insert(i, Convert.ToInt32(Console.ReadLine()));
                }
                
            }
            public List<News> a = new List<News>();
            public void display()
            {
                foreach (var item in a)
                {

                    Console.WriteLine($"Title: {item.title}");
                    Console.WriteLine($"Publish Date: {item.publishDate}");
                    Console.WriteLine($"Author: {item.author}");
                    Console.WriteLine($"Content: {item.content}");
                    Console.WriteLine($"Content: {item.averageRate}");
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("chon 1 – Insert news");
            Console.WriteLine("chon 2 – View list news ");
            Console.WriteLine("chon 3 – Average rate");
            Console.WriteLine("chon 4 – Exit");
            int choo;
            News a = new News();
            Console.Write("bạn hay nhap so ban chon :");
            choo = int.Parse(Console.ReadLine());
            switch (choo)
            {
                case 1:
                    a.nhap();
                    break;
                case 2:
                    a.display();
                    break;
                case 3:
                    a.calculate();
                    a.display();
                    break;
                case 4:
                    Console.WriteLine("ket thuc !!!");
                    break;
            }
                
        }
    }
}
