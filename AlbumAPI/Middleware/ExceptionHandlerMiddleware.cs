using AlbumAPI.Model;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace AlbumAPI.Middleware
{
    public static class ExceptionHandlerMiddleware
    {
               
        public static void UseGlobalExceptionHandler(this IApplicationBuilder app, ILogger logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        var errorDetail = new ErrorDetails();
                        errorDetail.StatusCode =  context.Response.StatusCode;
                        errorDetail.Message = "Internal Server Error UseGlobalExceptionHandler.";

                        if (errorDetail != null)
                        {

                            await context.Response.WriteAsJsonAsync<ErrorDetails>(errorDetail);
                        }
                        logger.LogError($"Something went wrong: {contextFeature.Error}");
                    }
                });
            });

        }
    }
}
