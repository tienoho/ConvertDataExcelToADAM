using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataExcelToADAM.ADAMFormat
{
    public class RecordXML
    {
        public StringBuilder getRecordXml(string systemBib)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<record xmlns=\"http://www.loc.gov/MARC21/slim\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.loc.gov/MARC21/slim http://www.loc.gov/standards/marcxml/schema/MARC21slim.xsd\">");
            sb.Append("<controlfield tag=\"SYS\">"+ systemBib + "</controlfield>");
            sb.Append("</record>");
            return sb;
        }
    }
}
