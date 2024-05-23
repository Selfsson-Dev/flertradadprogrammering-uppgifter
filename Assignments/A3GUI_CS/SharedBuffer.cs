using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Form
{
    public class SharedBuffer
    {
        private ProgressBar progressItems;
        private Label lblItemsProduced;

        private Product[] storage;

        private int inPos; // for producer to add
        private int outPos; // for consumers to remove
        private int bufferCount; // actual items in list

        private Semaphore producerSemaphor, consumerSemaphore;
        Mutex mutex;

        public SharedBuffer(ProgressBar progressItems, Label lblItemsProduced, int storageSize)
        {
            this.progressItems = progressItems;
            
            this.lblItemsProduced = lblItemsProduced;
            
            storage = new Product[storageSize];

            producerSemaphor = new Semaphore(storageSize, storageSize);
            consumerSemaphore = new Semaphore(0, storageSize);
            mutex = new Mutex();
        }

        public void Produce(Product product)
        {
            producerSemaphor.WaitOne();
            mutex.WaitOne();

            storage[inPos] = product;
            inPos = (inPos + 1) % storage.Length;
            bufferCount++;

            UpdateStorageGUI();

            mutex.ReleaseMutex();
            consumerSemaphore.Release();
        }

        public Product Consume()
        {
            consumerSemaphore.WaitOne();
            mutex.WaitOne();

            if (storage[outPos] == null)
            {
                return null;
            }

            Product product = storage[outPos];

            storage[outPos] = null;

            outPos = (outPos + 1) % storage.Length;
            bufferCount--;

            UpdateStorageGUI();

            mutex.ReleaseMutex();
            producerSemaphor.Release();

            return product;
        }

        private void UpdateStorageGUI()
        {
            progressItems.Invoke((MethodInvoker)(() => progressItems.Value = bufferCount));
            lblItemsProduced.Invoke((MethodInvoker)(() => lblItemsProduced.Text = $@"{bufferCount}"));
        }
    }
}
