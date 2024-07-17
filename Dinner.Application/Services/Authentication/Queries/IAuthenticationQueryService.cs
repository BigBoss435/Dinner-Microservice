using Dinner.Application.Services.Authentication.Common;
using ErrorOr;

namespace Dinner.Application.Services.Authentication.Queries;

public interface IAuthenticationQueryService
{
    ErrorOr<AuthenticationResult> Login(string email, string password);
}