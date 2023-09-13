using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods
{
    public static class StringUtil
    {
        public static bool IsEmpty(string value, bool trim = true)
        {
            //if( value == null )
            if (value is null)
                return true;
            if (trim)
            {
                // (value.Trim().Equals(""))
                if (value.Trim() == "")
                    return true;
            }
            else
            {
                if (value == "")
                    return true;
            }
            return false;
        }
        public static bool IsNumeric(string valeu, out double number, string culture = "tr-TR")
        {
            return double.TryParse(valeu, NumberStyles.Number, new CultureInfo(culture), out number);
        }
    }
}
