using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_PracticeProblem
{
    public class PatternMatcher
    {
        private readonly string pattern;

        public PatternMatcher(string pattern)
        {
            this.pattern = pattern;
        }

        public bool IsMatch(string input)
        {
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
    }
}
