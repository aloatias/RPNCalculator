namespace RpnCalculator.App.Models
{
    public class Division : IValidOperator
    {
        private readonly string _defaultOperator = "/";
        private readonly string _operatorToValidate;

        public Division()
        {
        }

        public Division(string operatorToValidate)
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
            return ((decimal)(operator2 / operator1)).ToString();
        }
    }
}
