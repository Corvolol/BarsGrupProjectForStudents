using Microsoft.AspNetCore.Mvc;

namespace Web
{
    public static class MinimalApiRoutes
    {
        public static WebApplication AddMinimalApiRoutes(this WebApplication app)
        {
            app.MapGet("tag", async (int tagId, ITagRepository repostiroty) => {
                return await repostiroty.GetTag(tagId);
            })
             .WithTags("Get")
             .Produces<Tag>(StatusCodes.Status200OK)
             .RequireAuthorization();


            app.MapPost("/add-tag", async (Tag tag, ITagRepository repostiroty) =>
            {
                if (await repostiroty.GetTag(tag.Id) == null)
                {
                    await repostiroty.AddTag(tag);
                    return Results.StatusCode(200);
                }
                return Results.StatusCode(400);
            })
              .WithTags("Post")
              .Produces<string>(StatusCodes.Status200OK)
              .RequireAuthorization();

            app.MapPut("/update-tag", async (Tag tag, ITagRepository repostiroty) =>
            {
                if (await repostiroty.GetTag(tag.Id) != null)
                {
                    await repostiroty.UpdateTag(tag);
                    return Results.StatusCode(200);
                }
                return Results.StatusCode(400);
            })
                .WithTags("Update")
                .Produces<string>(StatusCodes.Status200OK)
                .RequireAuthorization();
            return app;
        }
    }
}
