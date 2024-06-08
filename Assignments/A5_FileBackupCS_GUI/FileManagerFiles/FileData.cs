using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_FileBackupCS.FileManagerFiles;

using System;
using System.IO;

public class FileData
{
    public string FullPath { get; private set; }
    public string FileName { get; private set; }
    public string NameOnly { get; private set; }
    public string Extension { get; private set; }
    public string ErrorMsg { get; set; }
    public string PathOnly { get; private set; }
    public string BkpFullPath { get; set; }

    public FileData(string fullPath)
    {
        CreateThisFromPath(fullPath);
    }

    private void CreateThisFromPath(string fullPath)
    {
        try
        {
            //validate and parse path
            if (!File.Exists(fullPath))
            {
                ErrorMsg = "File does not exist.";
                return;
            }

            FullPath = fullPath;
            FileName = Path.GetFileName(fullPath);
            PathOnly = Path.GetDirectoryName(fullPath);

            int dotIndex = FileName.LastIndexOf('.');

            if(dotIndex == -1)
            {
                Extension = "";
                NameOnly = FileName;
            }
            else
            {
                NameOnly = FileName.Substring(0, dotIndex);
                Extension = FileName.Substring(dotIndex + 1);
            }
        }
        catch(Exception ex)
        {
            ErrorMsg = ex.Message;
        }
    }
   
}


