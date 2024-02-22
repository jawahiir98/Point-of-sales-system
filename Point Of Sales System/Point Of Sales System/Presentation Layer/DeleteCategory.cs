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
    public partial class DeleteCategory : Form
    {
        public DeleteCategory()
        {
            InitializeComponent();
        }

        private void DeleteCategory_Load(object sender, EventArgs e)
        {

        }

        private void DeleteCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryManagement cm = new CategoryManagement();
            cm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.DeleteCategory(Convert.ToInt32(DeleteCategoryTextBox.Text)))
            {
                MessageBox.Show("Category deleted");
            }
            else
            {
                MessageBox.Show("Error in deleting");
            }
            this.Hide();
            CategoryManagement cm = new CategoryManagement();
            cm.Show();
        }
    }
}
