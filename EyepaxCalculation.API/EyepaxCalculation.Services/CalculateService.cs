using EyepaxCalculation.Contracts;
using EyepaxCalculation.Services.Abstractions;

namespace EyepaxCalculation.Services
{
    public class CalculateService : ICalculateService
    {
        public async Task<decimal> Calculate(CalculateDto calculate)
        {
            if (calculate.CalculationType == (int)CalculationType.EQUALMONTHLYINSTALLMENT)
                return await EqualMonthlyInstallmentCalculate(calculate);
            else
                throw new ArgumentException("Please enter valid calculation type");
        }

        private async Task<decimal> EqualMonthlyInstallmentCalculate(CalculateDto calculate)
        {
            try
            {
                var powValue = Math.Round((decimal)Math.Pow((double)(calculate.Rate + 1), calculate.NoPayments), 3);
                var upValue = Math.Round(powValue * calculate.Rate, 6);
                var downValue = powValue - 1;
                var result = Math.Round(calculate.LoanAmount * (upValue / downValue), 2);

                return await Task.Run(() => result);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }
    }
}
