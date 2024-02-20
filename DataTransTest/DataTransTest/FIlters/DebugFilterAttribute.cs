using Microsoft.AspNetCore.Mvc.Filters;

namespace DataTransTest.FIlters
{
    public class DebugFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            DateTime refrence = new DateTime(2024, 1, 1);
            TimeSpan time = DateTime.Now - refrence;
            Console.WriteLine("[DebugFilterAttribute] OnActionExecuted - Time= " + time.TotalMilliseconds + "ms");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            DateTime refrence = new DateTime(2024, 1, 1);
            TimeSpan time = DateTime.Now - refrence;
            Console.WriteLine("[DebugFilterAttribute] OnActionExecuting - Time= " + time.TotalMilliseconds + "ms");
        }
    }
}