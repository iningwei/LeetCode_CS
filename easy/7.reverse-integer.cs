/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */
public class Solution
{
    public int Reverse(int x)
    {
        if (x > -10 && x < 10)
        {
            return x;
        }

        bool negative = false;
        if (x < 0)
        {
            negative = true;
            x = -x;
        }


        int rev = 0;
        while (x > 0)
        {
            int tmp = x % 10;
            x = x / 10;
            if (rev > int.MaxValue / 10)//rev*10>int.MaxValue 却不对！！！用例 1534236469 不通过
            {
                return 0;
            }
            rev = rev * 10 + tmp;
        }

        if (negative)
        {
            rev = -rev;
        }
        return rev;

    }
}

