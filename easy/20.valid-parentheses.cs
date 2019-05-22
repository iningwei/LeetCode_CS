/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */
using System.Collections;
using System.Collections.Generic;
public class Solution
{
    // {}(([]){})
    // (([]){})
    public bool IsValid(string s)
    {
        if (s == null || s.Length % 2 == 1)
        {
            return false;
        }
        int len = s.Length;
        char[] chars = s.ToCharArray();

        Queue<char> q = new Queue<char>();
        Stack<char> aided = new Stack<char>();
        for (int i = 0; i < len; i++)
        {
            q.Enqueue(chars[i]);
        }

        while (q.Count > 0)
        {
            if (aided.Count > 0 && ((aided.Peek() == '{' && q.Peek() == '}') ||
                (aided.Peek() == '(' && q.Peek() == ')') ||
                (aided.Peek() == '[' && q.Peek() == ']')))
            {
                aided.Pop();
                q.Dequeue();
            }
            else
            {
                aided.Push(q.Dequeue());
            }
        }

        return q.Count == 0 && aided.Count == 0;
    }
}

