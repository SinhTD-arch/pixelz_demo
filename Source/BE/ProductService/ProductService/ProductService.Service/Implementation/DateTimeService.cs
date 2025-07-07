using ProductService.Service.Contract;

namespace ProductService.Service.Implementation;

public class DateTimeService : IDateTimeService
{
    public DateTime NowUtc => DateTime.UtcNow;
}