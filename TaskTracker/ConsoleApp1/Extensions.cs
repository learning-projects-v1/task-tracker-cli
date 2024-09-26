using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public static class StringExtensions
{
    public static bool StartsAndEndsWithQuotes(this string input)
    {
        return input.StartsWith("\"") && input.EndsWith("\"");
    }

    public static bool isInteger(this string input)
    {
        return int.TryParse(input, out var integer);
    }
}

