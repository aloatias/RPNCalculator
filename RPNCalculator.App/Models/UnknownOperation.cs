namespace RpnCalculator.App.Models
{
    public class UnknownOperation : IOperator
    {
        public string Calculate(int operator1, int operator2)
        {
            return "0";
        }
    }
}
