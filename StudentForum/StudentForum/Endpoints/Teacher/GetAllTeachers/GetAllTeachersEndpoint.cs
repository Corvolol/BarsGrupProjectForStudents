namespace Web.Endpoints.Teacher.GetAllTeachers
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
                return await HandleAsync();
            })
              .WithTags("Teacher")
              .Produces<GetAllTeachersResponse>();
            //.RequireAuthorization();
        }

        public async Task<IResult> HandleAsync()
        {
            var Teachers = await _teacherRepository.GetAllTeachers();
            var responce = new GetAllTeachersResponse() { ListPair = Teachers.Select(x => new PairTeacherIdName() { Id = x.Id, Name = x.Name }).ToList() };

            return Results.Ok(responce);
        }
    }
}
