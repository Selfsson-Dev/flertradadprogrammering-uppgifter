using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptByBugs_part2
{
    public class AccountNoDeadlock
    {
        public int balance = 1000;

        public bool Operating { get; set; }

        private object LockObject1 = new object();
        private object LockObject2 = new object();

        public void Transfer(Account toAccount, int amount)
        {
            while (Operating)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is in transfer method");
                lock (LockObject1)
                {
                    Thread.Sleep(100);
                    lock (LockObject2)
                    {
                        toAccount.balance += amount;
                        balance -= amount;
                    }
                }
            }
        }
    }
}