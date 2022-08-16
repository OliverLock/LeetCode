using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*Write a function to find the longest common prefix string amongst an array of strings.
     * If there is no common prefix, return an empty string "".
     * 
     * Example 1:
     * Input: strs = ["flower","flow","flight"]
     * Output: "fl"
     * Example 2:
     * Input: strs = ["dog","racecar","car"]
     * 
     * Output: ""
     * Explanation: There is no common prefix among the input strings.
     * 
     * Constraints:
     * 1 <= strs.length <= 200
     * 0 <= strs[i].length <= 200
     * strs[i] consists of only lowercase English letters.
     */

    public static class LongestCommonPrefix
    {
        public static string Answer()
        {
            string[] strs = { "flower", "flow", "flight" };
            var output = "";
            var charCount = 0;
            var outputTemp = "";
            List<char[]> charsList = new List<char[]>();

            if (strs.Count() == 0)
                return "";
            if (strs.Count() == 1)
                return strs[0];


            for (int i = 0; i <= strs.Count() - 1; i++)
            {
                var charArray = strs[i].ToCharArray();
                charsList.Add(charArray);
            }
            while (charCount < charsList[0].Count())
            {

                outputTemp += charsList[0][charCount];
                foreach (var item in charsList)
                {
                    if (charCount > item.Count() - 1)
                    {
                        return output;
                    }
                    if (outputTemp[charCount] != item[charCount])
                    {
                        return output;
                    }
                }
                output += charsList[0][charCount];
                charCount++;
            }

            return output;
        }
    }
}
