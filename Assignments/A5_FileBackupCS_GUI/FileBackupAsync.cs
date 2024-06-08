using A5_FileBackupCS.FileManagerFiles;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace A5_FileBackupCS
{
    public class FileBackupAsync
    {
        // List to store metadata about each backed-up file.
        private List<FileData> fileDataList = new List<FileData>();

        // Total time taken for the backup process in milliseconds.
        private long timeTaken = 0;
        public long TimeTaken => timeTaken;

        /// <summary>
        /// Asynchronously starts the backup process for a set of files.
        /// </summary>
        /// <param name="filesToBackup">Array of file paths to be backed up.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of FileData objects, each representing a backed-up file.</returns>
        public async Task<List<FileData>> StartBackupAsync(string[] filesToBackup)
        {
            // Start a stopwatch to measure the backup duration.
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            // Create a list of tasks to handle the backup of each file concurrently.
            var tasks = new List<Task<FileData>>();
            foreach (string filePath in filesToBackup)
            {
                tasks.Add(BackupFileAsync(filePath));
            }

            // Wait for all backup tasks to complete and retrieve the results.
            var results = await Task.WhenAll(tasks);

            // Thread-safe update of fileDataList to avoid concurrency issues.
            lock (fileDataList)
            {
                fileDataList.AddRange(results);
            }

            // Stop the stopwatch and record the total backup time.
            stopwatch.Stop();
            timeTaken = stopwatch.ElapsedMilliseconds;

            // Return the list of FileData objects, each representing a backed-up file.
            return fileDataList;
        }

        /// <summary>
        /// Asynchronously backs up a single file.
        /// </summary>
        /// <param name="sourcePath">The path of the source file to backup.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a FileData object representing the backed-up file.</returns>
        private async Task<FileData> BackupFileAsync(string sourcePath)
        {
            FileData fileData = new FileData(sourcePath);

            // Check if the source file exists.
            if (!File.Exists(sourcePath))
            {
                fileData.ErrorMsg = "Source file does not exist: " + sourcePath;
                return fileData;
            }

            // Determine the destination path for the backup file.
            string backupPath = Path.Combine(fileData.PathOnly, "BKP", fileData.FileName);

            try
            {
                // Asynchronously copy the file to the backup location.
                await CopyFilesAsync(sourcePath, backupPath);
                fileData.BkpFullPath = backupPath;
            }
            catch (Exception e)
            {
                // If an error occurs during the copy process, record the error message.
                fileData.ErrorMsg = $"Failed to copy file: {e.Message}";
            }

            // Return the FileData object representing the backed-up file.
            return fileData;
        }

        /// <summary>
        /// Asynchronously copies a file from the source path to the target path.
        /// </summary>
        /// <param name="sourceFilePath">The path of the source file.</param>
        /// <param name="targetFilePath">The path of the target file.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task CopyFilesAsync(string sourceFilePath, string targetFilePath)
        {
            string directoryPath = Path.GetDirectoryName(targetFilePath);

            // Create the target directory if it doesn't exist.
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Copy the file to the backup location.
            File.Copy(sourceFilePath, targetFilePath, true);
        }
    }
}
