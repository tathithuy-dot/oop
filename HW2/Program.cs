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
            Console.WriteLine(" Nhập thông tin người dùng"); Console.WriteLine();
            Person[] people = new Person[3];
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Nhập thông tin người dùng thứ {i + 1}:");
                people[i] = Person.InputPersonInfo();
                Console.WriteLine();
            }
            Console.WriteLine("Thông tin người dùng vừa nhập"); Console.WriteLine();    
            foreach (var person in people)
            {
                person.DisplayPersonInfo();
                Console.WriteLine();
            }
            Console.WriteLine("Sắp xếp theo lương"); Console.WriteLine();
            people = Person.Saptheoluong(people);
            foreach (var person in people)
            {
                person.DisplayPersonInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
