namespace Web.Endpoints.Answer
{
    public class CreateAnswerRequest
    {
        public string? Value { get; set; }
        public int QuestionId { get; set; }
    }
}
