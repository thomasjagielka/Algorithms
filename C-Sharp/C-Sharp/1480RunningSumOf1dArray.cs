using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class _1480RunningSumOf1dArray
    {
        public static int[] RunningSum(int[] nums)
        {
            int counter = 0;
            int[] runningNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j <= counter; j++)
                    sum += nums[j];

                runningNums[i] = sum;
                counter++;
            }

            return runningNums;
        }
    }
}
