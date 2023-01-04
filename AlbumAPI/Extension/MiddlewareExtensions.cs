using AlbumAPI.Middleware;

namespace AlbumAPI.Extension
{
    public static class MiddlewareExtensions
    {

        public static IApplicationBuilder UseRequestLogger(this IApplicationBuilder applicationBuilder)
        {

            return applicationBuilder.UseMiddleware<RequestLoggerMiddleware>();
        }     
    }
}
