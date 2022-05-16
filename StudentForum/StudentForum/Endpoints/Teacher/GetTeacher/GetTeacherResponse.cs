namespace Web.Endpoints.Teacher
{
    public class GetTeacherResponse
    {
        public string? Name { get; set; }
        public string? Cafedra { get; set; }
        public List<string>? Tags { get; set; }
        public List<GetTeacherReview>? ReviewInfo { get; set; }
    }
}
