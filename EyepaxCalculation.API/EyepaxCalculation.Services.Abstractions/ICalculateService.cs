using EyepaxCalculation.Contracts;

namespace EyepaxCalculation.Services.Abstractions
{
    public interface ICalculateService
    {
        Task<decimal> Calculate(CalculateDto calculate);
    }
}
