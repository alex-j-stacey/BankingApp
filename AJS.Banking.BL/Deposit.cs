using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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

        public Deposit(DataRow row)
        {
            ID = Convert.ToInt32(row["TransactionID"]);
            Amount = Convert.ToDouble(row["TransactionAmount"])!;
            Date = Convert.ToDateTime(row["TransactionDate"]);
          
        }

        public List<SqlParameter> GetSqlParameters(int CustomerID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CustomerID", ID));
            parameters.Add(new SqlParameter("@TransactionAmount", Amount));
            parameters.Add(new SqlParameter("@TransactionDate", Date));

            return parameters;
        }
    }
}
