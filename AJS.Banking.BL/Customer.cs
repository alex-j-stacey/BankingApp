using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.Banking.BL
{
    public class Customer : Person
    {
        public int CustomerID { get; set; }
        public Deposit LastDeposit { get; set; }
        public Withdrawal LastWithdrawal { get; set; }
        public List<Deposit> DepositList { get;set; } = new List<Deposit>();
        public List<Withdrawal> WithdrawalList { get;set;} = new List<Withdrawal>();
    }
}
