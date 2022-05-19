namespace Web.Endpoints.Answer.GetAnswer
{
    public class GetAnswerEndpoint : IEndpoint<IResult>
    {
        private IAnswerRepository _answerRepository = default!;
        private int _answerId;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/answer", async (int answerId, IAnswerRepository repostiroty) =>
            {
                _answerId = answerId;
                _answerRepository = repostiroty;
                return await HandleAsync();
            })
              .WithTags("answer")
              .Produces<GetAnswerResponse>();
        }
        public async Task<IResult> HandleAsync()
        {
            var answer = await _answerRepository.GetAnswer(_answerId);
            return Results.Ok(new GetAnswerResponse() 
            { 
                Id = answer.Id,
                Value = answer.Value,
                Date = answer.Date,
                Question = answer.Question,
                User = answer.User
            });
        }
    }
}
