using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }
        public double Amount { get; set; }
        public double TotalPrice { get; set; }
    }
}
