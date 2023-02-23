using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _724FindPivotIndex
    {
        // TODO:
        // Improve time efficiency.

        public static int PivotIndex(int[] nums)
        {
            int leftMostSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int rightMostSum = 0;
                leftMostSum += nums[i];

                for (int j = i; j < nums.Length; j++)
                    rightMostSum += nums[j];

                if (leftMostSum == rightMostSum)
                    return i;
            }

            return -1;
        }
    }
}
