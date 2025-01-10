using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            int len = nums.Count;
            if (len == 0 || nums == null)
                return 0;
            nums.Sort();
            return nums[len -1];
        }
    }
}
