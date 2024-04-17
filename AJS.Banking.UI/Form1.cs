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
            // customers.Populate();

            // loads xml from specified filepath in CustomerCollection
            try
            {
                customers = (DataAccess.LoadFromXML(typeof(CustomerCollection))
                    as CustomerCollection)!;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error loading the customers.xml: " + ex.Message);
                // populates Collection with junk data if xml doesn't exist
                customers.Populate();
            }

            // sets datasource of listbox to data from CustomerCollection and the datasource for gridviews to selected customer's DepositList and WithdrawalList
            lstbxCustomers.DataSource = customers;

            Customer? customer = lstbxCustomers.SelectedItem as Customer;
            dgvDeposits.DataSource = customer.DepositList;
            dgvDeposits.Columns["Amount"].DefaultCellStyle.Format = "c";
            dgvWithdrawals.DataSource = customer.WithdrawalList;
            dgvWithdrawals.Columns["Amount"].DefaultCellStyle.Format= "c";

        }

        private void lstbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // populates form data with data from selected customer
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
            // gets the lowest unused id possible and lets user fill out form data for new customer
            lblDisplayedID.Text = customers.GetNextID(1).ToString();
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSSN.Text = "";
            txtDOB.Text = "";
            lblDisplayedAge.Text = "";
            lstbxCustomers.SelectedItem = null;
            dgvDeposits.DataSource = null;
            dgvWithdrawals.DataSource= null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // saves CustomerCollection to xml at filepath
            DataAccess.SaveToXML(typeof(CustomerCollection), customers);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // whether or not the form data deals with existing customer in CustomerCollection
            bool isMatchingID = false;

            // checks whether any customer in CustomerCollection has the id listed (ie an existing customer in Collection)
            // if so, sets isMatchingID to true
            try
            {
                foreach (Customer c in customers)
                {
                    if (c.CustomerID == int.Parse(lblDisplayedID.Text))
                    {
                        c.FirstName = txtFirstName.Text.Trim();
                        c.LastName = txtLastName.Text.Trim();
                        c.SSN = txtSSN.Text.Trim();
                        c.BirthDate = DateTime.Parse(txtDOB.Text.Trim());
                        lstbxCustomers.DataSource = null;
                        lstbxCustomers.DataSource = customers;
                        isMatchingID = true;
                    }
                }

                // if no existing customer ids match, add new customer with form data
                if (!isMatchingID)
                {
                    Customer? customer = new Customer();
                    customer.CustomerID = int.Parse(lblDisplayedID.Text);
                    customer.FirstName = txtFirstName.Text.Trim();
                    customer.LastName = txtLastName.Text.Trim();
                    customer.SSN = txtSSN.Text.Trim();
                    customer.BirthDate = DateTime.Parse(txtDOB.Text.Trim());

                    customers.Add(customer);

                    lstbxCustomers.DataSource = null;
                    lstbxCustomers.DataSource = customers;
                }
            } catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult yes = DialogResult.Yes;

            // deletes customer and resets form fields
            if (MessageBox.Show("Are you sure?", "Delete Customer", btns) == yes)
            {
                Customer? customer = lstbxCustomers.SelectedItem as Customer;
                if (customer != null)
                {
                    customers.Remove(customer);
                    dgvDeposits.DataSource = null;
                    dgvWithdrawals.DataSource = null;
                    lstbxCustomers.DataSource = null;
                    lstbxCustomers.DataSource = customers;

                    lblDisplayedID.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtSSN.Text = "";
                    txtDOB.Text = "";
                    lblDisplayedAge.Text = "";
                }
            }
        }
    }
}