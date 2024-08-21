namespace Assignment2
{
    partial class FormInvoice
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
            label1 = new Label();
            lblCustomerName = new Label();
            lblLastMonthElectricityMeter = new Label();
            lblThisMonthElectricityMeter = new Label();
            lblConsumption = new Label();
            lblElectricityMoney = new Label();
            btnPay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(258, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 54);
            label1.TabIndex = 0;
            label1.Text = "Electricity Invoice";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(281, 113);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(50, 20);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "label2";
            // 
            // lblLastMonthElectricityMeter
            // 
            lblLastMonthElectricityMeter.AutoSize = true;
            lblLastMonthElectricityMeter.Location = new Point(281, 148);
            lblLastMonthElectricityMeter.Name = "lblLastMonthElectricityMeter";
            lblLastMonthElectricityMeter.Size = new Size(50, 20);
            lblLastMonthElectricityMeter.TabIndex = 2;
            lblLastMonthElectricityMeter.Text = "label2";
            // 
            // lblThisMonthElectricityMeter
            // 
            lblThisMonthElectricityMeter.AutoSize = true;
            lblThisMonthElectricityMeter.Location = new Point(281, 181);
            lblThisMonthElectricityMeter.Name = "lblThisMonthElectricityMeter";
            lblThisMonthElectricityMeter.Size = new Size(50, 20);
            lblThisMonthElectricityMeter.TabIndex = 3;
            lblThisMonthElectricityMeter.Text = "label2";
            // 
            // lblConsumption
            // 
            lblConsumption.AutoSize = true;
            lblConsumption.Location = new Point(281, 218);
            lblConsumption.Name = "lblConsumption";
            lblConsumption.Size = new Size(50, 20);
            lblConsumption.TabIndex = 4;
            lblConsumption.Text = "label2";
            // 
            // lblElectricityMoney
            // 
            lblElectricityMoney.AutoSize = true;
            lblElectricityMoney.Location = new Point(281, 253);
            lblElectricityMoney.Name = "lblElectricityMoney";
            lblElectricityMoney.Size = new Size(50, 20);
            lblElectricityMoney.TabIndex = 5;
            lblElectricityMoney.Text = "label2";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(349, 308);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 29);
            btnPay.TabIndex = 6;
            btnPay.Text = "Payment";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPay);
            Controls.Add(lblElectricityMoney);
            Controls.Add(lblConsumption);
            Controls.Add(lblThisMonthElectricityMeter);
            Controls.Add(lblLastMonthElectricityMeter);
            Controls.Add(lblCustomerName);
            Controls.Add(label1);
            Name = "FormInvoice";
            Text = "FormInvoice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCustomerName;
        private Label lblLastMonthElectricityMeter;
        private Label lblThisMonthElectricityMeter;
        private Label lblConsumption;
        private Label lblElectricityMoney;
        private Button btnPay;
    }
}