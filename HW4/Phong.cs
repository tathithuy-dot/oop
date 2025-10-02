using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
        //Chuong trinh tinh tien thue phong khach san
    abstract class Phong //Xay dung lop truu tuong Phong
    {
        protected int songay;// Thanh phan du lieu
        public Phong(int songay) //Phuong thuc khoi tao co tham so
        {
            this.songay = songay;
        }
        public abstract double TinhTien(); // Phuong thuc truu tuong tinh tien, bat cac class con phai override
        public abstract void Hien(); //Phuong thuc truu tuong hien thi, bat cac class con phai override
    }
}


