using Microsoft.AspNetCore.Mvc;

namespace Web.Endpoints.Answer.CreateAnswer
{
    public class CreateanswerEndpoint : IEndpoint<IResult,CreateAnswerRequest>
    {

        private HttpContext _context = default!;
        private IAnswerRepository _answerRepository = default!;
        private IQuestionRepository _questionRepository = default!;
        private IUserRepository _userRepository = default!;

        public void AddRoute(IEndpointRouteBuilder app)
        {

            app.MapGet("/create-answer", async ([FromBody]CreateAnswerRequest answerRequest,[FromServices]HttpContext context, [FromServices] IAnswerRepository answerRepresitory, [FromServices] IQuestionRepository questionRepository, [FromServices] IUserRepository userRepository) =>
            {
                _context = context;
                _answerRepository = answerRepresitory;
                _questionRepository = questionRepository;
                _userRepository = userRepository;
                return HandleAsync( answerRequest);

            })
            .WithTags("answer")
            .Produces<CreateAnswerRequest>()
            .RequireAuthorization();
        }

        public async Task<IResult> HandleAsync(CreateAnswerRequest answerRequest)
        {
            var question = await _questionRepository.GetQuestion(answerRequest.QuestionId);
            var NewAnswer = new AnswerModel()
            {
                Value = answerRequest.Value,
                Date = DateTime.Now,
                User = await _userRepository.GetUser(_context.User.Claims.ToArray()[0].Value),
                Question = question
            };

           _answerRepository.AddAnswer(NewAnswer);
           return Results.Ok(NewAnswer);
        }
    }
}
