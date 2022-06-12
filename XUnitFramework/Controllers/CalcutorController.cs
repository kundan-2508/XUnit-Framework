using Microsoft.AspNetCore.Mvc;
using XUnitFramework.Repository;

namespace XUnitFramework.Controllers;

[ApiController]
[Route("[controller]")]
public class CalcutorController : ControllerBase
{
    
    private readonly ICalculatorRepository _calculator;

    public CalcutorController(ICalculatorRepository calculator)
    {
        _calculator = calculator;
    }

    [HttpGet("/sum")]
    public int Sum(int a, int b)
    {
        return _calculator.Sum(a, b);
    }
}

