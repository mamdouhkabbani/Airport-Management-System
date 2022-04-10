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
    public partial class View_tickets_on_board_of_a_flight : Form
    {
        public View_tickets_on_board_of_a_flight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f_id = int.Parse(txtFlight.Text);
            try
            {
                var myVar =  manager.Create_a_new_flight.ViewTicktOFFlight(f_id).Select(d => new
                {
                    id = d.Id,
                    Available = d.available,
                    Price = d.price
                });

                this.dataGridView1.DataSource = myVar.ToList() ;
            }
            catch
            {

            }
        }
    }
}
