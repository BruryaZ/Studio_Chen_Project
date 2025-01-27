using Studio_Chen.API.Middlewares;

namespace Studio_Chen.API
{
    public static class Extensions
    {
        /// <summary>
        /// Check if today is Shabbat
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseShabbat(this IApplicationBuilder app)
        {
            app.UseMiddleware<ShabbatMiddlware>();
            return app;
        }
    }
}
