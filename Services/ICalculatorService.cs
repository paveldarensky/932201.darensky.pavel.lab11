namespace LW_11_WebApplication.Services
{
    public interface ICalculatorService
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        string Divide(int a, int b);
    }
}
