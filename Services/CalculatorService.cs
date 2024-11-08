namespace LW_11_WebApplication.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public string Divide(int a, int b) => b != 0 ? (a / b).ToString() : "На ноль делить нельзя";
    }
}
