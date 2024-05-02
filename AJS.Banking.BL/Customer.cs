using AJS.Banking.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public Customer() { }
        
        public Customer(DataRow row)
        {
            CustomerID = Convert.ToInt32(row["CustomerID"])!;
            SSN = Convert.ToString(row["SSN"])!;
            FirstName = Convert.ToString(row["FirstName"])!;
            LastName = Convert.ToString(row["LastName"])!;
            BirthDate = Convert.ToDateTime(row["DOB"])!;
        }

        public void InsertIntoDB()
        {
            string sql = "INSERT INTO tblCustomers VALUES(@id, @SSN, @firstName, @lastName, @DOB); SELECT SCOPE_IDENTITY();";
            DataAccess.RunSql(sql, GetSqlParameters());
        }

        public void UpdateDB()
        {
            string sql = "UPDATE tblCustomers SET SSN = @SSN, FirstName = @firstName, LastName = @lastName, DOB = @DOB WHERE CustomerID = @id";
            DataAccess.RunSql(sql, GetSqlParameters());
        }

        public void DeleteFromDB()
        {
            string sql = "DELETE FROM tblCustomers WHERE CustomerID = @id";
            DataAccess.RunSql(sql, GetSqlParameters());
        }

        public List<SqlParameter> GetSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", CustomerID));
            parameters.Add(new SqlParameter("@SSN", SSN));
            parameters.Add(new SqlParameter("@firstName", FirstName));
            parameters.Add(new SqlParameter("@lastName", LastName));
            parameters.Add(new SqlParameter("@DOB", BirthDate));

            return parameters;
        }

        public void LoadDepositsFromDB()
        {
            string sql = "SELECT * FROM tblTransactions WHERE CustomerID = @id AND TransactionAmount > 0";
            DataTable table = DataAccess.RunSelect(sql, GetSqlParameters());

            DepositList.Clear();
            foreach (DataRow row in table.Rows)
            {
                DepositList.Add(new Deposit(row));
            }
        }

        public void LoadWithdrawalsFromDB()
        {
            string sql = "SELECT * FROM tblTransactions WHERE CustomerID = @id AND TransactionAmount < 0";
            DataTable table = DataAccess.RunSelect(sql, GetSqlParameters());

            WithdrawalList.Clear();
            foreach (DataRow row in table.Rows)
            {
                WithdrawalList.Add(new Withdrawal(row));
            }
        }
    }


}
