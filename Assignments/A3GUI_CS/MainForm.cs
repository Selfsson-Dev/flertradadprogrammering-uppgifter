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
        private Consumer ica, jula, power;

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
            foodThread.Name = "foodProducer";
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
            electronicsFactory = new Producer(buffer, lblStatusArla, CategoryType.Electronics);
            ThreadStart electronicStart = new ThreadStart(electronicsFactory.StartProducing);
            Thread electronicThread = new Thread(electronicStart);
            electronicThread.Name = "electronicProducer";
            electronicThread.Start();

            btnStartArla.Enabled = false;
            btnStopArla.Enabled = true;
        }

        /// <summary>
        /// Start  producer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartAxfood_Click(object sender, EventArgs e)
        {
            equipmentsFactory = new Producer(buffer, lblStatusAxfood, CategoryType.Equipment);
            ThreadStart equipmentThreadStart = new ThreadStart(equipmentsFactory.StartProducing);
            Thread equipmentThread = new Thread(equipmentThreadStart);
            equipmentThread.Name = "equipmentProducer";
            equipmentThread.Start();

            btnStartAxfood.Enabled = false;
            btnStopAxfood.Enabled = true;
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
            electronicsFactory.StopProducing();

            btnStartArla.Enabled = true;
            btnStopArla.Enabled = false;
        }

        /// <summary>
        /// Stop producer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopAxfood_Click(object sender, EventArgs e)
        {
            equipmentsFactory.StopProducing();

            btnStartAxfood.Enabled = true;
            btnStopAxfood.Enabled = false;
        }

        /// <summary>
        /// Start consumer 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartIca_Click(object sender, EventArgs e)
        {
            ica = new Consumer(buffer, lblIcaStatus, lblItems1, lstIca, 10, chkIcaCont);
            ThreadStart icaStart = new ThreadStart(ica.StartConsuming);
            Thread icaThread = new Thread(icaStart);

            icaThread.Start();

            btnStartIca.Enabled = false;
            btnStopIca.Enabled = true;
        }

        /// <summary>
        /// Stop thread 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopIca_Click(object sender, EventArgs e)
        {
            ica.StopConsuming();

            btnStartIca.Enabled = true;
            btnStopIca.Enabled = false;
        }

        /// <summary>
        /// Start  consumer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCoop_Click(object sender, EventArgs e)
        {
            power = new Consumer(buffer, lblCoopStatus, lblItems2, lstCoop, 12, chkCoopCont);
            ThreadStart elgigantenStart = new ThreadStart(power.StartConsuming);
            Thread powerThread = new Thread(elgigantenStart);
            powerThread.Start();

            btnStartCoop.Enabled = false;
            btnStopCoop.Enabled = true;
        }

        private void chkIcaCont_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCoopCont_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCityCont_CheckedChanged(object sender, EventArgs e)
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
            power.StopConsuming();

            btnStartCoop.Enabled = true;
            btnStopCoop.Enabled = false;
        }

        /// <summary>
        /// Start consumer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCity_Click(object sender, EventArgs e)
        {
            jula = new Consumer(buffer, lblCityStatus, lblItems3, lstCity, 8, chkCityCont);
            ThreadStart julaStart = new ThreadStart(jula.StartConsuming);
            Thread julaThread = new Thread(julaStart);
            julaThread.Start();

            btnStartCity.Enabled = false;
            btnStopCity.Enabled = true;
        }

        /// <summary>
        /// Stop thread 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCity_Click(object sender, EventArgs e)
        {
            jula.StopConsuming();

            btnStartCity.Enabled = true;
            btnStopCity.Enabled = false;
        }
    }
}
