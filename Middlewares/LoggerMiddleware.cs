using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Core;
using Serilog.Events;
namespace API_MongoDb_CosmoDb.Middlewares
{
    public static class LoggerMiddleware
    {
        public static void AddLoggerMiddleware(this IServiceCollection services)
        {
            var logger = UseLoggerMiddleware();

            logger.Write(LogEventLevel.Information, "Application initialized");
        }

        private static Logger UseLoggerMiddleware()
        {
            var logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.RollingFile(@"log.txt",
                    retainedFileCountLimit: 8, fileSizeLimitBytes: 409600)
                .CreateLogger();

            return logger;
        }
    }
}
