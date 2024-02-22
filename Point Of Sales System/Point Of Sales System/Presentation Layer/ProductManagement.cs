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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
            UpdateProductList();
        }
        void UpdateProductList()
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            ProductListDataGridView.DataSource = productDataAccess.GetAllProducts();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct ap = new AddProduct();
            ap.Show();
            UpdateProductList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteProduct dp = new DeleteProduct();
            dp.Show();
            UpdateProductList();
        }

        private void SearchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            ProductListDataGridView.DataSource = productDataAccess.GetProductsByName(SearchProductTextBox.Text);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProduct ep = new EditProduct();
            ep.Show();
            UpdateProductList();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalespersonNavigationPanel snp = new SalespersonNavigationPanel();
            snp.Show();
        }
    }
}
