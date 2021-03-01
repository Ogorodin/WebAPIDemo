using System;
using System.Net;
using System.Threading.Tasks;
using Domain;
using Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace APIDemo.Helpers
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (DataLayerException e)
            {
                await HandleDataLayerExceptionAsync(httpContext, e);
            }
            catch (UserServiceException e)
            {
                await HandleUserServiceExceptionAsync(httpContext, e);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e}");
                await HandleExceptionAsync(httpContext, e);
            }
        }


        private Task HandleDataLayerExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var errorDetailsJson = new ErrorDetails
            {
                StatusCode = context.Response.StatusCode,
                Message = "Something bad happened in data layer."
            }.ToJsonString();

            return context.Response.WriteAsync(errorDetailsJson);
        }


        private Task HandleUserServiceExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var errorDetailsJson = new ErrorDetails
            {
                StatusCode = context.Response.StatusCode,
                Message = "Something bad happened in UserService."
            }.ToJsonString();

            return context.Response.WriteAsync(errorDetailsJson);
        }


        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var errorDetailsJson = new ErrorDetails
            {
                StatusCode = context.Response.StatusCode,
                Message = "Something bad happened."
            }.ToJsonString();

            return context.Response.WriteAsync(errorDetailsJson);
        }
    }


    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
