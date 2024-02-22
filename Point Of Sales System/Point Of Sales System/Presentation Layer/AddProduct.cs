using Point_Of_Sales_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales_System.Presentation_Layer
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductManagement pm = new ProductManagement();
            pm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(AddProductNameTextBox.Text == null || AddProductPriceTextBox.Text == null ||
             AddProductQuantityTextBox.Text == null || AddProductCategoryIdComboBox.Text == null)
            {
                MessageBox.Show("Fields cannot empty");
            }
            else
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                int catId = categoryDataAccess.GetCategoryIdByName(AddProductCategoryIdComboBox.Text);
                if (catId > 0)
                {
                    ProductDataAccess productDataAccess = new ProductDataAccess();
                    if (productDataAccess.AddNewProduct(AddProductNameTextBox .Text, Convert.ToDouble(AddProductPriceTextBox.Text),Convert.ToDouble(AddProductQuantityTextBox.Text) ,catId))
                    {
                        MessageBox.Show("Product added");
                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }
                }
                else
                {
                    MessageBox.Show("Category not found");
                }
                this.Hide();
                ProductManagement pm = new ProductManagement();
                pm.Show();
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            AddProductCategoryIdComboBox.DataSource = categoryDataAccess.GetAllCategoryNames();
            AddProductCategoryIdComboBox.SelectedIndex = -1;
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
