using System;
using System.Collections.Generic;
using System.Linq;

namespace ASCalc.Utils
{
    class PostFixEvaluator
    {
        public decimal Evaluate(Queue<char> queue)
        {
            Stack<decimal> stack = new Stack<decimal>();
            foreach (char c in queue)
            {
                if (Utils.operRegex.Match(c.ToString()).Success)
                {
                    stack.Push(Calculate(stack.Pop(), c, stack.Pop() ));
                }
                else
                {
                    stack.Push(decimal.Parse(c.ToString()));
                }
            }
            return stack.First();
        }

        private static decimal Calculate(decimal b,char o, decimal a)
        {
            decimal result = 0;

            switch (o)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    try
                    {
                        result = a / b;
                    }catch (Exception ex)
                    {
                        Console.Write("You cannot divide by zero! ");
                    }
                    break;
            }
            return result;
        }
        
    }
}
