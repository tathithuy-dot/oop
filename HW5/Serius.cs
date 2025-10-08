using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuahangxe
{
    internal class Serius: Motor
    {
        private int tgianBaoHanh;
        public override void inputInfo()
        {
            base.inputInfo();
            Console.Write("Nhap thoi gian bao hanh");
            tgianBaoHanh = int.Parse(Console.ReadLine());
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("Thoi gian bao hanh: " + tgianBaoHanh);
        }
    }
}

