using System.Text.RegularExpressions;

namespace ConsoleApp.Helpers
{
    public static class InputHelper
    {
        private static readonly string PATTERN = @"([0-9]+)(x|X)([0-9]+)";
        public static int GetWidthFromInput(string input)
        {
            Regex regex = new Regex(PATTERN);
            Match match = regex.Match(input);
            string value = match.Groups[1].Value;
            return int.Parse(value);
        }

        public static int GetHeigthFromInput(string input)
        {
            Regex regex = new Regex(PATTERN);
            Match match = regex.Match(input);
            string value = match.Groups[3].Value;
            return int.Parse(value);
        }
    }
}
