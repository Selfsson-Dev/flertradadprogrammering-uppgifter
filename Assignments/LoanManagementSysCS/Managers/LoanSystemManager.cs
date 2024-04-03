
using LoanManagementSys.Tasks;
using System.Security.AccessControl;

namespace LoanManagementSys.Managers
{
    public class LoanSystemManager
    {
        public MemberManager MemberManager { get; set; } = new();
        public LoanItemManager LoanItemManager { get; set; } = new();
        public ProductManager ProductManager { get; set; } = new();

        private AdminTask adminTask;
        private LoanTask loanTask;
        private ReturnTask returnTask;
        private UpdateGUI updateGUI;

        private ListBox listItems;
        private ListBox listOutput;

        private List<Thread> threadList = new List<Thread>();

        public LoanSystemManager(ListBox listItems, ListBox listOutput)
        {
            this.listItems = listItems;
            this.listOutput = listOutput;

            adminTask = new(this);
            loanTask = new(this);
            returnTask = new(this);
            updateGUI = new(this);

            CreateThreads();
        }

        // ta bort isrunning
        public void CreateThreads()
        {
            threadList.Add(new Thread(adminTask.Run));
            threadList.Add(new Thread(loanTask.Run));
            threadList.Add(new Thread(returnTask.Run));
            threadList.Add(new Thread(updateGUI.Run));
        }

        /// <summary>
        /// On call update product items listbox in mainForm
        /// </summary>
        public void UpdateAllItems()
        {
            string[] itemArray = GetItemStringArray();
            if (listItems.InvokeRequired)
            {
                listItems.Invoke(new Action(UpdateAllItems));
            }
            else
            {
                listItems.Items.Clear();
                listItems.Items.AddRange(itemArray);
            }
        }

        private string[] GetItemStringArray()
        {
            List<string> itemList = new List<string>();

            DateTime currentTime = DateTime.Now;

            itemList.Add(currentTime.ToString());

            itemList.Add($"Products on loan: {LoanItemManager.LoanedItemList.Count}");

            foreach (var loanedItem in LoanItemManager.LoanedItemList)
            {
                itemList.Add(loanedItem.Product.ToString());
            }
            
            itemList.Add($"Number of products available: {ProductManager.productsList.Count}");

            foreach (var product in ProductManager.productsList)
            {
                itemList.Add(product.ToString());
            }

            return itemList.ToArray();
        }

        public void UpdateEventLogs(string eventMessage)
        {
            if (listOutput.InvokeRequired)
            {
                listOutput.Invoke(new Action<string>(UpdateEventLogs), eventMessage);
            }
            else
            {
                listOutput.Items.Add(eventMessage);
            }
        }

        public void Start()
        {
            adminTask.IsRunning = true;
            loanTask.IsRunning = true;
            returnTask.IsRunning = true;
            updateGUI.IsRunning = true;

            foreach (var thread in threadList)
            {
                try
                {
                    if (!thread.IsAlive)
                    {
                        thread.Start();
                    }
                }
                catch (ThreadStateException e)
                {
                    Console.WriteLine("Caught: {0}", e.Message);
                }
            }
        }

        // pause all tasks
        public void Stop()
        {
            adminTask.IsRunning = false;
            loanTask.IsRunning = false;
            returnTask.IsRunning = false;
            updateGUI.IsRunning = false;
        }
    }
}