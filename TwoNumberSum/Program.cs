using System;
using System.Collections.Generic;

namespace TwoNumberSum
{
    internal static class Program
    {
        public static void Main()
        {
            var data = TwoSum(new[] { 2, 7, 11, 15 }, 26);
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }
        }

        private static IEnumerable<int> TwoSum(IReadOnlyList<int> nums, in int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    return new[] { map[nums[i]], i };
                }
                
                map.Add(target - nums[i], i);
            }

            return null;
        }
    }
}