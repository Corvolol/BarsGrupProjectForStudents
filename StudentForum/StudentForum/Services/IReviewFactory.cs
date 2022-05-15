namespace Web.Services
{
    public interface IReviewFactory
    {
        public Review CreateReview(ReviewRequest review, Teacher teacher, UserModel user);
        public ReviewResponse CreateReviewResponse(Review review);
    }
}
