using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_GroceryBill
{
     public class Item 
    {
        private string name; // Class item chứa tên, giá và giảm giá của sản phẩm; đại diện cho một mặt hàng trong cửa hàng tạp hóa.
        private double price;
        private double discount;

        public Item(string name, double price, double discount) // Constructor khởi tạo tên, giá và giảm giá của sản phẩm
        {
            this.name = name;
            this.price = price;
            this.discount = discount;
        }
        public string GetName() {return name; } // Các phương thức Get để truy xuất tên, giá và giảm giá của sản phẩm
        public double GetPrice() {return price;}
        public double GetDiscount() {return discount;}

    }
}
