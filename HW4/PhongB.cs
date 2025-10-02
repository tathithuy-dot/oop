using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
      //Xay dung class tinh tien phong loai B
      class PhongB : Phong//Class Phong B ke thua tu class Phong
   {
       public PhongB(int songay) : base(songay)//Ke thua het cac thanh phan du lieu cua class Phong
       {
       }
       public override double TinhTien()//Phuong thuc tinh tien duoc ghi de
       {
           if (songay < 5) return songay * 60;
           else return 5 * 60 + (songay - 5) * 60 * 0.9;
       }
       public override void Hien()//Phuong thuc hien thi duoc ghi de
       {
           Console.WriteLine("Dich vu phong B");
           Console.WriteLine("Tien phong: " + TinhTien());
       }
   }
}





