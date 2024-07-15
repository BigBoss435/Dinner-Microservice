using Dinner.Application;
using Dinner.Infrastructure;
using Dinner.Api.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Dinner.Api.Errors;
using Microsoft.AspNetCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
    // builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
    builder.Services.AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory, DinnerProblemDetailsFactory>();
}
var app = builder.Build();
{
    // app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error");

    app.Map("/error", (HttpContext httpContext) =>
    {
        Exception? exception = httpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

        return Results.Problem();
    });

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}