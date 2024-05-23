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
            const int max = 50;
            items = new Product[max];
            for (int i = 0; i < 5; i++)
            {
                int j = i * 10;

                items[0 + j] = new Product("Milk, Gen Food" + (i + 1).ToString(), 1.0, 19.95, 6, CategoryType.Food);
                items[1 + j] = new Product("Egg, organic" + (i + 1).ToString(), 5.0, 60.55, 20, CategoryType.Food);
                items[2 + j] = new Product("Dish Washer" + (i + 1).ToString(), 15, 5990, 1, CategoryType.Electronics);
                items[3 + j] = new Product("Shaving machine" + (i + 1).ToString(), 200, 750, 2, CategoryType.Electronics);
                items[4 + j] = new Product("Screwdriver machine" + (i + 1).ToString(), 780, 459, 3, CategoryType.Equipment);
                items[5 + j] = new Product("Tigersaw" + (i + 1).ToString(), 450, 2000, 3, CategoryType.Equipment);
                items[6 + j] = new Product("Milk, Gen Food" + (i + 1).ToString(), 1.0, 19.95, 6, CategoryType.Food);
                items[7 + j] = new Product("Egg Gen Food" + (i + 1).ToString(), 5.0, 60.55, 20, CategoryType.Food);
                items[8 + j] = new Product("Dish Washer, Global El" + (i + 1).ToString(), 15, 5990, 1, CategoryType.Electronics);
                items[9 + j] = new Product("Shaving machine, Home Tools" + (i + 1).ToString(), 200, 750, 2, CategoryType.Electronics);
            }
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
            statusLabel.Invoke((MethodInvoker)(() => statusLabel.Text = @"NOT PRODUCING"));
        }
        private void Produce()
        {
            while (isProducing)
            {
                buffer.Produce(ChooseRandomItem());

                Thread.Sleep(300);
            }
            statusLabel.Invoke((MethodInvoker)(() => statusLabel.Text = @"NOT PRODUCING"));
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
