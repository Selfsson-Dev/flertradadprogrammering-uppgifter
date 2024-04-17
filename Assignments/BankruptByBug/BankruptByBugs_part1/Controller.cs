using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptByBugs_part1;

public class Controller
{
    private ListBox events;
    private ListBox output;

    private BankAccount bankAccount = new();
    private List<Client> clients = new();

    private List<Thread?> threads = new();

    private double totalAmountTransactioned;

    public Controller(ListBox events, ListBox output)
    {
        this.events = events;
        this.output = output;
        AddClients();
    }

    private void AddClients()
    {
        clients.Clear();

        for (var i = 0; i < 10; i++)
        {
            clients.Add(new Client(bankAccount, i, this));
        }
    }

    private void AddThreads()
    {
        threads.Clear();
        foreach (var client in clients)
        {
            threads.Add(new Thread(client.Run));
        }

        foreach (var thread in threads)
        {
            thread?.Start();
        }
    }

    public void StartClients()
    {
        if (threads.Any(thread => thread != null && thread.IsAlive))
        {
            foreach (var client in clients)
            {
                client.operating = true;
                
            }
            return;
        }

        AddClients();
        AddThreads();
    }

    public void StopClients()
    {
        try
        {
            foreach (var client in clients) client.operating = false;
        }
        finally
        {
            threads.Clear();
            GatherResults();
        }
    }

    public void GatherResults()
    {
        {
            foreach (var client in clients)
            {
                totalAmountTransactioned += client.clientTotalAmountTransactioned;
            }
        }

        var numberOfTransactions = $"Number of transactions: {bankAccount.numberOfTransactions}";

        var numberOfErrors = $"Number of errors: {bankAccount.security.numberOfErrors}";

        var transactionsSum = $"All transactions of clients sums into: {totalAmountTransactioned}, balance on account: {bankAccount.balance}";

        string[] _output = [numberOfTransactions, numberOfErrors, transactionsSum];

        UpdateOutput(_output);
    }

    public void UpdateOutput(string[] _output)
    {
        if (output.InvokeRequired)
        {
            output.Invoke(new Action<string[]>(UpdateOutput), _output);
        }
        else
        {
            output.Items.Clear();
            output.Items.AddRange(_output);
        }
    }

    public void UpdateEventLogs(string eventMessage)
    {
        if (events.InvokeRequired)
        {
            events.Invoke(new Action<string>(UpdateEventLogs), eventMessage);
        }
        else
        {
            events.Items.Add(eventMessage);
        }
    }

    public void UseLock()
    {
        foreach (var client in clients)
        {
            bankAccount.UseLock = !bankAccount.UseLock;
            client.useLock = !client.useLock;
            UpdateEventLogs($"Client: {client.id} will now use lock!");
        }
    }
}