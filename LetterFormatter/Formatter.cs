using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterFormatter
{
    public class Formatter
    {
        public static string[] FormatLetter(int k, int n, string[] lines)
        {
            // Заглушка: всегда возвращает null
            return null;
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
