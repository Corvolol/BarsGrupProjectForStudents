namespace Web.Endpoints.Teacher
{
    public class GetAllTeachersEndpoint : IEndpoint<IResult>
    {
        public Dictionary<int, string>? IdName { get; set; }

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
            var Ids = teachers.Select(x => x.Id).ToList();
            var Names = teachers.Select(x => x.Name).ToList();
            IdName = Ids.Select((i, n) => (i, n)).ToDictionary(x => x.i, x => Names[x.i]);

            return Results.Ok(IdName);
        }
    }
}
