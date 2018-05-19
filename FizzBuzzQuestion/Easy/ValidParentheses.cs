using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzzQuestion.Easy
{
    /*
        Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        An input string is valid if:
            - Open brackets must be closed by the same type of brackets.
            - Open brackets must be closed in the correct order.
        
        Note that an empty string is also considered valid.

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
    public static class ValidParentheses
    {
        private static IDictionary<char, char> PARENTHESIS_RULE = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };
    
        public static bool Solution(string s) 
        {   
            // 0) handle as requirement
            if (String.IsNullOrEmpty(s)) { return true; }
            
            var charStack = new Stack();
            foreach (var character in s)
            {
                // 1) check current character is 'open bracket' or not
                char temp;
                PARENTHESIS_RULE.TryGetValue(character, out temp);
                
                // 2) if yes push to stack
                if (temp != '\0') 
                { 
                    charStack.Push(character); 
                    continue;
                }
                
                // 3) if no, check that is there anything in stack
                if (charStack.Count == 0) { return false; }
                
                // 4) compare compatibility
                var lastElementInStack = (char) charStack.Pop();
                PARENTHESIS_RULE.TryGetValue(lastElementInStack, out temp);
                if (character != temp) { return false; }
            }
            
            return charStack.Count == 0;
        }
    }
}