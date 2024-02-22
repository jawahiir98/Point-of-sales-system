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
    public partial class SalespersonNavigationPanel : Form
    {
        public SalespersonNavigationPanel()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void ManageProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductManagement pm = new ProductManagement();
            pm.Show();
        }

        private void ManageCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryManagement cm = new CategoryManagement();
            cm.Show();
        }

        private void ManageTransactionsMenuStripItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillTransaction bt = new BillTransaction();
            bt.Show();
        }
    }
}
