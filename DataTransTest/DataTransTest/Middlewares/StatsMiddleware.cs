using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransTest.Middlewares
{
    public class StatsMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public StatsMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;

            _logger = logFactory.CreateLogger("StatsMiddleware");
        }

        public Task Invoke(HttpContext httpContext)
        {
            DateTime requestTime = DateTime.Now;
            _logger.LogInformation("StatsMiddleware executing..");
            DateTime responseTime = DateTime.Now;

            TimeSpan processDuration = requestTime - responseTime;
            Console.WriteLine("[inline Midelware] process duration =" + processDuration.TotalMilliseconds + "ms");


            var resulte = _next(httpContext); // calling next middleware
            return resulte;

        }
    }


}