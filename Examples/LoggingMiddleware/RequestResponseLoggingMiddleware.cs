public class RequestResponseLoggingMiddleware
{
    private readonly RequestDelegate _next;


    public RequestResponseLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var requestBodyStream = new MemoryStream();
        var originalRequestBody = context.Request.Body;
        await context.Request.Body.CopyToAsync(requestBodyStream);
        requestBodyStream.Seek(0, SeekOrigin.Begin);

        string requestBodyText = new StreamReader(requestBodyStream).ReadToEnd();
        Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path} - Body: {requestBodyText}");

        requestBodyStream.Seek(0, SeekOrigin.Begin);
        context.Request.Body = requestBodyStream;

        var originalResponseBody = context.Response.Body;
        using (var responseBodyStream = new MemoryStream())
        {
            context.Response.Body = responseBodyStream;
            await _next(context);

            responseBodyStream.Seek(0, SeekOrigin.Begin);
            string responseBodyText = new StreamReader(responseBodyStream).ReadToEnd();
            Console.WriteLine($"Response: {context.Request.Method} {context.Request.Path} - Body: {responseBodyText}");

            responseBodyStream.Seek(0, SeekOrigin.Begin);
            await responseBodyStream.CopyToAsync(originalResponseBody);
        }
    }
}