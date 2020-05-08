using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataExcelToADAM.ADAMFormat
{
  public  class HeaderXml
    {
        public StringBuilder getHeaderXml(StringBuilder ContentSB)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            sb.Append("<file>");
            sb.Append(ContentSB);
            sb.Append("</file>");
            return sb;
        }
    }
}
