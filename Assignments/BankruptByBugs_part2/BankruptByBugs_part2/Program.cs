namespace BankruptByBugs_part2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            Account account2 = new Account();

            AccountNoDeadlock account1NoDeadlock = new AccountNoDeadlock();
            AccountNoDeadlock account2NoDeadlock = new AccountNoDeadlock();

            account1.Operating = true;
            account2.Operating = true;

            account1NoDeadlock.Operating = true;
            account2NoDeadlock.Operating = true;

            //Threads with deadlock
            //// Thread for transferring money from account1 to account2
            //Thread t1 = new Thread(() => account1.Transfer(account2, 500));
            //// Thread for transferring money from account2 to account1
            //Thread t2 = new Thread(() => account2.Transfer(account1, 300));

            // Threads with no deadlock
            // Thread for transferring money from account1 to account2
            Thread t1 = new Thread(() => account1NoDeadlock.Transfer(account2, 500));
            // Thread for transferring money from account2 to account1
            Thread t2 = new Thread(() => account2NoDeadlock.Transfer(account1, 300));

            t1.Name = "Account 1 thread";
            t2.Name = "Account 2 thread";

            t1.Start();
            t2.Start();
        }
    }
}
