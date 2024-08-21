namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomerName = new TextBox();
            lbCustomerName = new Label();
            groupBox1 = new GroupBox();
            txtNumberOfMember = new TextBox();
            lbNumberOfMember = new Label();
            btnResetForm = new Button();
            btnCalculate = new Button();
            txtThisMonthElectricityMeter = new TextBox();
            lbThisMonthWaterMeter = new Label();
            txtLastMonthElectricityMeter = new TextBox();
            lbLastMonthWaterMeter = new Label();
            lbTypeOfCustomer = new Label();
            cbTypeOfCustomer = new ComboBox();
            lvInvoice = new ListView();
            txtSearch = new TextBox();
            lbSearch = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(45, 62);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Enter customer name";
            txtCustomerName.Size = new Size(312, 27);
            txtCustomerName.TabIndex = 0;
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(45, 39);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(119, 20);
            lbCustomerName.TabIndex = 1;
            lbCustomerName.Text = "Customer Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumberOfMember);
            groupBox1.Controls.Add(lbNumberOfMember);
            groupBox1.Controls.Add(btnResetForm);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(txtThisMonthElectricityMeter);
            groupBox1.Controls.Add(lbThisMonthWaterMeter);
            groupBox1.Controls.Add(txtLastMonthElectricityMeter);
            groupBox1.Controls.Add(lbLastMonthWaterMeter);
            groupBox1.Controls.Add(lbTypeOfCustomer);
            groupBox1.Controls.Add(cbTypeOfCustomer);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(lbCustomerName);
            groupBox1.Location = new Point(48, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 446);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "CalculatorForm";
            // 
            // txtNumberOfMember
            // 
            txtNumberOfMember.Enabled = false;
            txtNumberOfMember.Location = new Point(45, 200);
            txtNumberOfMember.Name = "txtNumberOfMember";
            txtNumberOfMember.PlaceholderText = "Enter number of member";
            txtNumberOfMember.Size = new Size(312, 27);
            txtNumberOfMember.TabIndex = 10;
            // 
            // lbNumberOfMember
            // 
            lbNumberOfMember.AutoSize = true;
            lbNumberOfMember.Location = new Point(45, 177);
            lbNumberOfMember.Name = "lbNumberOfMember";
            lbNumberOfMember.Size = new Size(135, 20);
            lbNumberOfMember.TabIndex = 11;
            lbNumberOfMember.Text = "Number of people:";
            // 
            // btnResetForm
            // 
            btnResetForm.Location = new Point(45, 399);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(94, 29);
            btnResetForm.TabIndex = 9;
            btnResetForm.Text = "Clear";
            btnResetForm.UseVisualStyleBackColor = true;
            btnResetForm.Click += ClearTextBoxes;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(263, 399);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += onClickCalculator;
            // 
            // txtThisMonthElectricityMeter
            // 
            txtThisMonthElectricityMeter.Location = new Point(45, 346);
            txtThisMonthElectricityMeter.Name = "txtThisMonthElectricityMeter";
            txtThisMonthElectricityMeter.PlaceholderText = "Enter this month’s electricity meter";
            txtThisMonthElectricityMeter.Size = new Size(312, 27);
            txtThisMonthElectricityMeter.TabIndex = 6;
            // 
            // lbThisMonthWaterMeter
            // 
            lbThisMonthWaterMeter.AutoSize = true;
            lbThisMonthWaterMeter.Location = new Point(45, 323);
            lbThisMonthWaterMeter.Name = "lbThisMonthWaterMeter";
            lbThisMonthWaterMeter.Size = new Size(205, 20);
            lbThisMonthWaterMeter.TabIndex = 7;
            lbThisMonthWaterMeter.Text = "This month’s electricity meter:";
            // 
            // txtLastMonthElectricityMeter
            // 
            txtLastMonthElectricityMeter.Location = new Point(45, 269);
            txtLastMonthElectricityMeter.Name = "txtLastMonthElectricityMeter";
            txtLastMonthElectricityMeter.PlaceholderText = "Enter last month’s electricity meter";
            txtLastMonthElectricityMeter.Size = new Size(312, 27);
            txtLastMonthElectricityMeter.TabIndex = 4;
            // 
            // lbLastMonthWaterMeter
            // 
            lbLastMonthWaterMeter.AutoSize = true;
            lbLastMonthWaterMeter.Location = new Point(45, 246);
            lbLastMonthWaterMeter.Name = "lbLastMonthWaterMeter";
            lbLastMonthWaterMeter.Size = new Size(209, 20);
            lbLastMonthWaterMeter.TabIndex = 5;
            lbLastMonthWaterMeter.Text = "Last month’s electricity  meter:";
            // 
            // lbTypeOfCustomer
            // 
            lbTypeOfCustomer.AutoSize = true;
            lbTypeOfCustomer.Location = new Point(45, 107);
            lbTypeOfCustomer.Name = "lbTypeOfCustomer";
            lbTypeOfCustomer.Size = new Size(126, 20);
            lbTypeOfCustomer.TabIndex = 3;
            lbTypeOfCustomer.Text = "Type of customer:";
            // 
            // cbTypeOfCustomer
            // 
            cbTypeOfCustomer.FormattingEnabled = true;
            cbTypeOfCustomer.Location = new Point(45, 130);
            cbTypeOfCustomer.Name = "cbTypeOfCustomer";
            cbTypeOfCustomer.Size = new Size(312, 28);
            cbTypeOfCustomer.TabIndex = 2;
            cbTypeOfCustomer.SelectedIndexChanged += cbTypeOfCustomer_SelectedIndexChanged;
            // 
            // lvInvoice
            // 
            lvInvoice.Location = new Point(457, 67);
            lvInvoice.Name = "lvInvoice";
            lvInvoice.Size = new Size(725, 410);
            lvInvoice.TabIndex = 3;
            lvInvoice.UseCompatibleStateImageBehavior = false;
            lvInvoice.SelectedIndexChanged += showInvoiceForm;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(519, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(251, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += searchElectricityBill;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(457, 37);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(56, 20);
            lbSearch.TabIndex = 5;
            lbSearch.Text = "Search:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 505);
            Controls.Add(lbSearch);
            Controls.Add(txtSearch);
            Controls.Add(lvInvoice);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private Label lbCustomerName;
        private GroupBox groupBox1;
        private Label lbTypeOfCustomer;
        private ComboBox cbTypeOfCustomer;
        private TextBox txtLastMonthElectricityMeter;
        private Label lbLastMonthWaterMeter;
        private TextBox txtThisMonthElectricityMeter;
        private Label lbThisMonthWaterMeter;
        private Button btnCalculate;
        private Button btnResetForm;
        private TextBox txtNumberOfMember;
        private Label lbNumberOfMember;
        private ListView lvInvoice;
        private TextBox txtSearch;
        private Label lbSearch;
    }
}
