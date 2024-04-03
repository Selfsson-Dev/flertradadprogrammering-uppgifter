using LoanManagementSys.Managers;

namespace LoanManagementSys;

public partial class MainForm : Form
{
    private LoanSystemManager loanSystem;

    public MainForm()
    {
        InitializeComponent();
        loanSystem = new LoanSystemManager(lstItems, lstOutput);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        loanSystem.Start();
    }


    private void btnStop_Click(object sender, EventArgs e)
    {
        loanSystem.Stop();
    }

    private void UpdateEventLog(string item, int i)
    {
        if (lstOutput.InvokeRequired)
        {
            lstOutput.Invoke(new Action<string, int>(UpdateEventLog), item, i);
        }
        else
        {
            if (i == 0)
                lstOutput.Items.Clear();

            lstOutput.Items.Add(item);
        }
    }

    private void UpdateProductListBox(string item, int i)
    {
        // Check if we need to call Invoke to marshal the call to the UI thread
        if (lstItems.InvokeRequired)
        {
            lstItems.Invoke(new Action<string, int>(UpdateProductListBox), item, i);
        }
        else
        {
            if (i == 0)
                lstItems.Items.Clear();

            lstItems.Items.Add(item);
        }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {

        Environment.Exit(Environment.ExitCode);
    }
}