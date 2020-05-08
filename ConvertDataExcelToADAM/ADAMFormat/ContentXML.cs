using ConvertDataExcelToADAM.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataExcelToADAM.ADAMFormat
{
  public  class ContentXML
    {
        public StringBuilder getContentXML(AdamEnitity adam)
        {
            StringBuilder sb = new StringBuilder();
            foreach(InfoFileEnitity enitity in adam.infoFileEnitities)
            {
                sb.Append("<z403>");
                sb.Append("<z403-doc-number>" + adam.SystemBib + "</z403-doc-number>");
                sb.Append("<z403-sequence>" + enitity.Sequence + "</z403-sequence>");
                sb.Append("<z403-derived-from-sequence>000000</z403-derived-from-sequence>");
                sb.Append("<z403-title></z403-title>");
                sb.Append("<z403-f-directory>/exlibris/aleph/a23_1/aof01/import_files/import/</z403-f-directory>");
                sb.Append("<z403-f-filename>" + enitity.Filename + "</z403-f-filename>");
                sb.Append("<z403-original-file-name>" + enitity.Filename + "</z403-original-file-name>");
                sb.Append("<z403-object-extension>" + enitity.Extension + "</z403-object-extension>");
                sb.Append("<z403-object-size>" + enitity.ObjectSize + "</z403-object-size>");
                sb.Append("<z403-u-path></z403-u-path>");
                sb.Append("<z403-usage-type>VIEW</z403-usage-type>");
                sb.Append("<z403-sub-library>" + adam.SubLibrary + "</z403-sub-library>");
                sb.Append("<z403-note-1></z403-note-1>");
                sb.Append("<z403-note-2></z403-note-2>");
                sb.Append("<z403-note-3></z403-note-3>");
                sb.Append("<z403-note-4></z403-note-4>");
                sb.Append("<z403-note-5></z403-note-5>");
                sb.Append("<z403-open-date>00000000</z403-open-date>");
                sb.Append("<z403-update-date>00000000</z403-update-date>");
                sb.Append("<z403-cataloger></z403-cataloger>");
                sb.Append("<z403-character-set></z403-character-set>");
                sb.Append("<z403-color-setting></z403-color-setting>");
                sb.Append("<z403-resolution></z403-resolution>");
                sb.Append("<z403-dimensions></z403-dimensions>");
                sb.Append("<z403-compression-ratio></z403-compression-ratio>");
                sb.Append("<z403-creation-date>00000000</z403-creation-date>");
                sb.Append("<z403-creation-hardware></z403-creation-hardware>");
                sb.Append("<z403-creation-software></z403-creation-software>");
                sb.Append("<z403-copyright-contact></z403-copyright-contact>");
                sb.Append("<z403-copyright-owner></z403-copyright-owner>");
                sb.Append("<z403-copyright-type></z403-copyright-type>");
                sb.Append("<z403-copyright-note></z403-copyright-note>");
                sb.Append("<z403-copyright-notice></z403-copyright-notice>");
                sb.Append("<z403-copyright-notice-type></z403-copyright-notice-type>");
                sb.Append("<z403-display-link></z403-display-link>");
                sb.Append("<z403-display-code></z403-display-code>");
                sb.Append("<z403-expiry-date>00000000</z403-expiry-date>");
                sb.Append("<z403-guest>N</z403-guest>");
                sb.Append("<z403-ip-address></z403-ip-address>");
                sb.Append("<z403-course></z403-course>");
                sb.Append("<z403-user-status></z403-user-status>");
                sb.Append("<z403-restrict-sub-library></z403-restrict-sub-library>");
                sb.Append("<z403-no-of-copies>000</z403-no-of-copies>");
                sb.Append("<z403-view-time>000</z403-view-time>");
                sb.Append("<z403-item-library></z403-item-library>");
                sb.Append("<z403-item-doc-number>000000000</z403-item-doc-number>");
                sb.Append("<z403-item-sequence>000000</z403-item-sequence>");
                sb.Append("<z403-enumeration-a></z403-enumeration-a>");
                sb.Append("<z403-enumeration-b></z403-enumeration-b>");
                sb.Append("<z403-enumeration-c></z403-enumeration-c>");
                sb.Append("<z403-chronological-i></z403-chronological-i>");
                sb.Append("<z403-chronological-j></z403-chronological-j>");
                sb.Append("<z403-pid></z403-pid>");
                sb.Append("<z403-stream-link></z403-stream-link>");
                sb.Append("<z403-ip-address-v6></z403-ip-address-v6>");
                sb.Append("</z403>");
            }
            
            return sb;
        }
        
    }
}
