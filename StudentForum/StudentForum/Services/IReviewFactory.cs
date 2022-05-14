namespace Web.Services
{
    public interface IReviewFactory
    {
        public Review CreateReview(ReviewRequest review, Teacher teacher, User user);
        public ReviewResponse CreateReviewResponse(Review review);
    }
}
