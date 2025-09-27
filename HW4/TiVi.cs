using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class TiVi: ThietBi //Kế thừa
    {
        public double KichThuocManHinh { get; set; }// Thêm thuộc tính mới, kế thừa những thuộc tính của ThietBi
        //Nhập thông tin của lớp MayLanh (những thông tin như nhà sản xuất, model, giá được kế thừa từ lớp ThietBi)
        public override void Nhap() //Dùng override ghi đè
        {
            Console.Write("Nhap Nha San Xuat: ");
            NhaSX = Console.ReadLine();
            Console.Write("Nhap Model: ");
            Model = Console.ReadLine();
            Console.Write("Nhap Gia: ");
            Gia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Kich Thuoc: ");
            KichThuocManHinh = Convert.ToDouble(Console.ReadLine());
        }
        //Xuất thông tin ti vi
        public override void Xuat()//Dùng override ghi đè
        {
            Console.WriteLine("Thong Tin Ti Vi:");
            Console.WriteLine("Nha San Xuat: " + NhaSX);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Gia: " + Gia);
            Console.WriteLine("Kich Thuoc: " + KichThuocManHinh);
        }
    }
}


