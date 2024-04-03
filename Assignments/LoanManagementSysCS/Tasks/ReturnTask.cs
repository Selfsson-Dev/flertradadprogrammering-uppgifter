using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using LoanManagementSys.Managers;

namespace LoanManagementSys.Tasks
{
    //This task simulates the return of a loaned item at random times, reflecting the
    //loan period.The return task can select to process a return after a randomly selected amount
    //of time, such as between 3 and 15 seconds.The item to be returned is also selected
    //randomly from the list of LoanItems.
    //Once selected, the LoanItem's product is added back to the list of products before removing
    //the loan item from the loan item list. The member is not re-added to the member list since
    //it was not removed when the loan item was created, thus maintaining a constant member
    //list throughout runtime.

    public class ReturnTask
    {
        private LoanSystemManager loanSystemManager;
        private Random random;

        public bool IsRunning { get; set; } = true;


        public ReturnTask(LoanSystemManager loanSystemManager) 
        {
            this.loanSystemManager = loanSystemManager;
            random = new Random();
        }

        public void ReturnRandomLoanedItem()
        {
            var loanItem = loanSystemManager.LoanItemManager.GetRandom(loanSystemManager.LoanItemManager.LoanedItemList);

            loanSystemManager.ProductManager.Add(loanItem.Product, loanSystemManager.ProductManager.productsList);
            loanSystemManager.LoanItemManager.Remove(loanItem, loanSystemManager.LoanItemManager.LoanedItemList);

            loanSystemManager.UpdateEventLogs($"{loanItem.Product.ToString()} returned by {loanItem.Member.ToString()}");
        }

        public void Run()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                if (IsRunning)
                {
                    if (!loanSystemManager.LoanItemManager.NoItemsLoaned())
                    {
                        ReturnRandomLoanedItem();
                    }
                    Thread.Sleep(random.Next(3000, 15001));
                }
                else
                {
                    Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId} is waiting for work");
                    Thread.Sleep(150);
                }
            }
        }
    }
}