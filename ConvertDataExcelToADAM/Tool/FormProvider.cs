using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertDataExcelToADAM.UserControlGui;

namespace ConvertDataExcelToADAM.Tool
{
    public class FormProvider
    {
        private static UCConvertDataXML _mainMenu;
        public static UCConvertDataXML MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new UCConvertDataXML();
                }
                return _mainMenu;
            }
        }
    }
}
