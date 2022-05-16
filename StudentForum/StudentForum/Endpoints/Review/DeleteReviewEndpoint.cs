namespace Web.Endpoints.Review
{
    public class DeleteReviewEndpoint : IEndpoint<IResult>
    {
        private HttpContext _context = default!;
        private IReviewRepository _reviewRepository = default!;
        private IUserRepository _userRepository = default!;
        private int _reviewId = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapDelete("delete-review", async (int reviewId, HttpContext context, IReviewRepository repository, IUserRepository userRepository) =>
            {
                _context = context;
                _reviewRepository = repository;
                _userRepository = userRepository;
                _reviewId = reviewId;
                return HandleAsync();
            }).WithTags("Review")
              .Produces(StatusCodes.Status200OK);
              //.RequireAuthorization();
        }
        public async Task<IResult> HandleAsync()
        {
            var user = await _userRepository.GetUser(_context.User.Claims.ToArray()[0].Value);
            var review = await _reviewRepository.GetReview(_reviewId);
            if (user == review.User)
            {
                await _reviewRepository.DeleteReview(review);
                return Results.Ok("Отзыв удален");
            }
            else return Results.BadRequest();
            
        }
    }
}
