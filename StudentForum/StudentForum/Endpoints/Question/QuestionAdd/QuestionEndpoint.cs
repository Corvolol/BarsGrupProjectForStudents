
namespace Web.Endpoints.Question.QuestionAdd
{
    public class QuestionEndpointAdd : IEndpoint<IResult,QuestionRequest>
    {

        private HttpContext _context = default!;
        private IQuestionRepresitory _questionRepository = default!;
        private ITagRepository _tagRepository = default!;
        private IUserRepository _userRepository = default;

        public void AddRoute(IEndpointRouteBuilder app)
        {

            app.MapGet("/question/add", async (HttpContext context, IQuestionRepresitory questionRepresitory, QuestionRequest questionRequest, ITagRepository tagRepository, IUserRepository userRepository) =>
            {
                _context = context;
                _questionRepository = questionRepresitory;
                _tagRepository = tagRepository;
                _userRepository = userRepository;
                return HandleAsync( questionRequest);

            })
    .WithTags("Question")
    .Produces<QuestionRequest>()
    .RequireAuthorization();
        }

        public async Task<IResult> HandleAsync(QuestionRequest questionRequest)
        {   
            var ListTags = new List<Tag>(await Task.WhenAll(questionRequest.ListTag.Select((questionRequest) => _tagRepository.GetTag(questionRequest))));

            var NewQuestion = new QuestionModel()
            {
                Essence = questionRequest.Essence,

                Info = questionRequest.Info,
                Tags = ListTags,
                User = await _userRepository.GetUser(_context.User.Claims.ToArray()[0].Value)
            };

           _questionRepository.AddQuestion(NewQuestion);
           return Results.Ok();
        }
    }
}
