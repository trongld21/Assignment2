using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class FormInvoice : Form
    {
        private Invoice invoice;

        public FormInvoice(Invoice invoice)
        {
            InitializeComponent();
            this.invoice = invoice;
            DisplayInvoiceDetails();
        }

        private void DisplayInvoiceDetails()
        {
            lblCustomerName.Text = $"Customer Name: {invoice.CustomerName}";
            lblLastMonthElectricityMeter.Text = $"Last Month's Electricity Meter: {invoice.LastMonthElectricityMeter}";
            lblThisMonthElectricityMeter.Text = $"This Month's Electricity Meter: {invoice.ThisMonthElectricityMeter}";
            lblConsumption.Text = $"Amount Of Consumption: {invoice.Consumption}";
            lblElectricityMoney.Text = $"Total Electricity Bill: {invoice.ElectricityMoney.ToString("N2")}";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment processed successfully!");
        }
    }
}
