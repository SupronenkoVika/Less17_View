using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Less17_View.Filters
{
    public class CustomExceptionFilter : Attribute, IAsyncExceptionFilter
    {
        public async Task OnExceptionAsync(ExceptionContext context)
        {
            if (context.Exception is ArgumentOutOfRangeException)
            {
                //context.HttpContext.Response.StatusCode = 404;
                context.ExceptionHandled = true;
                context.Result = new NotFoundResult();
            }
        }
    }
}
