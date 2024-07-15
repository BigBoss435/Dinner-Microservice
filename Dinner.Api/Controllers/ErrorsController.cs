using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Dinner.Api.Conrollers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Get()
    {
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Problem();
    }
}