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
    public partial class Edit_flight_details : Form
    {
        private TextBox txt_flight_number;
        private Button button1;
        private Button button2;
        private DateTimePicker DtDeparture;
        private DateTimePicker DtArrival;
        private Label label7;
        private TextBox txtairplainId;
        private ComboBox cboxdestination;
        private ComboBox cboxsource;
        private TextBox txtCapacity;
        private Label label2;
        private TextBox txtduration;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label1;

        public Edit_flight_details()
        {
            InitializeComponent();
            cboxsource.DataSource = manager.TicktManager.GetAvailableCity();
            cboxdestination.DataSource = manager.TicktManager.GetAvailableCity();
            cboxdestination.DisplayMember = "Name";
            cboxdestination.ValueMember = "Id";
            cboxsource.DisplayMember = "Name";
            cboxsource.ValueMember = "Id";
        }

        private void InitializeComponent()
        {
            this.txt_flight_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DtDeparture = new System.Windows.Forms.DateTimePicker();
            this.DtArrival = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtairplainId = new System.Windows.Forms.TextBox();
            this.cboxdestination = new System.Windows.Forms.ComboBox();
            this.cboxsource = new System.Windows.Forms.ComboBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_flight_number
            // 
            this.txt_flight_number.Location = new System.Drawing.Point(439, 37);
            this.txt_flight_number.Name = "txt_flight_number";
            this.txt_flight_number.Size = new System.Drawing.Size(100, 20);
            this.txt_flight_number.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = " flight number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(684, 57);
            this.button2.TabIndex = 26;
            this.button2.Text = "edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DtDeparture
            // 
            this.DtDeparture.Location = new System.Drawing.Point(98, 135);
            this.DtDeparture.Name = "DtDeparture";
            this.DtDeparture.Size = new System.Drawing.Size(200, 20);
            this.DtDeparture.TabIndex = 40;
            // 
            // DtArrival
            // 
            this.DtArrival.Location = new System.Drawing.Point(98, 174);
            this.DtArrival.Name = "DtArrival";
            this.DtArrival.Size = new System.Drawing.Size(200, 20);
            this.DtArrival.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "airplain Id";
            // 
            // txtairplainId
            // 
            this.txtairplainId.Location = new System.Drawing.Point(98, 262);
            this.txtairplainId.Name = "txtairplainId";
            this.txtairplainId.Size = new System.Drawing.Size(197, 20);
            this.txtairplainId.TabIndex = 37;
            // 
            // cboxdestination
            // 
            this.cboxdestination.FormattingEnabled = true;
            this.cboxdestination.Location = new System.Drawing.Point(98, 104);
            this.cboxdestination.Name = "cboxdestination";
            this.cboxdestination.Size = new System.Drawing.Size(197, 21);
            this.cboxdestination.TabIndex = 35;
            // 
            // cboxsource
            // 
            this.cboxsource.FormattingEnabled = true;
            this.cboxsource.Location = new System.Drawing.Point(98, 67);
            this.cboxsource.Name = "cboxsource";
            this.cboxsource.Size = new System.Drawing.Size(197, 21);
            this.cboxsource.TabIndex = 36;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(98, 232);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(197, 20);
            this.txtCapacity.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Capacity";
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(98, 204);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(197, 20);
            this.txtduration.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = " duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = " arrival date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = " departure date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "destination ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = " source";
            // 
            // Edit_flight_details
            // 
            this.ClientSize = new System.Drawing.Size(684, 356);
            this.Controls.Add(this.DtDeparture);
            this.Controls.Add(this.DtArrival);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtairplainId);
            this.Controls.Add(this.cboxdestination);
            this.Controls.Add(this.cboxsource);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtduration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_flight_number);
            this.Controls.Add(this.label1);
            this.Name = "Edit_flight_details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int source = int.Parse(cboxsource.SelectedValue.ToString());
            int destination = int.Parse(cboxdestination.SelectedValue.ToString());
            int idofflight = int.Parse(txt_flight_number.Text);
            flight f = manager.Create_a_new_flight.getflightinfo(idofflight);
            if (f !=null)
            {
                source = f.FromCity.Value ;
                destination = f.ToCity.Value;
                DtDeparture.Value = f.DepartureDate;
                DtArrival.Value = f.ArriveDate;
                txtduration.Text = f.time.ToString();
                txtCapacity.Text = f.Capacity.ToString();
                txtairplainId.Text = f.AirPlainId.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int source = int.Parse(cboxsource.SelectedValue.ToString());
            int destination = int.Parse(cboxdestination.SelectedValue.ToString());
            int idOflight = int.Parse(txt_flight_number.Text);
            manager.Create_a_new_flight.editflight(idOflight,source,destination ,DtDeparture.Value,
                DtArrival.Value,float.Parse(txtduration.Text),int.Parse(txtairplainId.Text));
            MessageBox.Show("Edit Done Successfully");
        }
    }
}
