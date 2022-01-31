using System.Text.RegularExpressions;

namespace Controller.Helpers
{
    public static class InputHelper
    {
        private static readonly string SIZE_PATTERN = @"([0-9]+)(x|X)([0-9]+)";

        public static int GetWidthFromInput(string input)
        {
            Regex regex = new Regex(SIZE_PATTERN);
            Match match = regex.Match(input);
            string width = match.Groups[1].Value;
            return int.Parse(width);
        }

        public static int GetHeigthFromInput(string input)
        {
            Regex regex = new Regex(SIZE_PATTERN);
            Match match = regex.Match(input);
            string heigth = match.Groups[3].Value;
            return int.Parse(heigth);
        }

        public static List<char> GetCharsFromInput(string input)
        {
            List<char> charsToKeep = new List<char> { 'F', 'R', 'L' };
            string newInput = string.Empty;
            foreach (char c in input) {
                if (charsToKeep.Contains(c)) {
                    newInput += c.ToString();
                }
            }
            return newInput.ToList<char>();
        }
    }
}
