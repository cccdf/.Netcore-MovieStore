using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MovieStore.MVC.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MovieStoreExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<MovieStoreExceptionMiddleware> _logger;

        public MovieStoreExceptionMiddleware(RequestDelegate next, ILogger<MovieStoreExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                _logger.LogInformation("MovieStoreExceptionMiddleware is called");
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception Happened: {ex}");
                await HandleException(httpContext, ex);
                
            }

            //return _next(httpContext);
        }

        public async Task HandleException(HttpContext context, Exception exception)
        {
            _logger.LogError($"Exception Message:{exception.Message}");
            _logger.LogError($"Exception Stacktrace:{exception.StackTrace}");
            _logger.LogInformation($"Exception for User:{context.User.Identity.Name}");
            _logger.LogInformation($"Exception Happened on {DateTime.UtcNow}");
            _logger.LogInformation("-------------END-------------");

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            context.Response.Redirect("/Home/Error");

            await Task.CompletedTask;


        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MovieStoreExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseMovieStoreExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MovieStoreExceptionMiddleware>();
        }
    }
}
