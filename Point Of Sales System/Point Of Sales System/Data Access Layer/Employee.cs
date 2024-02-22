using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class Employee
    {
        public int EmployeeId { set; get; }
        public string Name { set; get; }
        public string UserName { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string DateofBirth { set; get; }
        public string Gender { set; get; }
        public string Address { set; get; }
        public int UserId { set; get; }
    }
}
