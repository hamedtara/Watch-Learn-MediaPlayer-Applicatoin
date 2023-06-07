using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LearningLanguagePlayer
{
    public class FileLoader
    {
        private readonly FolderBrowserDialog _browserDialog;

        public FileLoader()
        {
            _browserDialog = new FolderBrowserDialog();
        }

        public List<string> LoadFiles()
        {
            List<string> filterFiles = new List<string>();
            DialogResult result = _browserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filterFiles = Directory.GetFiles(_browserDialog.SelectedPath, "*.*")
                    .Where(file => file.ToLower().EndsWith("wkv") || file.ToLower().EndsWith("mp4") || file.ToLower().EndsWith("wmv") || file.ToLower().EndsWith("avi") || file.ToLower().EndsWith("mp3"))
                    .ToList();
            }

            return filterFiles;
        }
    }
}
