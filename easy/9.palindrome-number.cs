/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        int length = x.ToString().Length;
        string[] chars = new string[length];
        int index = 0;
        while (x > 0)
        {
            chars[index] = (x % 10).ToString();
            x = x / 10;
            index++;
        }

        for (int i = 0; i < length/2; i++)
        {
            if(chars[i]!=chars[length-i-1])
            {
                return false;
            }
        }

        return true;
    }
}

