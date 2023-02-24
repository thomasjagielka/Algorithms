using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    static class _CountWords
    {
        static bool IsLatinLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public static int CountWords(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (IsLatinLetter(input[i]) && i == 0)
                    counter++;
                else if (!IsLatinLetter(input[i]) && IsLatinLetter(input[i + 1]))
                    counter++;
            }

            return counter;
        }
    }
}
