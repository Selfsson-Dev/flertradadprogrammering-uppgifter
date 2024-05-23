using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Form
{
    public class Consumer
    {
        private volatile bool isConsuming;
        private SharedBuffer sharedBuffer;
        private Label itemLabel, itemsLabelCount;
        private ListBox itemsListBox;
        private CheckBox checkBox;
        private int maxItems;
        private int itemCount;

        public Consumer(SharedBuffer sharedBuffer, Label itemLabel, Label itemsLabelCount, ListBox itemsListBox, int maxItems, CheckBox checkBox)
        {
            this.sharedBuffer = sharedBuffer;
            this.itemLabel = itemLabel;
            this.itemsLabelCount = itemsLabelCount;
            this.itemsListBox = itemsListBox;
            this.maxItems = maxItems;
            this.checkBox = checkBox;

            itemLabel.Invoke((MethodInvoker)(() => itemLabel.Text = $@"CONSUMING"));
        }

        public void StartConsuming()
        {
            isConsuming = true;
            itemCount = 0;

            itemsListBox.Invoke((MethodInvoker)(() => itemsListBox.Items.Clear()));
            itemLabel.Invoke((MethodInvoker)(() => itemLabel.Text = $@"{itemCount} items"));

            Consume();
        }

        public void StopConsuming()
        {
            isConsuming = false;
        }

        private void Consume()
        {
            while (isConsuming)
            {
                if (itemCount < maxItems)
                {
                    Product product = sharedBuffer.Consume();
                    itemCount++;

                    itemsListBox.Invoke((MethodInvoker)(() => itemsListBox.Items.Add(product.ToString())));
                    itemLabel.Invoke((MethodInvoker)(() => itemLabel.Text = $@"{itemCount} items"));
                    Thread.Sleep(600);
                }
                else if (checkBox.Checked)
                {
                    Thread.Sleep(1000);
                    itemCount = 0;

                    itemsListBox.Invoke((MethodInvoker)(() => itemsListBox.Items.Clear()));
                    itemsLabelCount.Invoke((MethodInvoker)(() => itemLabel.Text = $@"{itemCount} items"));
                }
            }
            itemLabel.Invoke((MethodInvoker)(() => itemLabel.Text = $@"NOT CONSUMING"));
        }
    }


}
