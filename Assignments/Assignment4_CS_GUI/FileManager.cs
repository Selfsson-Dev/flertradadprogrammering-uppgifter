using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI;

public class FileManager
{
    public List<string> ReadFromTextFile(string fileName, out string errMessage)
    {
        errMessage = string.Empty;

        StreamReader reader = null;
        var lines = new List<string>();

        using (reader = new StreamReader(fileName, Encoding.UTF8)) // start reading
        {
            try
            {
                while (!reader.EndOfStream) // read until on last line
                {
                    var strLine = reader.ReadLine(); 
                    lines.Add(strLine); // save line
                }
            }
            catch (Exception e)
            {
                errMessage = e.Message;
                return null;
            }
        }

        return lines;
    }
}