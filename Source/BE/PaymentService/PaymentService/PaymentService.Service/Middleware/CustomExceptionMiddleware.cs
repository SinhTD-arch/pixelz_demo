using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PaymentService.Service.Exceptions;
using System.Net;

namespace PaymentService.Service.Middleware;

public class CustomExceptionMiddleware(RequestDelegate next, ILogger<CustomExceptionMiddleware> logger)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception exceptionObj)
        {
            await HandleExceptionAsync(context, exceptionObj, logger);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception, ILogger<CustomExceptionMiddleware> logger)
    {
        int code;
        var result = exception.Message;

        switch (exception)
        {
            case ValidationException validationException:
                code = (int)HttpStatusCode.BadRequest;
                result = JsonConvert.SerializeObject(validationException.Failures);
                break;
            case BadRequestException badRequestException:
                code = (int)HttpStatusCode.BadRequest;
                result = badRequestException.Message;
                break;
            case DeleteFailureException deleteFailureException:
                code = (int)HttpStatusCode.BadRequest;
                result = deleteFailureException.Message;
                break;
            case NotFoundException _:
                code = (int)HttpStatusCode.NotFound;
                break;
            default:
                code = (int)HttpStatusCode.InternalServerError;
                break;
        }

        logger.LogError(result);

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = code;
        return context.Response.WriteAsync(JsonConvert.SerializeObject(new { StatusCode = code, ErrorMessage = exception.Message }));
    }
}