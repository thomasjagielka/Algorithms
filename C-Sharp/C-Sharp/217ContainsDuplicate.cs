using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _217ContainsDuplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            return nums.Length != set.Count;
        }
    }
}
