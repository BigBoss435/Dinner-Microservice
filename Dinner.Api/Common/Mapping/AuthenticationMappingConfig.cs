using Dinner.Contracts.Authentication;
using Mapster;
using Dinner.Application.Services.Authentication.Common;
using Dinner.Application.Authentication.Queries.Login;
using Dinner.Application.Authentication.Commands.Register;

namespace Dinner.Api.Common.Mapping;

public class AuthenticationMappingConfing : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}