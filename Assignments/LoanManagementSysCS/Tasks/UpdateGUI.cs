using LoanManagementSys.Managers;

namespace LoanManagementSys;

public class UpdateGUI
{
    private LoanSystemManager loanSys;

    public bool IsRunning { get; set; } = true;

    public UpdateGUI(LoanSystemManager loanSys)
    {
        this.loanSys = loanSys;
    }

    public void Run()
    {
        while (IsRunning)
        {
            loanSys.UpdateAllItems();
            Thread.Sleep(2000);
        }
    }
}

