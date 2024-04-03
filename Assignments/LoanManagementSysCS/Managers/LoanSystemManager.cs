
using LoanManagementSys.Tasks;

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

        private Thread? loanThread;
        private Thread? returnThread;
        private Thread? adminThread;
        private Thread? guiThread;

        public LoanSystemManager(ListBox listItems, ListBox listOutput)
        {
            this.listItems = listItems;
            this.listOutput = listOutput;

            CreateTasks();
        }

        private void CreateTasks()
        {
            adminTask = new(this);
            loanTask = new(this);
            returnTask = new(this);
            updateGUI = new(this);
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
        private void CreateThreads()
        {
            adminThread = new Thread(adminTask.Run);
            loanThread = new Thread(loanTask.Run);
            returnThread = new Thread(returnTask.Run);
            guiThread = new Thread(updateGUI.Run);
        }

        private void StartThreads()
        {
            adminThread.Start();
            loanThread.Start();
            returnThread.Start();
            guiThread.Start();
        }

        public void Start()
        {
            if ((loanThread != null) && (returnThread != null) && (adminThread != null) && (guiThread != null))
            {
                if (loanThread.IsAlive && adminThread.IsAlive && returnThread.IsAlive && guiThread.IsAlive)
                {
                    adminTask.IsRunning = true;
                    loanTask.IsRunning = true;
                    returnTask.IsRunning = true;
                    updateGUI.IsRunning = true;
                    return;
                }
            }

            CreateTasks();
            CreateThreads();
            StartThreads();
        }

        // stop all tasks
        public void Stop()
        {
            try
            {
                adminTask.IsRunning = false;
                loanTask.IsRunning = false;
                returnTask.IsRunning = false;
                updateGUI.IsRunning = false;
            }
            finally
            {
                loanThread = null;
                returnThread = null;
                guiThread = null;
                adminThread = null;
            }
        }
    }
}