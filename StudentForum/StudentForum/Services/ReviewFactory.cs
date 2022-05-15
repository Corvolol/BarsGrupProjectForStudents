namespace Web.Services
{
    public class ReviewFactory : IReviewFactory
    {
        public Review CreateReview(ReviewRequest reviewReq, Teacher teacher, UserModel user)
        {
            var resReview = new Review()
            {
                review = reviewReq.review,
                date = DateTime.Now,
                Teacher = teacher,
                User = user
            };

            return resReview;
        }

        public ReviewResponse CreateReviewResponse(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
