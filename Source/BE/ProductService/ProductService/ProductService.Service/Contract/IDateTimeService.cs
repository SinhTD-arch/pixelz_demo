namespace ProductService.Service.Contract
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}