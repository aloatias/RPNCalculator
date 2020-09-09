using System;
using System.Collections.Generic;

namespace RpnCalculator.Core
{
    public class RpnCore
    {
        public string Calculate(string operation)
        {
            var operatingElementsStack = new Stack<string>();

            string[] operatingElementsArray = operation.Trim().Split(" ");
            foreach (var element in operatingElementsArray)
            {
                if (int.TryParse(element, out _))
                {
                    operatingElementsStack.Push(element);
                }
                else
                {
                    int op1, op2;

                    switch (element)
                    {
                        case "+":
                            int.TryParse(operatingElementsStack.Pop(), out op1);
                            int.TryParse(operatingElementsStack.Pop(), out op2);

                            operatingElementsStack.Push((op2 + op1).ToString());

                            break;
                        case "-":
                            int.TryParse(operatingElementsStack.Pop(), out op1);
                            int.TryParse(operatingElementsStack.Pop(), out op2);

                            operatingElementsStack.Push((op2 - op1).ToString());

                            break;
                        case "*":
                            int.TryParse(operatingElementsStack.Pop(), out op1);
                            int.TryParse(operatingElementsStack.Pop(), out op2);

                            operatingElementsStack.Push((op2 * op1).ToString());

                            break;
                        case "/":
                            int.TryParse(operatingElementsStack.Pop(), out op1);
                            int.TryParse(operatingElementsStack.Pop(), out op2);

                            operatingElementsStack.Push((op2 / op1).ToString());

                            break;

                        default:
                            throw new ArgumentException("Invalid operating symbol. You can use '+', '-', '*', '/'");
                    }
                }
            }

            return operatingElementsStack.Pop();
        }
    }
}