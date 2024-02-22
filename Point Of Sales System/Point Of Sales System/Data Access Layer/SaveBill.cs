using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class SaveBill
    {
        public int BillId { get; set; }
        public double TotalPrice { get; set; }
        public double PaidAmount { get; set; }
        public double Change { get; set; }
    }
}
