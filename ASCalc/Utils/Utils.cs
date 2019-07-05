using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ASCalc.Utils
{
    static class Utils
    {
       public static Dictionary<char, int> operValue = new Dictionary<char, int>()
        {
            {'+', 0},
            {'-', 0},
            {'*', 1},
            {'/', 2},
        };

       public static Regex operRegex = new Regex(@"^[\+\-\*\/]$");
    }
}
