namespace Web.Endpoints.Teacher
{
    public class GetAllTeachersEndpoint : IEndpoint<IResult>
    {
        private ITeacherRepository _teacherRepository = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/get-all-teachers", async (ITeacherRepository repostiroty) =>
            {
                _teacherRepository = repostiroty;
                return HandleAsync();
            })
              .WithTags("Teacher")
              .Produces<ReviewModel>(StatusCodes.Status200OK);
            //.RequireAuthorization();
        }

        public async Task<IResult> HandleAsync()
        {
            var teachers = await _teacherRepository.GetAllTeachers();
            return Results.Ok(teachers);
        }
    }
}
