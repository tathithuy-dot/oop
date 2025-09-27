using HW4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class TiVi: ThietBi
    {
        public double KichThuocManHinh { get; set; }
        public override void Nhap()
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
        public override void Xuat()
        {
            Console.WriteLine("Thong Tin Ti Vi:");
            Console.WriteLine("Nha San Xuat: " + NhaSX);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Gia: " + Gia);
            Console.WriteLine("Kich Thuoc: " + KichThuocManHinh);
        }
    }
}
