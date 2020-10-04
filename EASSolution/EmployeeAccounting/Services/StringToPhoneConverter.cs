using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmployeeAccounting.Services
{
    public class StringToPhoneConverter
    {
        public object Converter(long value)
        {
            if (value == null)
                return String.Empty;
            string phomeNumber = value.ToString().Replace("(", string.Empty).Replace(")", string.Empty).Replace(" ", string.Empty).Replace("-", string.Empty);

            switch (phomeNumber.Length)
            {
                case 7:
                    return Regex.Replace(phomeNumber, @"(\d{3})(\d{4})", "$1-$2");
                case 10:
                    return Regex.Replace(phomeNumber, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3");
                case 11:
                    return Regex.Replace(phomeNumber, @"(\d{1})(\d{3})(\d{3})(\d{4})", "$1-$2-$3-$4");
                default:
                    return phomeNumber;
            }
        }
    }
}
