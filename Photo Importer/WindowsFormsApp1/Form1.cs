using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void sourceBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog{};

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                sourceText.Text = folderBrowser.SelectedPath;
            }
        }

        private void destBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog { };

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                destinationText.Text = folderBrowser.SelectedPath;
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            copyFiles(sourceText.Text, destinationText.Text);
        }

        private void copyFiles(string source, string destination)
        {
            // Prevent the GUI from freezing
            Application.DoEvents();
            statusLabel.Text = "Searching source directory...";

            // Make list of photos to import
            string[] allFiles = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories);
            List<string> photosToImport = new List<string>();
            foreach (var file in allFiles)
            {
                DateTime dateTaken = GetDateTakenFromImage(file);
                if (dateTaken > importDatePicker.Value.Date)
                {
                    System.Diagnostics.Debug.WriteLine(file);
                    photosToImport.Add(file);
                }
            }

            // Copy files
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Maximum = photosToImport.Count;
            progressBar.Value = 0;
            foreach (var sourceFile in photosToImport)
            {
                DateTime dateTaken = GetDateTakenFromImage(sourceFile);
                string dateDirectoryName = Path.Combine(destination, dateTaken.ToString("yyyy_MM_dd"));
                Directory.CreateDirectory(dateDirectoryName);
                // Check if file already exists
                string destinationFile = Path.Combine(dateDirectoryName, Path.GetFileName(sourceFile));
                // Copy files
                if (!File.Exists(destinationFile))
                {
                    statusLabel.Text = string.Format("Moving {0} to {1}", sourceFile, destinationFile);
                    File.Copy(sourceFile, destinationFile);
                }
                else
                {
                    statusLabel.Text = string.Format("{0} already exists", destinationFile);
                }
                // Prevent the GUI from freezing
                Application.DoEvents();
                progressBar.Value++;
            }
            statusLabel.Text = "Done :)";
        }


        // Below code is from https://stackoverflow.com/a/7713780

        //we init this once so that if the function is repeatedly called
        //it isn't stressing the garbage man
        private static Regex r = new Regex(":");

        //retrieves the datetime WITHOUT loading the whole image
        public static DateTime GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                PropertyItem propItem = myImage.GetPropertyItem(36867);
                string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
        }
    }
}
