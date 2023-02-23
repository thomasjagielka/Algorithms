using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _2103RingsAndRods
    {
        // TODO:
        // See if there is room for improvement.

        public static Dictionary<int, HashSet<char>> dict = new Dictionary<int, HashSet<char>>();

        public static int CountPoints(string rings)
        {
            for (int i = 0; i < rings.Length; i += 2)
            {
                if (dict.ContainsKey(rings[i + 1]))
                {
                    dict[rings[i + 1]].Add(rings[i]);
                }
                else
                {
                    dict.Add(rings[i + 1], new HashSet<char> { rings[i] });
                }
            }

            int count = 0;
            foreach (var item in dict)
            {
                if (item.Value.Count == 3)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
