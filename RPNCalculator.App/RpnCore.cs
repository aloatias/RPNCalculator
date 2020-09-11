using RpnCalculator.App.Models;
using System;
using System.Collections.Generic;

namespace RpnCalculator.Core
{
    public class RpnCore
    {
        private readonly List<Type> _validOperators;
        private readonly Stack<string> _operatingElementsStack = new Stack<string>();

        public RpnCore()
        {
            _validOperators = new List<Type> { typeof(Addition), typeof(Substraction), typeof(Multiplication), typeof(Division) };
        }

        public string CalculateCompleteExpression(string operation)
        {
            string[] operatingElementsArray = operation.Trim().Split(" ");
            foreach (var element in operatingElementsArray)
            {
                if (int.TryParse(element, out _))
                {
                    _operatingElementsStack.Push(element);
                }
                else
                {
                    CalculatePartialOperation(element);
                }
            }

            return _operatingElementsStack.Pop();
        }

        private void CalculatePartialOperation(string operatorSymbol)
        {
            IOperator resultClass = new UnknownOperation();
            _operatingElementsStack.Push(resultClass.Calculate(0, 0));

            _validOperators.ForEach(vo =>
            {
                var unchekedClass = (IValidOperator)Activator.CreateInstance(vo, operatorSymbol);
                resultClass = unchekedClass.Build();

                if (resultClass.GetType() != typeof(UnknownOperation))
                {
                    _operatingElementsStack.Pop();

                    int.TryParse(_operatingElementsStack.Pop(), out int op1);
                    int.TryParse(_operatingElementsStack.Pop(), out int op2);

                    _operatingElementsStack.Push(resultClass.Calculate(op1, op2));
                    return;
                }
            });
        }
    }
}