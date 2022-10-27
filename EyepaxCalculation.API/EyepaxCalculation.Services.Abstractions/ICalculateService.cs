using EyepaxCalculation.Contracts;

namespace EyepaxCalculation.Services.Abstractions
{
    public interface ICalculateService
    {
        Task<double> Calculate(CalculateDto calculate);
    }
}
