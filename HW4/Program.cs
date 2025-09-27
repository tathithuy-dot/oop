using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Program
    {
        static List<ThietBi> thietBi = new List<ThietBi>(); //Khởi tạo list lưu thông tin thiết bị
        static void NhapDL() // Nhập dữ liệu theo loại
        {
            while (true)
            {
                Console.WriteLine("1. May Lanh");
                Console.WriteLine("2. May Giat");
                Console.WriteLine("3. Ti Vi");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon loai thiet bi can nhap: "); 
                int choice = int.Parse(Console.ReadLine()); // Chọn loại thiết bị cần nhập
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
                //Kết thúc lựa chọn thiết bị
                tb.Nhap();// Nhập thông tin thiết bị
                thietBi.Add(tb); // Thêm thông tin thiết bị vào list
                Console.WriteLine("Da them thiet bi thanh cong!");
            }
        }
        //Xuất thông tin toàn bộ thiết bị
        static void XuatDL()
        {
            if (thietBi.Count == 0) // Nếu list rỗng thì hiển thị thông báo không có thông tin
            {
                Console.WriteLine("Khong co thiet bi nao de hien thi.");
                return;
            }
            // Ngược lại hiển thị thông tin từng thiết bị
            foreach (var tb in thietBi)
            {
                Console.WriteLine("Danh sach thiet bi:");
                tb.Xuat();
                Console.WriteLine("-----------------------");
            }
        }
        // Hiển thị thông tin thiết bị theo từng loại
        static void XuatTheoLoai()
        {
            Console.WriteLine("1. May Lanh");
            Console.WriteLine("2. May Giat");
            Console.WriteLine("3. Ti Vi");
            Console.Write("Chon loai thiet bi can hien thi: ");
            int choice = int.Parse(Console.ReadLine());// Chọn loại thiết bị
            Type type; // Biến type chứa loại của từng thiết bị
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
            // Lọc thiết bị theo loại
            // Đưa những thiết bị cùng loại vào 1 list
            var filteredList = thietBi.Where(tb => tb.GetType() == type).ToList(); //Dùng GetType() để lấy loại của thiết bị
            //Duyệt từng thiết bị sau khi chia theo loại
            foreach (var tb in filteredList)
            {
                Console.WriteLine("Danh sach thiet bi:");
                tb.Xuat();//Hiển thị thông tin thiết bị
                Console.WriteLine("-----------------------");
            }
        }
        //Hiển thị thông tin thiết bị theo nhà sản xuất
        static void XuatTheoNhaSX()
        {
            Console.Write("Nhap Nha San Xuat can tim: ");
            string nhaSX = Console.ReadLine();//Chọn nhà sản xuất cần tìm
            // Lọc thiết bị theo tên nhà sản xuất vừa nhập (Không phân biệt hoa thường) => Cho vào chung 1 list
            var filteredList = thietBi.Where(tb => tb.NhaSX.Equals(nhaSX, StringComparison.OrdinalIgnoreCase)).ToList(); 
            //Duyệt từng thiết bị sau khi phân loại
            foreach (var tb in filteredList)
            {
                Console.WriteLine("Danh sach thiet bi:");
                tb.Xuat();//Hiển thị thông tin thiết bị
                Console.WriteLine("-----------------------");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                // Tạo menu
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Nhap du lieu thiet bi");
                Console.WriteLine("2. Xuat danh sach thiet bi");
                Console.WriteLine("3. Xuat danh sach thiet bi theo loai");
                Console.WriteLine("4. Xuat danh sach thiet bi theo Nha San Xuat");
                Console.WriteLine("5. Thoat");
                Console.Write("Chon chuc nang: ");
                int choice = int.Parse(Console.ReadLine());//Chọn chức năng cần chạy
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

