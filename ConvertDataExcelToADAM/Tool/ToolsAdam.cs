using ConvertDataExcelToADAM.Enitity;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataExcelToADAM.Tool
{
   public class ToolsAdam
    {
        //đưa dữ liệu từ DataTable và List
        public List<ExcelEnitity> AddData(DataTable dataExcel)
        {
            List<ExcelEnitity> listExcelOrigin = new List<ExcelEnitity>();
            foreach (DataRow row in dataExcel.Rows)
            {
                if (!String.IsNullOrEmpty(row.Field<string>(3)))
                {
                    if (!String.IsNullOrEmpty(row.Field<string>(4)))
                    {
                        ExcelEnitity enitity = new ExcelEnitity();
                        //enitity.SystemNumber = $"{num:000000000000}";
                        enitity.SystemNumber = row.Field<string>(3).Trim();
                        enitity.FileName = row.Field<string>(4).Trim();
                        enitity.BookTitle = row.Field<string>(1).Trim();
                        enitity.PublishingYear = row.Field<string>(2).Trim();
                        listExcelOrigin.Add(enitity);
                    }
                }
            }
            return listExcelOrigin;
        }
        //chuyển đổi dữ liệu sang Adam thô
        public List<AdamEnitity> AddDataAdam(List<ExcelEnitity> excelEnitities, string[] filePaths)
        {
            List<AdamEnitity> listAdamOrigin = new List<AdamEnitity>();
            foreach (ExcelEnitity enitity in excelEnitities)
            {
                AdamEnitity adamEnitity = new AdamEnitity();
                adamEnitity.SystemBib = enitity.SystemNumber;
                adamEnitity.SubLibrary = "AOF";
                String[] file = SplitFileName(enitity.FileName);
                adamEnitity.infoFileEnitities=(AddInfoFileEnitity(file, filePaths));
                listAdamOrigin.Add(adamEnitity);
            }
            return listAdamOrigin;
        }
        //thêm thông cho file
        public List<InfoFileEnitity> AddInfoFileEnitity(string[] files, string[] filePaths)
        {
            List<InfoFileEnitity> InfoFileEnititys = new List<InfoFileEnitity>();
            for (int i = 0; i < filePaths.Length; i++)
            {
                string Filename = getInfoName(filePaths[i]);
                string Extension = getInfoExtension(filePaths[i]);
                long ObjectSize = getInfoObjectSize(filePaths[i]);
                for (int j = 0; j < files.Length; j++)
                {
                    if (Filename.Contains(files[j].Trim()))
                    {
                        InfoFileEnitity enitity = new InfoFileEnitity();
                        enitity.Filename = getFileNameNoExtension(Filename);
                        enitity.Sequence = $"{j:000000}";
                        enitity.Extension = Extension.Replace(".","");
                        enitity.ObjectSize = ObjectSize.ToString();
                        InfoFileEnititys.Add(enitity);
                    }                    
                }
            }            
            return InfoFileEnititys;
        }
        public String[] SplitFileName(string fileNames)
        {
           return fileNames.Split(';');
        }

        public String getInfoName(string FilePath)
        {
            string fileName;
            fileName= Path.GetFileName(FilePath);
            return fileName;
        }
        public String getFileNameNoExtension(string fileName)
        {
            if (fileName.Contains("."))
            {
                int i = fileName.LastIndexOf(".");
                fileName = fileName.Substring(0,i);
            }
            return fileName;
        }
        public String getInfoExtension(string FilePath)
        {
            string extension;
            extension = Path.GetExtension(FilePath);
            return extension;
        }
        public long getInfoObjectSize(string FilePath)
        {
            return new FileInfo(FilePath).Length;
        }
        public string getDate()
        {
            string text = DateTime.Now.Year.ToString();
            string text2 = DateTime.Now.Month.ToString();
            string text3 = DateTime.Now.Day.ToString();
            string text4 = DateTime.Now.Hour.ToString();
            string text5 = DateTime.Now.Minute.ToString();
            string text6 = DateTime.Now.Second.ToString();
            return "_" + text + "." + text2 + "." + text3 + "_" + text4 + "." + text5;
        }
    }
}
