namespace Web.Endpoints.Question.GetQuestion
{
    public class GetAnswerEndpoint : IEndpoint<IResult>
    {
        private IQuestionRepository _questionRepository = default!;
        private int _questionId;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/question", async (int questionId, IQuestionRepository repostiroty) =>
            {
                _questionId = questionId;
                _questionRepository = repostiroty;
                return await HandleAsync();
            })
              .WithTags("Question")
              .Produces<GetAnswerResponse>();
        }
        public async Task<IResult> HandleAsync()
        {
            var question = await _questionRepository.GetQuestion(_questionId);
            return Results.Ok(new GetAnswerResponse() 
            { 
                Id = question.Id,
                Essense = question.Essence,
                Tags = question.Tags
            });
        }
    }
}
