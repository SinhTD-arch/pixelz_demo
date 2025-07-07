using PaymentService.Service.Contract;

namespace PaymentService.Service.Implementation;

public class DateTimeService : IDateTimeService
{
    public DateTime NowUtc => DateTime.UtcNow;
}