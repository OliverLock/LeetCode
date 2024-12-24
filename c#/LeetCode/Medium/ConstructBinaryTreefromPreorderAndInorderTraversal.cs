using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    //TODO: Come back to
    /* Question 105:
     * https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
     * Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.
     * 
     * Example 1:
     * 
     * Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
     * Output: [3,9,20,null,null,15,7]
     * 
     * 
     * Example 2:
     * Input: preorder = [-1], inorder = [-1]
     * Output: [-1]
     * 
     * Constraints:
     * 
     * 1 <= preorder.length <= 3000
     * inorder.length == preorder.length
     * -3000 <= preorder[i], inorder[i] <= 3000
     * preorder and inorder consist of unique values.
     * Each value of inorder also appears in preorder.
     * preorder is guaranteed to be the preorder traversal of the tree.
     * inorder is guaranteed to be the inorder traversal of the tree.
    */
    public static class ConstructBinaryTreefromPreorderAndInorderTraversal
    {
        public static TreeNode Answer()
        {
            int[] preorder = { 3, 9, 20, 15, 7 },
                  inorder = { 9, 3, 15, 20, 7 };

            var tree = new TreeNode();

            foreach (var node in preorder)
            {
                tree.val = node;
                PopulateNode();

            }


            return new TreeNode();
        }

        private static TreeNode PopulateNode()
        { 
        


            return new TreeNode();
        }
    }



    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
