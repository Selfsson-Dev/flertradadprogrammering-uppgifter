using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankruptByBugs_part1
{
    public class Client
    {
        private int id;
        private BankAccount bankAccount;

        private double totalAmountTransactioned;

        private Random rand;

        public bool operating;
        public bool useLock;

        private object lockObject;

        public Client(BankAccount bankAccount) 
        {
            this.bankAccount = bankAccount;
            rand= new Random(); 
        }

        public void Run()
        {
            while (operating)
            {
                double amount = rand.NextDouble() * rand.Next(10000);

                if (useLock)
                {
                    lock (lockObject)
                    {
                        Transaction(amount);
                    }
                }
                else
                {
                    Transaction(amount);
                }
            }
        }

        private void Transaction(double amount)
        {
            if (rand.NextDouble() >= 0.5)
            {
                bankAccount.Deposit(amount, id);
                totalAmountTransactioned += amount;
            }
            else
            {
                bankAccount.Withdaw(amount, id);
                totalAmountTransactioned -= amount;
            }
        }
    }
}