/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

public class Solution
{                     
    public int[] TwoSum(int[] nums, int target)
    {        
        Hashtable h = new Hashtable();         
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (h.ContainsKey(complement) && (int)h[complement] != i)
            {
                return new int[] { i, (int)h[complement] };
            }
            else
            {                
                h[nums[i]]=i;
            }
        }
        throw new System.Exception("can not find solution");
    }
}

