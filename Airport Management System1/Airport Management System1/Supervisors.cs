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
    public partial class Supervisors : Form
    {
        public Supervisors()
        {
            InitializeComponent();
        }
        User u;

        public Supervisors(User u)
        {
            InitializeComponent();
            this.u = u;

            label1.Text = "welcom Supervisors: " + u.username;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            //this.Hide();
            s.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            View_flights v = new View_flights();
            v.Show();

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
    } 
}
