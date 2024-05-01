using Syncfusion.XlsIO;
using System.IO;
using System.Data;

namespace BlazorApp1.Data
{
    public class ExcelService
    {
        public MemoryStream CreateExcel(DataTable table)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Xlsx;
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet worksheet = workbook.Worksheets[0];
                worksheet.ImportDataTable(table, true, 1, 1);
                worksheet.UsedRange.AutofitColumns();
                using (MemoryStream stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream;
                }
            } 
        }


    }
}
