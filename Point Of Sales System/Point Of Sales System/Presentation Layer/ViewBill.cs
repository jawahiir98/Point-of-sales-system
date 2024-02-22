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
    public partial class ViewBill : Form
    {
        public ViewBill()
        {
            InitializeComponent();
            SaveBillDataAccess saveBillDataAccess = new SaveBillDataAccess();
            UpdateBills();
        }
        void UpdateBills()
        {
            SaveBillDataAccess saveBillDataAccess = new SaveBillDataAccess();
            BillDataGridView.DataSource = saveBillDataAccess.GetAllBills();
        }
        private void ViewBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveBillDataAccess saveBillDataAccess = new SaveBillDataAccess();
            if (saveBillDataAccess.DeleteBill(Convert.ToInt32(ClearBillTextBox.Text)))
            {
                MessageBox.Show("Bill deleted");
            }
            else MessageBox.Show("Error in deletion");
            UpdateBills();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminNavigationPanel anp = new AdminNavigationPanel();
            anp.Show();
        }
    }
}
