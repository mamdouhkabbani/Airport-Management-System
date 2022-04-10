using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_Management_System1
{
    public partial class EditCustomerAccount : Form
    {
        public EditCustomerAccount()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int idOfCustomer = int.Parse(txtSearch.Text);
            Customer c = manager.CutomerManager.GetCustomerInfo(idOfCustomer);
            if (c != null)
            {
                txtFirstName.Text = c.first_name;
                txtLastName.Text = c.last_name;
                txtPhoneNo.Text = c.phone_no;
                txtPassportName.Text = c.passport_no;
                txtNationality.Text = c.nationality;
                txtEmail.Text = c.email;
            }
            else
            {
                MessageBox.Show("There is not Customer with this id");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int idOfCustomer = int.Parse(txtSearch.Text);
            manager.CutomerManager.EditCustomerInfo(idOfCustomer,txtFirstName.Text,txtLastName.Text,
                txtPassportName.Text,txtNationality.Text,txtPhoneNo.Text,txtEmail.Text);

            MessageBox.Show("Edit Done Successfully");
        }
    }
}
