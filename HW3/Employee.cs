using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_GroceryBill
{
    public class Employee // Class Nhân viên
    {
        private string name; // Tên nhân viên
        public Employee(string name) // Constructor khởi tạo tên nhân viên
        { this.name = name; }
        public string Name // Thuộc tính chỉ đọc để truy xuất tên nhân viên
        {
            get { return name; }
        }
    }
}
