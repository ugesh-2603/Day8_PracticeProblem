using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_PracticeProblem
{
    internal class Sequence
    {
        public class SequenceFinder
        {
            private readonly string pattern;

            public SequenceFinder(string pattern)
            {
                this.pattern = pattern;
            }

            public MatchCollection FindSequences(string input)
            {
                Regex regex = new Regex(pattern);
                return regex.Matches(input);
            }
        }
    }
}
