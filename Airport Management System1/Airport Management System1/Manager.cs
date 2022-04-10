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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        User u;

        public Manager(User u)
        {
            InitializeComponent();
            this.u = u;

            label1.Text = "welcom Manager: " + u.username;

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_a_new_airplane a = new Add_a_new_airplane();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create_a_new_flight c = new Create_a_new_flight();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View_flights f = new View_flights();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_tickets_on_board_of_a_flight vt = new View_tickets_on_board_of_a_flight();
            vt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search_for_a_flight_using_it_s_number sft = new Search_for_a_flight_using_it_s_number();
            sft.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Edit_flight_details ef = new Edit_flight_details();
            ef.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Find_monthly_income fm = new Find_monthly_income();
            fm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            government g = new government();
            g.Show();
        }
    }
}
