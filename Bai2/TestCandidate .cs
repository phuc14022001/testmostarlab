using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class TestCandidate
    {
        private List<Candidate> ds;
        public TestCandidate()
        {

            this.ds = new();

        }
        public void Nhap()
        {

            int n;
            do
            {
                Console.Write("nhap so luong sinh vien : ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            for (int i = 0; i < n; i++)
            {
                Candidate a = new();
                a.nhap();
                ds.Add(a);
            }
        }
        public void xuat()
        {
            foreach (Candidate item in ds)
            {
                float tb = item.Toan + item.Van + item.Anh;
                if (tb > 1)
                {
                    item.xuat();
                }
            }
        }
    }
}
