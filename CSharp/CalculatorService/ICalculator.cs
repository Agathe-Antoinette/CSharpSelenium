using System.ServiceModel;

namespace CalculatorService
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        decimal Add(decimal a, decimal b);

        [OperationContract]
        decimal Substract(decimal a, decimal b);

        [OperationContract]
        decimal Multiply(decimal a, decimal b);

        [OperationContract]
        decimal Divide(decimal a, decimal b);
    }
}
