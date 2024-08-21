using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private List<Invoice> invoices = new List<Invoice>();
        public const double VAT = 0.1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTypeOfCustomer.Items.Add("Household customer");
            cbTypeOfCustomer.Items.Add("Administration agency, public services");
            cbTypeOfCustomer.Items.Add("Production units");
            cbTypeOfCustomer.Items.Add("Business services");

            lvInvoice.View = View.Details;
            lvInvoice.Columns.Add("Customer Name", 150);
            lvInvoice.Columns.Add("Last Month Electricity Meter", 100);
            lvInvoice.Columns.Add("This Month Electricity Meter", 100);
            lvInvoice.Columns.Add("Amount Of Consumption", 100);
            lvInvoice.Columns.Add("Total Electricity Bill", 100);
        }

        private void onClickCalculator(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string typeOfCustomer = cbTypeOfCustomer.Text;
            int numberOfMember = 0;
            double lastMonthElectricityMeter = 0;
            double thisMonthElectricityMeter = 0;

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(typeOfCustomer))
            {
                MessageBox.Show("Please select type of customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (typeOfCustomer.Equals("Household customer"))
            {
                if (!int.TryParse(txtNumberOfMember.Text, out numberOfMember) || numberOfMember <= 0)
                {
                    MessageBox.Show("Number of members must be a positive integer for Household customers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!double.TryParse(txtLastMonthElectricityMeter.Text, out lastMonthElectricityMeter) || lastMonthElectricityMeter < 0)
            {
                MessageBox.Show("Last month electricity meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtThisMonthElectricityMeter.Text, out thisMonthElectricityMeter) || thisMonthElectricityMeter < 0)
            {
                MessageBox.Show("This month electricity meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoice = Calculator(typeOfCustomer, numberOfMember, lastMonthElectricityMeter, thisMonthElectricityMeter);

            DisplayInvoice(customerName, lastMonthElectricityMeter, thisMonthElectricityMeter, invoice.Item1, invoice.Item2);
        }

        private void DisplayInvoice(string customerName, double lastMonthElectricityMeter, double thisMonthElectricityMeter, double consumption, double electricityMoney)
        {
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonthElectricityMeter.ToString());
            item.SubItems.Add(thisMonthElectricityMeter.ToString());
            item.SubItems.Add(consumption.ToString());
            item.SubItems.Add(electricityMoney.ToString("N2"));
            lvInvoice.Items.Add(item);
            Invoice invoice = new Invoice
            {
                CustomerName = customerName,
                LastMonthElectricityMeter = lastMonthElectricityMeter,
                ThisMonthElectricityMeter = thisMonthElectricityMeter,
                Consumption = consumption,
                ElectricityMoney = electricityMoney
            };
            invoices.Add(invoice);
        }

        private void ClearTextBoxes(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtThisMonthElectricityMeter.Text = "";
            txtLastMonthElectricityMeter.Text = "";
            cbTypeOfCustomer.SelectedIndex = -1;
            txtNumberOfMember.Text = "";
        }

        private (double, double) Calculator(string typeOfCustomer, int numberOfMember, double lastMonthElectricityMeter, double thisMonthElectricityMeter)
        {
            double consumption = thisMonthElectricityMeter - lastMonthElectricityMeter;
            double electricityMoney;

            if (typeOfCustomer.Equals("Household customer"))
            {
                double averageElectricityUsed = consumption / numberOfMember;
                electricityMoney = BillElectricityForHouseHold(averageElectricityUsed, consumption);
            }
            else if (typeOfCustomer.Equals("Administration agency, public services"))
            {
                electricityMoney = (consumption * 9955);
                electricityMoney += (electricityMoney * VAT);
            }
            else if (typeOfCustomer.Equals("Production units"))
            {
                electricityMoney = (consumption * 11615);
                electricityMoney += (electricityMoney * VAT);
            }
            else
            {
                electricityMoney = (consumption * 22086);
                electricityMoney += (electricityMoney * VAT);
            }

            return (consumption, electricityMoney);
        }

        private double BillElectricityForHouseHold(double average, double consumption)
        {
            double electricityMoney = 0;
            if (average >= 0 && average < 10)
            {
                electricityMoney = consumption * 5973;
            }
            else if (average >= 10 && average < 20)
            {
                electricityMoney = consumption * 7052;
            }
            else if (average >= 20 && average < 30)
            {
                electricityMoney = consumption * 8699;
            }
            else
            {
                electricityMoney = consumption * 22068;
            }
            return electricityMoney + electricityMoney * VAT;
        }

        private void cbTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeOfCustomer = cbTypeOfCustomer.Text;
            if (typeOfCustomer.Equals("Household customer"))
            {
                txtNumberOfMember.Enabled = true;
            }
            else
            {
                txtNumberOfMember.Enabled = false;
                txtNumberOfMember.Text = "";
            }
        }

        private void searchElectricityBill(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower().Trim();

            lvInvoice.Items.Clear();

            bool foundResult = false;

            if (string.IsNullOrEmpty(searchText))
            {
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthElectricityMeter.ToString());
                    item.SubItems.Add(invoice.ThisMonthElectricityMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.ElectricityMoney.ToString("N2"));
                    lvInvoice.Items.Add(item);
                }
                foundResult = true;
            }
            else
            {
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.CustomerName.ToLower().Contains(searchText))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthElectricityMeter.ToString());
                        item.SubItems.Add(invoice.ThisMonthElectricityMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.ElectricityMoney.ToString("N2"));
                        lvInvoice.Items.Add(item);
                        foundResult = true;
                    }
                }
            }

            if (!foundResult)
            {
                ListViewItem item = new ListViewItem("No results found");
                lvInvoice.Items.Add(item);
            }
        }

        private void showInvoiceForm(object sender, EventArgs e)
        {
            if (lvInvoice.SelectedItems.Count > 0)
            {
                int selectedIndex = lvInvoice.SelectedItems[0].Index;
                if (selectedIndex >= 0 && selectedIndex < invoices.Count)
                {
                    Invoice selectedInvoice = invoices[selectedIndex];
                    OpenInvoiceForm(selectedInvoice);
                }
            }
            else
            {
                MessageBox.Show("Please select an invoice to view details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenInvoiceForm(Invoice invoice)
        {
            FormInvoice formInvoice = new FormInvoice(invoice);
            formInvoice.Show();
        }
    }

    public class Invoice
    {
        public string CustomerName { get; set; }
        public double LastMonthElectricityMeter { get; set; }
        public double ThisMonthElectricityMeter { get; set; }
        public double Consumption { get; set; }
        public double ElectricityMoney { get; set; }
    }
}
