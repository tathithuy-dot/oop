using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
        //Class tinh tien phong loai A
        class PhongA : Phong //Class Phong A ke thua tu class Phong
    {
        protected int tiendv;// Thanh phan du lieu
        public PhongA(int songay) : base(songay) //Ke thua het cac thanh phan du lieu cua class Phong
        {
            Console.Write("Nhap tien dv:"); 
            tiendv = int.Parse(Console.ReadLine()); //Them thanh phan du lieu cua rieng class Phong A
        }
        public override double TinhTien()//Phuong thuc tinh tien duoc ghi de
        {
            if (songay < 5) return songay * 80 + tiendv;
            else
            {
                return 5 * 80 + (songay - 5) * 80 * 0.9 + tiendv;
            }
        }
        public override void Hien()//Phuong thuc hien thi duoc ghi de
        {
            Console.WriteLine("Dich vu phong A");
            Console.WriteLine("Tien dich vu: " + tiendv);
            Console.WriteLine("Tien phong: "+TinhTien());
        }
    }
}



