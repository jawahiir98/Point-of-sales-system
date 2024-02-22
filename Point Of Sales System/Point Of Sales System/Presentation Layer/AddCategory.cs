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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryManagement cm = new CategoryManagement();
            cm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(AddCategoryNameTextBox.Text == null)
            {
                MessageBox.Show("Field cannot be empty");
            }
            else
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                if (categoryDataAccess.AddNewCategory(AddCategoryNameTextBox.Text))
                {
                    MessageBox.Show("Category added");
                }
                else
                {
                    MessageBox.Show("Error in adding");
                }
                this.Hide();
                CategoryManagement cm = new CategoryManagement();
                cm.Show();
            }
        }

        private void AddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
