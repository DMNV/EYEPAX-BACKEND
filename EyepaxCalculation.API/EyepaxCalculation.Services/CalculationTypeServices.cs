using EyepaxCalculation.Contracts;
using EyepaxCalculation.Services.Abstractions;

namespace EyepaxCalculation.Services
{
    public class CalculationTypeServices : ICalculationTypeServices
    {
        public CalculationTypeServices()
        {

        }

        public Task<List<CalculationTypeDto>> GetCalculationTypes()
        { 
            return Task.Run(() => new List<CalculationTypeDto>() { 
                new CalculationTypeDto
                {
                    Id = 1,
                    Name = "Equal Monthly Installment (EMI)"
                }
            });
        }
    }
}
