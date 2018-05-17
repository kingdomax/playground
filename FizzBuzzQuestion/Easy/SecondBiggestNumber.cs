using System;

namespace FizzBuzzQuestion.Easy
{
    /*
        Find the second biggest number in the interger array
        
        Given array = [40, 20, 10, 30, 50]
        return 40
    */
    public class SecondBiggestNumber
    {
        public static int Calculate(int[] nums)
        {
            if (nums.Length < 1) { throw new ArgumentException("No two sum solution"); }
            
            int biggestNumber = nums[0];
            int secondBiggestNumber = nums[0];

            for (var i=1; i < nums.Length; i++)
            {
                var isThisNewBiggestValue = nums[i] > biggestNumber;
                var isThisNewSecondBiggestValue = nums[i] > secondBiggestNumber;

                secondBiggestNumber = (isThisNewBiggestValue) ? biggestNumber :
                                        (isThisNewSecondBiggestValue) ? nums[i] :
                                            secondBiggestNumber;
                biggestNumber = (isThisNewBiggestValue) ? nums[i] : biggestNumber;
            }

            return secondBiggestNumber;
        }
    }
}