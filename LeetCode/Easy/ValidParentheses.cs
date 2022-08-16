using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /* Question 20 Valid Parentheses:
     * https://leetcode.com/problems/valid-parentheses/
     * 
     * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
     * 
     * An input string is valid if:
     * Open brackets must be closed by the same type of brackets.
     * Open brackets must be closed in the correct order.
     * 
     * Example 1:
     * Input: s = "()"
     * Output: true
     * 
     * 
     * Example 2:
     * Input: s = "()[]{}"
     * Output: true
     * 
     * 
     * Example 3:
     * Input: s = "(]"
     * Output: false
     * 
     * 
     * Constraints:
     * 1 <= s.length <= 104
     * s consists of parentheses only '()[]{}'.
     * 
     */

    public static class ValidParentheses
    {
        public static bool AnswerRefactored()
        {
            var s = "{()}";

            var dict = new Dictionary<char, char>()
            {
               {'}', '{'},
               {']', '['},
               {')', '('}
            };

            Stack<char> stack = new Stack<char>();


            foreach (char ch in s)
            {
                if (dict.ContainsValue(ch))
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    var removed = stack.Pop();
                    if ((char)dict[ch] != removed)
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }


        public static bool Answer()
        {
            var s = "]";

            var stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (ch == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (ch == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else if (ch == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
