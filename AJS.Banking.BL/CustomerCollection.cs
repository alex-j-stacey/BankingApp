using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.Banking.BL
{
    public class CustomerCollection : List<Customer>
    {
        
        // junk data for testing
        public void Populate()
        {
            Customer customer = new Customer();
            customer.CustomerID = 1;
            customer.SSN = "123-45-6789";
            customer.FirstName = "John";
            customer.LastName = "Doe";
            customer.BirthDate = new DateTime(2000, 1, 1);
            customer.DepositList.Add(new Deposit(1, 100, new DateTime(2000, 2, 2)));
            customer.DepositList.Add(new Deposit(2, 200, new DateTime(2000, 2, 3)));
            customer.DepositList.Add(new Deposit(3, 300, new DateTime(2000, 2, 4)));
            customer.WithdrawalList.Add(new Withdrawal(1, 100, new DateTime(2000, 2, 5)));
            customer.WithdrawalList.Add(new Withdrawal(2, 50, new DateTime(2000, 2, 6)));
            customer.WithdrawalList.Add(new Withdrawal(3, 25, new DateTime(2000, 2, 7)));


            Add(customer);

            Customer customer2 = new Customer();
            customer2.CustomerID = 2;
            customer2.SSN = "345-76-9846";
            customer2.FirstName = "Jack";
            customer2.LastName = "Doe";
            customer2.BirthDate = new DateTime(2005, 6, 12);
            customer2.DepositList.Add(new Deposit(1, 400, new DateTime(2000, 5, 12)));
            customer2.DepositList.Add(new Deposit(2, 500, new DateTime(2000, 5, 13)));
            customer2.DepositList.Add(new Deposit(3, 600, new DateTime(2000, 5, 14)));
            customer2.WithdrawalList.Add(new Withdrawal(1, 100, new DateTime(2000, 5, 15)));
            customer2.WithdrawalList.Add(new Withdrawal(2, 150, new DateTime(2000, 5, 16)));
            customer2.WithdrawalList.Add(new Withdrawal(3, 125, new DateTime(2000, 5, 17)));
            Add(customer2);

            Customer customer3 = new Customer();
            customer3.CustomerID = 3;
            customer3.SSN = "903-82-2349";
            customer3.FirstName = "Jim";
            customer3.LastName = "Doe";
            customer3.BirthDate = new DateTime(1990, 3, 6);
            customer3.DepositList.Add(new Deposit(1, 700, new DateTime(2000, 12, 22)));
            customer3.DepositList.Add(new Deposit(2, 800, new DateTime(2000, 12, 23)));
            customer3.DepositList.Add(new Deposit(3, 900, new DateTime(2000, 12, 24)));
            customer3.WithdrawalList.Add(new Withdrawal(1, 1000, new DateTime(2000, 12, 25)));
            customer3.WithdrawalList.Add(new Withdrawal(2, 500, new DateTime(2000, 12, 26)));
            customer3.WithdrawalList.Add(new Withdrawal(3, 25, new DateTime(2000, 12, 27)));
            Add(customer3);


        }
    }
}
