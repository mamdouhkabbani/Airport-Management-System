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
    public partial class AddTicket : Form
    {
        public AddTicket()
        {
            InitializeComponent();
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airplainDBDataSet3.flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.airplainDBDataSet3.flight);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = int.Parse(txtPrice.Text);
            string type = cBoxType.Text;
            if (type == "Buisness")
            {
                price *= 2;
            }

            manager.TicktManager.AddTickt(cBoxType.Text, chBoxAvailble.Checked, price);
            MessageBox.Show("Data Add Successfully");
        }




    }
}
