using System;
using System.Collections.Generic;

namespace MyMath
{

    /// <sumary> This class contains multiple operations</sumary>
    public class Operations
    {
        /// <sumary>max integer of a list of numbers</sumary>
        /// <return>max integer inside given list</return>
        public static int Max(List<int> nums)
        {
            try
            {
                int MaxNum = nums[0];

                for (int i = 0; i < nums.Count; i++)
                {
                    if (MaxNum < nums[i])
                        MaxNum = nums[i];
                }
                return MaxNum;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
