using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
   internal abstract class  ThietBi
{
        public string NhaSX { get; set; }
        public string Model { get; set; }
        public double Gia { get; set; }
        public ThietBi()
        {

        }
        public ThietBi(string nhasx, string model, double gia)
        {
            NhaSX = nhasx;
            Model = model;
            Gia = gia;
        }
        public abstract void Nhap();
        public abstract void Xuat();
    }
}

