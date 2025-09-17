using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_GroceryBill
{
    public class DiscountBill: GroceryBill // Class Hóa đơn giảm giá cho khách đặc biệt kế thừa từ lớp GroceryBill
    {
        private bool preferred; // Biến để xác định khách hàng có đặc biệt hay không
        private int discountCount; // Số lượng sản phẩm được giảm giá
        private double discountAmount; // Tổng số tiền được giảm giá
        public DiscountBill(Employee clerk, bool preferred): base(clerk) // Constructor khởi tạo nhân viên thu ngân và trạng thái khách đặc biệt, gọi constructor của lớp cha
        {
            this.preferred = preferred;
        }
        public int GetDiscountCount() // Phương thức để truy xuất số lượng sản phẩm được giảm giá
        {
            if (!preferred) return 0;
            return discountCount;
        }
        public double GetDiscountAmount()// Phương thức để truy xuất tổng số tiền được giảm giá
        {
            if (!preferred) return 0.0;
            return discountAmount;
        }
        public new void Add(Item item)// Phương thức thêm mặt hàng vào hóa đơn, ẩn phương thức Add của lớp cha (chỉ chạy nếu khách đặc biệt và sản phẩm có giảm giá)
        {
            base.Add(item);
            if (preferred && item.GetDiscount() > 0) 
            {
                discountCount++;
                discountAmount += item.GetDiscount();
            }
        }
        public new double GetTotal() // Phương thức tính tổng giá trị của hóa đơn sau khi áp dụng giảm giá, ẩn phương thức GetTotal của lớp cha
        {
            double total = base.GetTotal();
            if (preferred) // Chỉ áp dụng giảm giá nếu khách hàng là khách đặc biệt
            {
                total -= discountAmount;
            }
            return total;
        }
        public double GetDiscountPercent() // Phương thức tính phần trăm giảm giá so với tổng giá trị ban đầu của hóa đơn
        {
            double beforeDiscount = base.GetTotal();
            if (preferred && beforeDiscount > 0) // Tránh chia cho 0
            {
                return (discountAmount / beforeDiscount) * 100.0;
            }
            return 0.0;
        }
        public new void PrintReceipt() // Phương thức in hóa đơn, ẩn phương thức PrintReceipt của lớp cha
        {
            base.PrintReceipt(); // Gọi phương thức in hóa đơn của lớp cha
            if (preferred)
            {
                Console.WriteLine("Hóa đơn giảm giá cho khách đặc biệt:");
                Console.WriteLine(" - Sản phẩm được giảm giá: " + GetDiscountCount());
                Console.WriteLine(" - Tổng tiền được giảm: $" + GetDiscountAmount());
                Console.WriteLine($" - Tương đương với giảm: { GetDiscountPercent():F2}%");
            }
        }
    }
}
