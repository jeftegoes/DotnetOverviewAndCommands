using Serilog;

Console.WriteLine("Hello, World!");

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

Log.Information("Hello, world!");

var a = 10;
var b = 0;

try
{
    Log.Debug("Dividing {0} by {1}", a, b);
    Console.WriteLine("Result: {0}", a / b);
}
catch (Exception ex)
{
    Log.Error(ex, "Something went wrong.");
}
finally
{
    Log.CloseAndFlush();
}