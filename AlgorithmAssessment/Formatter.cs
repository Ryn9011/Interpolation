using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmAssessment
{
    public class Formatter : IFormatter<string, Dictionary<string, string>>
    {
        public string FormatInput(string input, Dictionary<string, string> values)
        {
            if (string.IsNullOrEmpty(input) || values == null || values.Count == 0)
                return input;

            StringBuilder patternSb = new StringBuilder();

            patternSb.Append("(");

            foreach (var tokenKey in values.Keys)
            {
                if (patternSb.Length > 1)
                {
                    patternSb.Append("|");
                }
                patternSb.Append(Regex.Escape("[" + tokenKey + "]"));
            }

            Console.WriteLine(patternSb.ToString());


            patternSb.Append(")");

            var regex = new Regex(patternSb.ToString());

            var result = regex.Replace(input, match => values[match.Value.Trim('[', ']')]);

            return result;
        }
    }
}