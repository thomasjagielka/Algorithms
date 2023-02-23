using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _53MaximumSubarray
    {
        // TODO:
        // Fix Time Limit Exceeded.
        // Improve time efficiency.

        public static int MaxSubArray(int[] nums)
        {
            List<int> biggestSumSubarray = new List<int>{ int.MinValue };

            for (int i = 0; i < nums.Length; i++) 
            {
                int sum = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];

                    if (biggestSumSubarray.Sum() < sum)
                    {
                        biggestSumSubarray = new List<int>();

                        for (int k = i; k <= j; k++)
                        {
                            biggestSumSubarray.Add(nums[k]);
                        }
                    }
                }
            }

            return biggestSumSubarray.Sum();
        }
    }
}
