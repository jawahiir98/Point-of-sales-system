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
    public partial class EmployeeInformation : Form
    {
        public EmployeeInformation()
        {
            InitializeComponent();
            Updateemployeelist();
        }
        void Updateemployeelist()
        {
            EmployeeDataAccess nn = new EmployeeDataAccess();
            EmployeeListDataGridView.DataSource = nn.GetAllEmployess();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminNavigationPanel anp = new AdminNavigationPanel();
            anp.Show();
        }

        private void Deletebutton_Click_1(object sender, EventArgs e)
        {
            EmployeeDataAccess ss = new EmployeeDataAccess();
            if (ss.Deleateemployee(Convert.ToInt32(EmployeetextBox1.Text)))
            {
                MessageBox.Show("Employee DELETED");
                Updateemployeelist();
            }
            else
            {
                MessageBox.Show(" Employee NOT DELETED");
            }
        }

        private void Serachbutton_Click_1(object sender, EventArgs e)
        {
            EmployeeDataAccess ss = new EmployeeDataAccess();
            Employee ff = new Employee();
            ff = ss.GetemployeeNamebyid(Convert.ToInt32(EmployeeTextBox.Text));
            if (ff == null)
            {
                MessageBox.Show("ID NOT FOUND");
            }
            else
            {
                NameTextBox.Text = ff.Name;
                UserNametextBox.Text = ff.UserName;
                EmailtextBox.Text = ff.Email;
                PasswordtextBox.Text = ff.Password;
                dateOfBirthTimePicker.Text = ff.DateofBirth;
                AddresstextBox.Text = ff.Address;
                UserIdtextBox.Text = ff.UserId.ToString();
                if (maleradioButton.Checked)
                {
                    ff.Gender = "male";
                }
                else
                {
                    ff.Gender = "female";
                }
                Updateemployeelist();
            }
        }

        private void Editbutton_Click_1(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("name cannot be empty ");
            }
            else if ((UserNametextBox.Text == ""))
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (EmailtextBox.Text == "")
            {
                MessageBox.Show("EMAiI cannot be empty");
            }
            else if (PasswordtextBox.Text == "")
            {
                MessageBox.Show("PASS cannot be empty");
            }
            else if (dateOfBirthTimePicker.Value.Date.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Select proper date of birth");
            }
            else if ((maleradioButton.Checked == false) && (femaleradioButton.Checked == false))
            {
                MessageBox.Show("Select a gender");
            }
            else if (AddresstextBox.Text == "")
            {
                MessageBox.Show("Address cannot be empty");
            }
            else if (UserIdtextBox.Text == "")
            {
                MessageBox.Show("userId  cannot be empty");
            }
            else
            {
                Employee VB = new Employee();
                VB.Name = NameTextBox.Text;
                VB.UserName = UserNametextBox.Text;
                VB.Email = EmailtextBox.Text;
                VB.Password = PasswordtextBox.Text;
                VB.DateofBirth = dateOfBirthTimePicker.Text;
                VB.Address = AddresstextBox.Text;
                VB.UserId = Convert.ToInt32(UserIdtextBox.Text);

                if (maleradioButton.Checked)
                {
                    VB.Gender = "male";
                }
                else
                {
                    VB.Gender = "female";
                }

                EmployeeDataAccess ss = new EmployeeDataAccess();
                if (ss.Updateemployee(VB.Name, VB.UserName, VB.Email, VB.Password, VB.DateofBirth, VB.Gender, VB.Address, VB.UserId))
                {
                    MessageBox.Show("Employee Add succesfully");
                    Updateemployeelist();
                }
                else
                {
                    MessageBox.Show("Employee not Added");
                }
            }

        }

        private void EmployeeInformation_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
