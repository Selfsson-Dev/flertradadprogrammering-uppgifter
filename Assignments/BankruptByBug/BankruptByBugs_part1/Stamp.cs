using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptByBugs_part1
{
    public class Stamp
    {
        public int clientId;
        public double balance;

        public Stamp(double balance, int clientId) 
        {
            this.balance = balance;
            this.clientId = clientId;
        }
    }
}