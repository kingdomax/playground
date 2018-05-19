using System;
using System.Linq;

namespace FizzBuzzQuestion.Easy
{
    /*
        Input: x = 1, y = 4
        Output: 2

        Explanation:
        1   (0 0 0 1)
        4   (0 1 0 0)
     */
    public static class HammingDistance
    {
        public static int Solution(int x, int y) => Convert.ToString(x ^ y, 2).Count(diff => diff == '1');
    }
}