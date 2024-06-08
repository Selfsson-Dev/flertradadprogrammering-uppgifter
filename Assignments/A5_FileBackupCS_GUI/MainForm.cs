
using A5_FileBackupCS.FileManagerFiles;
using System.ComponentModel;

namespace A5_FileBackupCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lstSource.Items.Clear();
            lstTarget.Items.Clear();
        }

 
        private void btnStart_Click(object sender, EventArgs e)
        {
            String[] filePaths = GetFilePaths();

            if (filePaths != null)
            {
                //start backup
                FileBackup backup = new FileBackup();

                //Select a directory to get files to back-up
                List<FileData> list = backup.StartBackup(filePaths);

                //Now you can pass this list to filemanagerfiles.getfilesPath
                String[] bkpFileNames = FileManager.GetFilesPath(list, true);

                //back-up code
                lstTarget.Items.Clear();
                lstTarget.Items.AddRange(bkpFileNames);

                lstSource.Items.Add("");
                lstSource.Items.Add($"Time taken to back up: {backup.TimeTaken} milliseconds");
            }
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            String[] filePaths = GetFilePaths();

            if (filePaths != null)
            {
                FileBackupAsync backup = new FileBackupAsync();
                List<FileData> list = await backup.StartBackupAsync(filePaths);

                String[] bkpFileNames = FileManager.GetFilesPath(list, true);
                lstTarget.Items.Clear();
                lstTarget.Items.AddRange(bkpFileNames);

                lstSource.Items.Add(" ");
                lstSource.Items.Add($"Time taken to back up: {backup.TimeTaken} milliseconds");
                //back-up code
            }
        }



        private string[] GetFilePaths()
        {
            FileManager fileManager = new FileManager();

            string[] filePaths = fileManager.GetDirectoryFiles();

            if (filePaths != null)
            {
                lstSource.Items.Clear();
                lstSource.Items.AddRange(filePaths);
            }

            return filePaths;
        }

        public static string[] GetFilesPath(List<FileData> fileDataList, bool backup)
        {
            string[] fileNames = new string[fileDataList.Count];
            for(int i = 0; i< fileDataList.Count; i++)
            {
                fileNames[i] = backup ? fileDataList[i].BkpFullPath : fileDataList[i].BkpFullPath;
            }
            return fileNames;
        }
    }
}

