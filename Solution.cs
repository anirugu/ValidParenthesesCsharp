using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public bool IsValid(string s)
    {
        var chars = new Dictionary<char, char>()
        {
            {'(',')' },
            {'{','}' },
            {'[',']' }
        };

        Stack<char> stack = new Stack<char>(s.Length);
        foreach (var current in s)
        {
            if (chars.ContainsKey(current))
                stack.Push(current);
            else
            {
                var lastKey = chars.First(x => x.Value == current).Key;
                if (!stack.Any())
                    return false;
                if (stack.Pop() != lastKey)
                    return false;
            }
        }
        return (stack.Count == 0);
    }
}