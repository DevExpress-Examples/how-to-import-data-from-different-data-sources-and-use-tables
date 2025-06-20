using DevExpress.Drawing;
using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataImportExample
{
    #region #converter
    class TestDataValueConverter : IDataValueConverter
    {

        public bool TryConvert(object value, int index, out CellValue result) {
                if (value is string) {
                    string strValue = value as string;
        
                    try
                    {
                        result = DXImage.FromBase64String(strValue);
                    }
                    catch
                    {
                        int str2int = 0;
        
                        if (Int32.TryParse(strValue, out str2int))
                            result = str2int;
                        else
                            result = strValue;
                    }
                    return true;
                }        
                result = DevExpress.Spreadsheet.CellValue.TryCreateFromObject(value);
                return true;
        }
    }
    #endregion #converter
}
