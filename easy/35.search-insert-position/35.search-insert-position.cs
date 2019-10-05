/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int len=nums.Length;
        if(target<=nums[0]){
            return 0;
        }
        if(target>nums[len-1]){
            return len;
        }
        for (int i = 0; i < len; i++)
        {
            if(target==nums[i]){
                return i;
            }
        }
    }
}

