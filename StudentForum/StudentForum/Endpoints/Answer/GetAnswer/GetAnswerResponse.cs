namespace Web.Endpoints.Answer
{
    public class GetAnswerResponse
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public DateTime Date { get; set; }
        public QuestionModel? Question { get; set; }
        public UserModel? User { get; set; }
    }
}
