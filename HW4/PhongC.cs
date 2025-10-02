using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
        class PhongC : Phong//Class Phong C ke thua tu class Phong
    {
        public PhongC (int songay) : base(songay)//Ke thua het cac thanh phan du lieu cua class Phong
        {
        }
        public override double TinhTien()
        { return songay * 40; }//Phuong thuc tinh tien duoc ghi de
        public override void Hien()//Phuong thuc hien thi duoc ghi de
        {
            Console.WriteLine("Dich vu phong C");
            Console.WriteLine("Tien phong:" + TinhTien());
        }
    }
}



