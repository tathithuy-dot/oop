using System;
namespace HW4
{
  //Xay dung class hoa don
  class HoaDonKhach
  {
      //Thanh phan du lieu
      private string tenkhach;
      private int songay;
      private Phong loaiphong;
      //Phuong thuc nhap thong tin hoa don
      public void Nhap()
      {
          Console.WriteLine("Nhap thong tin hoa don khach hang");
          Console.WriteLine("Ho ten:");
          tenkhach = Console.ReadLine();
          Console.WriteLine("So ngay o:");
          songay = int.Parse(Console.ReadLine());
          Console.WriteLine("Cho biet loai phong dinh o A,B,C?");
          char ch = char.Parse(Console.ReadLine());
          switch (char.ToUpper(ch))
          {
              case 'A':
                  loaiphong = new PhongA(songay);
                  break;
              case 'B':
                  loaiphong = new PhongB(songay);
                  break;
              case 'C':
                  loaiphong = new PhongC(songay);
                  break;
          }
      }
      //Phuong thuc hien thi thong tin hoa don khach hang
      public void Hien()
      {
          Console.WriteLine("Thong tin hoa don khach hang");
          Console.WriteLine("Ho ten khach:"+tenkhach);
          Console.WriteLine("So ngay o:"+songay);
          Console.WriteLine("Khach hang da su dung");
          loaiphong.Hien();
      }
  }
}
