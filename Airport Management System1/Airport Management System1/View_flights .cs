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
    public partial class View_flights : Form
    {
        public View_flights()
        {
            InitializeComponent();
        }

        private void View_flights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airplainDBDataSet4.flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.airplainDBDataSet4.flight);

        }
    }
}
