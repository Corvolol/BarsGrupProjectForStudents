namespace Web.Endpoints.Review.UpdateReview
{
    public class UpdateReviewEndpoint : IEndpoint<IResult, UpdateReviewRequest>
    {
        private IReviewRepository _reviewReposiotry = default!;
        private IUserRepository _userRepository = default!;
        private HttpContext _context = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapPost("/update-review", async (UpdateReviewRequest reviewRequest, HttpContext context, IReviewRepository repostiroty,
                ITeacherRepository teacherRepository, IUserRepository userRepository) =>
            {
                _reviewReposiotry = repostiroty;
                _userRepository = userRepository;
                _context = context;
                return HandleAsync(reviewRequest);
            })
              .WithTags("Review")
              .Produces<string>(StatusCodes.Status200OK);
            //.RequireAuthorization();
        }

        public async Task<IResult> HandleAsync(UpdateReviewRequest reviewRequest)
        {
            var user = await _userRepository.GetUser(_context.User.Claims.ToArray()[0].Value);
            var rev = await _reviewReposiotry.GetReview(reviewRequest.Id);

            if (user == reviewRequest.User)
            {
                ReviewModel review = new ReviewModel()
                {
                    Id = rev.Id,
                    Value = reviewRequest.Value,
                    Date = rev.Date,
                    Teacher = rev.Teacher,
                    User = rev.User
                };
                await _reviewReposiotry.UpdateReview(review);

                return Results.Ok(review.Value);
            }
            else return Results.BadRequest();
        }
    }
}
