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
    public partial class Add_a_new_airplane : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtbrand;
        private TextBox txtmodel;
        private TextBox txtserial_number;
        private Button button1;
        private DataGridView dataGridView1;
        private AirplainDBDataSet1 airplainDBDataSet1;
        private BindingSource airPlainBindingSource;
        private IContainer components;
        private AirplainDBDataSet1TableAdapters.AirPlainTableAdapter airPlainTableAdapter;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private TextBox txtcapacity;

        public Add_a_new_airplane()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtserial_number = new System.Windows.Forms.TextBox();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.airplainDBDataSet1 = new Airport_Management_System1.AirplainDBDataSet1();
            this.airPlainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airPlainTableAdapter = new Airport_Management_System1.AirplainDBDataSet1TableAdapters.AirPlainTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplainDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPlainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " serial number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "capacity ";
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(147, 12);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(100, 20);
            this.txtbrand.TabIndex = 4;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(147, 48);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(100, 20);
            this.txtmodel.TabIndex = 5;
            // 
            // txtserial_number
            // 
            this.txtserial_number.Location = new System.Drawing.Point(147, 78);
            this.txtserial_number.Name = "txtserial_number";
            this.txtserial_number.Size = new System.Drawing.Size(100, 20);
            this.txtserial_number.TabIndex = 6;
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(147, 115);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(100, 20);
            this.txtcapacity.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = " Add a new airplane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.airPlainBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(427, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // airplainDBDataSet1
            // 
            this.airplainDBDataSet1.DataSetName = "AirplainDBDataSet1";
            this.airplainDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airPlainBindingSource
            // 
            this.airPlainBindingSource.DataMember = "AirPlain";
            this.airPlainBindingSource.DataSource = this.airplainDBDataSet1;
            // 
            // airPlainTableAdapter
            // 
            this.airPlainTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // Add_a_new_airplane
            // 
            this.ClientSize = new System.Drawing.Size(1055, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcapacity);
            this.Controls.Add(this.txtserial_number);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_a_new_airplane";
            this.Load += new System.EventHandler(this.Add_a_new_airplane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplainDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPlainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.Add_a_new_airplane.add_airplane(txtbrand.Text, txtmodel.Text,Convert.ToInt32( txtserial_number.Text),Convert.ToInt32( txtcapacity.Text));
        }

        private void Add_a_new_airplane_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airplainDBDataSet1.AirPlain' table. You can move, or remove it, as needed.
            this.airPlainTableAdapter.Fill(this.airplainDBDataSet1.AirPlain);

        }
    }
}
