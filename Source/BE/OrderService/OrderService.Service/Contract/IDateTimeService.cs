namespace OrderService.Service.Contract
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}