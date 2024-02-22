using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class SaveBillDataAccess : DataAccess
    {
        public List<SaveBill> GetAllBills()
        {
            string sql = "SELECT * FROM Bills";
            SqlDataReader reader = this.GetData(sql);
            List<SaveBill> saveBills = new List<SaveBill>();
            while (reader.Read())
            {
                SaveBill save = new SaveBill();
                save.BillId = (int)reader["BillId"];
                save.PaidAmount = (double)reader["PaidAmount"];
                save.TotalPrice = (double)reader["TotalPrice"];
                save.Change = (double)reader["Change"];
                saveBills.Add(save);
            }
            return saveBills;
        }
        public bool AddNewBill(double TotalPrice,double PaidAmount,double Change)
        {
            string sql = "INSERT INTO Bills(TotalPrice, PaidAmount, Change) VALUES("+TotalPrice+", "+PaidAmount+", "+Change+")";

            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteBill(int BillId)
        {
            string sql = "DELETE FROM Bills WHERE BillId=" + BillId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
