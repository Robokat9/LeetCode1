using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[2];
            int[] arr = { 1, 3, 3, 4, 5 };
            result = TwoSum(arr, 6);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] arr = new int[2]; 
            for (int i=0; i < nums.Length; i++)
            {
                int t = target - nums[i];

                if (nums.Contains(t))
                {
                    int k = Array.IndexOf(nums, t);
                    if (k != i)
                    {
                        arr[0] = i;
                        arr[1] = k;
                    }
                }
            }
           
            return arr;
        }
    }
}
