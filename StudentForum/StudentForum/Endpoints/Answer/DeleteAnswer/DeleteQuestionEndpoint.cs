namespace Web.Endpoints.Answer
{
    public class DeleteanswerEndpoint : IEndpoint<IResult>
    {
        private HttpContext _context = default!;
        private IAnswerRepository _answerRepository = default!;
        private IUserRepository _userRepository = default!;
        private int _answerId = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapDelete("delete-answer", async (int answerId, HttpContext context, IAnswerRepository repository, IUserRepository userRepository) =>
            {
                _context = context;
                _answerRepository = repository;
                _userRepository = userRepository;
                _answerId = answerId;
                return await HandleAsync();
            }).WithTags("answer")
              .Produces<string>()
              .RequireAuthorization();
        }
        public async Task<IResult> HandleAsync()
        {
            var user = await _userRepository.GetUser(_context.User.Claims.ToArray()[0].Value);
            var answer = await _answerRepository.GetAnswer(_answerId);
            if (user == answer.User)
            {
                await _answerRepository.DeleteAnswer(answer);
                return Results.Ok("Вопрос удален");
            }
            else return Results.BadRequest();

        }
    }
}
