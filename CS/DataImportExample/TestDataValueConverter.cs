using DevExpress.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataImportExample
{
    #region #converter
    class TestDataValueConverter : DevExpress.Spreadsheet.IDataValueConverter
    {
        public bool TryConvert(object value, int columnIndex, out DevExpress.Spreadsheet.CellValue result)
        {
            switch (value)
            {
                case string strValue:
                    try
                    {
                        result = DXImage.FromBase64String(strValue);
                    }
                    catch
                    {
                        int str2int = 0;
                        if (Int32.TryParse(strValue, out str2int))
                        {
                            result = str2int;
                        }
                        else
                        {
                            result = strValue;
                        }
                    }
                    return true;
                case int intValue:
                    result = intValue;
                    return true;
                case bool boolValue:
                    result = boolValue;
                    return true;
                default:
                    result = value == null ? null : value.ToString();
                    return true;
            }
        }
    }
    #endregion #converter
}
