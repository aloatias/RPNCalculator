namespace RpnCalculator.App.Models
{
    public class Substraction : IValidOperator
    {
        private readonly string _defaultOperator = "-";
        private readonly string _operatorToValidate;

        public Substraction()
        {
        }

        public Substraction(string operatorToValidate)
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
            return (operator2 - operator1).ToString();
        }
    }
}
