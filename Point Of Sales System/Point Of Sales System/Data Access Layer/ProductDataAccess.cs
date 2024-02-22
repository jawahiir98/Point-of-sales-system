using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class ProductDataAccess : DataAccess
    {
        public List<Product> GetAllProducts()
        {
            string sql = "SELECT * FROM Products";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = Convert.ToDouble(reader["Quantity"]);
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }
        public bool AddNewProduct(string productName, double price,double quantity,int categoryId)
        {
            string sql = "INSERT INTO Products(ProductName,Price,Quantity,CategoryId) VALUES('" + productName + "'," + price + "," + quantity + " ," + categoryId + ")";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateProduct(int productId, string productName, double price,double quantity, int categoryId)
        {
            string sql = "UPDATE Products SET ProductName='" + productName + "',Price=" + price + ", Quantity = " + quantity + ",CategoryId=" + categoryId + " WHERE ProductId=" + productId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteProduct(int productId)
        {
            string sql = "DELETE FROM Products WHERE ProductId=" + productId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public List<Product> GetAllProductsByCategoryId(int categoryId)
        {
            string sql = "SELECT * FROM Products WHERE CategoryId=" + categoryId;
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = Convert.ToDouble(reader["Quantity"]);
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }

        public List<Product> GetProductsByName(string productName)
        {
            string sql = "SELECT * FROM Products WHERE ProductName LIKE '" + productName + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = Convert.ToDouble(reader["Quantity"]);
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }
        public double GetProductPriceByID(int productId)
        {
            string sql = "SELECT * FROM Products WHERE ProductId=" + productId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return (double)(reader["Price"]);
            }
            return -1.0;
        }
        public string GetProductNameByID(int productId)
        {
            string sql = "SELECT * FROM Products WHERE ProductId=" + productId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return (reader["ProductName"].ToString());
            }
            return null;
        }
        public Product GetProduct(int productId)
        {
            string sql = "SELECT * FROM Products WHERE ProductId=" + productId;
            SqlDataReader reader = this.GetData(sql);
            Product product = new Product();
            if (reader.Read())
            {
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = Convert.ToDouble(reader["Quantity"]);
                product.CategoryId = (int)reader["CategoryId"];
                return product;
            }
            else return null;
        }
    }
}
