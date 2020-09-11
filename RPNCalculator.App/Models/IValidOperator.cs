namespace RpnCalculator.App.Models
{
    public interface IValidOperator : IOperator
    {
        IOperator Build();
    }
}