using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Program
    {
        static List<ThietBi> thietBi = new List<ThietBi>();
        static void NhapDL()
        {
            while (true)
            {
                Console.WriteLine("1. May Lanh");
                Console.WriteLine("2. May Giat");
                Console.WriteLine("3. Ti Vi");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon loai thiet bi can nhap: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 4) break;
                ThietBi tb;
                switch (choice)
                {
                    case 1:
                        tb = new MayLanh();
                        break;
                    case 2:
                        tb = new MayGiat();
                        break;
                    case 3:
                        tb = new TiVi();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        continue;
                }
                tb.Nhap();
                thietBi.Add(tb);
                Console.WriteLine("Da them thiet bi thanh cong!");
            }
        }
        static void XuatDL()
        {
            if (thietBi.Count == 0)
            {
                Console.WriteLine("Khong co thiet bi nao de hien thi.");
                return;
            }
            foreach (var tb in thietBi)
            {
                Console.WriteLine("Danh sach thiet bi:");
                tb.Xuat();
                Console.WriteLine("-----------------------");
            }
        }
        static void XuatTheoLoai()
        {
            Console.WriteLine("1. May Lanh");
            Console.WriteLine("2. May Giat");
            Console.WriteLine("3. Ti Vi");
            Console.Write("Chon loai thiet bi can hien thi: ");
            int choice = int.Parse(Console.ReadLine());
            Type type;
            switch (choice)
            {
                case 1:
                    type = typeof(MayLanh);
                    break;
                case 2:
                    type = typeof(MayGiat);
                    break;
                case 3:
                    type = typeof(TiVi);
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    return;
            }
            var filteredList = thietBi.Where(tb => tb.GetType() == type).ToList(); // Loc danh sach theo loai bang cach su dung LINQ
            foreach (var tb in filteredList)
            {
                Console.WriteLine("Danh sach thiet bi:");
                tb.Xuat();
                Console.WriteLine("-----------------------");
            }
        }
        static void XuatTheoNhaSX()
        {
            Console.Write("Nhap Nha San Xuat can tim: ");
            string nhaSX = Console.ReadLine();
            var filteredList = thietBi.Where(tb => tb.NhaSX.Equals(nhaSX, StringComparison.OrdinalIgnoreCase)).ToList(); // Loc danh sach theo Nha San Xuat bang cach su dung LINQ
            foreach (var tb in filteredList)
            {
                Console.WriteLine("Danh sach thiet bi:");
                tb.Xuat();
                Console.WriteLine("-----------------------");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Nhap du lieu thiet bi");
                Console.WriteLine("2. Xuat danh sach thiet bi");
                Console.WriteLine("3. Xuat danh sach thiet bi theo loai");
                Console.WriteLine("4. Xuat danh sach thiet bi theo Nha San Xuat");
                Console.WriteLine("5. Thoat");
                Console.Write("Chon chuc nang: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        NhapDL();
                        break;
                    case 2:
                        XuatDL();
                        break;
                    case 3:
                        XuatTheoLoai();
                        break;
                    case 4:
                        XuatTheoNhaSX();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            }
        }
    }
}
