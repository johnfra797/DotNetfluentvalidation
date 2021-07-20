using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace DotNetfluentvalidation.API.MiddleWares
{
    public static class MiddleWareExtensions
    {
        public static IApplicationBuilder UserCustomeExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
