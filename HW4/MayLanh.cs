using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class MayLanh: ThietBi
    {
        public double MaLuc { get; set; }
        public override void Nhap()
        {
            Console.Write("Nhap Nha San Xuat: ");
            NhaSX = Console.ReadLine();
            Console.Write("Nhap Model: ");
            Model = Console.ReadLine();
            Console.Write("Nhap Gia: ");
            Gia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Ma Luc: ");
            MaLuc = Convert.ToDouble(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Thong Tin May Lanh:");
            Console.WriteLine("Nha San Xuat: " + NhaSX);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Gia: " + Gia);
            Console.WriteLine("Ma Luc: " + MaLuc);
        }
    }
}
