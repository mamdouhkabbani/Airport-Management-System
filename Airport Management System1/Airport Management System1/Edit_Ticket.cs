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
    public partial class Edit_Ticket : Form
    {
        public Edit_Ticket()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int idofticket = int.Parse(txt_ticket_id.Text);
            Tickt t = manager.TicktManager.GetTicktInfo(idofticket);
            if (t != null)
            {
                
                cBoxType.Text = t.type;
                txtPrice.Text = t.price.ToString();
                chBoxAvailble.Checked = t.available;
         
            }
            else
            {
                MessageBox.Show("There is not tickt with this id");
            }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idOfticket = int.Parse(txt_ticket_id.Text);
            manager.TicktManager.editticktinfo(idOfticket,cBoxType.Text
            ,chBoxAvailble.Checked, Convert.ToInt32( txtPrice.Text));
            MessageBox.Show("Edit Done Successfully");
        }
    }
}
