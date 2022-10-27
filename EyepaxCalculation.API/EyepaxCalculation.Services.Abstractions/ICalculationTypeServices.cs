using EyepaxCalculation.Contracts;

namespace EyepaxCalculation.Services.Abstractions
{
    public interface ICalculationTypeServices
    {
        Task<List<CalculationTypeDto>> GetCalculationTypes();
    }
}
