using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_GroceryBill
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo nhân viên thu ngân số 1 
            Employee clerk1 = new Employee("Nguyễn Văn An");
            // Tạo và in hóa đơn thông thường
            Console.WriteLine("Hóa đơn thông thường:");
            GroceryBill bill = new GroceryBill(clerk1);
            Item item1 = new Item("Sữa", 2.5, 0.5);
            Item item2 = new Item("Bánh mì", 1.0, 0.2);
            Item item3 = new Item("Trứng", 0.2, 0.05);
            bill.Add(item1);
            bill.Add(item2);
            bill.Add(item3);
            bill.PrintReceipt();
            Console.WriteLine();
            // Tạo nhân viên thu ngân số 2
            Employee clerk2 = new Employee("Trần Thị Bình");
            // Tạo và in hóa đơn giảm giá cho khách đặc biệt
            Console.WriteLine("Hóa đơn giảm giá cho khách đặc biệt:");
            DiscountBill discountBill = new DiscountBill(clerk2, true);
            discountBill.Add(item1);
            discountBill.Add(item2);
            discountBill.Add(item3);
            discountBill.PrintReceipt();
            Console.WriteLine();
            // Tạo và in hóa đơn với số lượng sản phẩm
            Console.WriteLine("Hóa đơn với số lượng sản phẩm:");
            GroceryBillWithLines billWithLines = new GroceryBillWithLines(clerk1, true); // Khách đặc biệt
            billWithLines.Add(item1, 2);
            billWithLines.Add(item2, 3);
            billWithLines.Add(item3, 12);
            billWithLines.PrintReceipt();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
