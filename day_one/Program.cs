//still trying to solve part 2 this shi hard

using System;
using System.Text.RegularExpressions;
using System.Text;

class Program
{
    static void Main()
    {
      string ex = "nine1two";
      var pattern = @"(?=(one|two|three|four|five|six|seven|eight|nine|\d))";

      var transform = new Dictionary<string, string>
        {
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" },
            { "1", "1" },
            { "2", "2" },
            { "3", "3" },
            { "4", "4" },
            { "5", "5" },
            { "6", "6" },
            { "7", "7" },
            { "8", "8" },
            { "9", "9" }
        };

      var matches = Regex.Matches(ex, pattern);
      Console.WriteLine(transform[matches.First().Groups[1].Value]);
    }
}
