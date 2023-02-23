using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _53MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int first = int.MinValue;
            int second = int.MinValue;

            foreach (int num in nums)
            {
                if (num > first && num > second)
                {
                    if (num > second)
                        second = first;

                    first = num;
                }
                else if (num > second)
                    second = num;
            }

            return first + second;
        }
    }
}
