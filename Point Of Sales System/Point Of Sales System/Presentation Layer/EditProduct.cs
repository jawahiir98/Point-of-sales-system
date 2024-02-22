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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void EditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductManagement pm = new ProductManagement();
            pm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(EditProductNameTextBox.Text == null || EditProductPriceTextBox.Text == null ||
             EditProductQuantityTextBox.Text == null || EditProductCIDComboBox.Text == null || SearchProductIdTextBox.Text == null)
            {
                MessageBox.Show("Fields cannot be empty");
            }
            else
            {
                ProductDataAccess productDataAccess = new ProductDataAccess();
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                int catId = categoryDataAccess.GetCategoryIdByName(EditProductCIDComboBox.Text);
                if (productDataAccess.UpdateProduct(Convert.ToInt32(SearchProductIdTextBox.Text), EditProductNameTextBox.Text, Convert.ToDouble(EditProductPriceTextBox.Text), Convert.ToDouble(EditProductQuantityTextBox.Text), catId))
                {
                    MessageBox.Show("Product updated");
                }
                else
                {
                    MessageBox.Show("Error in updating");
                }
                this.Hide();
                ProductManagement pm = new ProductManagement();
                pm.Show();
            }
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            CategoryDataAccess cda = new CategoryDataAccess();
            EditProductCIDComboBox.DataSource = cda.GetAllCategoryNames();
            EditProductCIDComboBox.SelectedIndex = -1;
        }
    }
}
