using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    //Question 14
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
