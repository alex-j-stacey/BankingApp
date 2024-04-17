using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.Banking.BL
{
    public class Deposit
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public Deposit(int ID, double Amount, DateTime Date)
        {
            this.ID = ID;
            this.Amount = Amount;
            this.Date = Date;
        }

        public Deposit() { }
    }
}
