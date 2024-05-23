using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace Assignment4_CS_GUI;

public partial class MainForm : Form
{
    private FileManager fileMngr = new();
    private List<string> lines;

    private BoundedBuffer buffer;

    private Writer[] writers = new Writer[3];
    private Modifier[] modifiers = new Modifier[4];
    private Reader reader;

    private Thread[] writerThreads = new Thread[3];
    private Thread[] modifierThreads = new Thread[4];
    private Thread readerThread;

    public MainForm()
    {
        InitializeComponent();
        InitializeGUI();

        buffer = new BoundedBuffer(25);
    }

    private void InitializeGUI()
    {
        toolTip1.SetToolTip(txtFind, "Select a text from the source and copy here!");
        toolTip1.SetToolTip(txtReplace, "Select a text to replace the above with!");
        toolTip1.SetToolTip(rtxtSource, "You can also write or change the text here manually!");
    }

    private void btnLoadFile_Click(object sender, EventArgs e)
    {
        openFileDialog1.Title = "Open file for reading as txt!";

        openFileDialog1.Filter = "Text files |*.txt| All files |*.*";

        openFileDialog1.FilterIndex = 0;

        openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var fileName = openFileDialog1.FileName; //important
            readDataFromTextFile(fileName);
        }
    }

    private void readDataFromTextFile(string fileName)
    {
        rtxtSource.Clear();
        lstStatus.Items.Clear();
        var errorMsg = string.Empty;
        lines = fileMngr.ReadFromTextFile(fileName, out errorMsg);
        lblSource.Text = fileName;

        foreach (var line in lines) 
            rtxtSource.AppendText(line + "\n");

        lstStatus.Items.Add("Lines read from the file: " + lines.Count);
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        rtxtDest.Clear();
        buffer = new BoundedBuffer(lines.Count);

        var findText = txtFind.Text;
        var replaceText = txtReplace.Text;

        //writer threads write the content of "lines" to the buffer
        for (var i = 0; i < writers.Length; i++)
        {
            writers[i] = new Writer(buffer, lines, lstStatus, i + 1)
            {
                isRunning = true
            };
            var writeStart = new ThreadStart(writers[i].Write);
            writerThreads[i] = new Thread(writeStart);
            writerThreads[i].Start();
        }

        //modifier threads modify the buffer if the word in the find box exist with the word in the replace box
        for (var i = 0; i < modifiers.Length; i++)
        {
            modifiers[i] = new Modifier(buffer, findText, replaceText, lstStatus, i + 1)
            {
                isRunning = true
            };
            var modifyStart = new ThreadStart(modifiers[i].Modify);
            modifierThreads[i] = new Thread(modifyStart);
            modifierThreads[i].Start();
        }

        //reader thread reads from the buffer and updates the destination box
        reader = new Reader(buffer, rtxtDest, lstStatus)
        {
            isRunning = true
        };
        var readerStart = new ThreadStart(reader.Read);
        readerThread = new Thread(readerStart);
        readerThread.Start();

        // Start a thread to monitor completion and stop other threads
        var monitorThread = new Thread(MonitorCompletion);
        monitorThread.Start();
    }

    private void MonitorCompletion()
    {
        // Wait for writers to finish
        foreach (var writerThread in writerThreads) writerThread.Join();

        // Signal modifiers to stop once all writers are done
        foreach (var modifier in modifiers) modifier.isRunning = false;

        reader.isRunning = false;

        lstStatus.Invoke((MethodInvoker)delegate { lstStatus.Items.Add("All processing complete."); });
    }

    private void txtFind_TextChanged(object sender, EventArgs e)
    {
        var findText = txtFind.Text;
        HighlightText(findText);
    }

    private void txtReplace_TextChanged(object sender, EventArgs e)
    {
    }

    private void HighlightText(string searchText)
    {
        // Clear existing highlighting
        rtxtSource.SelectAll();
        rtxtSource.SelectionBackColor = rtxtSource.BackColor;

        // Start highlighting anew
        var startIndex = 0;
        while (startIndex < rtxtSource.TextLength)
        {
            var index = rtxtSource.Find(searchText, startIndex, RichTextBoxFinds.None);
            if (index != -1)
            {
                rtxtSource.SelectionStart = index;
                rtxtSource.SelectionLength = searchText.Length;
                rtxtSource.SelectionBackColor = Color.Yellow;
                startIndex = index + searchText.Length;
            }
            else
            {
                break;
            }
        }

        rtxtSource.SelectionStart = rtxtSource.TextLength;
    }
}