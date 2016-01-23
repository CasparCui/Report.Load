using Microsoft.Office.Interop.Excel;
using System.IO;

namespace Report.Load
{
    public class LoadXlsxData
    {
        public string ExcelFilePath { get; set; }
        public string ExportFilesSavePath { get; set; }


        public LoadXlsxData(string excelFilePath,string exportFilesSavePath)
        {
            ExcelFilePath = excelFilePath;
            if(!File.Exists(excelFilePath))
            {
                throw new FileNotFoundException("File not find! Please check file path: {0}", excelFilePath);
            }
            else
            {
                FileInfo file = new FileInfo(excelFilePath);
                if (!file.Extension.Contains("xls"))
                {
                    throw new System.IO.IOException("This file is not an excel file! Please check file type.");
                }
            }
            ExportFilesSavePath = exportFilesSavePath;
            if(!Directory.Exists(exportFilesSavePath))
            {
                Directory.CreateDirectory(exportFilesSavePath);
            }
        }

        public void SaveSheetsIntoDiffTxtFiles(SaveFileFormat FileFormat)
        {
            var excel = new Application();
            var workBook = excel.Application.Workbooks.Open(ExcelFilePath);
            excel.Visible = false;
            excel.DisplayAlerts = false;
            var workBookName = workBook.Name;
            //workBook.SaveAs(ExportFilesSavePath + "\\" + "4", XlFileFormat.,Type.Missing,Type.Missing,Type.Missing,Type.Missing,XlSaveAsAccessMode.xlExclusive,Type.Missing,Type.Missing,Type.Missing,XlTextVisualLayoutType.xlTextVisualLTR,Type.Missing);
            var workSheets = workBook.Sheets;
            foreach(Microsoft.Office.Interop.Excel.Worksheet workSheet in workSheets)
            {
                workSheet.SaveAs(ExportFilesSavePath + "\\" + workBookName + "_" + workSheet.Name + "."+FileFormat.ToString().ToLower(), XlFileFormat.xlTextPrinter);
            }
            workBook.Save();
            excel.Quit();
        }
    }
    public enum SaveFileFormat
    {
        Txt = 0,
        Prn = 1, 
    }
}
