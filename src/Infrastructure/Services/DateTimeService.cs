using REpo_gIt.Application.Common.Interfaces;

namespace REpo_gIt.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
