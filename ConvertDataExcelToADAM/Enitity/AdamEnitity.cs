using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataExcelToADAM.Enitity
{
   public class AdamEnitity
    {
        public string SystemBib { get; set; }
        public List<InfoFileEnitity> infoFileEnitities { get; set; }
        public string SubLibrary { get; set; }
    }
}
