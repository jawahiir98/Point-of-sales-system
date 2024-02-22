using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class CartDataAccess : DataAccess
    {
        public List<Cart> GetAllCartItems()
        {
            string sql = "SELECT * FROM Carts";
            SqlDataReader reader = this.GetData(sql);
            List<Cart> carts = new List<Cart>();
            while (reader.Read())
            {
                Cart cart = new Cart();
                cart.CartId = (int)reader["CartId"];
                cart.ProductId = (int)reader["ProductId"];
                cart.Price = (double)reader["Price"];
                cart.ProductName = reader["ProductName"].ToString();
                cart.Amount = (double)(reader["Amount"]);
                ProductDataAccess pda = new ProductDataAccess();
                cart.TotalPrice = pda.GetProductPriceByID(cart.ProductId) * cart.Amount;
                carts.Add(cart);
            }
            return carts;
        }
        public bool AddNewIem(int ProductId,string productName,double price, double amount, double totaprice)
        {
            string sql = "INSERT INTO Carts(ProductName, Price, Productid,TotalPrice,Amount) VALUES('" + productName + "', " + price + ", " + ProductId + ", " + totaprice + ", " + amount + ")";
            
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool RemoveAllItems()
        {
            string sql = "DELETE FROM Carts";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
