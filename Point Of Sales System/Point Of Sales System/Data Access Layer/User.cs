using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class User
    {
        //'" + ss.Name + "','" + ss.userName + "','" + ss.Email + "','" + ss.Password + "',
        //'" + ss.DateofBirth + "',
        //'" + ss.Gender + "','" + ss.Address + "','" + ss.UserType + "'
        public int UserId { set; get; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string UserType { get; set; }
    }
}
