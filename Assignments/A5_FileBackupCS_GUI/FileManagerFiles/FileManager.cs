using A5_FileBackupCS.FileManagerFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms; // Ensure you have the reference for FolderBrowserDialog

namespace A5_FileBackupCS.FileManagerFiles
{
    public class FileManager
    {
        /// <summary>
        /// Prompts the user to select a directory and returns the full paths of files in that directory.
        /// </summary>
        /// <returns>An array of file paths if a directory is selected; otherwise, null.</returns>
        public string[] GetDirectoryFiles()
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Select a Directory";

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo directory = new DirectoryInfo(folderBrowser.SelectedPath);

                    // Check if the directory exists and contains files
                    if (!directory.Exists || directory.GetFiles().Length == 0)
                        return null;

                    // Get file paths
                    return directory.GetFiles().Select(file => file.FullName).ToArray();
                }
                else
                {
                    // User cancelled or closed the dialog
                    return null;
                }
            }
        }

        /// <summary>
        /// Retrieves the last modified date and time of a file, if it exists.
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <returns>The last modified DateTime, or null if the file doesn't exist.</returns>
        public DateTime? GetDateModified(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            return file.Exists ? file.LastWriteTime : null;
        }

        /// <summary>
        /// Extracts the paths of either original or backup files from a list of FileData objects.
        /// </summary>
        /// <param name="fileDataList">The list of FileData objects.</param>
        /// <param name="backup">If true, returns backup paths; otherwise, returns original paths.</param>
        /// <returns>An array of file paths.</returns>
        public static string[] GetFilesPath(List<FileData> fileDataList, bool backup)
        {
            return fileDataList.Select(data => backup ? data.BkpFullPath : data.FullPath).ToArray();
        }
    }
}
