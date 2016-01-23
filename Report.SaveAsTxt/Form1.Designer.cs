namespace Report.SaveAsTxt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.XlsxFilePath = new System.Windows.Forms.Label();
            this.ExportPath = new System.Windows.Forms.Label();
            this.XlsxFilePathTextBox = new System.Windows.Forms.TextBox();
            this.ExportPathText = new System.Windows.Forms.TextBox();
            this.XlsxFileBrowser = new System.Windows.Forms.Button();
            this.ExportFolderBrowser = new System.Windows.Forms.Button();
            this.SaveAsFileFormat = new System.Windows.Forms.Label();
            this.FileFormatComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.XlsxFileBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ExportPathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.XlsxFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // XlsxFilePath
            // 
            this.XlsxFilePath.AutoSize = true;
            this.XlsxFilePath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XlsxFilePath.Location = new System.Drawing.Point(27, 41);
            this.XlsxFilePath.Name = "XlsxFilePath";
            this.XlsxFilePath.Size = new System.Drawing.Size(83, 17);
            this.XlsxFilePath.TabIndex = 0;
            this.XlsxFilePath.Text = "Xlsx File Path";
            // 
            // ExportPath
            // 
            this.ExportPath.AutoSize = true;
            this.ExportPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExportPath.Location = new System.Drawing.Point(27, 89);
            this.ExportPath.Name = "ExportPath";
            this.ExportPath.Size = new System.Drawing.Size(75, 17);
            this.ExportPath.TabIndex = 1;
            this.ExportPath.Text = "Export Path";
            // 
            // XlsxFilePathTextBox
            // 
            this.XlsxFilePathTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XlsxFilePathTextBox.Location = new System.Drawing.Point(138, 37);
            this.XlsxFilePathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XlsxFilePathTextBox.Name = "XlsxFilePathTextBox";
            this.XlsxFilePathTextBox.Size = new System.Drawing.Size(357, 23);
            this.XlsxFilePathTextBox.TabIndex = 2;
            // 
            // ExportPathText
            // 
            this.ExportPathText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExportPathText.Location = new System.Drawing.Point(138, 85);
            this.ExportPathText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportPathText.Name = "ExportPathText";
            this.ExportPathText.Size = new System.Drawing.Size(357, 23);
            this.ExportPathText.TabIndex = 3;
            // 
            // XlsxFileBrowser
            // 
            this.XlsxFileBrowser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XlsxFileBrowser.Location = new System.Drawing.Point(519, 34);
            this.XlsxFileBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XlsxFileBrowser.Name = "XlsxFileBrowser";
            this.XlsxFileBrowser.Size = new System.Drawing.Size(87, 33);
            this.XlsxFileBrowser.TabIndex = 4;
            this.XlsxFileBrowser.Text = "Browser..";
            this.XlsxFileBrowser.UseVisualStyleBackColor = true;
            this.XlsxFileBrowser.Click += new System.EventHandler(this.XlsxFileBrowser_Click);
            // 
            // ExportFolderBrowser
            // 
            this.ExportFolderBrowser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExportFolderBrowser.Location = new System.Drawing.Point(519, 82);
            this.ExportFolderBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportFolderBrowser.Name = "ExportFolderBrowser";
            this.ExportFolderBrowser.Size = new System.Drawing.Size(87, 33);
            this.ExportFolderBrowser.TabIndex = 5;
            this.ExportFolderBrowser.Text = "Browser..";
            this.ExportFolderBrowser.UseVisualStyleBackColor = true;
            this.ExportFolderBrowser.Click += new System.EventHandler(this.ExportFolderBrowser_Click);
            // 
            // SaveAsFileFormat
            // 
            this.SaveAsFileFormat.AutoSize = true;
            this.SaveAsFileFormat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveAsFileFormat.Location = new System.Drawing.Point(29, 133);
            this.SaveAsFileFormat.Name = "SaveAsFileFormat";
            this.SaveAsFileFormat.Size = new System.Drawing.Size(53, 17);
            this.SaveAsFileFormat.TabIndex = 6;
            this.SaveAsFileFormat.Text = "Save As";
            // 
            // FileFormatComboBox
            // 
            this.FileFormatComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileFormatComboBox.FormattingEnabled = true;
            this.FileFormatComboBox.Items.AddRange(new object[] {
            "Print Uncode Text(.txt)",
            "Print File(.prn)"});
            this.FileFormatComboBox.Location = new System.Drawing.Point(138, 129);
            this.FileFormatComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileFormatComboBox.Name = "FileFormatComboBox";
            this.FileFormatComboBox.Size = new System.Drawing.Size(193, 25);
            this.FileFormatComboBox.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveButton.Location = new System.Drawing.Point(519, 129);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 33);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Export";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // XlsxFileBrowserDialog
            // 
            this.XlsxFileBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.XlsxFileBrowserDialog.SelectedPath = "D:\\Users\\Caspar\\Desktop";
            this.XlsxFileBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // XlsxFileDialog
            // 
            this.XlsxFileDialog.CheckFileExists = true;
            this.XlsxFileDialog.OverwritePrompt = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 173);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FileFormatComboBox);
            this.Controls.Add(this.SaveAsFileFormat);
            this.Controls.Add(this.ExportFolderBrowser);
            this.Controls.Add(this.XlsxFileBrowser);
            this.Controls.Add(this.ExportPathText);
            this.Controls.Add(this.XlsxFilePathTextBox);
            this.Controls.Add(this.ExportPath);
            this.Controls.Add(this.XlsxFilePath);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Load Xlsx Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XlsxFilePath;
        private System.Windows.Forms.Label ExportPath;
        private System.Windows.Forms.TextBox XlsxFilePathTextBox;
        private System.Windows.Forms.TextBox ExportPathText;
        private System.Windows.Forms.Button XlsxFileBrowser;
        private System.Windows.Forms.Button ExportFolderBrowser;
        private System.Windows.Forms.Label SaveAsFileFormat;
        private System.Windows.Forms.ComboBox FileFormatComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FolderBrowserDialog XlsxFileBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog ExportPathBrowserDialog;
        private System.Windows.Forms.SaveFileDialog XlsxFileDialog;
    }
}

