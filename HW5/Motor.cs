using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Motor: IMotor
    {
        protected string code;
        protected string name;
        protected double capacity;
        protected int num;
        public Motor()
        {
            code = "";
            name = "";
            capacity = 0;
            num = 0;
        }
        public Motor(string code, string name, double capacity, int num)
        {
            this.code = code;
            this.name = name;
            this.capacity = capacity;
            this.num = num;
        }
        public virtual void inputInfo()
        {
            Console.Write("Nhap ma xe: ");
            code = Console.ReadLine();
            Console.Write("Nhap ten xe: ");
            name = Console.ReadLine();
            Console.Write("Nhap dung tich xe: ");
            capacity = double.Parse(Console.ReadLine());
            Console.Write("Nhap so may: ");
            num = int.Parse(Console.ReadLine());
        }
        public virtual void showInfo()
        {
            Console.WriteLine("Ma xe: " + code);
            Console.WriteLine("Ten xe: " + name);
            Console.WriteLine("Dung tich xe: " + capacity);
            Console.WriteLine("So may: " + num);
        }
        public virtual void changeInfo()
        {
            Console.Write("Nhap ma xe moi: ");
            code = Console.ReadLine();
            Console.Write("Nhap ten xe moi: ");
            name = Console.ReadLine();
            Console.Write("Nhap dung tich xe moi: ");
            capacity = double.Parse(Console.ReadLine());
            Console.Write("Nhap so may moi: ");
            num = int.Parse(Console.ReadLine());
        }
    }
}
