using Report.Load;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var xlsxLoad = new LoadXlsxData(@"D:\Users\Caspar\Desktop\1.xlsx", @"D:\Users\Caspar\Desktop");
            xlsxLoad.SaveSheetsIntoDiffTxtFiles(SaveFileFormat.Txt);

        }
    }
}
