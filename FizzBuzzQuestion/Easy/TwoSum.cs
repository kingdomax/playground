using System;
using System.Collections.Generic;

namespace FizzBuzzQuestion.Easy
{
    /*
        Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        
        Given nums = [2, 7, 11, 15], target = 9,
        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1]
    */
    public static class TwoSum
    {
        public static int[] Calculate(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];

                var anotherIndex = 0;
                if (dict.TryGetValue(complement, out anotherIndex)) { return new int[] { anotherIndex, i }; }

                if (!dict.ContainsKey(nums[i])) { dict.Add(nums[i], i); }
            }

            throw new ArgumentException("No two sum solution");
        }
    }
}
