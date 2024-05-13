using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptByBugs_part2
{
    public class Account
    {
        public int balance = 1000;

        public bool Operating { get; set; }

        public void Transfer(Account toAccount, int amount) 
        {
            while (Operating)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is in transfer method");
                lock (this)
                {
                    Thread.Sleep(100);
                    lock (toAccount)
                    {
                        toAccount.balance += amount;
                        balance -= amount;
                    }
                }
            }
        }
    }
}