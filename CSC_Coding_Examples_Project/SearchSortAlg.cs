using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    class SearchSortAlg
    {
        public static int FindMin(int[] arr)
        {
            int minValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                // if the value of arr sub i is less than
                // the min value, make minvalue equal to
                // arr sub i.
                if (arr[i] < minValue)
                    minValue = arr[i];
            }

            return minValue;
        }

        // Change method above to find the maximum
        public static int FindMax(int[] arr)
        {
            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                // the searching algorithm stays the same
                // the result we are looking for is the greater
                // than, so we simply change packman.
                if (arr[i] > maxValue)
                    maxValue = arr[i];
            }

            return maxValue;
        }
    }
}
