﻿namespace Assignment3_Form
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnStopAxfood = new System.Windows.Forms.Button();
            this.btnStartAxfood = new System.Windows.Forms.Button();
            this.lblStatusAxfood = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnStopArla = new System.Windows.Forms.Button();
            this.btnStartArla = new System.Windows.Forms.Button();
            this.lblStatusArla = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.lblStatusScan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblItems3 = new System.Windows.Forms.Label();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.btnStopCity = new System.Windows.Forms.Button();
            this.btnStartCity = new System.Windows.Forms.Button();
            this.chkCityCont = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCityStatus = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblItems2 = new System.Windows.Forms.Label();
            this.lstCoop = new System.Windows.Forms.ListBox();
            this.btnStopCoop = new System.Windows.Forms.Button();
            this.btnStartCoop = new System.Windows.Forms.Button();
            this.chkCoopCont = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCoopStatus = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblItems1 = new System.Windows.Forms.Label();
            this.lstIca = new System.Windows.Forms.ListBox();
            this.btnStopIca = new System.Windows.Forms.Button();
            this.btnStartIca = new System.Windows.Forms.Button();
            this.chkIcaCont = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIcaStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblItemsProduced = new System.Windows.Forms.Label();
            this.progressItems = new System.Windows.Forms.ProgressBar();
            this.lblMax = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(343, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producers";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnStopAxfood);
            this.groupBox6.Controls.Add(this.btnStartAxfood);
            this.groupBox6.Controls.Add(this.lblStatusAxfood);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(9, 402);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(325, 154);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Int Equipments";
            // 
            // btnStopAxfood
            // 
            this.btnStopAxfood.Enabled = false;
            this.btnStopAxfood.Location = new System.Drawing.Point(224, 89);
            this.btnStopAxfood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopAxfood.Name = "btnStopAxfood";
            this.btnStopAxfood.Size = new System.Drawing.Size(72, 35);
            this.btnStopAxfood.TabIndex = 3;
            this.btnStopAxfood.Text = "Stop";
            this.btnStopAxfood.UseVisualStyleBackColor = true;
            this.btnStopAxfood.Click += new System.EventHandler(this.btnStopAxfood_Click);
            // 
            // btnStartAxfood
            // 
            this.btnStartAxfood.Location = new System.Drawing.Point(44, 91);
            this.btnStartAxfood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartAxfood.Name = "btnStartAxfood";
            this.btnStartAxfood.Size = new System.Drawing.Size(148, 35);
            this.btnStartAxfood.TabIndex = 2;
            this.btnStartAxfood.Text = "Start Producing";
            this.btnStartAxfood.UseVisualStyleBackColor = true;
            this.btnStartAxfood.Click += new System.EventHandler(this.btnStartAxfood_Click);
            // 
            // lblStatusAxfood
            // 
            this.lblStatusAxfood.AutoSize = true;
            this.lblStatusAxfood.Location = new System.Drawing.Point(120, 48);
            this.lblStatusAxfood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusAxfood.Name = "lblStatusAxfood";
            this.lblStatusAxfood.Size = new System.Drawing.Size(143, 20);
            this.lblStatusAxfood.TabIndex = 1;
            this.lblStatusAxfood.Text = "NOT PRODUCING";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnStopArla);
            this.groupBox5.Controls.Add(this.btnStartArla);
            this.groupBox5.Controls.Add(this.lblStatusArla);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(9, 214);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(325, 154);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Home Electronics";
            // 
            // btnStopArla
            // 
            this.btnStopArla.Enabled = false;
            this.btnStopArla.Location = new System.Drawing.Point(224, 89);
            this.btnStopArla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopArla.Name = "btnStopArla";
            this.btnStopArla.Size = new System.Drawing.Size(72, 35);
            this.btnStopArla.TabIndex = 3;
            this.btnStopArla.Text = "Stop";
            this.btnStopArla.UseVisualStyleBackColor = true;
            this.btnStopArla.Click += new System.EventHandler(this.btnStopArla_Click);
            // 
            // btnStartArla
            // 
            this.btnStartArla.Location = new System.Drawing.Point(44, 91);
            this.btnStartArla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartArla.Name = "btnStartArla";
            this.btnStartArla.Size = new System.Drawing.Size(148, 35);
            this.btnStartArla.TabIndex = 2;
            this.btnStartArla.Text = "Start Producing";
            this.btnStartArla.UseVisualStyleBackColor = true;
            this.btnStartArla.Click += new System.EventHandler(this.btnStartArla_Click);
            // 
            // lblStatusArla
            // 
            this.lblStatusArla.AutoSize = true;
            this.lblStatusArla.Location = new System.Drawing.Point(120, 48);
            this.lblStatusArla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusArla.Name = "lblStatusArla";
            this.lblStatusArla.Size = new System.Drawing.Size(143, 20);
            this.lblStatusArla.TabIndex = 1;
            this.lblStatusArla.Text = "NOT PRODUCING";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStopScan);
            this.groupBox4.Controls.Add(this.btnStartScan);
            this.groupBox4.Controls.Add(this.lblStatusScan);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(9, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(325, 154);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Food Factory";
            // 
            // btnStopScan
            // 
            this.btnStopScan.Enabled = false;
            this.btnStopScan.Location = new System.Drawing.Point(224, 89);
            this.btnStopScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(72, 35);
            this.btnStopScan.TabIndex = 3;
            this.btnStopScan.Text = "Stop";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(44, 91);
            this.btnStartScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(148, 35);
            this.btnStartScan.TabIndex = 2;
            this.btnStartScan.Text = "Start Producing";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // lblStatusScan
            // 
            this.lblStatusScan.AutoSize = true;
            this.lblStatusScan.Location = new System.Drawing.Point(120, 48);
            this.lblStatusScan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusScan.Name = "lblStatusScan";
            this.lblStatusScan.Size = new System.Drawing.Size(143, 20);
            this.lblStatusScan.TabIndex = 1;
            this.lblStatusScan.Text = "NOT PRODUCING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Location = new System.Drawing.Point(399, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(615, 582);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consumers";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblItems3);
            this.groupBox11.Controls.Add(this.lstCity);
            this.groupBox11.Controls.Add(this.btnStopCity);
            this.groupBox11.Controls.Add(this.btnStartCity);
            this.groupBox11.Controls.Add(this.chkCityCont);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.lblCityStatus);
            this.groupBox11.Location = new System.Drawing.Point(28, 402);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Size = new System.Drawing.Size(577, 154);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Food && tools";
            // 
            // lblItems3
            // 
            this.lblItems3.AutoSize = true;
            this.lblItems3.Location = new System.Drawing.Point(181, 71);
            this.lblItems3.Name = "lblItems3";
            this.lblItems3.Size = new System.Drawing.Size(47, 20);
            this.lblItems3.TabIndex = 10;
            this.lblItems3.Text = "items";
            this.lblItems3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 20;
            this.lstCity.Location = new System.Drawing.Point(234, 35);
            this.lstCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(334, 104);
            this.lstCity.TabIndex = 8;
            // 
            // btnStopCity
            // 
            this.btnStopCity.Enabled = false;
            this.btnStopCity.Location = new System.Drawing.Point(166, 109);
            this.btnStopCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopCity.Name = "btnStopCity";
            this.btnStopCity.Size = new System.Drawing.Size(60, 35);
            this.btnStopCity.TabIndex = 7;
            this.btnStopCity.Text = "Stop";
            this.btnStopCity.UseVisualStyleBackColor = true;
            this.btnStopCity.Click += new System.EventHandler(this.btnStopCity_Click);
            // 
            // btnStartCity
            // 
            this.btnStartCity.Location = new System.Drawing.Point(11, 109);
            this.btnStartCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartCity.Name = "btnStartCity";
            this.btnStartCity.Size = new System.Drawing.Size(122, 35);
            this.btnStartCity.TabIndex = 6;
            this.btnStartCity.Text = "Start Loading";
            this.btnStartCity.UseVisualStyleBackColor = true;
            this.btnStartCity.Click += new System.EventHandler(this.btnStartCity_Click);
            // 
            // chkCityCont
            // 
            this.chkCityCont.AutoSize = true;
            this.chkCityCont.Location = new System.Drawing.Point(11, 70);
            this.chkCityCont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCityCont.Name = "chkCityCont";
            this.chkCityCont.Size = new System.Drawing.Size(133, 24);
            this.chkCityCont.TabIndex = 5;
            this.chkCityCont.Text = "Continue load";
            this.chkCityCont.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-1, 35);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Status:";
            // 
            // lblCityStatus
            // 
            this.lblCityStatus.AutoSize = true;
            this.lblCityStatus.Location = new System.Drawing.Point(54, 35);
            this.lblCityStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCityStatus.Name = "lblCityStatus";
            this.lblCityStatus.Size = new System.Drawing.Size(144, 20);
            this.lblCityStatus.TabIndex = 3;
            this.lblCityStatus.Text = "NOT CONSUMING";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblItems2);
            this.groupBox9.Controls.Add(this.lstCoop);
            this.groupBox9.Controls.Add(this.btnStopCoop);
            this.groupBox9.Controls.Add(this.btnStartCoop);
            this.groupBox9.Controls.Add(this.chkCoopCont);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.lblCoopStatus);
            this.groupBox9.Location = new System.Drawing.Point(28, 214);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Size = new System.Drawing.Size(577, 154);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Coop Market";
            // 
            // lblItems2
            // 
            this.lblItems2.AutoSize = true;
            this.lblItems2.Location = new System.Drawing.Point(182, 70);
            this.lblItems2.Name = "lblItems2";
            this.lblItems2.Size = new System.Drawing.Size(47, 20);
            this.lblItems2.TabIndex = 10;
            this.lblItems2.Text = "items";
            this.lblItems2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstCoop
            // 
            this.lstCoop.FormattingEnabled = true;
            this.lstCoop.ItemHeight = 20;
            this.lstCoop.Location = new System.Drawing.Point(245, 35);
            this.lstCoop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCoop.Name = "lstCoop";
            this.lstCoop.Size = new System.Drawing.Size(321, 104);
            this.lstCoop.TabIndex = 8;
            // 
            // btnStopCoop
            // 
            this.btnStopCoop.Enabled = false;
            this.btnStopCoop.Location = new System.Drawing.Point(166, 95);
            this.btnStopCoop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopCoop.Name = "btnStopCoop";
            this.btnStopCoop.Size = new System.Drawing.Size(60, 35);
            this.btnStopCoop.TabIndex = 7;
            this.btnStopCoop.Text = "Stop";
            this.btnStopCoop.UseVisualStyleBackColor = true;
            this.btnStopCoop.Click += new System.EventHandler(this.btnStopCoop_Click);
            // 
            // btnStartCoop
            // 
            this.btnStartCoop.Location = new System.Drawing.Point(22, 109);
            this.btnStartCoop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartCoop.Name = "btnStartCoop";
            this.btnStartCoop.Size = new System.Drawing.Size(122, 35);
            this.btnStartCoop.TabIndex = 6;
            this.btnStartCoop.Text = "Start Loading";
            this.btnStartCoop.UseVisualStyleBackColor = true;
            this.btnStartCoop.Click += new System.EventHandler(this.btnStartCoop_Click);
            // 
            // chkCoopCont
            // 
            this.chkCoopCont.AutoSize = true;
            this.chkCoopCont.Location = new System.Drawing.Point(22, 70);
            this.chkCoopCont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCoopCont.Name = "chkCoopCont";
            this.chkCoopCont.Size = new System.Drawing.Size(133, 24);
            this.chkCoopCont.TabIndex = 5;
            this.chkCoopCont.Text = "Continue load";
            this.chkCoopCont.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Status:";
            // 
            // lblCoopStatus
            // 
            this.lblCoopStatus.AutoSize = true;
            this.lblCoopStatus.Location = new System.Drawing.Point(65, 35);
            this.lblCoopStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoopStatus.Name = "lblCoopStatus";
            this.lblCoopStatus.Size = new System.Drawing.Size(144, 20);
            this.lblCoopStatus.TabIndex = 3;
            this.lblCoopStatus.Text = "NOT CONSUMING";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblItems1);
            this.groupBox7.Controls.Add(this.lstIca);
            this.groupBox7.Controls.Add(this.btnStopIca);
            this.groupBox7.Controls.Add(this.btnStartIca);
            this.groupBox7.Controls.Add(this.chkIcaCont);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.lblIcaStatus);
            this.groupBox7.Location = new System.Drawing.Point(28, 29);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(577, 154);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Gen Groceries";
            // 
            // lblItems1
            // 
            this.lblItems1.AutoSize = true;
            this.lblItems1.Location = new System.Drawing.Point(181, 59);
            this.lblItems1.Name = "lblItems1";
            this.lblItems1.Size = new System.Drawing.Size(47, 20);
            this.lblItems1.TabIndex = 9;
            this.lblItems1.Text = "items";
            this.lblItems1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstIca
            // 
            this.lstIca.FormattingEnabled = true;
            this.lstIca.ItemHeight = 20;
            this.lstIca.Location = new System.Drawing.Point(245, 24);
            this.lstIca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstIca.Name = "lstIca";
            this.lstIca.Size = new System.Drawing.Size(321, 104);
            this.lstIca.TabIndex = 8;
            this.lstIca.SelectedIndexChanged += new System.EventHandler(this.lstIca_SelectedIndexChanged);
            // 
            // btnStopIca
            // 
            this.btnStopIca.Enabled = false;
            this.btnStopIca.Location = new System.Drawing.Point(166, 98);
            this.btnStopIca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopIca.Name = "btnStopIca";
            this.btnStopIca.Size = new System.Drawing.Size(60, 35);
            this.btnStopIca.TabIndex = 7;
            this.btnStopIca.Text = "Stop";
            this.btnStopIca.UseVisualStyleBackColor = true;
            this.btnStopIca.Click += new System.EventHandler(this.btnStopIca_Click);
            // 
            // btnStartIca
            // 
            this.btnStartIca.Location = new System.Drawing.Point(22, 98);
            this.btnStartIca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartIca.Name = "btnStartIca";
            this.btnStartIca.Size = new System.Drawing.Size(122, 35);
            this.btnStartIca.TabIndex = 6;
            this.btnStartIca.Text = "Start Loading";
            this.btnStartIca.UseVisualStyleBackColor = true;
            this.btnStartIca.Click += new System.EventHandler(this.btnStartIca_Click);
            // 
            // chkIcaCont
            // 
            this.chkIcaCont.AutoSize = true;
            this.chkIcaCont.Location = new System.Drawing.Point(22, 59);
            this.chkIcaCont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIcaCont.Name = "chkIcaCont";
            this.chkIcaCont.Size = new System.Drawing.Size(133, 24);
            this.chkIcaCont.TabIndex = 5;
            this.chkIcaCont.Text = "Continue load";
            this.chkIcaCont.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            // 
            // lblIcaStatus
            // 
            this.lblIcaStatus.AutoSize = true;
            this.lblIcaStatus.Location = new System.Drawing.Point(65, 24);
            this.lblIcaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcaStatus.Name = "lblIcaStatus";
            this.lblIcaStatus.Size = new System.Drawing.Size(144, 20);
            this.lblIcaStatus.TabIndex = 3;
            this.lblIcaStatus.Text = "NOT CONSUMING";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblItemsProduced);
            this.groupBox3.Controls.Add(this.progressItems);
            this.groupBox3.Controls.Add(this.lblMax);
            this.groupBox3.Location = new System.Drawing.Point(19, 612);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(994, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Storage";
            // 
            // lblItemsProduced
            // 
            this.lblItemsProduced.AutoSize = true;
            this.lblItemsProduced.Location = new System.Drawing.Point(892, 24);
            this.lblItemsProduced.Name = "lblItemsProduced";
            this.lblItemsProduced.Size = new System.Drawing.Size(80, 20);
            this.lblItemsProduced.TabIndex = 9;
            this.lblItemsProduced.Text = "Max items";
            this.lblItemsProduced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressItems
            // 
            this.progressItems.ForeColor = System.Drawing.Color.Blue;
            this.progressItems.Location = new System.Drawing.Point(233, 58);
            this.progressItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressItems.Maximum = 20;
            this.progressItems.Name = "progressItems";
            this.progressItems.Size = new System.Drawing.Size(735, 35);
            this.progressItems.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressItems.TabIndex = 2;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(9, 65);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(156, 20);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Max capacity (items):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Supply System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressItems;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnStopAxfood;
        private System.Windows.Forms.Button btnStartAxfood;
        private System.Windows.Forms.Label lblStatusAxfood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnStopArla;
        private System.Windows.Forms.Button btnStartArla;
        private System.Windows.Forms.Label lblStatusArla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Label lblStatusScan;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.Button btnStopCity;
        private System.Windows.Forms.Button btnStartCity;
        private System.Windows.Forms.CheckBox chkCityCont;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCityStatus;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox lstCoop;
        private System.Windows.Forms.Button btnStopCoop;
        private System.Windows.Forms.Button btnStartCoop;
        private System.Windows.Forms.CheckBox chkCoopCont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCoopStatus;
        private System.Windows.Forms.ListBox lstIca;
        private System.Windows.Forms.Button btnStopIca;
        private System.Windows.Forms.Button btnStartIca;
        private System.Windows.Forms.CheckBox chkIcaCont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIcaStatus;
        private System.Windows.Forms.Label lblItems1;
        private System.Windows.Forms.Label lblItems3;
        private System.Windows.Forms.Label lblItems2;
        private System.Windows.Forms.Label lblItemsProduced;
    }
}

