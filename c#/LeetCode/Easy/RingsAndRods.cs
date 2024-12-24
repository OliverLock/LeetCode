using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LeetCode.Easy
{
    /* Question 2103:
     *  https://leetcode.com/problems/rings-and-rods/
     * 
     * There are n rings and each ring is either red, green, or blue. The rings are distributed across ten rods labeled from 0 to 9.
     * 
     * You are given a string rings of length 2n that describes the n rings that are placed onto the rods. Every two characters in rings forms a color-position pair that is used to describe each ring where:
     * 
     * The first character of the ith pair denotes the ith ring's color ('R', 'G', 'B').
     * The second character of the ith pair denotes the rod that the ith ring is placed on ('0' to '9').
     * For example, "R3G2B1" describes n == 3 rings: a red ring placed onto the rod labeled 3, a green ring placed onto the rod labeled 2, and a blue ring placed onto the rod labeled 1.
     * 
     * Return the number of rods that have all three colors of rings on them.
     * 
     * 
     * Example 1:
     * 
     * Input: rings = "B0B6G0R6R0R6G9"
     * 
     * Output: 1
     * 
     * Explanation: 
     * - The rod labeled 0 holds 3 rings with all colors: red, green, and blue.
     * - The rod labeled 6 holds 3 rings, but it only has red and blue.
     * - The rod labeled 9 holds only a green ring.
     * Thus, the number of rods with all three colors is 1.
     */
    public static class RingsAndRods
    {
        public static int Answer()
        {
            string rings = "B0B6G0R6R0R6G9";

            var dict = new Dictionary<int, string>();

            for (int i = 0; i < rings.Count(); i += 2)
            {
                var key = Convert.ToInt32(rings[i + 1].ToString());

                if (dict.ContainsKey(key))
                {
                    dict[key] += rings[i].ToString();
                }
                else
                {
                    dict.Add(key, rings[i].ToString());
                }
            }
            return dict.Where(x => x.Value.Contains("R") && x.Value.Contains("G") && x.Value.Contains("B")).Count();

        }
    }
}
