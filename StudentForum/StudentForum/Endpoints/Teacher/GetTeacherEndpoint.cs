namespace Web.Endpoints.Teacher
{
    public class GetTeacherEndpoint : IEndpoint<IResult>
    {
        private ITeacherRepository _teacherRepository = default!;
        private int _teacherId;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/teacher", async (int teacherId, ITeacherRepository repostiroty) =>
            {
                _teacherId = teacherId;
                _teacherRepository = repostiroty;
                return HandleAsync();
            })
              .WithTags("Teacher")
              .Produces<ReviewModel>(StatusCodes.Status200OK);
            //.RequireAuthorization();
        }

        public async Task<IResult> HandleAsync()
        {
            var teacher = await _teacherRepository.GetTeacher(_teacherId);
            return Results.Ok(teacher);
        }
    }
}
