using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace LeetCode.Easy
{
    /* Question 1941:
     * Given a string s, return true if s is a good string, or false otherwise.
     * 
     * A string s is good if all the characters that appear in s have the same number of occurrences (i.e., the same frequency).
     * 
     * Example 1:
     * 
     * Input: s = "abacbc"
     * Output: true
     * Explanation: The characters that appear in s are 'a', 'b', and 'c'. All characters occur 2 times in s.
     * 
     * 
     * Example 2:
     * 
     * Input: s = "aaabb"
     * Output: false
     * Explanation: The characters that appear in s are 'a' and 'b'. 'a' occurs 3 times while 'b' occurs 2 times, which is not the same number of times.
     * 
     * Constraints:
     * 1 <= s.length <= 1000
     * s consists of lowercase English letters.
     */

    public static class CheckIfAllCharactersHaveEqualNumberofOccurrences
    {
        public static bool AnswerPerformant()
        {
            string s = "abacbc";
            var dict = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                { 
                    dict.Add(ch, 1);
                }
            }
            return dict.All(x => x.Value == dict.FirstOrDefault().Value);

        }

        public static bool AnswerRefactored()
        {
            string s = "abacbc";
            var charArray = s.ToCharArray();
            var count = 0;
            var firstCount = s.Count(a => a == s[0]);
            foreach (var ch in charArray)
            {
                count = s.Count(a => a == ch);
                if (count != firstCount)
                {
                    return false;
                }
            }
            return true;
        }


        public static bool Answer()
        {
            string s = "aaabb";
            var charArray = s.ToCharArray();
            var numberOfFirstInstance = 0;


            for (int i = 0; i < charArray.Count(); i++)
            {
                var counterOfInstance = 0;
                for (int j = 0; j < charArray.Count(); j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        if (i == 0)
                        {
                            numberOfFirstInstance++;
                            counterOfInstance++;
                        }
                        if (i != 0)
                        {
                            counterOfInstance++;
                        }
                    }
                }
                if (counterOfInstance != numberOfFirstInstance)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
