namespace DownloadFiles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SourceFileTextBox = new System.Windows.Forms.TextBox();
            this.DestinationFilesTextBox = new System.Windows.Forms.TextBox();
            this.DestinationButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.logLabel = new System.Windows.Forms.Label();
            this.ErrorLogLabel = new System.Windows.Forms.Label();
            this.LogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(167, 33);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(104, 23);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open File...";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SourceFileTextBox
            // 
            this.SourceFileTextBox.Enabled = false;
            this.SourceFileTextBox.Location = new System.Drawing.Point(15, 35);
            this.SourceFileTextBox.Name = "SourceFileTextBox";
            this.SourceFileTextBox.Size = new System.Drawing.Size(143, 20);
            this.SourceFileTextBox.TabIndex = 1;
            // 
            // DestinationFilesTextBox
            // 
            this.DestinationFilesTextBox.Enabled = false;
            this.DestinationFilesTextBox.Location = new System.Drawing.Point(363, 35);
            this.DestinationFilesTextBox.Name = "DestinationFilesTextBox";
            this.DestinationFilesTextBox.Size = new System.Drawing.Size(143, 20);
            this.DestinationFilesTextBox.TabIndex = 3;
            // 
            // DestinationButton
            // 
            this.DestinationButton.Location = new System.Drawing.Point(515, 34);
            this.DestinationButton.Name = "DestinationButton";
            this.DestinationButton.Size = new System.Drawing.Size(104, 23);
            this.DestinationButton.TabIndex = 2;
            this.DestinationButton.Text = "Destination Path";
            this.DestinationButton.UseVisualStyleBackColor = true;
            this.DestinationButton.Click += new System.EventHandler(this.DestinationButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(228, 77);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(155, 23);
            this.DownloadButton.TabIndex = 4;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(12, 125);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(51, 13);
            this.logLabel.TabIndex = 5;
            this.logLabel.Text = "LogLabel";
            // 
            // ErrorLogLabel
            // 
            this.ErrorLogLabel.AutoSize = true;
            this.ErrorLogLabel.Location = new System.Drawing.Point(12, 165);
            this.ErrorLogLabel.Name = "ErrorLogLabel";
            this.ErrorLogLabel.Size = new System.Drawing.Size(73, 13);
            this.ErrorLogLabel.TabIndex = 6;
            this.ErrorLogLabel.Text = "ErrorLogLabel";
            // 
            // LogButton
            // 
            this.LogButton.Location = new System.Drawing.Point(12, 190);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(87, 23);
            this.LogButton.TabIndex = 7;
            this.LogButton.Text = "Log File";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Visible = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 222);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.ErrorLogLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.DestinationFilesTextBox);
            this.Controls.Add(this.DestinationButton);
            this.Controls.Add(this.SourceFileTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "Form1";
            this.Text = "Download Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox SourceFileTextBox;
        private System.Windows.Forms.TextBox DestinationFilesTextBox;
        private System.Windows.Forms.Button DestinationButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label ErrorLogLabel;
        private System.Windows.Forms.Button LogButton;
    }
}

