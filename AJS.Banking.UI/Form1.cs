using AJS.Banking.BL;
using AJS.Banking.PL;


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

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblDisplayedID.Text = customers.GetNextID(1).ToString();
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSSN.Text = "";
            txtDOB.Text = "";
            lblDisplayedAge.Text = "";
            lstbxCustomers.SelectedItem = null;
            dgvDeposits.DataSource = null;
            dgvWithdrawals.DataSource= null;
            


            //customer.FirstName = txtFirstName.Text.Trim();
            //customer.LastName = txtLastName.Text.Trim();
            //customer.SSN= txtSSN.Text.Trim();
            //customer.BirthDate = DateTime.Parse(txtDOB.Text.Trim());

            //customers.Add(customer);
            //lstbxCustomers.DataSource = null;
            //lstbxCustomers.DataSource = customers;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataAccess.SaveToXML(typeof(CustomerCollection), customers);
        }
    }
}