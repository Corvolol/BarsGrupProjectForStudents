using Microsoft.AspNetCore.Mvc;

namespace Web
{
    public static class MinimalApiRoutes
    {
        public static WebApplication AddMinimalApiRoutes(this WebApplication app)
        {
            app.MapGet("/teacher", async (int teacherId, ITeacherRepository repostiroty) => {
                return await repostiroty.GetTeacher(teacherId);
            })
              .WithTags("Get")
              .Produces<Teacher>(StatusCodes.Status200OK)
              .RequireAuthorization();

            app.MapGet("/get-all-teachers", async (ITeacherRepository repostiroty) =>
            {
                return await repostiroty.GetAllTeachers();
            })
              .WithTags("Get")
              .Produces<Teacher>(StatusCodes.Status200OK);

            app.MapPost("/add-teacher", async (Teacher teacher, ITeacherRepository repostiroty) =>
            {
                if (await repostiroty.GetTeacher(teacher.TeacherId) == null)
                {
                    await repostiroty.AddTeacher(teacher);
                    return Results.StatusCode(200);
                }
                return Results.StatusCode(400);
            })
              .WithTags("Post")
              .Produces<string>(StatusCodes.Status200OK)
              .RequireAuthorization();

            app.MapDelete("/delete-teacher", async ([FromBody] Teacher teacher, ITeacherRepository repostiroty) =>
            {
                if (await repostiroty.GetTeacher(teacher.TeacherId) != null)
                {
                    await repostiroty.DeleteTeacher(teacher);
                    return Results.StatusCode(200);
                }
                return Results.StatusCode(400);
            })
                .WithTags("Delete")
                .Produces<string>(StatusCodes.Status200OK)
                .RequireAuthorization();

            app.MapPut("/update-teacher", async (Teacher teacher, ITeacherRepository repostiroty) =>
            {
                if (await repostiroty.GetTeacher(teacher.TeacherId) != null)
                {
                    await repostiroty.UpdateTeacher(teacher);
                    return Results.StatusCode(200);
                }
                return Results.StatusCode(400);
            })
                .WithTags("Update")
                .Produces<string>(StatusCodes.Status200OK)
                .RequireAuthorization();

            app.MapGet("/review", async (int reviewId, IReviewRepository repostiroty) => {
                return await repostiroty.GetReview(reviewId);
            })
              .WithTags("Get")
              .Produces<Review>(StatusCodes.Status200OK)
              .RequireAuthorization();

            app.MapPost("/add-review", async (Review review, HttpContext context, IReviewRepository repostiroty) =>
            {
                await repostiroty.AddReview(review);
                return Results.StatusCode(200);
            })
              .WithTags("Post")
              .Produces<string>(StatusCodes.Status200OK)
              .RequireAuthorization();

            app.MapDelete("/delete-review", async ([FromBody] Review review, HttpContext context, IReviewRepository repostiroty) =>
            {
                if (await repostiroty.GetReview(review.Id) != null)
                {
                    await repostiroty.DeleteReview(review, context.User.Claims.ToArray()[0].Value);
                    return Results.StatusCode(200);
                }
                return Results.StatusCode(400);
            })
                .WithTags("Delete")
                .Produces<string>(StatusCodes.Status200OK)
                .RequireAuthorization();

            app.MapPut("/update-review", async (Review review, HttpContext context, IReviewRepository repostiroty) =>
            {
                if (await repostiroty.GetReview(review.Id) != null)
                {
                    await repostiroty.UpdateReview(review, context.User.Claims.ToArray()[0].Value);
                    return Results.StatusCode(200);
                }
                return Results.StatusCode(400);
            })
                .WithTags("Update")
                .Produces<string>(StatusCodes.Status200OK)
                .RequireAuthorization();
            app.MapGet("tag", async (int tagId, ITagRepository repostiroty) => {
                return await repostiroty.GetTag(tagId);
            })
             .WithTags("Get")
             .Produces<Tag>(StatusCodes.Status200OK)
             .RequireAuthorization();


            app.MapPost("/add-tag", async (Tag tag, ITagRepository repostiroty) =>
            {
                if (await repostiroty.GetTag(tag.TagId) == null)
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
                if (await repostiroty.GetTag(tag.TagId) != null)
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
