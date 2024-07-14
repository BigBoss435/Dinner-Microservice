using Dinner.Domain.Entities;

namespace Dinner.Application.Services.Authentication;

public record AuthenticationResult(
    User user,
    string Token);