namespace BankruptByBugs_part1
{
    partial class BankruptByBugs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            eventListBox = new ListBox();
            label1 = new Label();
            outputListBox = new ListBox();
            label2 = new Label();
            buttonStart = new Button();
            buttonReset = new Button();
            buttonStop = new Button();
            threadUseButton = new RadioButton();
            SuspendLayout();
            // 
            // eventListBox
            // 
            eventListBox.FormattingEnabled = true;
            eventListBox.ItemHeight = 15;
            eventListBox.Location = new Point(22, 52);
            eventListBox.Name = "eventListBox";
            eventListBox.Size = new Size(388, 364);
            eventListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Thread action logs";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 15;
            outputListBox.Location = new Point(437, 52);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(519, 49);
            outputListBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(587, 24);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Output";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(437, 362);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(103, 54);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(672, 362);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(103, 54);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(555, 362);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(103, 54);
            buttonStop.TabIndex = 6;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // threadUseButton
            // 
            threadUseButton.AutoSize = true;
            threadUseButton.Location = new Point(437, 337);
            threadUseButton.Name = "threadUseButton";
            threadUseButton.Size = new Size(106, 19);
            threadUseButton.TabIndex = 7;
            threadUseButton.TabStop = true;
            threadUseButton.Text = "Use thread lock";
            threadUseButton.UseVisualStyleBackColor = true;
            threadUseButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // BankruptByBugs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 450);
            Controls.Add(threadUseButton);
            Controls.Add(buttonStop);
            Controls.Add(buttonReset);
            Controls.Add(buttonStart);
            Controls.Add(label2);
            Controls.Add(outputListBox);
            Controls.Add(label1);
            Controls.Add(eventListBox);
            Name = "BankruptByBugs";
            Text = "BankruptByBugs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox eventListBox;
        private Label label1;
        private ListBox outputListBox;
        private Label label2;
        private Button buttonStart;
        private Button buttonReset;
        private Button buttonStop;
        private RadioButton threadUseButton;
    }
}
