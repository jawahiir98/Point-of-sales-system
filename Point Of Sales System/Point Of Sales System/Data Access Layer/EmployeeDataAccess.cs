using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class EmployeeDataAccess : DataAccess
    {
        public List<Employee> GetAllEmployess()
        {
            string sql = "SELECT*FROM Employees";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> gh = new List<Employee>();
            while (reader.Read())
            {
                Employee jj = new Employee();
                jj.EmployeeId = (int)reader["EmployeeId"];
                jj.Name = reader["Name"].ToString();
                jj.UserName = reader["UserName"].ToString();
                jj.Email = reader["Email"].ToString();
                jj.Password = reader["Password"].ToString();
                jj.DateofBirth = reader["DateofBirth"].ToString();
                jj.Gender = reader["Gender"].ToString();
                jj.Address = reader["Address"].ToString();
                jj.UserId = (int)reader["UserId"];
                gh.Add(jj);
            }
            return gh;
        }

        public bool AddEmployee(string Name, string UserName, string Email, string Password, string DateOfBirth, string Gender, String Address, int UserId)
        {
            string sql = "INSERT INTO Employees (Name,UserName,Email,Password,DateOfBirth,Gender,Address,UserId) VALUES('" + Name + "','" + UserName + "','" + Email + "','" + Password + "','" + DateOfBirth + "','" + Gender + "','" + Address + "'," + UserId + ")";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool Updateemployee(string Name, string UserName, string Email, string Password, string DateOfBirth, string Gender, String Address, int UserId)
        {
            string sql = "UPDATE Employees SET Name='" + Name + "',UserName='" + UserName + "',Email='" + Email + "',Password ='" + Password + "',DateOfBirth ='" + DateOfBirth + "',Gender='" + Gender + "',Address = '" + Address + "'  WHERE UserId=" + UserId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool Deleateemployee(int EmployeeId)
        { 
            string sql = "DELETE FROM Employees WHERE EmployeeId=" + EmployeeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public Employee GetemployeeNamebyid(int EmployeeId)
        {
            string sql = "SELECT*FROM Employees WHERE EmployeeId=" + EmployeeId;
            SqlDataReader reader = this.GetData(sql);
            Employee ee = new Employee();
            if (reader.Read())
            {
                ee.Name = reader["Name"].ToString();
                ee.UserName = reader["UserName"].ToString();
                ee.Email = reader["Email"].ToString();
                ee.Password = reader["Password"].ToString();
                ee.DateofBirth = reader["DateOfBirth"].ToString();
                ee.Gender = reader["Gender"].ToString();
                ee.Address = reader["Address"].ToString();
                ee.UserId = (int)reader["UserId"];
                return ee;
            }
            return null;
        }
    }
}
