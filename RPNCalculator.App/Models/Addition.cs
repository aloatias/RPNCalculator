namespace RpnCalculator.App.Models
{
    public class Addition : IValidOperator
    {
        private readonly string _defaultOperator = "+";
        private readonly string _operatorToValidate;

        public Addition()
        {
        }

        public Addition(string operatorToValidate)
        {
            _operatorToValidate = operatorToValidate;
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
            return (operator1 + operator2).ToString();
        }
    }
}
