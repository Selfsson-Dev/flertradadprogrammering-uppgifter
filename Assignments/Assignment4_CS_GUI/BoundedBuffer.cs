namespace Assignment4_CS_GUI;

public class BoundedBuffer
{
    // seperate rows and rowStatuses of those rows;
    private readonly string[] rows;
    private readonly BufferStatus[] rowStatuses;

    // rows positions
    private int writePos = 0;
    private int readPos = 0;
    private int modifyPos = 0;

    private readonly object _lock = new(); // lås
    private int currentRow; // rad

    public BoundedBuffer(int capacity)
    {
        rows = new string[capacity];
        rowStatuses = new BufferStatus[capacity];
        for (var i = 0; i < capacity; i++) rowStatuses[i] = BufferStatus.Empty;
    }

    public bool Write(List<string> data)
    {
        Monitor.Enter(_lock);
        try
        {
            while (rowStatuses[writePos] != BufferStatus.Empty) Monitor.Wait(_lock);

            if (currentRow >= data.Count)
                return false;

            rows[writePos] = data[currentRow];
            currentRow++;

            rowStatuses[writePos] = BufferStatus.New;
            writePos = (writePos + 1) % rows.Length;
            Monitor.PulseAll(_lock);
            return true;
        }
        finally
        {
            Monitor.Exit(_lock);
        }
    }

    public void Modify(string searchString, string replacementString)
    {
        Monitor.Enter(_lock); // Acquire the lock
        try
        {
            while (rowStatuses[modifyPos] != BufferStatus.New) Monitor.Wait(_lock);

            if (rows[modifyPos].Contains(searchString))
                rows[modifyPos] = rows[modifyPos].Replace(searchString, replacementString);
            rowStatuses[modifyPos] = BufferStatus.Checked;
            modifyPos = (modifyPos + 1) % rows.Length;

            Monitor.PulseAll(_lock);
        }
        finally
        {
            Monitor.Exit(_lock);
        }
    }

    /// <summary>
    /// Hold lock while reading
    /// if current row is not checked let go off lock
    /// 
    /// </summary>
    /// <returns></returns>
    public string Read()
    {
        Monitor.Enter(_lock);
        try
        {
            while (rowStatuses[readPos] != BufferStatus.Checked)
                Monitor.Wait(_lock);

            var data = rows[readPos];
            rowStatuses[readPos] = BufferStatus.Empty;
            readPos = (readPos + 1) % rows.Length;

            Monitor.PulseAll(_lock);
            return data;
        }
        finally
        {
            Monitor.Exit(_lock);
        }
    }
}