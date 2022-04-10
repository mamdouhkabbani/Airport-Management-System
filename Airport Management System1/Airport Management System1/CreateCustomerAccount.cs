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
    public partial class CreateCustomerAccount : Form
    {
        public CreateCustomerAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            manager.CutomerManager.Create_customer_account(txtFirstName.Text, txtLastName.Text, txtPassportName.Text, txtNationality.Text,
                txtPhoneNo.Text, txtEmail.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
