using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập thông tin người dùng
            Console.WriteLine(" Nhập thông tin người dùng"); Console.WriteLine();
            // Khởi tạo mảng để chứa thông tin 3 người cần nhập theo bài yêu cầu
            Person[] people = new Person[3];
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Nhập thông tin người dùng thứ {i + 1}:");
                people[i] = Person.InputPersonInfo();
                Console.WriteLine();
            }
            // Hiển thị thông tin của 3 người vừa nhập.
            Console.WriteLine("Thông tin người dùng vừa nhập"); Console.WriteLine();    
            foreach (var person in people)
            {
                person.DisplayPersonInfo();
                Console.WriteLine();
            }
            // Sắp xếp lương theo thứ tự từ thấp đến cao
            Console.WriteLine("Sắp xếp theo lương"); Console.WriteLine();
            people = Person.Saptheoluong(people);
            // Hiển thị thông tin người dùng theo thứ tự đã sắp ở trên
            foreach (var person in people)
            {
                person.DisplayPersonInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
