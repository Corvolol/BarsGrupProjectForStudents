namespace Web
{
    public static class MinimalApiRoutes
    {
        public static WebApplication AddMinimalApiRoutes(this WebApplication app)
        {
            app.MapPost("/registration", async (Registration registration, IAuthServices authService, IUserRepository repostiroty) =>
            {
                if (await repostiroty.GetUser(registration.Email) == null)
                {
                    registration.Password = authService.HashingPassword(registration.Password);
                    string token = authService.GenerateJWT(registration.Email);
                    User user = authService.CreateUser(registration);
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

            app.MapGet("/user", async (HttpContext context, IUserRepository repostiroty) =>
            {
                return await repostiroty.GetUser(context.User.Claims.ToArray()[0].Value);
            })
              .WithTags("Get")
              .Produces<User>(StatusCodes.Status200OK)
              .RequireAuthorization();

            app.MapPut("/user/addquestion", async (HttpContext context, IUserRepository repostiroty, Question question) =>
            {
                await repostiroty.UpdateUser(context.User.Claims.ToArray()[0].Value, question);
                return Results.StatusCode(StatusCodes.Status200OK);
            }).WithTags("Put")
              .RequireAuthorization()
              .Produces(StatusCodes.Status200OK);

            app.MapPut("/user/addanswer", async (HttpContext context, IUserRepository repostiroty, Answer answer) =>
            {
                await repostiroty.UpdateUser(context.User.Claims.ToArray()[0].Value, answer);
                return Results.StatusCode(StatusCodes.Status200OK);
            }).WithTags("Put")
              .RequireAuthorization()
              .Produces(StatusCodes.Status200OK);

            app.MapPut("/user/addreview", async (HttpContext context, IUserRepository repostiroty, Review review) =>
            {
                await repostiroty.UpdateUser(context.User.Claims.ToArray()[0].Value, review);
                return Results.StatusCode(StatusCodes.Status200OK);
            }).WithTags("Put")
              .RequireAuthorization()
              .Produces(StatusCodes.Status200OK);

            app.MapPut("/user/update", async (HttpContext context, IAuthServices authService, IUserRepository repostiroty, User user) =>
            {
                await repostiroty.UpdateUser(user);
                user.Password = authService.HashingPassword(user.Password);
                return Results.StatusCode(StatusCodes.Status200OK);
            }).WithTags("Put")
             .RequireAuthorization()
             .Produces(StatusCodes.Status200OK);

            app.MapDelete("user/delete", async (HttpContext context, IUserRepository repostiroty) =>
             {
                 await repostiroty.DeleteUser(context.User.Claims.ToArray()[0].Value);
                 return Results.StatusCode(StatusCodes.Status200OK);
             }).WithTags("Delete")
               .RequireAuthorization()
               .Produces(StatusCodes.Status200OK); ;
            return app;
        }
    }
}
