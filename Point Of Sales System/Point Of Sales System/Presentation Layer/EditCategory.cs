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
    public partial class EditCategory : Form
    {
        public EditCategory()
        {
            InitializeComponent();
            CategoryDataAccess cda = new CategoryDataAccess();
            CategoryListDataGridView.DataSource = cda.GetAllCategories();
        }

        private void EditCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            string value = categoryDataAccess.GetCategoryNameById(Convert.ToInt32(SearchCategoryIdTextBox.Text));
            if (value == null)
            {
                MessageBox.Show("Category not found");
            }
            else
            {
                UpdateCategoryNameTextBox.Text = value;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.UpdateCategory(Convert.ToInt32(SearchCategoryIdTextBox.Text), UpdateCategoryNameTextBox.Text))
            {
                MessageBox.Show("Category updated");
                SearchCategoryIdTextBox.Text = UpdateCategoryNameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
            this.Hide();
            CategoryManagement cm = new CategoryManagement();
            cm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryManagement cm = new CategoryManagement();
            cm.Show();
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
