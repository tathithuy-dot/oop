using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cuahangxe
{
    internal class Yamada
    {
        private List<Motor> motors = new List<Motor>();
        public void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Nhap thong tin xe");
                Console.WriteLine("2. Hien thi thong tin xe");
                Console.WriteLine("3. Sap xep thong tin xe theo thoi gian bao hanh");
                Console.WriteLine("4. Tim kiem thong tin xe co ten Serius");
                Console.WriteLine("5. Thoat");
                Console.Write("Nhap lua chon: ");
                choice = int.Parse(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            InputMotors();
                            break;
                        case 2:
                            DisplayMotors();
                            break;
                        case 3:
                            SortMotors();
                            break;
                        case 4:
                            SearchMotors();
                            break;
                        case 5:
                            Console.WriteLine("Thoat chuong trinh");
                            break;
                        default:
                            Console.WriteLine("Lua chon khong hop le");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Loi: " + ex.Message);
                }
            } while (choice != 5);
        }
        private void InputMotors()
        {
            Console.Write("Nhap thong tin 3 xe Jupiter: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nhap thong tin xe thu " + (i + 1));
                Jupiter motorJ= new Jupiter();
                motorJ.inputInfo();
                motors.Add(motorJ);
            }
            Console.Write("Nhap thong tin 3 xe Serius: ");
            for(int i = 0;i<3;i++)
            {
                Console.WriteLine("Nhap thong tin xe thu " + (i + 1));
                Serius motorS = new Serius();
                motorS.inputInfo();
                motors.Add(motorS);
            }
        }
        private void DisplayMotors()
        {
            Console.WriteLine("Thong tin cac xe vua nhap: ");
            foreach(Motor motor in motors)
            {
                motor.showInfo();
                Console.WriteLine("---------------------");
            }
        }
        private void SortMotors()
        {
            Console.WriteLine("Sap xep theo bao hanh");
            //Khong sap xep duoc vi khong co thuoc tinh thoi gian bao hanh cua xe trong class Motor
            DisplayMotors();
            Console.WriteLine("Da sap xep"); //Do khong biet thoi gian bao hanh cua tung loai xe nen khong sap xep duoc
        }
        private void SearchMotors()
        {
            Console.WriteLine("Tim kiem xe co ten Serius");
            var result = motors.Where(m => m is Serius).ToList();
            if(result.Count == 0)
            {
                Console.WriteLine("Khong tim thay xe Serius");
            }
            else
            {
                foreach(Motor motor in result)
                {
                    motor.showInfo();
                    Console.WriteLine("---------------------");
                }
            }
        }
    }
}

