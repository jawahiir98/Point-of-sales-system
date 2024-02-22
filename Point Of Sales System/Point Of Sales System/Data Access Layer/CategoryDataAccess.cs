using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales_System.Data_Access_Layer
{
    class CategoryDataAccess : DataAccess
    {
        public List<Category> GetAllCategories()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = this.GetData(sql);
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = (int)reader["CategoryId"];
                category.CategoryName = reader["CategoryName"].ToString();
                categories.Add(category);
            }
            return categories;
        }

        public bool AddNewCategory(string categoryName)
        {
            string sql = "INSERT INTO Categories(CategoryName) VALUES('" + categoryName + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteCategory(int categoryId)
        {
            string sql = "DELETE FROM Categories WHERE CategoryId=" + categoryId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateCategory(int categoryId, string categoryName)
        {
            string sql = "UPDATE Categories SET CategoryName='" + categoryName + "' WHERE CategoryId=" + categoryId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public string GetCategoryNameById(int categoryId)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryId=" + categoryId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return reader["CategoryName"].ToString();
            }
            return null;
        }
        public int GetCategoryIdByName(string categoryName)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryName='" + categoryName + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return (int)reader["CategoryId"];
            }
            return -1;
        }
        public List<string> GetAllCategoryNames()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = this.GetData(sql);
            List<string> categoryNames = new List<string>();
            while (reader.Read())
            {
                categoryNames.Add(reader["CategoryName"].ToString());
            }
            return categoryNames;
        }
    }
}
