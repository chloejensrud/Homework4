// Written By CHloe Jensrud
// 2/16/25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSwap
{
    public class Swap
    {
        public string FlipEndChar(string str)
        {
            if (str.Length < 2)
                return "Incompatiable.";
            if (str[0] == str[^1])
                return "Two's a pair.";

            char first = str[0];
            char last = str[^1];
            return last + str.Substring(1, str.Length -2) + first;
        }
    }
}
