namespace Web
{
    public static class MinimalApiRoutes
    {
        public static WebApplication AddMinimalApiRoutes(this WebApplication app)
        {
            app.MapPost("/login", () => Console.WriteLine());
            return app;
        }
    }
}
