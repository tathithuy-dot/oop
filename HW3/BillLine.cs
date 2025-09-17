using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_GroceryBill
{
    public class BillLine // Class BillLine đại diện cho một dòng trong hóa đơn, bao gồm mặt hàng và số lượng
    {
        private Item item;
        private int quantity;
        public BillLine(Item item, int quantity) 
        {
            this.item = item;
            this.quantity = quantity;
        }
        public Item GetItem() { return item; }
        public int GetQuantity() { return quantity; }
        public double GetLineTotal(bool preferred) // Phương thức tính tổng giá trị của dòng, có áp dụng giảm giá nếu khách đặc biệt
        {
            if (preferred)
                return (item.GetPrice() - item.GetDiscount()) * quantity;
            return item.GetPrice() * quantity;
        }
        public override string ToString() // Phương thức ghi đè ToString để hiển thị thông tin dòng
        {
            return $"{item.GetName(),-20} {quantity,5} = {GetLineTotal(true),10:C}";// Giả sử khách hàng là khách đặc biệt để hiển thị giá đã giảm, nếu không thì thay true bằng false
        }
    }
}
