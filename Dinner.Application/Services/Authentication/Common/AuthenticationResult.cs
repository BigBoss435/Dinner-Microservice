using Dinner.Domain.Entities;

namespace Dinner.Application.Services.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);