using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuahangxe
{
    internal class Jupiter: Motor
    {
        private int thoigianBaoHanh;
        public override void inputInfo()
        {
            base.inputInfo();
            Console.Write("Nhap thoi gian bao hanh: ");
            thoigianBaoHanh = int.Parse(Console.ReadLine());
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("Thoi gian bao hanh: " + thoigianBaoHanh);
        }
    }
}

