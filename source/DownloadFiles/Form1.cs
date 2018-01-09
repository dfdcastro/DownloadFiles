using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadFiles
{
    public partial class Form1 : Form
    {
        List<String> successDownload;
        List<String> errorDownload;

        public Form1()
        {
            InitializeComponent();

            this.logLabel.Text = string.Empty;
            this.ErrorLogLabel.Text = string.Empty;
        }        

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Show extensions
                this.openFileDialog.AddExtension = true;

                // Show only text files
                this.openFileDialog.Filter = "Text files|*.txt";

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.SourceFileTextBox.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                string message = $"Error: {ex.Message}";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult;

                dialogResult = MessageBox.Show(message, caption, buttons);

                if (dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.DestinationFilesTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                string message = $"Error: {ex.Message}";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult;

                dialogResult = MessageBox.Show(message, caption, buttons);

                if (dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            try
            {                
                this.OpenFileButton.Enabled = false;
                this.DestinationButton.Enabled = false;
                this.DownloadButton.Enabled = false;
                this.LogButton.Visible = false;

                successDownload = new List<string>();
                errorDownload = new List<string>();

                var lines = File.ReadLines(SourceFileTextBox.Text);

                int count = 0;
                int errorCount = 0;

                this.logLabel.Text = $"Download {count++} of {lines.Count()}";
                this.ErrorLogLabel.Text = $"Downloads failed: {errorCount++}";

                foreach (var line in lines)
                {
                    this.logLabel.Text = $"Download {count++} of {lines.Count()}";
                    this.logLabel.Refresh();

                    try
                    {
                        using (WebClient client = new WebClient())
                        {
                            Uri url = new Uri(line);

                            await client.DownloadFileTaskAsync(url, $"{DestinationFilesTextBox.Text}\\{url.Segments.Last()}");
                            successDownload.Add(line);
                        }
                    }
                    catch (Exception ex)
                    {
                        this.ErrorLogLabel.Text = $"Downloads failed: {errorCount++}";
                        this.ErrorLogLabel.Refresh();
                        errorDownload.Add("URL: " + line);
                        errorDownload.Add("Error: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = $"Error: {ex.Message}";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult dialogResult;

                dialogResult = MessageBox.Show(message, caption, buttons);

                if (dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
            finally
            {                
                this.OpenFileButton.Enabled = true;
                this.DestinationButton.Enabled = true;
                this.DownloadButton.Enabled = true;
                this.LogButton.Visible = true;
            }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "Log";
            sfd.Title = "Save Text File";


            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;

                using (StreamWriter bw = new StreamWriter(File.Create(path)))
                {
                    bw.WriteLine("=====SUCCESS=====");
                    foreach (var item in this.successDownload)
                    {
                        bw.WriteLine(item);
                    }

                    bw.WriteLine("");
                    bw.WriteLine("");

                    bw.WriteLine("=====ERROR=====");
                    foreach (var item in this.errorDownload)
                    {
                        bw.WriteLine(item);
                    }

                    bw.Close();
                }
            }
        }
    }
}
