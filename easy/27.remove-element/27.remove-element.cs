/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */
using System.Collections;
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                continue;
            }
            nums[index] = nums[i];
            index++;
        }
        return index;
    }
}

