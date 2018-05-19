using System;
using System.Collections.Generic;

namespace FizzBuzzQuestion.Easy
{
    /*
        For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II.
        The number twenty seven is written as XXVII, which is XX + V + II. Roman numerals are usually written largest to smallest from left to right.
        Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.
        There are six instances where subtraction is used:

        I can be placed before V (5) and X (10) to make 4 and 9. 
        X can be placed before L (50) and C (100) to make 40 and 90. 
        C can be placed before D (500) and M (1000) to make 400 and 900.

        Input: "()"
        Output: true
        
        Input: "()[]{}"
        Output: true
        
        Input: "(]"
        Output: false
        
        Input: "([)]"
        Output: false
        
        Input: "{[]}"
        Output: true
     */
    public static class RomanToInteger
    {
        private static int NULL_VALUE = 0;
        private static IDictionary<char, int> TABLE = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        
        public static int Solution(string s) 
        {
            if (s.Length < 1) { throw new ArgumentException(); }
            
            var result = 0;
            var previousCharValue = NULL_VALUE; // for holding previous character
                
            foreach (var character in s)
            {
                // get current char value
                var currentCharValue = 0;
                TABLE.TryGetValue(character, out currentCharValue);
                
                // Handle 
                if (currentCharValue == 0) { continue; }
                
                // 1st condition
                if (previousCharValue == NULL_VALUE)
                {
                    previousCharValue = currentCharValue;
                    continue;
                }
                
                // 2nd condition (current > previous)
                var subtractValue = GetSubtractValue(currentCharValue, previousCharValue);
                if (subtractValue != NULL_VALUE)
                {
                    result += subtractValue;
                    previousCharValue = NULL_VALUE;
                    continue;
                }
                
                // 3rd condition (current <= previous)
                result += previousCharValue;
                previousCharValue = currentCharValue;
            }
            
            // clear last slot
            return (previousCharValue != NULL_VALUE) ? result + previousCharValue : result;
        }
        
        private static int GetSubtractValue(int currentCharValue, int previousCharValue)
        {
            if (currentCharValue <= previousCharValue) { return NULL_VALUE; }
            
            var diff = currentCharValue - previousCharValue;
            return (diff % 4 == 0 || diff % 9 == 0) ? diff : NULL_VALUE;
        }
    }
}