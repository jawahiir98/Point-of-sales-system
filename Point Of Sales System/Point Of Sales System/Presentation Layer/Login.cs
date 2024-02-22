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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            User_data_acces ffv = new User_data_acces();
            string type = ffv.GetUser(UserNametextBox.Text, PaswordtextBox.Text);
            UserRegistration ur = new UserRegistration();
            if (type == "SalesPerson")
            {
                this.Hide();
                SalespersonNavigationPanel sp = new SalespersonNavigationPanel();
                sp.Show();
            }
            else if(type == "Admin")
            {
                this.Hide();
                AdminNavigationPanel ap = new AdminNavigationPanel();
                ap.Show();
            }
            else
            {
                MessageBox.Show("Incorrect password or username");
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRegistration ur = new UserRegistration();
            ur.Show();
        }
    }
}
