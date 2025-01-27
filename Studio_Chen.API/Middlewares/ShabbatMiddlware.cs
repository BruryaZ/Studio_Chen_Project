namespace Studio_Chen.API.Middlewares
{
    public class ShabbatMiddlware(RequestDelegate next, ILogger<ShabbatMiddlware> logger)
    {
        private readonly RequestDelegate _next = next; 
        private readonly ILogger<ShabbatMiddlware> _logger = logger;

        public async Task InvokeAsync(HttpContext context /**the object that wraps the request**/)
        { 
            var guid = Guid.NewGuid().ToString();
            _logger.LogInformation($"Request Starts {guid}");

            DateTime currentDate = DateTime.Now;

            if (currentDate.DayOfWeek == DayOfWeek.Saturday)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }

            context.Items.Add("ReqId", guid);
            await _next(context);
            _logger.LogInformation($"Request Ends {guid}");
        }
    }
}