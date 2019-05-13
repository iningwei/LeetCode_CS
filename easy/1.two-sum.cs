/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // for (int i = 0; i < nums.Length; i++)
        // {             
        //     for (int j = (i + 1); j < nums.Length; j++)
        //     {               
        //         if ((nums[i] + nums[j]) == target)
        //         {                    
        //             return new int[]{i,j};
        //         }
        //     }
        // }
        // throw new System.Exception("can not find solution");





        Hashtable h = new Hashtable();

        for (int i = 0; i < nums.Length; i++)
        {
            h[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (h.ContainsKey(complement) && (int)h[complement] != i)
            {
                return new int[] { i, (int)h[complement] };
            }
        }
        throw new System.Exception("can not find solution");



        // Hashtable h = new Hashtable();         
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     int complement = target - nums[i];
        //     if (h.ContainsKey(complement) && (int)h[complement] != i)
        //     {
        //         return new int[] { i, (int)h[complement] };
        //     }
        //     else
        //     {                
        //         h[nums[i]]=i;
        //     }
        // }
        // throw new System.Exception("can not find solution");



        // var numAndIndex = new Dictionary<int, int>();
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     var curNumber = nums[i];
        //     var numberA = target - curNumber;

        //     if (numAndIndex.ContainsKey(numberA))
        //     {
        //         return new int[] { numAndIndex[numberA], i };
        //     }

        //     numAndIndex[curNumber] = i;
        // }
        // throw new System.Exception("can not find solution");
    }
}

