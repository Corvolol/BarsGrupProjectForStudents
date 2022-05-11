namespace Web
{
    public static class MinimalApiRoutes
    {
        public static WebApplication AddMinimalApiRoutes(this WebApplication app)
        {
            app.MapPost("/registration", async (User user, IAuthServices authService, IUserRepository repostiroty) =>
            {
                if (await repostiroty.GetUser(user.Email) == null)
                {
                    user.Password = authService.HashingPassword(user.Password);
                    string token = authService.GenerateJWT(user.Email);
                    await repostiroty.AddUSer(user);
                    return Results.Json(token);
                }
                return Results.StatusCode(400);
            })
              .WithTags("Post")
              .Produces<string>(StatusCodes.Status200OK);

            app.MapPost("/login", async (Auth auth, IAuthServices authService, IUserRepository repostiroty) =>
             {
                 User user = await repostiroty.GetUser(auth.Email);
                 if (user != null && user.Password == authService.HashingPassword(auth.Password))
                 {
                     return Results.Json(authService.GenerateJWT(auth.Email));
                 }
                 return Results.StatusCode(400);
             })
               .WithTags("Post")
              .Produces<string>(StatusCodes.Status200OK);

            app.MapGet("user", async (HttpContext context, IUserRepository repostiroty) => { return await repostiroty.GetUser(context.User.Claims.ToArray()[0].Value); 
            })
              .WithTags("Get")
              .Produces<User>(StatusCodes.Status200OK)
              .RequireAuthorization();
            return app;
        }
    }
}
