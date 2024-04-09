using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptByBugs_part1
{
    public class Controller
    {
        private ListBox events;
        private ListBox output;

        private BankAccount bankAccount;
        private List<Client> clients;

        public Controller(ListBox events, ListBox output)
        {
            this.events = events;
            this.output = output;
            bankAccount = new BankAccount();
        }

        public void StartClients()
        {

        }

        public void Wait()
        {

        }

        public void StopClients()
        {

        }

        public void GatherResults() 
        {
        
        }
    }
}