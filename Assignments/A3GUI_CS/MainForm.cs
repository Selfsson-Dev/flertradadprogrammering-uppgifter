using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3_Form
{
    public partial class MainForm : Form
    {
        private SharedBuffer buffer;
        private Producer foodFactory, electronicsFactory, equipmentsFactory;
        private Consumer ica, coop, power;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            int storageSize = 20;
            lblMax.Text = $@"Buffer status (Max: {storageSize})";
            progressItems.Maximum = storageSize;
            buffer = new SharedBuffer(progressItems, lblItemsProduced, storageSize);
        }

        /// <summary>
        /// Start  producer 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartScan_Click(object sender, EventArgs e)
        {
            foodFactory = new Producer(buffer, lblStatusScan, CategoryType.Food);
            ThreadStart foodStart = new ThreadStart(foodFactory.StartProducing);
            Thread foodThread = new Thread(foodStart);
            foodThread.Start();

            btnStartScan.Enabled = false;
            btnStopScan.Enabled = true;
        }

        /// <summary>
        /// Start producer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartArla_Click(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Start  producer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartAxfood_Click(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Stop  producer´1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopScan_Click(object sender, EventArgs e)
        {
            foodFactory.StopProducing();

            btnStartScan.Enabled = true;
            btnStopScan.Enabled = false;
        }

        /// <summary>
        /// Stop  producer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopArla_Click(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Stop producer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopAxfood_Click(object sender, EventArgs e)
        {
          }
        /// <summary>
        /// Start consumer 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartIca_Click(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Stop thread 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopIca_Click(object sender, EventArgs e)
        {
            
            //Use the following patter to invoke updating of a control by other threads
            //lblIcaStatus.Invoke((MethodInvoker)(() => lblIcaStatus.Text = 
                   //xxThread.IsAlive ? "alive" : "dead"));



        }

        /// <summary>
        /// Start  consumer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCoop_Click(object sender, EventArgs e)
        {
  
        }
 
        private void lstIca_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lblIcaStatus.Invoke((MethodInvoker)(() => 
            //lblIcaStatus.Text = xxThread.IsAlive ? "alive" : "dead"));

        }

        /// <summary>
        /// Stop  thread 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCoop_Click(object sender, EventArgs e)
        {
          }

        /// <summary>
        /// Start consumer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCity_Click(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Stop thread 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCity_Click(object sender, EventArgs e)
        {
   
        }
    }
}
