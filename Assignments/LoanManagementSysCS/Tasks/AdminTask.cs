using LoanManagementSys.Managers;

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
            while (IsRunning)
            {
                CreateNewProduct();
                Thread.Sleep(random.Next(6000, 16001));
            }
        }
    }
}