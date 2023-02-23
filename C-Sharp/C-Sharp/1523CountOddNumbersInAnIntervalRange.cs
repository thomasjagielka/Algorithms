using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _1523CountOddNumbersInAnIntervalRange
    {
        public static int CountOdds(int low, int high)
        {
            if ((low & 1) == 0) low++;
            return low > high ? 0 : (high - low) / 2 + 1;
        }
    }
}
