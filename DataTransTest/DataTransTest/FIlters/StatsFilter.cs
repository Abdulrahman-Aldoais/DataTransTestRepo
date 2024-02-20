using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DataTransTest.FIlters
{
    public class StatsFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            DateTime refrence = new DateTime(2024, 1, 1);
            TimeSpan time = DateTime.Now - refrence;
            Console.WriteLine("[OnActionExecuted] OnActionExecuting - Time= " + time.TotalMilliseconds + "ms");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            DateTime refrence = new DateTime(2024, 1, 1);
            TimeSpan time = DateTime.Now - refrence;
            Console.WriteLine("[OnActionExecuted] OnActionExecuted - Time= " + time.TotalMilliseconds + "ms");
        }
    }
}