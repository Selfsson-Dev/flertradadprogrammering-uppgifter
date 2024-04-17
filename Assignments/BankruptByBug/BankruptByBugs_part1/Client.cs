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
        public int id;
        private BankAccount bankAccount;

        public double clientTotalAmountTransactioned;

        private Random rand = new Random();

        public bool operating = true;
        public bool useLock;

        private object lockObject = new();

        private Controller controller;

        public Client(BankAccount bankAccount, int id, Controller controller) 
        {
            this.bankAccount = bankAccount;
            this.id = id;
            this.controller = controller;
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
                Thread.Sleep(10);
            }

            controller.UpdateEventLogs($"Client: {id} is done.");
        }

        private void Transaction(double amount)
        {
            if (rand.NextDouble() >= 0.5)
            {
                bankAccount.Deposit(amount, id);
                clientTotalAmountTransactioned += amount;
                controller.UpdateEventLogs($"Client: {id} deposited {amount}");
            }
            else
            {
                bankAccount.Withdaw(amount, id);
                clientTotalAmountTransactioned -= amount;
                controller.UpdateEventLogs($"Client: {id} withdrew {amount}");
            }
        }
    }
}