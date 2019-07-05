using System;
using System.Collections.Generic;
using System.Linq;

namespace ASCalc.Utils
{
    class ShuntingYard
    {
        public Queue<char> InfixToPostfix(string str)
        {
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();   

            foreach (char c in str)
            {
                if (Utils.operRegex.Match(c.ToString()).Success)
                {
                    if (stack.Count != 0)
                    {
                        while(true)
                        {
                            if (stack.Count != 0 && Utils.operValue[c] <= Utils.operValue[stack.First()])
                            {
                                queue.Enqueue(stack.Pop());
                            }
                            else
                            {
                                stack.Push(c);
                                break;
                            }
                        }
                    }
                    else
                    {
                        stack.Push(c);
                    }
                } else
                {
                    queue.Enqueue(c);
                }
            }

            while(stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }
    }
}
