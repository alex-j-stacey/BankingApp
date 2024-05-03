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

            // OLD METHOD
            // fills CustomerCollection with data from the CustomerCollection class
            // customers.Populate();
            // loads xml from specified filepath in CustomerCollection

            // loads customer data from Customer DB
            try
            {
                //customers = (DataAccess.LoadFromXML(typeof(CustomerCollection))
                    //as CustomerCollection)!;
                customers.LoadFromDB();
                lstbxCustomers.DataSource = customers;


            }
            catch (Exception ex)
            {
                // MessageBox.Show("There was an error loading the customers.xml: " + ex.Message);
                // populates Collection with junk data if DB doesn't exist
                customers.Populate();
            }

            // sets datasource of listbox to data from CustomerCollection and the datasource for gridviews to selected customer's DepositList and WithdrawalList
            //lstbxCustomers.DataSource = customers;

            /* OLD METHOD
            Customer? customer = lstbxCustomers.SelectedItem as Customer;
            dgvDeposits.DataSource = customer.DepositList;
            dgvDeposits.Columns["Amount"].DefaultCellStyle.Format = "c";
            dgvWithdrawals.DataSource = customer.WithdrawalList;
            dgvWithdrawals.Columns["Amount"].DefaultCellStyle.Format= "c";
            */

        }

        private void lstbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // populates deposits and withdrawl DGV data with data from transaction DB
            Customer? customer = lstbxCustomers.SelectedItem as Customer;
            if (customer != null) 
            {
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtSSN.Text = customer.SSN;
                txtDOB.Text = customer.BirthDate.ToString("MM/dd/yyyy");
                lblDisplayedID.Text = customer.CustomerID.ToString();
                lblDisplayedAge.Text = customer.Age.ToString();

                customer.LoadDepositsFromDB();
                dgvDeposits.DataSource = customer.DepositList;
                dgvDeposits.Columns["Amount"].DefaultCellStyle.Format = "c";
                customer.LoadWithdrawalsFromDB();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (lstbxCustomers.SelectedItem == null)
            {
                // creates new customer to be inserted into customer DB
                Customer? customer = new Customer();
                customer.CustomerID = Convert.ToInt32(lblDisplayedID.Text);
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.SSN = txtSSN.Text;
                customer.BirthDate = Convert.ToDateTime(txtDOB.Text);
                customer.InsertIntoDB();
                lstbxCustomers.DataSource = null;
                customers.Clear();
                customers.LoadFromDB();
                lstbxCustomers.DataSource = customers;
            }
            else
            {
                // updates customer DB with changed customer data
                Customer? customer = lstbxCustomers.SelectedItem as Customer;
                customer.CustomerID = Convert.ToInt32(lblDisplayedID.Text);
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.SSN = txtSSN.Text;
                customer.BirthDate = Convert.ToDateTime(txtDOB.Text);
                customer.UpdateDB();
                lstbxCustomers.DataSource = null;
                customers.Clear();
                customers.LoadFromDB();
                lstbxCustomers.DataSource = customers;
            }


            /* OLD METHOD
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
            */
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult yes = DialogResult.Yes;

            // deletes customer and resets form fields
            if (MessageBox.Show("Are you sure?", "Delete Customer", btns) == yes)
            {
                try
                {
                    Customer? customer = lstbxCustomers.SelectedItem as Customer;
                    customer.CustomerID = Convert.ToInt32(lblDisplayedID.Text);
                    customer.FirstName = txtFirstName.Text;
                    customer.LastName = txtLastName.Text;
                    customer.SSN = txtSSN.Text;
                    customer.BirthDate = Convert.ToDateTime(txtDOB.Text);
                    customer.DeleteFromDB();                
                    customers.Clear();
                    lstbxCustomers.DataSource = null;
                    customers.LoadFromDB();
                    lstbxCustomers.DataSource = customers;
                    lblDisplayedID.Text = ""; txtFirstName.Text = ""; txtLastName.Text = ""; txtSSN.Text = ""; txtDOB.Text = ""; lblDisplayedAge.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You must select a customer to delete them: ");
                }

                /* OLD METHOD
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
                */
            }
        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            DataAccess.SaveToXML(typeof(CustomerCollection), customers);
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            // loads xml from specified filepath in CustomerCollection
            try
            {
                customers = (DataAccess.LoadFromXML(typeof(CustomerCollection))
                    as CustomerCollection)!;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error loading the customers.xml: " + ex.Message);
            }
            lstbxCustomers.DataSource = null;
            lstbxCustomers.DataSource = customers;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataAccess.SaveToXML(typeof(CustomerCollection), customers);

        }
    }
}