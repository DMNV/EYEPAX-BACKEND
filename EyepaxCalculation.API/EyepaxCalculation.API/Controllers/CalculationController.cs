using EyepaxCalculation.Contracts;
using EyepaxCalculation.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EyepaxCalculation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationTypeServices _calculationTypesServices;
        private readonly ICalculateService _calculateService ;

        public CalculationController(ICalculationTypeServices calculationTypes, ICalculateService calculateService)
        {
            _calculationTypesServices = calculationTypes;
            _calculateService = calculateService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCalculationTypes()
        {   
            return Ok(await _calculationTypesServices.GetCalculationTypes());
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(CalculateDto calculate)
        { 
            return Ok(await _calculateService.Calculate(calculate));
        }
    }
}
