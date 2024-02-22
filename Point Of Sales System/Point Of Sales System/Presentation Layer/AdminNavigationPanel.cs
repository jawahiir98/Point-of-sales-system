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
    public partial class AdminNavigationPanel : Form
    {
        public AdminNavigationPanel()
        {
            InitializeComponent();
        }

        private void AdminNavigationPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void StuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeInformation ve = new EmployeeInformation();
            ve.Show();
        }

        private void billingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBill vb = new ViewBill();
            vb.Show();
        }
    }
}
