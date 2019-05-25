/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        int minLen = strs[0].Length;
        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length < minLen)
            {
                minLen = strs[i].Length;
            }
        }


        string target = "";
        for (int i = 0; i < minLen; i++)
        {
            string strTmp = strs[0].Substring(0, i + 1);
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j].Substring(0, i + 1).Equals(strTmp) == false)
                {
                    return target;
                }
            }
            target = strTmp;
        }

        return target;
    }
}

