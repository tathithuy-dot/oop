using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
   internal abstract class  ThietBi // Lớp trừu tượng, bắt buộc các lớp khác kế thừa
{
        public string NhaSX { get; set; } // Do dùng thuộc tính nên vẫn có thể để public cho tiện nhập/ xuất
        public string Model { get; set; }
        public double Gia { get; set; }
        public ThietBi() // Constructor mặc định
        {
        }
        public ThietBi(string nhasx, string model, double gia) // Constructor có tham số
        {
            NhaSX = nhasx;
            Model = model;
            Gia = gia;
        }
        public abstract void Nhap(); // Phương thức trừu tượng, bắt buộc phải kế thừa
        public abstract void Xuat(); //Phương thức trừu tượng, bắt buộc phải kế thừa
    }
}



