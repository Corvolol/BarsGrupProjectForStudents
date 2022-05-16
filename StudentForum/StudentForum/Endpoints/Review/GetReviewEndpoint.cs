﻿namespace Web.Endpoints.Review.GetReview
{
    public class GetReviewEndpoint : IEndpoint<IResult>
    {
        private IReviewRepository _reviewRepository = default!;
        private int _reviewId;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/review", async (int reviewId, IReviewRepository repostiroty) =>
            {
                _reviewId = reviewId;
                _reviewRepository = repostiroty;
                return await HandleAsync();
            })
              .WithTags("Review")
              .Produces<ReviewModel>();
        }

        public async Task<IResult> HandleAsync()
        {
            var review = await _reviewRepository.GetReview(_reviewId);
            return Results.Ok(review);
        }
    }
}
