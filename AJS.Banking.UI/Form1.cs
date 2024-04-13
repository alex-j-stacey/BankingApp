using AJS.Banking.BL;

namespace AJS.Banking.UI
{
    public partial class Form1 : Form
    {
        // creates new CustomerCollection
        private CustomerCollection customers = new CustomerCollection();

        public Form1()
        {
            InitializeComponent();
            // fills CustomerCollection with data from the CustomerCollection class
            customers.Populate();

            // sets datasource of listbox to data from CustomerCollection class and the datasource for gridviews to each customer's DepositList and WithdrawalList
            lstbxCustomers.DataSource = customers;

            Customer? customer = lstbxCustomers.SelectedItem as Customer;
            dgvDeposits.DataSource = customer.DepositList;
            dgvDeposits.Columns["Amount"].DefaultCellStyle.Format = "c";
            dgvWithdrawals.DataSource = customer.WithdrawalList;
            dgvWithdrawals.Columns["Amount"].DefaultCellStyle.Format= "c";

        }

        private void lstbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // populates form data with data from CustomerCollection class when selection changed
            Customer? customer = lstbxCustomers.SelectedItem as Customer;
            if (customer != null) 
            {
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtSSN.Text = customer.SSN;
                txtDOB.Text = customer.BirthDate.ToString("MM/dd/yyyy");
                lblDisplayedID.Text = customer.CustomerID.ToString();
                lblDisplayedAge.Text = customer.Age.ToString();

                dgvDeposits.DataSource = customer.DepositList;
                dgvDeposits.Columns["Amount"].DefaultCellStyle.Format = "c";
                dgvWithdrawals.DataSource = customer.WithdrawalList;
                dgvWithdrawals.Columns["Amount"].DefaultCellStyle.Format = "c";

            }
        }
    }
}