using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class SinhVien
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Addre { get; set; }
        public float Gpa { get; set; }
        public SinhVien() { }
        public SinhVien(string id, string name, int age, string addre, float gpa)
        {
            Id = id;
            Name = name;
            Age = age;
            Addre = addre;
            Gpa = gpa;
        }
    }
}
