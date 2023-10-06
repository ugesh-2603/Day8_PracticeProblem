using System.Text.RegularExpressions;
using static Day8_PracticeProblem.Sequence;

namespace Day8_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueExecution = true;
            while (continueExecution)
            {
                Console.WriteLine("Please choose program to perform:");
                Console.WriteLine("1.Pattern Matches \n2.Sequence \n3.Occurances \n4.HTMLTag \n5.ImageFileType \n6.WebsiteValidator");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:

                        string input = "abbb"; 
                        string pattern = @"ab{2,3}";

                        PatternMatcher patternMatcher = new PatternMatcher(pattern);
                        bool isMatch = patternMatcher.IsMatch(input);

                        if (isMatch)
                        {
                            Console.WriteLine("The input string matches the pattern.");
                        }
                        else
                        {
                            Console.WriteLine("The input string does not match the pattern.");
                        }


                        break;

                    case 2:

                        string input1 = "abc_def_ghi jkl_mno"; // Input string
                        string pattern1 = @"[a-z]+_[a-z]+"; // Pattern

                        SequenceFinder sequenceFinder = new SequenceFinder(pattern1);
                        MatchCollection matches = sequenceFinder.FindSequences(input1);

                        if (matches.Count > 0)
                        {
                            Console.WriteLine("Sequences found:");
                            foreach (Match match in matches)
                            {
                                Console.WriteLine(match.Value);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No sequences found.");
                        }
                        break;

                    case 3:

                        string input2 = "foxes are omnivorous mammals belonging to several genera of the family Canidae fox.";
                        string pattern2 = @"fox(es)?";

                        int occurrenceCount = PatternCounter.CountOccurrences(input2, pattern2);

                        Console.WriteLine($"There are {occurrenceCount} occurrences.");

                        break;

                    case 4:

                        HtmlTagsFetcher.FetchHtmlTags();
                        break;

                    case 5:

                        ImageFileExtensionCheck.ExtensionChecker();
                        break;

                    case 6:

                        WebsiteValidator.ValidateWebsite();
                        break;


                }
                Console.WriteLine("Do you want to continue.(yes/no)");
                string userInput = Console.ReadLine();
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }
            Console.ReadLine();
        }
    }
}
        
    
