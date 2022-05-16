namespace Web.Endpoints.Teacher
{
    public class GetTeacherResponse
    {
        public string? Name { get; set; }
        public string? Cafedra { get; set; }
        public List<string>? Tags { get; set; }
        public List<ReviewInfo>? ReviewInfos { get; set; }
    }

    public class ReviewInfo
    {
        public string? Value { get; set; }
        public string? ReviewUserNickName { get; set; }
        public DateTime Date { get; set; }
    }
}
