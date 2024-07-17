using Dinner.Domain.Entities;

namespace Dinner.Application.Services.Authentication.Common;

public record AuthenticationResult(
    User user,
    string Token);