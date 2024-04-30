using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.Banking.BL
{
    public class Customer : Person
    {
        public int CustomerID { get; set; }
        public Deposit? LastDeposit { get; set; }
        public Withdrawal? LastWithdrawal { get; set; }
        public List<Deposit> DepositList { get;set; } = new List<Deposit>();
        public List<Withdrawal> WithdrawalList { get;set;} = new List<Withdrawal>();

        public Customer(DataRow row)
        {
            CustomerID = Convert.ToInt32(row["CustomerID"])!;
            SSN = Convert.ToString(row["SSN"])!;
            FirstName = Convert.ToString(row["FirstName"])!;
            LastName = Convert.ToString(row["LastName"])!;
            BirthDate = Convert.ToDateTime(row["DOB"])!;
        }

        public Customer() { }
    }


}
