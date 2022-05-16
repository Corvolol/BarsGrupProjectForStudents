namespace Web.Endpoints.Review.CreateReview
{
    public class CreateReviewEndpoint : IEndpoint<IResult, CreateReviewRequest>
    {
        private IReviewRepository _reviewReposiotry = default!;
        private IUserRepository _userRepository = default!;
        private ITeacherRepository _teacherRepository = default!;
        private HttpContext _context = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapPost("/add-review", async (CreateReviewRequest reviewRequest, HttpContext context, IReviewRepository repostiroty,
                ITeacherRepository teacherRepository, IUserRepository userRepository) =>
            {
                _reviewReposiotry = repostiroty;
                _userRepository = userRepository;
                _teacherRepository = teacherRepository;
                _context = context;
                return await HandleAsync(reviewRequest);
            })
              .WithTags("Review")
              .Produces<CreateReviewRequest>()
              .RequireAuthorization();
        }

        public async Task<IResult> HandleAsync(CreateReviewRequest reviewRequest)
        {
                var teacher = await _teacherRepository.GetTeacher(reviewRequest.TeacherId);
                var user = await _userRepository.GetUser(_context.User.Claims.ToArray()[0].Value);
                ReviewModel review = new ReviewModel()
                {
                    Value = reviewRequest.Value,
                    Date = DateTime.Now,
                    Teacher = teacher,
                    User = user
                };
                await _reviewReposiotry.AddReview(review);

                List<string> results = new List<string> {review.Value, review.Date.ToString()};
                return Results.Ok(results);
        }
    }
}
