namespace RpnCalculator.App.Models
{
    public class Multiplication : IValidOperator
    {
        private readonly string _defaultOperator = "*";
        private readonly string _operatorToValidate;

        public Multiplication()
        {
        }

        public Multiplication(string operatorToValidate)
        {
            _operatorToValidate = operatorToValidate;
            Build();
        }

        public IOperator Build()
        {
            if (_defaultOperator != _operatorToValidate)
            {
                return new UnknownOperation();
            }

            return this;
        }

        public string Calculate(int operator1, int operator2)
        {
            return (operator1 * operator2).ToString();
        }
    }
}
