﻿using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Operations Class</summary>
    public class Operations
    {
        ///<summary>returns the max integer in a list of integers</summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }
            int maxInt = nums[0];
            foreach (int tmp in nums)
            {
                if (tmp > maxInt)
                {
                    maxInt = tmp;
                }
            }
            return maxInt;
        }
    }
}
