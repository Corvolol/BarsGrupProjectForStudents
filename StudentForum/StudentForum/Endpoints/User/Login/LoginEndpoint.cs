namespace Web.Endpoints.User.Login
{
    public class LoginEndpoint : IEndpoint<IResult, LoginRequest>
    {
        private IGenerateUserJWT _generateUserJWT = default!;
        private IUserRepository _userRepository = default!;
        private IHashingPassword _hashingPassword = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapPost("/login", async (LoginRequest loginRequest, IGenerateUserJWT generateUserJWT, IUserRepository userRepository, IHashingPassword hashingPassword) =>
            {
                _generateUserJWT = generateUserJWT;
                _userRepository = userRepository;
                _hashingPassword = hashingPassword;
                return HandleAsync(loginRequest);
            })
              .WithTags("User")
             .Produces<LoginResponce>();
        }

        public async Task<IResult> HandleAsync(LoginRequest loginRequest)
        {
            UserModel user = await _userRepository.GetUser(loginRequest.Email);
            if (user != null && user.Password == _hashingPassword.Hashing(loginRequest.Password))
            {
                var token = _generateUserJWT.GenerateJWT(loginRequest.Email);
                return Results.Ok(new LoginResponce() { Token = token, Username = user.NickName });
            }
            return Results.BadRequest();
        }
    }
}
