using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI;

public class Writer
{
    private BoundedBuffer buffer;
    private List<string> lines;

    private ListBox lstStatus;
    private string name;

    public bool isRunning { get; set; }

    public Writer(BoundedBuffer buffer, List<string> lines, ListBox lstStatus, int writerIndex)
    {
        this.buffer = buffer;
        this.lines = lines;
        this.lstStatus = lstStatus;
        name = "Writer " + writerIndex;
    }

    public void Write()
    {
        while (isRunning)
        {
            Thread.Sleep(1000);
            isRunning = buffer.Write(lines);

            lstStatus.Invoke((MethodInvoker)delegate { lstStatus.Items.Add($"{name} wrote a line."); });
        }
    }
}