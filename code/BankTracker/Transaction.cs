using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Contains the information for an outogoing transaction
namespace BankTracker
{    
    class Transaction
    {
        private DateTime dt;
        private int id;
        private String transType;
        private String payee;
        private double amount;

        public Transaction(DateTime dt, int id,String transType, String payee, double amount)
        {
            this.dt = dt;
            this.id = id;
            this.transType = transType;
            this.payee = payee;
            this.amount = amount;
        }

        public DateTime getDate()
        {
            return dt;
        }

        public String getPayee()
        {
            return payee;
        }

        public double getAmount()
        {
            return amount;
        }
        public String toString()
        {
            return dt.Date.ToShortDateString() + "\n" + payee + "\n$" + amount;
        }
    }
}
