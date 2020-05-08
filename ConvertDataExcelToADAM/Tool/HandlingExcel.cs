using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadPatronExcelAOF.Tool
{
    public class HandlingExcel
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public HandlingExcel()
        {
            log4net.Config.BasicConfigurator.Configure();
            log.Info("");
        }
        public DataTable ReadFromExcelfile(string path, string sheetName)
        {
            // Khởi tạo data table
            DataTable dt = new DataTable();
            // Load file excel và các setting ban đầu
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                if (package.Workbook.Worksheets.Count() < 1)
                { // Log - Không có sheet nào tồn tại trong file excel của bạn 
                    return null;
                }
                // Lấy Sheet đầu tiện trong file Excel để truy vấn 
                // Truyền vào name của Sheet để lấy ra sheet cần, nếu name = null thì lấy sheet đầu tiên 
                using (ExcelWorksheet workSheet = package.Workbook.Worksheets.FirstOrDefault(x => x.Name == sheetName) ?? package.Workbook.Worksheets.FirstOrDefault())
                {
                    // Đọc tất cả các header
                    foreach (var firstRowCell in workSheet.Cells[4, 1, 1, workSheet.Dimension.End.Column])
                    {
                        dt.Columns.Add(firstRowCell.Text);
                    }
                    // Đọc tất cả data bắt đầu từ row thứ 2
                    for (var rowNumber = 5; rowNumber <= workSheet.Dimension.End.Row; rowNumber++)
                    {
                        // Lấy 1 row trong excel để truy vấn
                        var row = workSheet.Cells[rowNumber, 1, rowNumber, workSheet.Dimension.End.Column];
                        // tạo 1 row trong data table
                        var newRow = dt.NewRow();
                        foreach (var cell in row)
                        {
                            newRow[cell.Start.Column - 1] = cell.Text;
                        }
                        dt.Rows.Add(newRow);
                    }
                }
            }
            return dt;
        }
        public void CreateExcelFile<T>(List<T> List, string filePath)
        {
            //var list = CreateTestItems();
            using (var excelPackage = new ExcelPackage())
            {
                // Tạo author cho file Excel
                excelPackage.Workbook.Properties.Author = "Tien-TED";
                // Tạo title cho file Excel
                excelPackage.Workbook.Properties.Title = "EPP test background";
                // thêm tí comments vào làm màu 
                excelPackage.Workbook.Properties.Comments = "This is my fucking generated Comments";
                // Add Sheet vào file Excel
                excelPackage.Workbook.Worksheets.Add("First Sheet");
                // Lấy Sheet bạn vừa mới tạo ra để thao tác 
                var workSheet = excelPackage.Workbook.Worksheets[1];
                // Đổ data vào Excel file
                workSheet.Cells[1, 1].LoadFromCollection(List, true, TableStyles.Dark9);
                // BindingFormatForExcel(workSheet, list);
                //excelPackage.Save();
                excelPackage.SaveAs(new FileInfo(filePath));
                //return excelPackage.Stream;
            }
        }
        //đếm số dòng của của DataGridView
        public void CountColumnDataGridView(DataGridView gdv, Label lb)
        {
            if (gdv.ColumnCount > 0)
            {
                lb.Text = "Số lượng: " + gdv.RowCount.ToString();
            }
        }

    }

}
