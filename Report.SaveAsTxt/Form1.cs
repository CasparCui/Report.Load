using System;
using System.Windows.Forms;
using Report.Load;

namespace Report.SaveAsTxt
{
    public partial class Form1 : Form
    {
        private string xlsxFileFullPath = String.Empty;
        private string exportFolderPath = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void XlsxFileBrowser_Click(object sender, EventArgs e)
        {
            var result = this.XlsxFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                xlsxFileFullPath = this.XlsxFileDialog.FileName;
                this.XlsxFilePathTextBox.Text = xlsxFileFullPath;
                exportFolderPath = xlsxFileFullPath.Substring(0, xlsxFileFullPath.LastIndexOf("\\"));
                this.ExportPathText.Text = exportFolderPath;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ExportFolderBrowser_Click(object sender, EventArgs e)
        {
            var result = this.ExportPathBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                exportFolderPath = ExportPathBrowserDialog.SelectedPath;
                this.ExportPathText.Text = exportFolderPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FileFormatComboBox.SelectedItem = FileFormatComboBox.Items[0];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var saveFileFormat = Load_SaveFileFormatComboBox();
            try
            {
                
                var fileDataLoader = new LoadXlsxData(xlsxFileFullPath, exportFolderPath);
                fileDataLoader.SaveSheetsIntoDiffTxtFiles(saveFileFormat);
                MessageBox.Show("Export Finished!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(System.IO.IOException ioException)
            {
                MessageBox.Show(ioException.ToString(), "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private SaveFileFormat Load_SaveFileFormatComboBox()
        {
            switch(FileFormatComboBox.SelectedItem.ToString())
            {
                case "Print Uncode Text(.txt)":
                    return SaveFileFormat.Txt;
                case "Print File(.prn)":
                    return SaveFileFormat.Prn;
                default:
                    return SaveFileFormat.Txt;
            }

        }
    }
}
