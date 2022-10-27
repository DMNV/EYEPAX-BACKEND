using EyepaxCalculation.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EyepaxCalculation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationTypeServices _CalculationTypes;

        public CalculationController(ICalculationTypeServices calculationTypes)
        {
            _CalculationTypes = calculationTypes;
        }

        public async Task<IActionResult> GetCalculationTypes()
        {
            var calculationTypes = await _CalculationTypes.GetCalculationTypes();
            return Ok(calculationTypes);
        }
    }
}
