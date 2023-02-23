using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    // TODO:
    // Can you come up with an algorithm that is less than O(n2) time complexity?

    internal class _1TwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;

                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }

            return null;
        }
    }
}
