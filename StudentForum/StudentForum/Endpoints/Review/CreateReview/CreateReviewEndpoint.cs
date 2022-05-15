﻿namespace Web.Endpoints.Review.CreateReview
{
    public class CreateReviewEndpoint : IEndpoint<IResult, ReviewRequest>
    {
        private IReviewRepository _reviewReposiotry = default!;
        private IUserRepository _userRepository = default!;
        private ITeacherRepository _teacherRepository = default!;
        private HttpContext _context = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapPost("/add-review", async (ReviewRequest reviewRequest, HttpContext context, IReviewRepository repostiroty,
                ITeacherRepository teacherRepository, IUserRepository userRepository) =>
            {
                _reviewReposiotry = repostiroty;
                _userRepository = userRepository;
                _teacherRepository = teacherRepository;
                _context = context;
                return HandleAsync(reviewRequest);
            })
              .WithTags("Review")
              .Produces<string>(StatusCodes.Status200OK)
              .RequireAuthorization();
        }

        public async Task<IResult> HandleAsync(ReviewRequest reviewRequest)
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
                return Results.Ok();
        }
    }
}
