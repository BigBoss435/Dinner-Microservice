using Dinner.Application;
using Dinner.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Dinner.Api.Common.Errors;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
    builder.Services.AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory, DinnerProblemDetailsFactory>();
}
var app = builder.Build();
{
    app.UseExceptionHandler("/error");

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}