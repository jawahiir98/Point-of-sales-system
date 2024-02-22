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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void DeleteProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductManagement pm = new ProductManagement();
            pm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(DeleteProductTextBox.Text == null)
            {
                MessageBox.Show("Fields cannot be empty");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ProductDataAccess productDataAccess = new ProductDataAccess();
                    if (productDataAccess.DeleteProduct(Convert.ToInt32(DeleteProductTextBox.Text)))
                    {
                        MessageBox.Show("Product deleted");
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting");
                    }
                }
                this.Hide();
                ProductManagement pm = new ProductManagement();
                pm.Show();
            }
        }
    }
}
