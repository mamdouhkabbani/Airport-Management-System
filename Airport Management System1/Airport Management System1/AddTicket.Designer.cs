namespace Airport_Management_System1
{
    partial class AddTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airplainDBDataSet3 = new Airport_Management_System1.AirplainDBDataSet3();
            this.label7 = new System.Windows.Forms.Label();
            this.chBoxAvailble = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flightTableAdapter = new Airport_Management_System1.AirplainDBDataSet3TableAdapters.flightTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplainDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "Buisness",
            "Economy "});
            this.cBoxType.Location = new System.Drawing.Point(92, 45);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(183, 21);
            this.cBoxType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type";
            // 
            // btnBook
            // 
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBook.Location = new System.Drawing.Point(0, 189);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(304, 64);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "Add";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "flight";
            this.flightBindingSource.DataSource = this.airplainDBDataSet3;
            // 
            // airplainDBDataSet3
            // 
            this.airplainDBDataSet3.DataSetName = "AirplainDBDataSet3";
            this.airplainDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Avilable";
            // 
            // chBoxAvailble
            // 
            this.chBoxAvailble.AutoSize = true;
            this.chBoxAvailble.Location = new System.Drawing.Point(109, 156);
            this.chBoxAvailble.Name = "chBoxAvailble";
            this.chBoxAvailble.Size = new System.Drawing.Size(84, 17);
            this.chBoxAvailble.TabIndex = 9;
            this.chBoxAvailble.Text = "is Avilable ? ";
            this.chBoxAvailble.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(92, 89);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(183, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "price";
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 253);
            this.Controls.Add(this.chBoxAvailble);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxType);
            this.Name = "AddTicket";
            this.Text = "BookTicket";
            this.Load += new System.EventHandler(this.BookTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplainDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chBoxAvailble;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private AirplainDBDataSet3 airplainDBDataSet3;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private AirplainDBDataSet3TableAdapters.flightTableAdapter flightTableAdapter;
    }
}