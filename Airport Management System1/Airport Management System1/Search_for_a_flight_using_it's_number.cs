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
    public partial class Search_for_a_flight_using_it_s_number : Form
    {
        public Search_for_a_flight_using_it_s_number()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fl_id = int.Parse(txtfligtid.Text);
            try
            {
                List<flight> myVar =  new List<flight> { manager.Create_a_new_flight.Viewtlight(fl_id) };
                var res = myVar.Select(d =>new 
                {
                    id = d.id,
                    Time=d.time,
                    ArriveDate=d.ArriveDate,
                    DepartureDate= d.DepartureDate,
                    Distance= d.Distance
                });

                this.dataGridView1.DataSource = res.ToList() ;
            }
            catch
            {

            }
        }
    }
}
