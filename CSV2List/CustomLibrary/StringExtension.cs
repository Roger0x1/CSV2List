using System;
using System.Collections.Generic;
using System.Text;

namespace CSV2List.CustomLibrary
{
    public static class StringExtension
    {
        public static string Truncate(this string value, int maxLength)                 //  because who knew that string didn't have a truncate method?
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value: value.Substring(0, maxLength);
        }

    }
}
