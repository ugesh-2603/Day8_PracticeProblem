using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_PracticeProblem
{
    internal class PatternCounter
    {
        public static int CountOccurrences(string input, string pattern)
        {
            
            Regex regex = new Regex(pattern);

            
            MatchCollection matches = regex.Matches(input);

           
            return matches.Count;
        }
    }
}
