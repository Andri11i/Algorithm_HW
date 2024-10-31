using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_HW
{
    using System;

    static public class MissingNumberFinder
    {
        public static int FindMissingNumber(int[] nums, int n)
        {
      
            int expectedSum = n * (n + 1) / 2;

 
            int actualSum = 0;
            foreach (int num in nums)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }
    }

}
