using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8Assignment
{
    public class MatchingString
    {
        public void MethodString()
        {
            string input1 = "abb";      // Match
            string input2 = "abbb";     // Match
            string input3 = "abtfui";    // No match
            string input4 = "acbb";     // No match

            string pattern = @"ab{2,3}";

            Console.WriteLine("Matching pattern: " + pattern);
            Console.WriteLine();

            MatchString(input1, pattern);
            MatchString(input2, pattern);
            MatchString(input3, pattern);
            MatchString(input4, pattern);
        }

        public static void MatchString(string input, string pattern)
        {
            bool isMatch = Regex.IsMatch(input, pattern);

            Console.WriteLine("Input: " + input);
            Console.WriteLine("Match: " + isMatch);
            Console.WriteLine();
        }
    }
}
