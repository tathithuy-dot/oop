using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_GroceryBill
{
    public class GroceryBill // Class Hóa đơn tạp hóa
    {
        private Employee clerk; // Nhân viên thu ngân
        private List<Item> items; // Danh sách các mặt hàng trong hóa đơn
        public GroceryBill(Employee clerk) // Constructor khởi tạo nhân viên thu ngân và danh sách mặt hàng
        { 
            this.clerk = clerk;
            items = new List<Item>(); // Khởi tạo danh sách mặt hàng rỗng
        }
        public void Add(Item item) // Phương thức thêm mặt hàng vào hóa đơn
        {
            items.Add(item);
        }
        public double GetTotal() // Phương thức tính tổng giá trị của hóa đơn (không bao gồm giảm giá)
        {
            double total = 0;
            foreach (Item item in items)
            {
                total += item.GetPrice();
            }
            return total;
        }
        public void PrintReceipt() // Phương thức in hóa đơn
        {
            Console.WriteLine("Hóa đơn được thu bởi:" + clerk.Name);
            Console.WriteLine("Items:");
            foreach (Item item in items)
            {
                Console.WriteLine(" - " + item.GetName() + ": $" + item.GetPrice());
            }
            Console.WriteLine("Total: $" + GetTotal());
        }
    }
}
