using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Phần mở rộng của đề bài
namespace BTH_GroceryBill
{
    public class GroceryBillWithLines // Class Hóa đơn tạp hóa với các dòng, mỗi dòng bao gồm mặt hàng và số lượng
    {
        private Employee clerk;
        private List<BillLine> lines;
        private bool preferred;
        public GroceryBillWithLines(Employee clerk, bool preferred) 
        {
            this.clerk = clerk;
            this.preferred = preferred;
            lines = new List<BillLine>();
        }
        public void Add(Item item, int quantity) 
        {
            lines.Add(new BillLine(item, quantity)); 
        }
        public double GetTotal()
        {
            double total = 0;
            foreach (BillLine line in lines)
            {
                total += line.GetLineTotal(preferred); // Tính tổng giá trị của tất cả các dòng, có áp dụng giảm giá nếu khách đặc biệt
            }
            return total;
        }
        public void PrintReceipt()
        {
            Console.WriteLine("Hóa đơn được thu bởi: " + clerk.Name);
            Console.WriteLine("Sản phẩm:");
            foreach (BillLine line in lines)
            {
                Console.WriteLine(line.ToString()); // Gọi phương thức ToString của BillLine để hiển thị thông tin dòng
            }
            Console.WriteLine("Tổng: " + GetTotal().ToString("C")); 
        }
    }
}
