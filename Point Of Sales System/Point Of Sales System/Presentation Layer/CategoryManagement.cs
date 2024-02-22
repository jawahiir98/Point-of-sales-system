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
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
        }
        private void CategoryManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void UpdateCategoryList()
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            CategoryListDataGridView.DataSource = categoryDataAccess.GetAllCategories();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCategory ac = new AddCategory();
            ac.Show();
            UpdateCategoryList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditCategory ec = new EditCategory();
            ec.Show();
            UpdateCategoryList();
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            UpdateCategoryList();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            SearchCategoryComboBox.DataSource = categoryDataAccess.GetAllCategoryNames();
            SearchCategoryComboBox.SelectedIndex = -1;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteCategory DC = new DeleteCategory();
            DC.Show();
            UpdateCategoryList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SearchCategoryComboBox.Text != null)
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                int catId = categoryDataAccess.GetCategoryIdByName(SearchCategoryComboBox.Text);
                ProductDataAccess productDataAccess = new ProductDataAccess();
                CategoryListDataGridView.DataSource = productDataAccess.GetAllProductsByCategoryId(catId);
            }
            else
            {
                UpdateCategoryList();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalespersonNavigationPanel snp = new SalespersonNavigationPanel();
            snp.Show();
        }
    }
}
