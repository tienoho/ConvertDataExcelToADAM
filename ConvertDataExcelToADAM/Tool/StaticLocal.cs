using ConvertDataExcelToADAM.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataExcelToADAM.Tool
{
    public static class StaticLocal
    {
        public static string pathUserLog = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\ConvertLog";
        public static List<AdamEnitity> ListAdamOrigin { get; set; }
        public static List<ExcelEnitity> AddDataOrigin { get; set; }
        public static string[] files { get; set; }
    }
}
