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
    public partial class Create_a_new_flight : Form
    {
        public Create_a_new_flight()
        {
            InitializeComponent();
            cboxsource.DataSource = manager.TicktManager.GetAvailableCity();
            cboxdestination.DataSource = manager.TicktManager.GetAvailableCity();
            cboxdestination.DisplayMember = "Name";
            cboxdestination.ValueMember = "Id";
            cboxsource.DisplayMember = "Name";
            cboxsource.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int source = int.Parse(cboxsource.SelectedValue.ToString());
            int destination = int.Parse(cboxdestination.SelectedValue.ToString());
            DateTime dtAr = DtArrival.Value;
            DateTime dtDp = DtDeparture.Value;
            float duration = float.Parse(txtduration.Text);
            int capacity = int.Parse(txtCapacity.Text);
            int a_ID = int.Parse(txtairplainId.Text);

            manager.Create_a_new_flight.AddFlight(source,destination,dtDp,dtAr,duration,a_ID);

            MessageBox.Show("Done");

        }


        private void Create_a_new_flight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airplainDBDataSet2.flight' table. You can move, or remove it, as needed.

        }


    }
}
