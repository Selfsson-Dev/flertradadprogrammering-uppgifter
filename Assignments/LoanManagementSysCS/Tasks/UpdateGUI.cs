using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanManagementSys.Managers;

namespace LoanManagementSys;

public class UpdateGUI
{
    private Random random;
    private LoanSystemManager loanSys;

    public bool IsRunning { get; set; } = true;

    public UpdateGUI(LoanSystemManager loanSys)
    {
        this.loanSys = loanSys;
        random = new Random();
    }

    public void Run()
    {
        while (Thread.CurrentThread.IsAlive)
        {
            if (IsRunning)
            {
                loanSys.UpdateAllItems();
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId} is waiting for work");
                Thread.Sleep(150);
            }
        }
    }
}

