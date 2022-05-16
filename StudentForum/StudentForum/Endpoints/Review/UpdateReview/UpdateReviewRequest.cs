namespace Web.Endpoints.Review.UpdateReview
{
    public class UpdateReviewRequest
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public UserModel? User { get; set; }
    }
}
