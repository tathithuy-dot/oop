using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
        //Chuong trinh chinh
    class Program
    {
        static void Main()
        {
            HoaDonKhach kh1 = new HoaDonKhach(); //Tao doi tuong hoa don cua khach hang thu nhat
            kh1.Nhap();//Nhap thong tin hoa don cua khach thu nhat
            Console.Clear();
            kh1.Hien(); // Hien thi thong tin cua hoa don vua nhap
            Console.ReadKey();
        }
    }
}


