using A5_FileBackupCS.FileManagerFiles;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace A5_FileBackupCS
{
    public class FileBackup
    {
        // List to store information about each backed-up file
        private List<FileData> fileDataList = new List<FileData>();

        // Total time taken for the backup process
        private long timeTaken = 0;
        public long TimeTaken => timeTaken;

        // Lock object for thread synchronization
        private object lockObject = new object();

        /// <summary>
        /// Starts the backup process for the specified files.
        /// </summary>
        /// <param name="filesToBackup">Array of file paths to backup.</param>
        /// <returns>List of FileData objects containing backup details.</returns>
        public List<FileData> StartBackup(string[] filesToBackup)
        {
            int taskCount = filesToBackup.Length;          // Number of files to backup
            int remainingTasks = taskCount;              // Counter for remaining tasks
            var stopwatch = System.Diagnostics.Stopwatch.StartNew(); // Timer to measure backup time

            // Queue backup tasks for each file
            foreach (string filePath in filesToBackup)
            {
                ThreadPool.QueueUserWorkItem(state =>     // Queue work item on the thread pool
                {
                    try
                    {
                        FileData result = BackupFile(filePath);  // Perform backup
                        lock (fileDataList)                    // Thread-safe addition to list
                        {
                            fileDataList.Add(result);
                        }
                    }
                    finally
                    {
                        lock (lockObject)                       // Thread-safe decrement
                        {
                            remainingTasks--;
                        }
                    }
                });
            }

            // Wait for all tasks to complete
            while (remainingTasks > 0)
            {
                //Thread.Sleep(100); // Check every 100ms
            }

            stopwatch.Stop();
            timeTaken = stopwatch.ElapsedMilliseconds;

            // Return a copy of the list to prevent modification
            return new List<FileData>(fileDataList);
        }

        /// <summary>
        /// Backs up a single file to the specified location.
        /// </summary>
        /// <param name="sourcePath">Path of the file to backup.</param>
        /// <returns>FileData object containing backup details.</returns>
        private FileData BackupFile(string sourcePath)
        {
            FileData fileData = new FileData(sourcePath);

            // Check if source file exists
            if (!File.Exists(sourcePath))
            {
                fileData.ErrorMsg = "Source file does not exist: " + sourcePath;
                return fileData;
            }

            // Determine backup path
            string backupPath = Path.Combine(fileData.PathOnly, "BKP", fileData.FileName);

            // Attempt to copy file
            bool ok = CopyFiles(sourcePath, backupPath);
            if (ok)
            {
                fileData.BkpFullPath = backupPath;
            }
            else
            {
                fileData.ErrorMsg = "Failed to copy file.";
            }
            return fileData;
        }

        /// <summary>
        /// Copies a file from the source path to the target path.
        /// </summary>
        /// <param name="sourceFilePath">Path of the source file.</param>
        /// <param name="targetFilePath">Path of the target file.</param>
        /// <returns>True if successful, false otherwise.</returns>
        private bool CopyFiles(string sourceFilePath, string targetFilePath)
        {
            try
            {
                string directoryPath = Path.GetDirectoryName(targetFilePath);

                // Create directory if it doesn't exist
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Copy file
                File.Copy(sourceFilePath, targetFilePath, true);
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
