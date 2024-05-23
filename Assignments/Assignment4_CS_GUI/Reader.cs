using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI;

public class Reader
{
    private BoundedBuffer buffer;
    private RichTextBox rtxtDest;
    private ListBox lstStatus;

    public bool isRunning { get; set; }

    public Reader(BoundedBuffer buffer, RichTextBox rtxtDest, ListBox lstStatus)
    {
        this.buffer = buffer;
        this.rtxtDest = rtxtDest;
        this.lstStatus = lstStatus;
    }

    public void Read()
    {
        while (isRunning)
        {
            var data = buffer.Read();

            rtxtDest.Invoke((MethodInvoker)delegate { rtxtDest.AppendText(data + "\n"); });

            lstStatus.Invoke((MethodInvoker)delegate { lstStatus.Items.Add("Reader read a line"); });
        }
    }
}