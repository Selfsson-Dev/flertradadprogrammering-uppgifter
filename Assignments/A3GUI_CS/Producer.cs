using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Form
{
    public class Producer
    {
        private bool isProducing;
        private Random random = new Random();
        private Product[] items;

        private SharedBuffer buffer;
        private Label statusLabel;

        private CategoryType Category { get; set; }

        public Producer(SharedBuffer buffer, Label statusLabel, CategoryType category)
        {
            CreateTestProducts();

            this.buffer = buffer;
            this.statusLabel = statusLabel;
            Category = category;

            statusLabel.Invoke((MethodInvoker)(() => statusLabel.Text = @"NOT PRODUCING"));
        }

        private void CreateTestProducts()
        {
            throw new NotImplementedException();
        }

        public void StartProducing()
        {
            isProducing = true;
            statusLabel.Invoke((MethodInvoker)(() => statusLabel.Text = @"PRODUCING"));
            Produce();
        }

        public void StopProducing()
        {
            isProducing = false;
            statusLabel.Invoke((MethodInvoker)(() => statusLabel.Text = @"PRODUCING"));
        }
        private void Produce()
        {
            while (isProducing)
            {
                buffer.Produce(ChooseRandomItem());

                Thread.Sleep(300);
            }
        }

        private Product ChooseRandomItem()
        {
            bool done = false;

            Product product;

            do
            {
                product = items[random.Next(items.Length)];
                done = (product.Category == Category);

            } while (!done);

            return product;
        }

    }
}
