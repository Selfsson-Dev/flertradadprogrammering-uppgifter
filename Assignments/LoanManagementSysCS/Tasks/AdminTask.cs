using LoanManagementSys.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LoanManagementSys.Tasks
{
    //This task adds a new test product to the product list at random intervals, e.g.
    //ranging from 6 to 16 seconds.
    public class AdminTask
    {
        private Random random;
        private LoanSystemManager loanSystemManager;

        public bool IsRunning { get; set; } = true;

        public AdminTask(LoanSystemManager loanSystemManager) 
        {
            random = new Random();
            this.loanSystemManager = loanSystemManager;
        }

        private void CreateNewProduct()
        {
            Product product = loanSystemManager.ProductManager.AddNewTestProduct();
            loanSystemManager.UpdateEventLogs($"{product.ToString()} ADDED to the list.");
        }

        public void Run()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                if (IsRunning)
                {
                    CreateNewProduct();
                    Thread.Sleep(random.Next(6000, 16001));
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