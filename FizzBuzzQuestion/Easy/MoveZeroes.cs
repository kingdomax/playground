using System.Collections.Generic;

namespace FizzBuzzQuestion.Easy
{
    public static class MoveZeroes
    {
        // O(n)
        public static void Solution(int[] nums)
        {
            // track index for non-zeroes
            var index = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if(nums[i]==0) { continue; }
            
                var temp =  nums[index];
                nums[index] = nums[i];
                nums[i] = temp;
                index++;
            }
        }

        // O(n^2)
        public static void NaiveSolution(int[] nums)
        {
            // 1) check how many '0' in input
            var zeroPosition = new List<int>();
            for (var i=0; i<nums.Length; i++) { if(nums[i]==0) zeroPosition.Add(i); }
        
            // 2) handle 
            if (zeroPosition.Count == 0 || zeroPosition.Count == nums.Length) { return; }
            
            // 3) swap position of zero in single array
            for(var j=0; j<zeroPosition.Count; j++) 
            { 
                var index = zeroPosition[j];
                MoveAzeroToLast(ref nums, index);
            }
        }

        private static void MoveAzeroToLast(ref int[] nums, int index)
        {
            var lastSwapIndex = index;
            for (var i=lastSwapIndex; i < nums.Length; i++)
            {
                // don't swap other '0' in array
                if (nums[i] == 0) { continue; }
                
                // replace last known position with 0
                nums[lastSwapIndex] = nums[i];
                nums[i] = 0;
                lastSwapIndex = i;
            }
        }
    }
}