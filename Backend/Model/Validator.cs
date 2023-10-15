using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    public static class Validator
    {
        public static bool ValidateValue(object value, Type type)
        {
            if (type == typeof(int))
                return ValidateInt(value);
            if (type == typeof(double))
                return ValidateDouble(value);
            if (type == typeof(string))
                return ValidateString(value);
            if (type == typeof(DateTime))
                return ValidateDateTime(value);
            return false;
        }

        private static bool ValidateInt(object value)
        {
            int intValue;
            return int.TryParse(value.ToString(), out intValue);
        }

        private static bool ValidateDouble(object value)
        {
            double doubleValue;
            return double.TryParse(value.ToString(), out doubleValue);
        }

        private static bool ValidateString(object value)
        {
            if (value is string stringValue)
            {
                return !string.IsNullOrEmpty(stringValue);
            }

            return false;
        }

        private static bool ValidateDateTime(object value)
        {
            DateTime dateTimeValue;
            return DateTime.TryParse(value.ToString(), out dateTimeValue);
        }
    }
}