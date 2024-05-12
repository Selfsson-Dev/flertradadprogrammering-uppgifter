using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Form
{
    public class SharedBuffer
    {
        private ProgressBar progressItems;
        private Label lblItemsProduced;
        private int storageSize;

        public SharedBuffer(ProgressBar progressItems, Label lblItemsProduced, int storageSize)
        {
            this.progressItems = progressItems;
            this.lblItemsProduced = lblItemsProduced;
            this.storageSize = storageSize;
        }

        internal void Produce(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
