namespace Web.Endpoints.Review
{
    public class GetReviewResponse
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public string? ReviewUserNickName { get; set; }
        public DateTime Date { get; set; }
    }
}
