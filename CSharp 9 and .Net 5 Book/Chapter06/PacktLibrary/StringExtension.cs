using System;
using System.Collections.Generic;
using static System.Console;
using System.Text.RegularExpressions;

namespace Packt.Shared
{
    public static class StringExtension
    {
        public static bool IsValidMail(this string input)
        {
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}
