using Microsoft.AspNetCore.Mvc;

namespace Web.Endpoints.Teacher
{
    public class GetTeacherEndpoint : IEndpoint<IResult>
    {
        private ITeacherRepository _teacherRepository = default!;
        private int _teacherId;
        private IReviewRepository _reviewRepository = default!;

        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/teacher", async ([FromBody] int teacherId, [FromServices] ITeacherRepository repostiroty, [FromServices] IReviewRepository reviewRepository, [FromServices] IUserRepository userRepository, [FromServices] ITagRepository tagRepository) =>
            {
                _teacherId = teacherId;
                _teacherRepository = repostiroty;
                _reviewRepository = reviewRepository;
                return await HandleAsync();
            })
              .WithTags("Teacher")
              .Produces<GetTeacherResponse>();
        }

        public async Task<IResult> HandleAsync()
        {
            var teacher = await _teacherRepository.GetTeacher(_teacherId);
            var reviews = await GetReviewsByTeacherId(_teacherId);


            return Results.Ok(new GetTeacherResponse()
            {
                Name = teacher.Name,
                Cafedra = teacher.Cafedra,
                Tags = teacher.Tags.Select(x => x.Name).ToList(),
                ReviewInfo = reviews.Select(x => new GetTeacherReview() { Value = x.Value, ReviewUserNickName = x.User.NickName, Date = x.Date}).ToList()
            });
        }

        public async Task<List<ReviewModel>> GetReviewsByTeacherId(int teacherId)
        {
            var teacher = await _teacherRepository.GetTeacher(teacherId);
            var reviews = await _reviewRepository.GetAllReviews();
            var reviewsTeacher = reviews.Where(x => x.Teacher == teacher).ToList();
            return reviewsTeacher;
        }
    }
}
