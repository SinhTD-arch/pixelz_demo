namespace PaymentService.Service.Contract
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}