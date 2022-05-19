using Microsoft.AspNetCore.Mvc;

namespace Web.Endpoints.Question.QuestionAdd
{
    public class CreateAnswerEndpoint : IEndpoint<IResult,CreateAnswerRequest>
    {

        private HttpContext _context = default!;
        private IQuestionRepository _questionRepository = default!;
        private ITagRepository _tagRepository = default!;
        private IUserRepository _userRepository = default!;

        public void AddRoute(IEndpointRouteBuilder app)
        {

            app.MapGet("/question/add", async ([FromBody]CreateAnswerRequest questionRequest,[FromServices]HttpContext context, [FromServices] IQuestionRepository questionRepresitory, [FromServices] ITagRepository tagRepository, [FromServices] IUserRepository userRepository) =>
            {
                _context = context;
                _questionRepository = questionRepresitory;
                _tagRepository = tagRepository;
                _userRepository = userRepository;
                return HandleAsync( questionRequest);

            })
            .WithTags("Question")
            .Produces<CreateAnswerRequest>()
            .RequireAuthorization();
        }

        public async Task<IResult> HandleAsync(CreateAnswerRequest questionRequest)
        {   
            var ListTags = new List<TagModel>(await Task.WhenAll(questionRequest.ListTag.Select((questionRequest) => _tagRepository.GetTag(questionRequest))));

            var NewQuestion = new QuestionModel()
            {
                Essence = questionRequest.Essence,

                Info = questionRequest.Info,
                Tags = ListTags,
                User = await _userRepository.GetUser(_context.User.Claims.ToArray()[0].Value)
            };

           _questionRepository.AddQuestion(NewQuestion);
           return Results.Ok(NewQuestion);
        }
    }
}
