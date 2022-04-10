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
    public partial class Find_monthly_income : Form
    {
        public Find_monthly_income()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Find_monthly_income_Load(object sender, EventArgs e)
        {
            var res = manager.TicktManager.GetReservation().Select(data => new
            {
                Id = data.id,
                flight_ID = data.flightId,
                Tickt_Id = data.ticketId,
                Customer_Id = data.CustomerId
            });
            dataGridView1.DataSource = res.ToList();

            lblMonthlyIncom.Text = string.Format("{0:c}", manager.TicktManager.GetMonthlyIncom());
        }
    }
}
