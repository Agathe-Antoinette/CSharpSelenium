namespace CalculatorService
{
    public class Calculator : ICalculator
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Substract(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
