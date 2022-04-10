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
    public partial class BookTickt : Form
    {
        bool isFirst = true;
        public BookTickt()
        {
            InitializeComponent();
        }

        private void BookTickt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airplainDBDataSet7.Tickt' table. You can move, or remove it, as needed.
            var res = manager.TicktManager.GetAvailbleTickts();
            this.dataGridView2.DataSource = res.Select(data => new
            {
                Id = data.Id,
                type = data.type,
                available = data.available,
                price = data.price
            }).ToList();
            
            cBoxFrom.DataSource = manager.TicktManager.GetAvailableCity();
            cBoxTo.DataSource = manager.TicktManager.GetAvailableCity();
            cBoxFrom.DisplayMember = "Name";
            cBoxFrom.ValueMember = "Id";
            cBoxTo.DisplayMember = "Name";
            cBoxTo.ValueMember = "Id";

            var result  = manager.Create_a_new_flight.GetListOfFlightFromTo(1, 2);
            this.dataGridView1.DataSource = result.Select(data => new
            {
                id = data.id,
                time = data.time,
                From_City = data.FromCity,
                To_City = data.ToCity,
                AirPlainId = data.AirPlainId,
                ArrivalDate = data.ArriveDate,
                DepartualDate = data.DepartureDate,
                Distance =  data.Distance
            }).ToList();

            isFirst = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c_id = int.Parse(txtCustomerID.Text);
            double dist =  manager.TicktManager.CheckDistance(c_id);
            if (dist >= 9000)
            {
                MessageBox.Show("wow you are a golden customer so the price now is:" + manager.TicktManager.MakeDiscount(t_id, 17));
            }
            else if(dist >= 500)
            {
                MessageBox.Show("wow you are a Silver customer so the price now is:" + manager.TicktManager.MakeDiscount(t_id, 10));

            }
            manager.TicktManager.BookATickt(t_id, f_id, c_id);
            MessageBox.Show("Done");
            var res = manager.TicktManager.GetAvailbleTickts();
            this.dataGridView2.DataSource = res.Select(data => new
            {
                Id = data.Id,
                type = data.type,
                available = data.available,
                price = data.price
            }).ToList();
            



        }

        private void cBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                int source = int.Parse(cBoxFrom.SelectedValue.ToString());
                int destionation = int.Parse(cBoxTo.SelectedValue.ToString());
                var res = manager.TicktManager.GetAvailbleTickts();
                this.dataGridView2.DataSource = res.Select(data => new
                {
                    Id = data.Id,
                    type = data.type,
                    available = data.available,
                    price = data.price
                }).ToList();
            }
        }
        int t_id;
        int f_id;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridView d = sender as DataGridView;
            t_id = int.Parse(d.Rows[index].Cells[0].Value.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridView d = sender as DataGridView;
            f_id = int.Parse(d.Rows[index].Cells[0].Value.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
