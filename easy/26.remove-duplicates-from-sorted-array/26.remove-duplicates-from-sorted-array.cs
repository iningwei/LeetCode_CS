/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */
using System.Collections;
using System.Collections.Generic;
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        Hashtable map = new Hashtable();
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.Contains(nums[i]))
            {
                continue;
            }
            map[nums[i]] = index;
            nums[index] = nums[i];
            index++;
        }
        return map.Count;
    }
}

