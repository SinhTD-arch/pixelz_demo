using OrderService.Service.Contract;

namespace OrderService.Service.Implementation;

public class DateTimeService : IDateTimeService
{
    public DateTime NowUtc => DateTime.UtcNow;
}