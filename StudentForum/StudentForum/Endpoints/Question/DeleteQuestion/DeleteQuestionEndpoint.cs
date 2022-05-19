namespace Web.Endpoints.Question.DeleteQuestion
{
    public class DeleteQuestionEndpoint : IEndpoint<IResult>
    {
        private HttpContext _context = default!;
        private IQuestionRepository _questionRepository = default!;
        private IUserRepository _userRepository = default!;
        private int _questionId = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapDelete("delete-question", async (int questionId, HttpContext context, IQuestionRepository repository, IUserRepository userRepository) =>
            {
                _context = context;
                _questionRepository = repository;
                _userRepository = userRepository;
                _questionId = questionId;
                return await HandleAsync();
            }).WithTags("Question")
              .Produces<string>()
              .RequireAuthorization();
        }
        public async Task<IResult> HandleAsync()
        {
            var user = await _userRepository.GetUser(_context.User.Claims.ToArray()[0].Value);
            var question = await _questionRepository.GetQuestion(_questionId);
            if (user == question.User)
            {
                await _questionRepository.DeleteQuestion(question);
                return Results.Ok("Вопрос удален");
            }
            else return Results.BadRequest();

        }
    }
}
