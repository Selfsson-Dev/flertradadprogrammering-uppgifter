using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankruptByBugs_part1
{
    public class BankAccount
    {
        private double balance;
        private Security security = new();
        private object lockTransaction = new object();
        public bool UseLock { get;  set; }
        private int numberOfTransactions;
    
        public BankAccount() 
        {
        
        }

        public void Withdaw(double amount, int clientId)
        {
            if (UseLock)
            {
                lock (lockTransaction)
                {
                    security.MakePreTransactionStamp(balance, clientId);
                    balance -= amount;
                    numberOfTransactions++;
                    security.MakePostTransactionsStamp(balance, clientId);
                    security.VerifyLastTransaction(-amount, clientId);
                }
            }
            else
            {
                security.MakePreTransactionStamp(balance, clientId);
                balance -= amount;
                numberOfTransactions++;
                security.MakePostTransactionsStamp(balance, clientId);
                security.VerifyLastTransaction(-amount, clientId);
            }
        }

        public void Deposit(double amount, int clientId)
        {
            if (UseLock)
            {
                lock (lockTransaction)
                {
                    security.MakePreTransactionStamp(balance, clientId);
                    balance += amount;
                    numberOfTransactions++;
                    security.MakePostTransactionsStamp(balance, clientId);
                    security.VerifyLastTransaction(amount, clientId);
                }
            }
            else
            {
                security.MakePreTransactionStamp(balance, clientId);
                balance += amount;
                numberOfTransactions++;
                security.MakePostTransactionsStamp(balance, clientId);
                security.VerifyLastTransaction(amount, clientId);
            }
        }
    }
}