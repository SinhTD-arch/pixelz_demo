using System.Runtime.Serialization;

namespace OrderService.Service.Exceptions;

[Serializable]
public class BadRequestException : Exception
{
    public BadRequestException(string message)
        : base(message)
    {
    }

    protected BadRequestException(SerializationInfo info, StreamingContext context)
       : base(info, context)
    {
    }

}