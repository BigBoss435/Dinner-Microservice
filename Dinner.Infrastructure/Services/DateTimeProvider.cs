using Dinner.Application.Common.Interfaces.Services;

namespace Dinner.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}