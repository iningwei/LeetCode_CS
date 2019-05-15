/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */
public class Solution
{
    public int RomanToInt(string s)
    {
        int value = 0;
        char[] strChar = s.ToCharArray();
        for (int i = strChar.Length - 1; i >= 0; i--)
        {
            char last = strChar[i];
            char last_1 = ' ';
            if (i >= 1)
            {
                last_1 = strChar[i - 1];
            }
            char last_2 = ' ';
            if (i >= 2)
            {
                last_2 = strChar[i - 2];
            }
            if ((last == last_1) && (last == last_2))
            {
                value += 3 * getValue(last);
                i-=2;
            }
            else if (last == last_1)
            {
                value += 2 * getValue(last);
                i--;
            }
            else if (last == 'V' && last_1 == 'I')
            {
                value += 4;
                i--;
            }
            else if (last == 'X' && last_1 == 'I')
            {
                value += 9;
                 i--;
            }
            else if (last == 'L' && last_1 == 'X')
            {
                value += 40;
                i--;
            }
            else if (last == 'C' && last_1 == 'X')
            {
                value += 90;
                i--;
            }
            else if (last == 'D' && last_1 == 'C')
            {
                value += 400;
                i--;
            }
            else if (last == 'M' && last_1 == 'C')
            {
                value += 900;
                i--;
            }
            else
            {
                value += getValue(last);
            }

        }

        return value;
    }

    private int getValue(char c)
    {
        switch (c)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
        }
        
        //wrong char
        return 0;
    }
}

