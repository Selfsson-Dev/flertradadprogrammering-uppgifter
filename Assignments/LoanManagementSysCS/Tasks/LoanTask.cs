using LoanManagementSys.Managers;

namespace LoanManagementSys.Tasks
{
    //This task simulates loaning a randomly selected Product to a randomly selected
    //member at random intervals, e.g.ranging from 2 to 6 seconds.These two objects create a
    //loan item, which is then added to the loan item list.
    //
    //The product is subsequently removed from the product list, ensuring it only contains products available for loaning.
    //
    //As a simplification, the product can be added to the end of the list.
    //The member, however, is not removed from the member list, allowing them to loan another product at a later time.
    //
    //task should not proceed when the product list is empty, indicating that all elements are currently on loan.

    public class LoanTask
    {
        private LoanSystemManager loanSystemManager;
        Random random;

        public bool IsRunning { get; set; } = true;


        public LoanTask(LoanSystemManager loanSystemManager)
        {
            this.loanSystemManager = loanSystemManager;
            random = new();
        }

        public void CreateRandomLoan()
        {
            var product = loanSystemManager.ProductManager.GetRandom(loanSystemManager.ProductManager.productsList);
            var member = loanSystemManager.MemberManager.GetRandom(loanSystemManager.MemberManager.membersList);

            LoanItem loanItem = loanSystemManager.LoanItemManager.CreateLoanItem(product, member);
            loanSystemManager.ProductManager.Remove(product, loanSystemManager.ProductManager.productsList);
            loanSystemManager.UpdateEventLogs(loanItem.ToString());
        }

        public void Run()
        {
            while (IsRunning)
            {
                if (!loanSystemManager.ProductManager.NoProductsAvailable())
                {
                    CreateRandomLoan();
                    Thread.Sleep(random.Next(2000, 6001));
                }
            }
        }

    }
}