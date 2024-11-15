using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterFormatter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            string[] lines = new string[n];
            for (int i = 0; i < n; i++)
                lines[i] = Console.ReadLine();

            foreach (var line in FormatLetter(k, n, lines))
                Console.WriteLine(line);
        }

        public static string[] FormatLetter(int k, int n, string[] lines)
        {
            var formattedLines = new List<string>();
            foreach (var line in lines)
            {
                string formatted = FormatLine(k, line);
                if (formatted == null)
                    return new[] { "Impossible." };
                formattedLines.Add(formatted);
            }
            return formattedLines.ToArray();
        }

        public static string FormatLine(int k, string line)
        {
            int contentLength = line.Trim().Length;
            if (contentLength > k) return null;

            int totalSpaces = k - contentLength;
            int leadingSpaces = totalSpaces / 2;
            int trailingSpaces = totalSpaces - leadingSpaces;

            return new string(' ', leadingSpaces) + line.Trim() + new string(' ', trailingSpaces);
        }

    }
}
