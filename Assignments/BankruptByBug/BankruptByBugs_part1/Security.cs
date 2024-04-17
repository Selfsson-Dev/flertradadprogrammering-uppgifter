using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptByBugs_part1
{
    public class Security
    {
        private List<Stamp> transactionHistory = new();
        public int numberOfErrors;
        private object transactionLock = new();

        /// <summary>
        /// Creates a transaction record and stores it in the transaction history for a specific client.
        /// 
        /// This method creates a new transaction record (often called a "stamp") that captures the current `balance` 
        /// for the provided `clientId`. The record is then added to the `transactionHistory` list, which likely 
        /// maintains a chronological order of transactions for the client.
        /// </summary>
        /// <param name="balance">The current balance for the client.</param>
        /// <param name="clientId">The unique identifier for the client.</param>


        public void MakePreTransactionStamp(double balance, int clientId)
        {
            lock (transactionLock)
            {
                transactionHistory.Add(new Stamp(balance, clientId));
            }
        }

        /// <summary>
        /// Creates a transaction record and stores it in the transaction history for a specific client.
        /// 
        /// This method creates a new transaction record (often called a "stamp") that captures the current `balance` 
        /// for the provided `clientId`. The record is then added to the `transactionHistory` list, which likely 
        /// maintains a chronological order of transactions for the client.
        /// </summary>
        /// <param name="balance">The current balance for the client.</param>
        /// <param name="clientId">The unique identifier for the client.</param>


        public void MakePostTransactionsStamp(double balance, int clientId) 
        {
            lock (transactionLock)
            {
                transactionHistory.Add(new Stamp(balance, clientId));
            }
        }


        /// <summary>
        /// Validates two transaction stamps for a specific client.
        /// 
        /// This method compares the 'preTransactionStamp' and 'postTransactionStamp' associated with the `clientId`. 
        /// It verifies if the sum of the current balance and `amount` equals the new balance reflected in the `postTransactionStamp`.
        /// If the validation succeeds, no errors are reported (numberoferrors is not incremented).
        /// 
        /// Assumptions:
        ///  - Only two transaction stamps can exist for a given `clientId` at any point.
        ///  - The `preTransactionStamp` represents the account balance before the transaction.
        ///  - The `postTransactionStamp` represents the account balance after the transaction.
        /// </summary>
        /// <param name="amount">The transaction amount.</param>
        /// <param name="clientId">The client identifier.</param>
        public void VerifyLastTransaction(double amount, int clientId)
        {
            lock (transactionLock)
            {
                List<Stamp> matches = transactionHistory.Where(stamp => stamp.clientId == clientId).ToList();

                if ((matches[0].balance += amount) != matches[1].balance)
                {
                    numberOfErrors++;
                }
                
                transactionHistory.RemoveAll(stamp => stamp.clientId == clientId);
            }
        }
    }
}