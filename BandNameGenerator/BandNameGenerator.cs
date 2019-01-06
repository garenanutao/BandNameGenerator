using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public class Kata
    {
        public static string BandNameGenerator(string str)
        {
            if (str == null) return "n/a";
            char firstChar = (char)((int)str[0] - 32);
            string restOfStr = str.Substring(1, str.Length - 1);
            if (str[0] != str[str.Length - 1]) return ("The " + firstChar + restOfStr);
            else return (firstChar + restOfStr + restOfStr);
        }
    }
}
