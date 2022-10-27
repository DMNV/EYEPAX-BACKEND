using EyepaxCalculation.Contracts;
using EyepaxCalculation.Services.Abstractions;

namespace EyepaxCalculation.Services
{
    public class CalculateService : ICalculateService
    {
        public Task<double> Calculate(CalculateDto calculate)
        {

            var a = (calculate.Rate + 1) * calculate.NoPayments;

             var result =calculate.LoanAmount * ((a * calculate.Rate) / calculate.Rate - 1);

             return Task.Run(() => result);
        }
    }
}
