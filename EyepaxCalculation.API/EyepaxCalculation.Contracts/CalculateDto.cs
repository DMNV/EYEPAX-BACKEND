using System.ComponentModel.DataAnnotations;

namespace EyepaxCalculation.Contracts
{
    public class CalculateDto
    { 

        [Required(ErrorMessage = "Calculation type is required")]
        public string CalculationType { get; set; }

        [Required(ErrorMessage = "Loan amount is required")]
        public decimal LoanAmount { get; set; }

        [Required(ErrorMessage = "Rate is required")]
        public decimal Rate { get; set; }

        [Required(ErrorMessage = "No of payments is required")]
        public int NoPayments  { get; set; }
    }
}
