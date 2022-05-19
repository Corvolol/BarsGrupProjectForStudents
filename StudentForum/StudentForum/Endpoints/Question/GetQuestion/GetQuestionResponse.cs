namespace Web.Endpoints.Question
{
    public class GetAnswerResponse
    {
        public int Id { get; set; }
        public string? Essense { get; set; }
        public List<TagModel>? Tags { get; set; }
    }
}
