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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }
        User u;

        public employees(User u)
        {
            InitializeComponent();
            this.u = u;

            label1.Text = "welcom employee: " + u.username;

        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateCustomerAccount ca = new CreateCustomerAccount();
            ca.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCustomerAccount ec = new EditCustomerAccount();
            ec.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTicket bt = new AddTicket();
            bt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edit_Ticket et = new Edit_Ticket();
            et.Show();
        }

        private void btnBookTickt_Click(object sender, EventArgs e)
        {
            BookTickt b = new BookTickt();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cancel_Ticket ct = new cancel_Ticket();
            ct.Show();
        }
    }
}
