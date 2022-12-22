// See https://aka.ms/new-console-template for more information
using Bai3;
using System.Security.Cryptography;

List<SinhVien> sv = new ();
void Nhap(List<SinhVien> sv)
{
    {
        SinhVien ql = new SinhVien();
        ql.nhap();
        sv.Add(ql);
    }
}
void Xuat(List<SinhVien> sv)
{
    if (sv.Count == 0)
    {
        Console.WriteLine("Yeu cau nhap lai ");
        return;
    }
    else
    {
        Console.WriteLine($"{"Ma Sinh vien",10} {"Ho va ten",10} {"Ngay Sinh",10} {"Dia chi",10} {"Diem",10} ");
        foreach (var item in sv)
        {
            Console.WriteLine($"{item.Id,10} {item.Name,10} {item.Age,10} {item.Addre,10} {item.Gpa,10} ");
        }
    }
}
void xoa(List<SinhVien> sv)
{
    Console.Write("Nhap ma sinh vien muon xoa :");
    string s = Console.ReadLine();
    var query = sv.Single(r => r.Id == s);
    if (query == null)
    {
        Console.WriteLine("Khong tim thay ma de xoa ");
    }
    else
    {
        sv.Remove(query);
        Console.WriteLine("Da xoa");
    }
}
void Sua(List<SinhVien> sv)
{
    if (sv.Count == 0)
    {
         Console.WriteLine("Yeu cau nhap du lieu ");
         return;
     }
     else
    { 
         Console.Write("Nhap ma sinh vien can sua ");
         string s = Console.ReadLine();
         var query = (from sinhvien in sv
                      where sinhvien.Id.Contains(s.ToLower())
                      select sinhvien).ToList();
        if (query != null)
        {

            foreach (var item in query)
            {
                Console.Write("Nhap ten sinh vien :");
                item.Name = Console.ReadLine();
                Console.Write("nhap tuoi : ");
                item.Age = int.Parse(Console.ReadLine());
                Console.Write("nhap dia chi : ");
                item.Addre = Console.ReadLine();
                Console.Write("nhap diem gpa : ");
                item.Gpa = float.Parse(Console.ReadLine());
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien de sua ");
            return;
        }
     }
}
void SapxepbyGPA(List<SinhVien> sv)
{
    for (int i = 0; i < sv.Count - 1; i++)
    {
        for (int j = i + 1; j < sv.Count; j++)
        {
            if (sv[i].Gpa > sv[j].Gpa)
            {
                SinhVien gt = sv[i];
                sv[i] = sv[j];
                sv[j] = gt;
            }
        }
    }
    Xuat(sv);
}
int choose;

do
{
    Console.WriteLine("Moi chon chuc nang :");
    Console.WriteLine("/**********************************************/");
    Console.WriteLine("1. Add a student.");
    Console.WriteLine("2. Edit student by id.");
    Console.WriteLine("3. Delete student by id.");
    Console.WriteLine("4. Sort students by gpa.");
    Console.WriteLine("5. Sort students by name.");
    Console.WriteLine("6. Show students.");
    Console.WriteLine("0. Exit");
    
    choose = int.Parse(Console.ReadLine());
    
    switch (choose)
    {
        case 1:
            Nhap(sv);
            break;
        case 2:
            Sua(sv);
            break;
        case 3:
            xoa(sv);
            break;
        case 4:
            SapxepbyGPA(sv);
            break;
        case 5:
            SapxepbyGPA(sv);
            break;
        case 6:
            Xuat(sv);
            break;
        case 0:
            System.Environment.Exit(0);
            break;
    }
}
while (choose >= 0 && choose <= 6);