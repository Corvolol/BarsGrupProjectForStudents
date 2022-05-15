namespace Web.Endpoints.User.UserInfo
{
    public class UserInfoEndpoint : IEndpoint<IResult>
    {
        private HttpContext _context = default!;
        private IUserRepository _userRepository = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/user/info", async (HttpContext context, IUserRepository userRepository) =>
            {
                _context = context;
                _userRepository = userRepository;
                return HandleAsync();
            })
              .WithTags("User")
              .Produces<UserInfoResponce>()
              .RequireAuthorization();
        }

        public async Task<IResult> HandleAsync()
        {
            var user =  await _userRepository.GetUser(_context.User.Claims.ToArray()[0].Value);
           return Results.Ok(new UserInfoResponce()
            {
                Name = user.Name,
                NickName = user.NickName,
                Faculty = user.Faculty,
                Groupnumber = user.Groupnumber,
                LastName = user.LastName,
                Speciality = user.Speciality
            });
        }
    }
}
