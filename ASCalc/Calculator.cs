using ASCalc.Utils;
using System;

namespace ASCalc
{
    class Calculator
    {
        public decimal Calculate(string str)
        {
            ShuntingYard sy = new ShuntingYard();
            PostFixEvaluator pfe = new PostFixEvaluator();

            return Math.Round(pfe.Evaluate(sy.InfixToPostfix(str)),2);
        }
    }
}
