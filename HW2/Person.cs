using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Person
    {
        private string name;
        private string address;
        private double salary;
        // Khởi tạo constructor có tham số
        public Person(string name, string address, double salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }
        // Dùng get/set với các thuộc tính của class Person
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }   
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        // Phương thức nhập thông tin người dùng (có kiểm tra điều kiện về lương)
        public static Person InputPersonInfo()
        {
            Console.WriteLine("Nhập thông tin người dùng.");
            Console.Write("Họ và tên: ");
            string name = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            string address = Console.ReadLine();
            string salaryInput;
            double salary;
            // Kiểm tra điều kiện về lương. Hiện ra thông báo nếu lương để trống, lương âm hoặc lương không là một số.
            while (true)
            {
                Console.Write("Lương: ");
                salaryInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(salaryInput))
                        {
                            Console.WriteLine("Lương không được để trống. Vui lòng nhập lại.");
                        }
                else if (!double.TryParse(salaryInput, out salary))
                        {
                            Console.WriteLine("Lương phải là một số hợp lệ. Vui lòng nhập lại.");
                        }
                else if (salary < 0)
                        {
                            Console.WriteLine("Lương không được âm. Vui lòng nhập lại.");
                        }
                else
                        break;

            }
            return new Person(name, address, salary);
        }
        // Phương thức hiển thị thông tin người dùng
        public void DisplayPersonInfo()
        {
            Console.WriteLine("Thông tin người dùng:");
            Console.WriteLine($"Họ và tên: {name}");
            Console.WriteLine($"Địa chỉ: {address}");
            Console.WriteLine($"Lương: {salary}");
        }
        // Phương thức sắp xếp lương tăng dần theo BubbleSort
        public static Person[] Saptheoluong(Person[] people)
        {
            // Duyệt qua mảng 
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = 0; j<people.Length - i -1;  j++)
                {
                    // So sánh cặp phần tử liền kề
                    if (people[i].Salary > people[j+1].Salary) // Đổi chỗ nếu phần tử trước lớn hơn phần tử sau.
                    {
                        Person tmp = people[i];
                        people[i] = people[j+1];
                        people[j+1] = tmp;
                    }
                }
            }
            return people;
        }
    }
}
