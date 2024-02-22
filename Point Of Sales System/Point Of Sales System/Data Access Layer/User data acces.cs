using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class User_data_acces : DataAccess
    {
        public bool Useregistration(User ss)
        {
            string sql = "INSERT INTO Users (Name,UserName,Email,Password,DateOfBirth,Gender,Address,UserType) VALUES ('" + ss.Name + "','" + ss.UserName + "','" + ss.Email + "','" + ss.Password + "','" + ss.DateofBirth + "','" + ss.Gender + "','" + ss.Address + "','" + ss.UserType + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;

        }
        public bool LoginValidation(string Username, string Password)
        {
            string sql = "SELECT * FROM Users WHERE UserName = '" + Username + "' AND Password = '" + Password + "' ";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
        public string GetUser(string Username, string Password)
        {
            string sql = "SELECT * FROM Users WHERE UserName = '" + Username + "' AND Password = '" + Password + "' ";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                //Console.WriteLine("{0}", reader["UserType"].ToString());
                return reader["UserType"].ToString();
            }
            return null;
        }
        public int GetUserID(string Username, string Password)
        {
            string sql = "SELECT * FROM Users WHERE UserName = '" + Username + "' AND Password = '" + Password + "' ";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                //Console.WriteLine("{0}", reader["UserType"].ToString());
                return (int)reader["UserId"];
            }
            return 0;
        }

    }
}
