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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
            Submitbutton.Enabled = false;
        }
        
        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void Submitbutton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty ");
            }
            else if (UserNametextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (EmailtextBox3.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (PasswordtextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (ConfimPasswordtextBox.Text == "")
            {
                MessageBox.Show("Confirm password cannot be empty");
            }
            else if (AddresstextBox.Text == "")
            {
                MessageBox.Show("Address cannot be empty");
            }

            else if (DateOfBirthTimePicker.Value.Date.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Select proper date of birth");
            }
            else if (MaleradioButton.Checked == false && FemaleradioButton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if(PasswordtextBox.Text != ConfimPasswordtextBox.Text)
            {
                MessageBox.Show("Password and confirm password does not match");
            }
            else if(SalesPersonradioButton.Checked == false && AdminradioButton.Checked == false)
            {
                MessageBox.Show("Please select a Type");
            }
            User VB = new User();
            VB.Name = NametextBox.Text;
            VB.UserName = UserNametextBox.Text;
            VB.Email = EmailtextBox3.Text;
            VB.Password = PasswordtextBox.Text;
            VB.Address = AddresstextBox.Text;
            VB.DateofBirth = DateOfBirthTimePicker.Text;
            if (MaleradioButton.Checked)
            {
                VB.Gender = "male";
            }
            else
            {
                VB.Gender = "female";
            }

            if (SalesPersonradioButton.Checked)
            {
                VB.UserType = "SalesPerson";
            }
            else
            {
                VB.UserType = "Admin";
            }
            User_data_acces ss = new User_data_acces();
            if (ss.Useregistration(VB))
            {
                MessageBox.Show("User registered succesfully");
                EmployeeDataAccess eda = new EmployeeDataAccess();
                bool ok = eda.AddEmployee(VB.Name, VB.UserName, VB.Email, VB.Password, VB.DateofBirth, VB.Gender, VB.Address, ss.GetUserID(VB.UserName, VB.Password));
                Login dd = new Login();
                dd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not registered succesfully");
            }
        }

        private void AllTermsAndCondition_CheckedChanged(object sender, EventArgs e)
        {
            Submitbutton.Enabled = true;
        }
    }
}
