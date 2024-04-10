using Foodle.Application.Common.Interfaces.Services;

namespace Foodle.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}