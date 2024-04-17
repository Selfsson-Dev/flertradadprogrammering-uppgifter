namespace BankruptByBugs_part1
{
    public partial class BankruptByBugs : Form
    {
        private Controller controller;

        public BankruptByBugs()
        {
            InitializeComponent();
            controller = new Controller(eventListBox, outputListBox);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            controller.StartClients();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            controller.StopClients();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            eventListBox.Items.Clear();
            outputListBox.Items.Clear();

            controller = new Controller(eventListBox, outputListBox);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            controller.UseLock();
        }
    }
}
