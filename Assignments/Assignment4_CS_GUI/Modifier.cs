using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI;

public class Modifier
{
    private BoundedBuffer buffer;
    private string findText, replaceText;
    private ListBox lstStatus;
    private string name;

    public bool isRunning { get; set; }

    public Modifier(BoundedBuffer buffer, string findText, string replaceText, ListBox lstStatus, int ID)
    {
        this.buffer = buffer;
        this.findText = findText;
        this.replaceText = replaceText;
        this.lstStatus = lstStatus;
        name = $"Modifier {ID}";
    }

    public void Modify()
    {
        while (isRunning)
        {
            buffer.Modify(findText, replaceText);

            lstStatus.Invoke((MethodInvoker)delegate { lstStatus.Items.Add($"{name} modified a line"); });
        }
    }
}