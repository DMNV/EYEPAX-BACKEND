using System.ComponentModel.DataAnnotations;

namespace EyepaxCalculation.Contracts
{
    public class CalculateDto
    {
        [Required(ErrorMessage = "Loan amount is required")]
        public double LoanAmount { get; set; }

        [Required(ErrorMessage = "Rate is required")]
        public double Rate { get; set; }

        [Required(ErrorMessage = "No of payments is required")]
        public int NoPayments  { get; set; }
    }
}
