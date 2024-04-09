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

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }
    }
}
